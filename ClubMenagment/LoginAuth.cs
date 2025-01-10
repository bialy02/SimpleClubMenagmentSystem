using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMenagment
{
    internal class LoginAuth
    {
        private readonly string connectionString = "Server=localhost;Database=clubmenagment;User Id=root;Password=;";
        string username;
        string password_hash;

        public LoginAuth(string username, string password)
        {
            this.username = username;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in data)
                {
                    sb.Append(b.ToString("x2"));
                }

                string ph = sb.ToString();
                this.password_hash = ph;
                
                
            }

        }

        public (bool,string) Authenticate()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "SELECT Name FROM users WHERE username = @username AND PasswordHash = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password_hash);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read(); 
                                string name = reader.GetString("Name");

                                return (true, name); 
                            }
                            else
                            {
                                return (false, null); 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Clipboard.SetText("An error occurred while authenticating: " + ex.Message);
                return (false, null); 
            }

        }
    }
}
