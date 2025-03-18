using BlazorChatApp.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorChatApp.Server.api
{

	[ApiController]
	[Route("api/[controller]")]
	public class ChatController : ControllerBase
	{
		private static List<ChatMessage> messages = new List<ChatMessage>();

		[HttpGet]
		public IEnumerable<ChatMessage> GetMessages()
		{
			return messages.OrderBy(m => m.Timestamp);
		}

		[HttpPost]
		public IActionResult PostMessage([FromBody] ChatMessage message)
		{
			if (message == null || string.IsNullOrWhiteSpace(message.User) || string.IsNullOrWhiteSpace(message.Message))
			{
				return BadRequest("Invalid message.");
			}

			message.Timestamp = DateTime.UtcNow;
			messages.Add(message);
			return Ok();
		}
	}
}