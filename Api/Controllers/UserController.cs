using Application.Common.Interfaces.Authorization;
using Application.Common.Interfaces.Entities.Users;
using Application.Common.Interfaces.Entities.Users.DTOs;
using Application.Common.Validations.Errors;
using Application.Common.Validations.UserValidations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace Api.Controllers;

[ApiController]
[Route("/api/users")]
public class UserController : ControllerBase
{
	private readonly IUserService _userService;
	private readonly IUserAuthorizationService _userAuthorizationService;

	public UserController(IUserService userService, IUserAuthorizationService userAuthorizationService)
	{
		_userService = userService ?? throw new ArgumentNullException(nameof(userService));
		_userAuthorizationService = userAuthorizationService ??
		                            throw new ArgumentNullException(nameof(userAuthorizationService));
	}

	[HttpGet("{userId:int}", Name = "GetUserById")]
	public async Task<ActionResult<UserDataResponse>> GetUserById(int userId)
	{
		return await _userService.GetUserByIdAsync(userId);
	}

	[HttpPost("register")]
	public async Task<ActionResult<UserResponse>> Register(CreateUserRequest createCreateUserRequest)
	{
		CreateUserRequestValidator requestValidator = new();
		ValidationResult validationResult = await requestValidator.ValidateAsync(createCreateUserRequest);
		if (!validationResult.IsValid)
		{
			var errors = validationResult.Errors
				.Select(e => new ValidationError(e.PropertyName, e.ErrorMessage));
			return BadRequest(errors);
		}

		UserResponse createdUser = await _userService.RegisterAsync(createCreateUserRequest);

		return new CreatedAtRouteResult(nameof(GetUserById), new { userId = createdUser.Id }, createdUser);
	}

	[HttpPost("login")]
	public async Task<ActionResult<UserResponse>> Login(UserLoginRequest userLoginRequest)
	{
		LoginUserValidator requestValidator = new();
		ValidationResult validationResult = await requestValidator.ValidateAsync(userLoginRequest);
		if (!validationResult.IsValid)
		{
			var errors = validationResult.Errors
				.Select(e => new ValidationError(e.PropertyName, e.ErrorMessage));
			return BadRequest(errors);
		}

		UserResponse loggedInUser = await _userService.LoginAsync(userLoginRequest);

		return Ok(loggedInUser);
	}

	[Authorize]
	[HttpPut("{userId:int}")]
	public async Task<ActionResult<UserDataResponse>> Update(EditUserRequest editUserRequest, int userId)
	{
		EditUserRequestValidator requestValidator = new();
		ValidationResult validationResult = await requestValidator.ValidateAsync(editUserRequest);
		if (!validationResult.IsValid)
		{
			var errors = validationResult.Errors
				.Select(e => new ValidationError(e.PropertyName, e.ErrorMessage));
			return BadRequest(errors);
		}

		int loggedInUserId = _userAuthorizationService.GetUserIdFromJwtToken(User);

		return await _userService.EditAsync(editUserRequest, userId, loggedInUserId);
	}
}