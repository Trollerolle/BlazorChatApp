using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChatApp.Shared
{
	public class ChatMessage
	{
		public string User { get; set; } = string.Empty;
		public string Message { get; set; } = string.Empty;
		public DateTime Timestamp { get; set; }
	}
}