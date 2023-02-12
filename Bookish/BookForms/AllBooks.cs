using Bookish.Entities;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http.Headers;
using System.Text;

namespace Bookish.BookForms
{
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
        }
        private string SelectedUserId;
        private List<User> Users { get; set; }
        private async void AllBooks_Load(object sender, EventArgs e)
        {
            await AllBooks_LoadAsync(sender, e);
            await GetUsers();
        }

        private async Task AllBooks_LoadAsync(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("BookId", typeof(string));
            dataTable.Columns.Add("Title", typeof(string));
            dataTable.Columns.Add("ISBN", typeof(string));
            dataTable.Columns.Add("Edition", typeof(string));
            dataTable.Columns.Add("PublishTime", typeof(DateTime));
            dataTable.Columns.Add("Language", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));
            using var client = new HttpClient();
            var token = Helper.LoadToken();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var content = new StringContent("{}", Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:5000/api/Book/GetBooks", content);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var books = JsonConvert.DeserializeObject<List<Book>>(json);
                if (books != null)
                {
                    foreach (var book in books)
                    {

                        DataRow row = dataTable.NewRow();
                        row["BookId"] = book.BookId;
                        row["Title"] = book.Title;
                        row["ISBN"] = book.ISBN;
                        row["Edition"] = book.Edition;
                        row["PublishTime"] = book.PublishTime;
                        row["Language"] = book.Language;
                        row["Description"] = book.Description;

                        dataTable.Rows.Add(row);
                    }
                }
            }
            else
            {
                throw new Exception("Failed to retrieve user info. " + await response.Content.ReadAsStringAsync());
            }
            AllBooksGridView.DataSource = dataTable;
        }
        private async Task GetUsers()
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
                Users = users;
                UsersListComboBox.DataSource = users.Select(s => s.Email).ToList();
            }
        }
        private void UsersListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void BorrowButton_Click(object sender, EventArgs e)
        {
            await BorrowButton_ClickAsync(sender, e);
            Close();
            var allBooks = new AllBooks();
            allBooks.Show();
        }
        private async Task BorrowButton_ClickAsync(object sender, EventArgs e)
        {
            SelectedUserId = Users[UsersListComboBox.SelectedIndex].Id;
            using var client = new HttpClient();
            var token = Helper.LoadToken();
            int selectedIndex = AllBooksGridView.SelectedRows[0].Index;
            var bookId = (AllBooksGridView.Rows[selectedIndex].Cells["BookId"].Value).ToString();
            var borrowBookCommandModel = new List<BorrowBookCommandModel>
            {
             new BorrowBookCommandModel
             {
                 UserId = SelectedUserId,
                 BookId =bookId
             }
            };
            var content = new StringContent(JsonConvert.SerializeObject(new { borrowBookCommandModel }), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5000/api/Book/BorrowBook") { Content = content };
            var response = await client.SendAsync(request);
            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<Response<User>>(json);
            if (data?.ResponseStatus == "Success")
            {
                MessageBox.Show("Book borrowed successfully", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Book is not available", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
