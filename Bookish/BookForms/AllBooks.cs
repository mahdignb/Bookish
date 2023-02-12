using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookish.BookForms
{
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
        }

        private void AllBooks_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Columns.Add("Gender", typeof(string));

            // Add rows to the DataTable
            dataTable.Rows.Add(1, "John Doe", 30, "Male");
            dataTable.Rows.Add(2, "Jane Doe", 25, "Female");
            dataTable.Rows.Add(3, "Jim Smith", 35, "Male");
            dataTable.Rows.Add(4, "Samantha Lee", 28, "Female");

            // Set the DataSource of the DataGridView to the DataTable
            AllBooksGridView.DataSource = dataTable;
        }
    }
}
