using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMenagment.forms
{
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(passwordTxt.Text));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in data)
                {
                    sb.Append(b.ToString("x2"));
                }

                string ph = sb.ToString();
                
                using(MySqlConnection connection = new MySqlConnection("Server=localhost;Database=clubmenagment;User Id=root;Password=;"))
                {
                    connection.Open();
                    string query = "INSERT INTO users (Username, PasswordHash, Name) VALUES (@Username, @PasswordHash, @Name)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Username", loginTxt.Text);
                    command.Parameters.AddWithValue("@PasswordHash", ph);
                    command.Parameters.AddWithValue("@Name", nameTxt.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("User added successfully!");
                    this.Close();
                }

            }
        }

        private void addUser_Load(object sender, EventArgs e)
        {

        }
    }
}
