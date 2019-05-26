using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizedClass
{
    public class AdminNEW
    {
        public int counter;
        static public string connectionString = ConfigurationManager.AppSettings["connectionString"];
        static SqlConnection connection = new SqlConnection(connectionString);
        protected string Login { get; set; }
        protected string Password { get; set; }
        protected string Email { get; set; }
        protected string Position { get; set; }

        public AdminNEW()
        {
            Login = "admin";
            Password = "admin";
            Email = "testabt@ukr.net";
            Position = "QA engineer";
        }
        public AdminNEW(string login, string password, string email, string position)
        {
            Login = login;
            Password = password;
            Email = email;
            Position = position;
        }
        public virtual void addAdmin(string login, string password, string email, string position)
        {
            string query = "INSERT INTO Admin (Login, Password, Email, Position)" +
                " VALUES(@Login, @Password, @Email, @Position)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Position", position);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public virtual void AdminExist(string login, string password, string email, string position)
        {
            counter = 1;
            string query = "Select [Login], [Password], [Email], [Position] from Admin where  Login =  '" + login + "' and Password = '" + password + "' and Email = '" + email + "' and Position = '" + position + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand Command = new SqlCommand(query, connection);
                SqlDataReader reader;
                connection.Open();
                reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    counter = 0;
                }
            }
        }
    }
}
