namespace GCLibrary
{
    partial class fMain
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
            this.lbAvailableBooks = new System.Windows.Forms.ListBox();
            this.bCheckout = new System.Windows.Forms.Button();
            this.lAvailableBooks = new System.Windows.Forms.Label();
            this.bReturn = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bBookSearch = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAvailableBooks
            // 
            this.lbAvailableBooks.FormattingEnabled = true;
            this.lbAvailableBooks.Location = new System.Drawing.Point(13, 30);
            this.lbAvailableBooks.Name = "lbAvailableBooks";
            this.lbAvailableBooks.Size = new System.Drawing.Size(259, 69);
            this.lbAvailableBooks.TabIndex = 0;
            // 
            // bCheckout
            // 
            this.bCheckout.Location = new System.Drawing.Point(13, 106);
            this.bCheckout.Name = "bCheckout";
            this.bCheckout.Size = new System.Drawing.Size(75, 23);
            this.bCheckout.TabIndex = 1;
            this.bCheckout.Text = "Checkout";
            this.bCheckout.UseVisualStyleBackColor = true;
            // 
            // lAvailableBooks
            // 
            this.lAvailableBooks.AutoSize = true;
            this.lAvailableBooks.Location = new System.Drawing.Point(13, 13);
            this.lAvailableBooks.Name = "lAvailableBooks";
            this.lAvailableBooks.Size = new System.Drawing.Size(83, 13);
            this.lAvailableBooks.TabIndex = 2;
            this.lAvailableBooks.Text = "Available Books";
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(197, 105);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(75, 23);
            this.bReturn.TabIndex = 3;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(100, 195);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 4;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 5;
            // 
            // bBookSearch
            // 
            this.bBookSearch.AutoSize = true;
            this.bBookSearch.Location = new System.Drawing.Point(13, 153);
            this.bBookSearch.Name = "bBookSearch";
            this.bBookSearch.Size = new System.Drawing.Size(69, 13);
            this.bBookSearch.TabIndex = 6;
            this.bBookSearch.Text = "Book Search";
            this.bBookSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(13, 226);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bBookSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.lAvailableBooks);
            this.Controls.Add(this.bCheckout);
            this.Controls.Add(this.lbAvailableBooks);
            this.Name = "fMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvailableBooks;
        private System.Windows.Forms.Button bCheckout;
        private System.Windows.Forms.Label lAvailableBooks;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label bBookSearch;
        private System.Windows.Forms.Button bSave;
    }
}