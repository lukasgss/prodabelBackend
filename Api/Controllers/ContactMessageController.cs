using Application.Common.Interfaces.Entities.ContactMessages;
using Application.Common.Interfaces.Entities.ContactMessages.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/api/contact-message")]
public class ContactMessageController : ControllerBase
{
    private readonly IContactMessageService _contactMessageService;

    public ContactMessageController(IContactMessageService contactMessageService)
    {
        _contactMessageService = contactMessageService;
    }

    [HttpGet]
    public async Task<ActionResult<ContactMessageResponse>> GetContactMessages()
    {
        var messages = await _contactMessageService.GetContactMessages();
        return Ok(messages);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ContactMessageResponse>> GetContactMessageById(int id)
    {
        var message = await _contactMessageService.GetContactMessageById(id);
        return Ok(message);
    }
    
    [HttpPost]
    public async Task<ActionResult<ContactMessageResponse>> CreateContactMessage(CreateContactMessage createContactMessage)
    {
        return await _contactMessageService.CreateContactMessage(createContactMessage);
    }
}