using Bookish.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;

namespace Bookish.BookForms
{
    public partial class ReturnBookForm : Form
    {
        public List<BorrowBookModel> BorrowedBooks { get; set; }
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private async void ReturnBookForm_Load(object sender, EventArgs e)
        {
            await GetBorrowedBooks();
        }

        private async Task GetBorrowedBooks()
        {
            using var client = new HttpClient();
            var token = Helper.LoadToken();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var content = new StringContent("{}", Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:5000/api/Book/GetBorrowedBooks", content);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Response<BorrowBookModel>>(json);
                var books = data.Data.ToList();
                BorrowedBooks =books;
                BorrowedBooksComboBox.DataSource = books
                    .Select(s => s.UserId +","+ s.BookId)
                    .ToList();
            }
        }
        public class BorrowBookModel
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("userId")]
            public string UserId { get; set; }

            [JsonPropertyName("bookId")]
            public string BookId { get; set; }

            [JsonPropertyName("createdAt")]
            public DateTime CreatedAt { get; set; }

            [JsonPropertyName("updatedAt")]
            public DateTime UpdatedAt { get; set; }

            [JsonPropertyName("isReturned")]
            public bool IsReturned { get; set; }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var searchText = ReturnBookTextBox.Text;
            int index = BorrowedBooksComboBox.FindString(searchText);
            if (index != -1)
            {
                BorrowedBooksComboBox.SelectedIndex = index;
            }
        }
        private async void ReturnBookButton_Click(object sender, EventArgs e)
        {
            await ReturnBookButton_ClickAsync(sender,e);
        }
        private async Task ReturnBookButton_ClickAsync(object sender, EventArgs e)
        {
            if (BorrowedBooksComboBox.SelectedItem != null)
            {
                string selectedValue = BorrowedBooksComboBox
                    .SelectedItem.ToString();
                var values=selectedValue.Split(',');
                var userName = values[0];
                var bookName = values[1];
                var borrowBookId = BorrowedBooks
                    .Where(w => w.UserId == userName)
                    .Where(w => w.BookId == bookName)
                    .Select(s => s.Id)
                    .FirstOrDefault();
                var returnBookModel = new ReturnBookModel
                {
                    BorrowBookId = borrowBookId
                };
                using var client = new HttpClient();
                var token = Helper.LoadToken();
                var content = new StringContent(JsonConvert.SerializeObject(new { returnBookModel }), Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5000/api/Book/ReturnBook") { Content = content };
                var response = await client.SendAsync(request);
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Response<string>>(json);
                if (data?.ResponseStatus == "Success")
                {
                    MessageBox.Show("Book returned successfully", "Success", MessageBoxButtons.OK);
                    Close();
                    var panel = new Panel();
                    panel.BringToFront();
                }
                else
                {
                    MessageBox.Show("Book is not exist", "Error", MessageBoxButtons.OK);
                }
            }
        }
        public class ReturnBookModel
        {
            public string BorrowBookId { get; set; }
        }
    }
}
