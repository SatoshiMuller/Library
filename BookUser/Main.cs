using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BookUser
{
    public partial class Main : Form
    {

        //private SqlConnection connection;
        private MySqlConnection mysql_connection;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
            InitConnection();
        }

        private void InitConnection()
        {
            string host = "sql11.freemysqlhosting.net"; // Name Host 
            string database = "sql11646769"; // Name DataBase
            string user = "sql11646769"; // Name User
            string password = "zrLYPQSwZV"; // Password User

            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password + ";CharSet = utf8"; 

            mysql_connection = new MySqlConnection(Connect);

            #region MsSql Server

            //string connectionString = "Data Source=DESKTOP-9HN7J17;Initial Catalog=DataBooksUsers;Integrated Security=True";
            //connection = new SqlConnection(connectionString);

            #endregion 

        }

        private void BtnAddUser(object sender, EventArgs e)
        {
            try
            {
                mysql_connection.Open();

                var userName = textBoxNewUserName.Text;

                if (String.IsNullOrEmpty(userName))
                {
                    return;
                }

                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = $"INSERT Users (name) VALUES ('{userName}');";

                mysql_query.ExecuteNonQuery();
                
                textBoxNewUserName.Clear();

                #region MsSql Server

                //connection.Open();

                //string query = "INSERT INTO Users (name) VALUES (@userName)";

                //using (SqlCommand command = new SqlCommand(query, connection))
                //{
                //    var userName = textBoxNewUserName.Text;
                //    if (String.IsNullOrEmpty(userName))
                //    {
                //        return;
                //    }
                //    command.Parameters.AddWithValue("userName", userName);

                //    command.ExecuteNonQuery();

                //    textBoxNewUserName.Clear();
                //}

                #endregion 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении пользователя: " + ex.Message);
            }
            finally
            {
                //connection.Close();
                mysql_connection.Close();
                BtnShowAllUsers(sender, e);
            }
        }

        private void BtnAddBook(object sender, EventArgs e)
        {
            var selected = listBoxUsers.SelectedItem;
            if (selected == null || String.IsNullOrWhiteSpace(textBoxNewBookName.Text))
            {
                return;
            }
            try
            {
                mysql_connection.Open();

                var book = textBoxNewBookName.Text;
                var temp = (User)selected;
                var userId = temp.Id;

                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = $"INSERT INTO Books (Title, userId) VALUES ('{book}', {userId})";

                mysql_query.ExecuteNonQuery();
                textBoxNewBookName.Clear();

                #region MsSql Server

                //connection.Open();

                //string query = "INSERT INTO Books (Title, userId) VALUES (@book, @userId)";

                //var temp = (User)selected;
                //var selectedUser = temp.Id;

                //using (SqlCommand command = new SqlCommand(query, connection))
                //{

                //    var book = textBoxNewBookName.Text;

                //    command.Parameters.AddWithValue("book", book);
                //    command.Parameters.AddWithValue("@userId", selectedUser);

                //    command.ExecuteNonQuery();

                //    textBoxNewBookName.Clear();
                //}

                #endregion 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении книги: " + ex.Message);
            }
            finally
            {
                //connection.Close();
                mysql_connection.Close();
                BtnShowUserBooks(sender, e);
            }
        }

        private void BtnShowUserBooks(object sender, EventArgs e)
        {
            listBoxBooks.Items.Clear();
            var selected = listBoxUsers.SelectedItem;
            if (selected == null)
            {
                return;
            }
            try
            {
                mysql_connection.Open();

                var temp = (User)selected;
                var userId = temp.Id;

                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = $"SELECT * FROM Books WHERE userId = {userId}";

                MySqlDataReader mysql_result;

                mysql_result = mysql_query.ExecuteReader();
                while (mysql_result.Read())
                {
                    string bookTitle = mysql_result["Title"].ToString();
                    listBoxBooks.Items.Add(bookTitle);
                }

                #region MsSql Server

                //connection.Open();

                //var temp = (User)selected;
                //var selectedUser = temp.Id;

                //string query = "SELECT * FROM Books WHERE userId = " + selectedUser;

                //using (SqlCommand command = new SqlCommand(query, connection))
                //{
                //    var Title = listBoxBooks.Text;

                //    command.Parameters.AddWithValue("Title", Title);

                //    SqlDataReader reader = command.ExecuteReader();

                //    while (reader.Read())
                //    {
                //        string bookTitle = reader["Title"].ToString();
                //        listBoxBooks.Items.Add(bookTitle);
                //    }

                //    reader.Close();
                //}

                #endregion 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке книг: " + ex.Message);
            }
            finally
            {
                //connection.Close();
                mysql_connection.Close();
            }
        }

        private void BtnShowAllUsers(object sender, EventArgs e)
        {
            try
            {
                listBoxUsers.Items.Clear();

                mysql_connection.Open();

                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "SELECT * FROM Users;";

                MySqlDataReader mysql_result;

                mysql_result = mysql_query.ExecuteReader();
                while (mysql_result.Read())
                {
                    User user = new User();
                    user.Name = mysql_result["name"].ToString();
                    user.Id = Convert.ToInt32(mysql_result["id"]);
                    listBoxUsers.Items.Add(user);
                }

                #region MsSql Server

                //connection.Open();

                //string query = "SELECT * FROM Users";

                //using (SqlCommand command = new SqlCommand(query, connection))
                //{
                //    SqlDataReader reader = command.ExecuteReader();
                //    while (reader.Read())
                //    {
                //        User user = new User();
                //        user.Name = reader["name"].ToString();
                //        user.Id = Convert.ToInt32(reader["id"]);
                //        listBoxUsers.Items.Add(user);
                //    }
                //    reader.Close();
                //}

                #endregion 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка пользователей: " + ex.Message);
            }
            finally
            {
                // connection.Close();
                mysql_connection.Close();
            }
        }

        private void BtnDeleteSelectedBook(object sender, EventArgs e)
        {
            var selected = listBoxUsers.SelectedItem;

            if (selected == null)
            {
                return;
            }
            try
            {
                mysql_connection.Open();

                var temp = (User)selected;
                var selectedUser = temp.Id;
                var selectedBook = listBoxBooks.SelectedItem.ToString();

                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = $"DELETE FROM Books WHERE userId = {selectedUser} AND Title = '{selectedBook}'";

                mysql_query.ExecuteNonQuery();
                textBoxNewUserName.Clear();

                #region MsSql Server

                //connection.Open();

                //var temp = (User)selected;
                //var selectedUser = temp.Id;
                //var selectedBook = listBoxBooks.SelectedItem.ToString();

                //string query = $"DELETE FROM Books WHERE userId = {selectedUser} AND Title = '{selectedBook}'";

                //using (SqlCommand command = new SqlCommand(query, connection))
                //{
                //    command.ExecuteNonQuery();
                //}

                #endregion

                listBoxBooks.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении книг: " + ex.Message);
            }
            finally
            {
                //connection.Close();
                mysql_connection.Close();
                BtnShowUserBooks(sender, e);
            }
        }

        private void BtnDeleteSelectedUser(object sender, EventArgs e)
        {
            var selected = listBoxUsers.SelectedItem;
            if (selected == null)
            {
                return;
            }
            try
            {
                mysql_connection.Open();

                var temp = (User)selected;
                var selectedUser = temp.Id;

                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = $"DELETE FROM Users WHERE id = {selectedUser}";

                mysql_query.ExecuteNonQuery();
                textBoxNewUserName.Clear();

                #region MsSql Server

                //connection.Open();

                //var temp = (User)selected;
                //var selectedUser = temp.Id;

                //string query = "DELETE FROM Users WHERE id = " + selectedUser;

                //using (SqlCommand command = new SqlCommand(query, connection))
                //{
                //    command.ExecuteNonQuery();
                //}

                #endregion 

                listBoxUsers.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении пользователя: " + ex.Message);
            }
            finally
            {
                //connection.Close();
                mysql_connection.Close();
                BtnShowAllUsers(sender, e);
            }
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
