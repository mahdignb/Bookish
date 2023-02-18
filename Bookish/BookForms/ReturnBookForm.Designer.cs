namespace Bookish.BookForms
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.BorrowedBooksComboBox = new System.Windows.Forms.ComboBox();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.ReturnBookTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorrowedBooksComboBox
            // 
            this.BorrowedBooksComboBox.FormattingEnabled = true;
            this.BorrowedBooksComboBox.Location = new System.Drawing.Point(101, 251);
            this.BorrowedBooksComboBox.Name = "BorrowedBooksComboBox";
            this.BorrowedBooksComboBox.Size = new System.Drawing.Size(647, 40);
            this.BorrowedBooksComboBox.TabIndex = 0;
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Location = new System.Drawing.Point(364, 347);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(150, 46);
            this.ReturnBookButton.TabIndex = 1;
            this.ReturnBookButton.Text = "ReturnBook";
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // ReturnBookTextBox
            // 
            this.ReturnBookTextBox.Location = new System.Drawing.Point(132, 90);
            this.ReturnBookTextBox.Name = "ReturnBookTextBox";
            this.ReturnBookTextBox.Size = new System.Drawing.Size(329, 39);
            this.ReturnBookTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search User";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(489, 86);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 46);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 542);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnBookTextBox);
            this.Controls.Add(this.ReturnBookButton);
            this.Controls.Add(this.BorrowedBooksComboBox);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox BorrowedBooksComboBox;
        private Button ReturnBookButton;
        private TextBox ReturnBookTextBox;
        private Label label1;
        private Button SearchButton;
    }
}