using Newtonsoft.Json;
using System.Text;

namespace Bookish
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SaveToken(string token)
        {
            File.WriteAllText("token.txt", token);
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            await LoginButton_ClickAsync(sender, e);
        }
        private async Task LoginButton_ClickAsync(object sender, EventArgs e)
        {
            await GetTokenAsync(UserNameTextBox.Text, PasswordTextBox.Text);
        }

        private async Task<string> GetTokenAsync(string userName, string password)
        {
            using var client = new HttpClient();
            var payload = new
            {
                username = userName,
                password = password,
                twoFactorToken = ""
            };
            var content = new StringContent(JsonConvert.SerializeObject(payload),Encoding.UTF8,"application/json");
            var response = await client.PostAsync("http://localhost:5000/api/User/AccessToken", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var token = JsonConvert.DeserializeObject<TokenResponse>(json);
                if (token != null)
                {
                    SaveToken(token.AccessToken.Token);
                }
                var panel = new UserPanel();
                Hide();
                panel.Show();
                return token?.AccessToken.Token ?? string.Empty;
            }
            else
            {
                throw new Exception("Failed to authenticate.");
            }
        }
        private class AccessToken
        {
            [JsonProperty("token")]
            public string Token { get; set; }

            [JsonProperty("validTo")]
            public string ValidTo { get; set; }

            [JsonProperty("additionalMessages")]
            public string AdditionalMessages { get; set; }

            [JsonProperty("userType")]
            public string UserType { get; set; }
        }

        private class RefreshToken
        {
            [JsonProperty("token")]
            public string Token { get; set; }

            [JsonProperty("validTo")]
            public string ValidTo { get; set; }

            [JsonProperty("additionalMessages")]
            public string AdditionalMessages { get; set; }

            [JsonProperty("userType")]
            public string UserType { get; set; }
        }

        private class TokenResponse
        {
            [JsonProperty("accessToken")]
            public AccessToken AccessToken { get; set; }

            [JsonProperty("refreshToken")]
            public RefreshToken RefreshToken { get; set; }
        }
    }
}