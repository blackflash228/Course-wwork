using System.Configuration;
using System.Data.SqlClient;
using System.Dynamic;
using System.Runtime.Serialization.Formatters;

namespace AuthorizedClass
{
    public class AdminAuthorization
    {
        static public string connectionString = ConfigurationManager.AppSettings["connectionString"];

        static SqlConnection connection = new SqlConnection(connectionString);

        protected string Password;

        protected string Login;

        protected string Position;

        protected string Email;

         public string email{get; set;}

         public string position { get; set; }

        public string password { set; get; }

        public string login { set; get; }

        public int counter;


        public virtual void AdminAuthing(string login, string pass)
        {
            string query = "Select [Login], [Password] from Admin where Login = '" + login + "' and Password = '" + pass + "'";
            using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                SqlCommand Command = new SqlCommand(query, Connection);
                SqlDataReader Reader;
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    counter++;
                }
            }
        }
    }  
}