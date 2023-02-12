namespace Bookish.BookForms
{
    partial class AllBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllBooksGridView = new System.Windows.Forms.DataGridView();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.UsersListComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBooksGridView
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllBooksGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllBooksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllBooksGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AllBooksGridView.BackgroundColor = System.Drawing.Color.White;
            this.AllBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksGridView.Location = new System.Drawing.Point(-2, 31);
            this.AllBooksGridView.Name = "AllBooksGridView";
            this.AllBooksGridView.RowHeadersWidth = 82;
            this.AllBooksGridView.RowTemplate.Height = 41;
            this.AllBooksGridView.Size = new System.Drawing.Size(1637, 344);
            this.AllBooksGridView.TabIndex = 0;
            // 
            // BorrowButton
            // 
            this.BorrowButton.Location = new System.Drawing.Point(253, 507);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(246, 68);
            this.BorrowButton.TabIndex = 1;
            this.BorrowButton.Text = "Borrow";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // UsersListComboBox
            // 
            this.UsersListComboBox.FormattingEnabled = true;
            this.UsersListComboBox.Location = new System.Drawing.Point(863, 522);
            this.UsersListComboBox.Name = "UsersListComboBox";
            this.UsersListComboBox.Size = new System.Drawing.Size(400, 40);
            this.UsersListComboBox.TabIndex = 2;
            this.UsersListComboBox.SelectedIndexChanged += new System.EventHandler(this.UsersListComboBox_SelectedIndexChanged);
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bookish.Properties.Resources._24manguel_superJumbo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1672, 765);
            this.Controls.Add(this.UsersListComboBox);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.AllBooksGridView);
            this.Name = "AllBooks";
            this.Text = "AllBooks";
            this.Load += new System.EventHandler(this.AllBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView AllBooksGridView;
        private Button BorrowButton;
        private ComboBox UsersListComboBox;
    }
}