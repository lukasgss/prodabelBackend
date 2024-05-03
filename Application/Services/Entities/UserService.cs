using Application.Common.Exceptions;
using Application.Common.Extensions.Mapping;
using Application.Common.Interfaces.Authentication;
using Application.Common.Interfaces.Entities.Users;
using Application.Common.Interfaces.Entities.Users.DTOs;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Application.Services.Entities;

public class UserService : IUserService
{
	private readonly IUserRepository _userRepository;
	private readonly IJwtTokenGenerator _jwtTokenGenerator;

	public UserService(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
	{
		_userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
		_jwtTokenGenerator = jwtTokenGenerator ?? throw new ArgumentNullException(nameof(jwtTokenGenerator));
	}

	public async Task<UserDataResponse> GetUserByIdAsync(int userId)
	{
		User? searchedUser = await _userRepository.GetUserByIdAsync(userId);

		if (searchedUser is null)
		{
			throw new NotFoundException("Não foi possível obter o usuário com o id especificado.");
		}

		return searchedUser.ToUserDataResponse();
	}

	public async Task<UserResponse> RegisterAsync(CreateUserRequest createUserRequest)
	{
		User userToCreate = new()
		{
			FullName = createUserRequest.FullName,
			UserName = createUserRequest.Email,
			PhoneNumber = createUserRequest.PhoneNumber,
			Email = createUserRequest.Email,
			EmailConfirmed = true,
		};

		User? userAlreadyExists = await _userRepository.GetUserByEmailAsync(createUserRequest.Email);
		if (userAlreadyExists is not null)
		{
			throw new ConflictException("Usuário com o e-mail especificado já existe.");
		}

		IdentityResult registrationResult =
			await _userRepository.RegisterUserAsync(userToCreate, createUserRequest.Password);

		if (!registrationResult.Succeeded)
		{
			throw new InternalServerErrorException();
		}

		string jwtToken = _jwtTokenGenerator.GenerateJwtToken(userToCreate.Id, userToCreate.FullName);

		return userToCreate.ToUserResponse(jwtToken);
	}

	public async Task<UserDataResponse> EditAsync(EditUserRequest editUserRequest, int userId, int loggedInUserId)
	{
		if (userId != loggedInUserId)
		{
			throw new ForbiddenException("Você não possui permissão para editar este usuário.");
		}

		User? user = await _userRepository.GetUserByIdAsync(userId);
		if (user is null)
		{
			throw new NotFoundException("Usuário com o id especificado não existe.");
		}

		user.FullName = editUserRequest.FullName;
		user.PhoneNumber = editUserRequest.PhoneNumber;

		await _userRepository.CommitAsync();

		return user.ToUserDataResponse();
	}

	public async Task<UserResponse> LoginAsync(UserLoginRequest userLoginRequest)
	{
		User? userToLogin = await _userRepository.GetUserByEmailAsync(userLoginRequest.Email)
		                    ?? new User() { SecurityStamp = Guid.NewGuid().ToString() };

		SignInResult signInResult = await _userRepository.CheckCredentials(userToLogin, userLoginRequest.Password);

		if (!signInResult.Succeeded || userToLogin is null)
		{
			throw new UnauthorizedException("Credenciais inválidas.");
		}

		string jwtToken = _jwtTokenGenerator.GenerateJwtToken(userToLogin.Id, userToLogin.FullName);

		return userToLogin.ToUserResponse(jwtToken);
	}
}