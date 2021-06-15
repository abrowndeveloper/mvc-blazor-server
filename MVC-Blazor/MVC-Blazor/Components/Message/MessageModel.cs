using Microsoft.AspNetCore.Components;

namespace MVC_Blazor.Components.Message
{
    public class MessageModel
    {
        public string Title { get; set; }
        public MarkupString Content { get; set; }
    }
}
