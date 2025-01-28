using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace skibidCRUD_SQL
{
    public partial class Form1 : Form
    {
        string serverName = "SERVER=localhost";
        string user = "UID=root";
        string password = "PASSWORD=";
        private string connectionString = "SERVER" + serverName + ";UID=" + user + ";PASSWORD" + password;

        private MySqlConnection connection;
        
        ConnectionState = new MySqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string serverName = "SERVER=localhost";
            string serverUser = ";UID=root";
            string serverPass = ";PASSWORD=";
            string finalConnection = serverName + serverUser + serverPass;
            MySqlConnection connection = new MySqlConnection(finalConnection);
            try
            {
                connection.Open();
                if(connection.State == ConnectionState.Open)
                {
                    msgLabel.Text = "Úspěšně připojeno";
                    string commandSQL = "SHOW DATABASES";
                    MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);
                    MySqlDataReader dataReader = dataSQL.ExecuteReader();
                    lstDatabases.Items.Clear();
                    while (dataReader.Read())
                    {
                        lstDatabases.Items.Add(dataReader[0].ToString());
                    }
                    dataReader.Close();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                msgLabel.Text = "Chyba";
            }
        }
    }
}
