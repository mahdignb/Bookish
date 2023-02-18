namespace Bookish.UserForms
{
    partial class ShowUsers
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
            this.ShowUsersGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShowUsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowUsersGridView
            // 
            this.ShowUsersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowUsersGridView.Location = new System.Drawing.Point(12, 29);
            this.ShowUsersGridView.Name = "ShowUsersGridView";
            this.ShowUsersGridView.RowHeadersWidth = 82;
            this.ShowUsersGridView.RowTemplate.Height = 41;
            this.ShowUsersGridView.Size = new System.Drawing.Size(1489, 300);
            this.ShowUsersGridView.TabIndex = 0;
            // 
            // ShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 526);
            this.Controls.Add(this.ShowUsersGridView);
            this.Name = "ShowUsers";
            this.Text = "ShowUsers";
            this.Load += new System.EventHandler(this.ShowUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowUsersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ShowUsersGridView;
    }
}