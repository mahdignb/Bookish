using Newtonsoft.Json;

namespace Bookish.Entities
{
    public class Response<T>
    {
        [JsonProperty("responseText")]
        public string ResponseText { get; set; }

        [JsonProperty("responseStatus")]
        public string ResponseStatus { get; set; }

        [JsonProperty("data")]
        public List<T> Data { get; set; }
    }
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("userType")]
        public string UserType { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("numberOfBorrowedBooks")]
        public int NumberOfBorrowedBooks { get; set; }
    }
}
