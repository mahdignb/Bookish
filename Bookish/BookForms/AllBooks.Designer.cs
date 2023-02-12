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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBooksGridView
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllBooksGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllBooksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllBooksGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AllBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksGridView.Location = new System.Drawing.Point(-2, 31);
            this.AllBooksGridView.Name = "AllBooksGridView";
            this.AllBooksGridView.RowHeadersWidth = 82;
            this.AllBooksGridView.RowTemplate.Height = 41;
            this.AllBooksGridView.Size = new System.Drawing.Size(1183, 344);
            this.AllBooksGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Borrow";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllBooksGridView);
            this.Name = "AllBooks";
            this.Text = "AllBooks";
            this.Load += new System.EventHandler(this.AllBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView AllBooksGridView;
        private Button button1;
    }
}