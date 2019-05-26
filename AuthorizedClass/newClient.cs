using System;
using System.Configuration;
using System.Data.SqlClient;
namespace AuthorizedClass
{
    public class newClient
    {
        public int counter;
        static public string connectionString = ConfigurationManager.AppSettings["connectionString"];

        static SqlConnection connection = new SqlConnection(connectionString);

        protected string Firstname { get; set; }

        protected string Name { get; set; }

        protected string Phonenumber { get; set; }

        protected string Model { get; set; }

        protected string Brand { get; set; }

        protected string Mulfunction { get; set; }

        protected int Year { get; set; }

        protected double Enginevalue { get; set; }

        protected string Fueltype { get; set; }

        protected string Time { get; set; }
        public newClient()
        {
            Firstname = "Іванов";
            Name = "Іван";
            Phonenumber = "+380777777777";
            Model = "Audi";
            Brand = "R8";
            Mulfunction = " ";
            Year = 20018;
            Enginevalue = 3.5;
            Fueltype = "Бензин";
            Time = "30.05.19 10:30";
        }
        public newClient(string firstName, string name, string phonenubmer, string brand, string model, string mulfunction, int year, double enginevalue, string fueltype, string time)
        {
            Firstname = firstName;
            Name = name;
            Phonenumber = phonenubmer;
            Model = model;
            Brand = brand;
            Mulfunction = mulfunction;
            Year = year;
            Enginevalue = enginevalue;
            Fueltype = fueltype;
            Time = time;
        }
        public virtual void nEWClient(string firstName, string name, string phonenubmer, string brand, string model, string mulfunction, string year, string enginevalue, string fueltype, string time)
        {
            string query = "INSERT INTO Client (Firstname, Name, Brand, Model, Year, Date, Fueltype, Enginevalue, Clientphone, Malfunction)" +
                " VALUES(@Firstname, @Name, @Brand, @Model, @Year, @Date, @Fueltype, @Enginevalue, @Clientphone, @Malfunction)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.AddWithValue("@Firstname", firstName);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Brand", brand);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Date", time);
                  command.Parameters.AddWithValue("@Fueltype", fueltype);
                command.Parameters.AddWithValue("@Enginevalue", enginevalue);
                command.Parameters.AddWithValue("@Clientphone", phonenubmer);
                command.Parameters.AddWithValue("@Malfunction", mulfunction);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public virtual void ClientExist(string firstName, string name, string model)
        {
            counter = 1;
            string query = "Select [Firstname], [Name], [Model] from Client where Firstname = '" + firstName + "' and Name = '" + name + "' and Model = '" + model + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand Command = new SqlCommand(query, connection);
                SqlDataReader reader;
                connection.Open();
                reader = Command.ExecuteReader();
                while(reader.Read())
                {
                    counter = 0;
                }
            }
        }
    }

}
