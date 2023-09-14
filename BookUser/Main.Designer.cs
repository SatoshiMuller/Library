namespace BookUser
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddNewUser = new System.Windows.Forms.Button();
            this.textBoxNewUserName = new System.Windows.Forms.TextBox();
            this.textBoxNewBookName = new System.Windows.Forms.TextBox();
            this.BtnAddNewBook = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.BtnShowUsers = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.BtnExitApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnShowAllUserBook = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(83, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новый пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(348, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новая книга";
            // 
            // BtnAddNewUser
            // 
            this.BtnAddNewUser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddNewUser.Location = new System.Drawing.Point(10, 50);
            this.BtnAddNewUser.Name = "BtnAddNewUser";
            this.BtnAddNewUser.Size = new System.Drawing.Size(263, 23);
            this.BtnAddNewUser.TabIndex = 2;
            this.BtnAddNewUser.Text = "Добавить пользователя";
            this.BtnAddNewUser.UseVisualStyleBackColor = false;
            this.BtnAddNewUser.Click += new System.EventHandler(this.BtnAddUser);
            // 
            // textBoxNewUserName
            // 
            this.textBoxNewUserName.Location = new System.Drawing.Point(10, 24);
            this.textBoxNewUserName.Name = "textBoxNewUserName";
            this.textBoxNewUserName.Size = new System.Drawing.Size(263, 20);
            this.textBoxNewUserName.TabIndex = 3;
            // 
            // textBoxNewBookName
            // 
            this.textBoxNewBookName.Location = new System.Drawing.Point(279, 24);
            this.textBoxNewBookName.Name = "textBoxNewBookName";
            this.textBoxNewBookName.Size = new System.Drawing.Size(215, 20);
            this.textBoxNewBookName.TabIndex = 4;
            // 
            // BtnAddNewBook
            // 
            this.BtnAddNewBook.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddNewBook.Location = new System.Drawing.Point(279, 50);
            this.BtnAddNewBook.Name = "BtnAddNewBook";
            this.BtnAddNewBook.Size = new System.Drawing.Size(215, 23);
            this.BtnAddNewBook.TabIndex = 5;
            this.BtnAddNewBook.Text = "Добавить Книгу";
            this.BtnAddNewBook.UseVisualStyleBackColor = false;
            this.BtnAddNewBook.Click += new System.EventHandler(this.BtnAddBook);
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteBook.Location = new System.Drawing.Point(279, 344);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(215, 30);
            this.BtnDeleteBook.TabIndex = 9;
            this.BtnDeleteBook.Text = "Удалить книгу";
            this.BtnDeleteBook.UseVisualStyleBackColor = false;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteSelectedBook);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(279, 124);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(215, 212);
            this.listBoxBooks.TabIndex = 10;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(10, 124);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(263, 212);
            this.listBoxUsers.TabIndex = 11;
            // 
            // BtnShowUsers
            // 
            this.BtnShowUsers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnShowUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnShowUsers.Location = new System.Drawing.Point(10, 95);
            this.BtnShowUsers.Name = "BtnShowUsers";
            this.BtnShowUsers.Size = new System.Drawing.Size(263, 23);
            this.BtnShowUsers.TabIndex = 12;
            this.BtnShowUsers.Text = "Показать пользователей ";
            this.BtnShowUsers.UseVisualStyleBackColor = false;
            this.BtnShowUsers.Click += new System.EventHandler(this.BtnShowAllUsers);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteUser.Location = new System.Drawing.Point(10, 344);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(263, 30);
            this.BtnDeleteUser.TabIndex = 13;
            this.BtnDeleteUser.Text = "Удалить пользователя ";
            this.BtnDeleteUser.UseVisualStyleBackColor = false;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteSelectedUser);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelHeader.Controls.Add(this.BtnExitApp);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(1, 1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(505, 31);
            this.panelHeader.TabIndex = 14;
            // 
            // BtnExitApp
            // 
            this.BtnExitApp.BackColor = System.Drawing.Color.Red;
            this.BtnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitApp.Location = new System.Drawing.Point(469, 5);
            this.BtnExitApp.Name = "BtnExitApp";
            this.BtnExitApp.Size = new System.Drawing.Size(25, 20);
            this.BtnExitApp.TabIndex = 0;
            this.BtnExitApp.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookUser.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(-20, -159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 296);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnDeleteUser);
            this.panel2.Controls.Add(this.BtnAddNewUser);
            this.panel2.Controls.Add(this.BtnShowUsers);
            this.panel2.Controls.Add(this.textBoxNewUserName);
            this.panel2.Controls.Add(this.listBoxUsers);
            this.panel2.Controls.Add(this.textBoxNewBookName);
            this.panel2.Controls.Add(this.listBoxBooks);
            this.panel2.Controls.Add(this.BtnAddNewBook);
            this.panel2.Controls.Add(this.BtnDeleteBook);
            this.panel2.Controls.Add(this.BtnShowAllUserBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 384);
            this.panel2.TabIndex = 15;
            // 
            // BtnShowAllUserBook
            // 
            this.BtnShowAllUserBook.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnShowAllUserBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowAllUserBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnShowAllUserBook.Location = new System.Drawing.Point(279, 95);
            this.BtnShowAllUserBook.Name = "BtnShowAllUserBook";
            this.BtnShowAllUserBook.Size = new System.Drawing.Size(215, 23);
            this.BtnShowAllUserBook.TabIndex = 8;
            this.BtnShowAllUserBook.Text = "Показать книги";
            this.BtnShowAllUserBook.UseVisualStyleBackColor = false;
            this.BtnShowAllUserBook.Click += new System.EventHandler(this.BtnShowUserBooks);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(507, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Библиотека";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddNewUser;
        private System.Windows.Forms.TextBox textBoxNewUserName;
        private System.Windows.Forms.TextBox textBoxNewBookName;
        private System.Windows.Forms.Button BtnAddNewBook;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button BtnShowUsers;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button BtnExitApp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnShowAllUserBook;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

