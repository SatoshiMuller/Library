using BookUser.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookUser
{
    public partial class Main : Form
    {
        private SqlConnection connection;

     

       

        public Main()
        {
            InitializeComponent();
            InitConnection();

        }


        private void InitConnection()
        {
            string connectionString = "Data Source=DESKTOP-9HN7J17;Initial Catalog=DataBooksUsers;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }


        private void BtnAddUser(object sender, EventArgs e)
        {
            try
            {
                
                connection.Open();

                string query = "INSERT INTO Users (name) VALUES (@userName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var userName = textBoxNewUserName.Text;
                    if (String.IsNullOrEmpty(userName))
                    {
                        return;
                    }
                    command.Parameters.AddWithValue("userName", userName);

                    command.ExecuteNonQuery();

                    textBoxNewUserName.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении пользователя: " + ex.Message);
            }
            finally
            {

                connection.Close();

                
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
                connection.Open();

                string query = "INSERT INTO Books (Title, userId) VALUES (@book, @userId)";

                var temp = (User)selected;
                var selectedUser = temp.Id;

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    var book = textBoxNewBookName.Text;

                    command.Parameters.AddWithValue("book", book);
                    command.Parameters.AddWithValue("@userId", selectedUser);

                    command.ExecuteNonQuery();

                    textBoxNewBookName.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении книги: " + ex.Message);
            }
            finally
            {
                connection.Close();
                
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
                connection.Open();

                var temp = (User)selected;
                var selectedUser = temp.Id;

                string query = "SELECT * FROM Books WHERE userId = " + selectedUser;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var Title = listBoxBooks.Text;

                    command.Parameters.AddWithValue("Title", Title);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string bookTitle = reader["Title"].ToString();
                        listBoxBooks.Items.Add(bookTitle);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке книг: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BtnShowAllUsers(object sender, EventArgs e)
        {
             
            try
            {
                listBoxUsers.Items.Clear();

                connection.Open();

                string query = "SELECT * FROM Users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Name = reader["name"].ToString();
                        user.Id = Convert.ToInt32(reader["id"]);
                        listBoxUsers.Items.Add(user);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка пользователей: " + ex.Message);
            }
            finally
            {
                connection.Close();
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
                connection.Open();

                var temp = (User)selected;
                var selectedUser = temp.Id;
                var selectedBook = listBoxBooks.SelectedItem.ToString();

                string query = $"DELETE FROM Books WHERE userId = {selectedUser} AND Title = '{selectedBook}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                listBoxBooks.Items.Clear();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении книг: " + ex.Message);

            }
            finally
            {
                connection.Close();   
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
                connection.Open();

                var temp = (User)selected;
                var selectedUser = temp.Id;

                string query = "DELETE FROM Users WHERE id = " + selectedUser;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }

                listBoxUsers.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении пользователя: " + ex.Message);
            }
            finally
            {
                connection.Close();
                
            }
        }

    }
}
