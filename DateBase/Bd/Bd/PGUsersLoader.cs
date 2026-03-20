using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Bd
{
    class PGUsersLoader
    {
        public List<User> Users()
        {
            List<User> allUsers = new List<User>();
            var cs = "Host=192.168.1.48;Username=postgres;Password=PG@dmin$;Database=proptest";
            var con = new NpgsqlConnection(cs);

            con.Open();
            var sql = "SELECT login,password,name,last_name,age FROM myusers";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                allUsers.Add(new User
                {
                    Login = reader.GetString(0),
                    Password = reader.GetString(1),
                    Last_name = reader.GetString(2),
                    Name = reader.GetString(3),
                    Phone = reader.GetString(4),
                    EMail = reader.GetString(5)
                });
            }
            con.Close();

            return allUsers;

            var sql_del = @"DELETE FROM students WHERE login = @login";
            string connectionString = ConfigurationHelper.GetConnectionString("DefaultConnection");

            try
            {
                var dataSource_del = NpgsqlDataSource.Create(connectionString);
                var cmd_del = dataSource_del.CreateCommand(sql_del);
                cmd_del.Parameters.AddWithValue("@login", 1);
                cmd_del.ExecuteNonQueryAsync();
                Console.WriteLine("The row has been deleted successfully.");
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
