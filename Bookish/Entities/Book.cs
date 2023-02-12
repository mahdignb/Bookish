using Newtonsoft.Json;

namespace Bookish.Entities
{
    public class Book
    {
        [JsonProperty("bookId")]
        public string BookId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("isbn")]
        public string ISBN { get; set; }

        [JsonProperty("edition")]
        public string Edition { get; set; }

        [JsonProperty("publishTime")]
        public DateTime PublishTime { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
