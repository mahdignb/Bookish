﻿using Bookish.BookForms;
using Bookish.Entities;
using Bookish.UserForms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Bookish
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }
        private static async Task<CurrentUserInfo> CurrentUserTypeAsync()
        {
            using var client = new HttpClient();
            var token = Helper.LoadToken();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync("http://localhost:5000/api/User/GetCurrentUser");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CurrentUserInfo>(json);
            }
            else
            {
                throw new Exception("Failed to retrieve user info. " + await response.Content.ReadAsStringAsync());
            }
        }
        private class CurrentUserInfo
        {
            [JsonProperty("userName")]
            public string UserName { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("userType")]
            public string UserType { get; set; }
        }

        private void ShowAllBooks_Click(object sender, EventArgs e)
        {
            var bookListForm = new AllBooks();
            bookListForm.Show();
        }

        private void HelpMenuStrip_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/mahdignb/");
        }

        private void VersionMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.1","Version");
        }

        private void ShowUsers_Click(object sender, EventArgs e)
        {
            var form = new ShowUsers();
            form.Show();
        }

        private void ReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ReturnBookForm();
            form.Show();
        }
    }
}
