using Newtonsoft.Json;

namespace CEOGroup.Core.Models
{

    public class MessageDrilldownModel
    {
        [JsonProperty("listid")]
        public string Listid { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("recid")]
        public string Recid { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("ts")]
        public long Ts { get; set; }

        [JsonProperty("linkURI")]
        public string LinkUri { get; set; }

        public int ActionId { get; set; }
    }
}
