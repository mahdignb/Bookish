using Bookish.Entities;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http.Headers;

namespace Bookish.UserForms
{
    public partial class ShowUsers : Form
    {
        public ShowUsers()
        {
            InitializeComponent();
        }

        private void ShowUsers_Load(object sender, EventArgs e)
        {
            AllUsers_Load(sender, e);
        }
        private async void AllUsers_Load(object sender, EventArgs e)
        {
            await AllUsers_LoadAsync(sender, e);
        }
        private async Task AllUsers_LoadAsync(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("UserName", typeof(string));
            dataTable.Columns.Add("UserType", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("NumberOfBorrowedBooks", typeof(int));
            var users = await GetUsers();
            if (users.Count > 0)
            {
                foreach (var user in users)
                {

                    DataRow row = dataTable.NewRow();
                    row["UserName"] = user.Email;
                    row["UserType"] = user.UserType;
                    row["PhoneNumber"] = user.PhoneNumber;
                    row["NumberOfBorrowedBooks"] = user.NumberOfBorrowedBooks;

                    dataTable.Rows.Add(row);
                }
            }
            else
            {
                throw new Exception("Failed to retrieve user info. ");
            }
            ShowUsersGridView.DataSource = dataTable;
        }
        private async Task<List<User>> GetUsers()
        {
            using var client = new HttpClient();
            var token = Helper.LoadToken();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync("http://localhost:5000/api/User/GetUsers");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Response<User>>(json);
                var users = data.Data.ToList();
                return users;
            }
            return new List<User>();
        }
    }
}
