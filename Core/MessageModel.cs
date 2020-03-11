using Newtonsoft.Json;

namespace CEOGroup.Core.Models
{
    public class MessageModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("msg_id")]
        public string MessageId { get; set; }

        [JsonProperty("time_when")]
        public string TimeWhen { get; set; }

        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        [JsonProperty("is_text_only")]
        public string IsTextOnly { get; set; }

        [JsonProperty("timestamp")]
        public object Timestamp { get; set; }

        [JsonProperty("sender_email")]
        public string SenderEmail { get; set; }
    }
}
