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

namespace CRUD_SQL
{
    public partial class Form1 : Form
    {

        private MySqlConnection connection;
        // Nastavení proměnných pro připojení k databázi MySQL
        string serverName = "SERVER=localhost";  // Určuje server, na kterém je databáze (v tomto případě localhost)
        string serverUser = ";UID=root";         // Nastavuje uživatelské jméno pro připojení k databázi (root)
        string serverPass = ";PASSWORD=";        // Určuje heslo (v tomto případě není nastaveno žádné heslo)

        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

         
        }


        private void connectButton_Click(object sender, EventArgs e)
        {
            // Sestavení finálního připojovacího řetězce pro MySQL
            string finalConnection = serverName + serverUser + serverPass;
            MySqlConnection connection = new MySqlConnection(finalConnection);  // Vytvoření nové instance připojení k databázi
            try
            {
                // Pokus o otevření připojení k databázi
                connection.Open();

                // Pokud je připojení úspěšně otevřeno
                if (connection.State == ConnectionState.Open)
                {
                    msgLabel.Text = "Úspěšné připojeno";  // Zobrazí zprávu o úspěšném připojení
                    string commandSQL = "SHOW DATABASES";  // SQL příkaz pro získání seznamu databází
                    MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);  // Vytvoření příkazu pro vykonání SQL dotazu
                    MySqlDataReader dataReader = dataSQL.ExecuteReader();  // Vykonání dotazu a získání výsledků
                    databasesList.Items.Clear();  // Vyčištění listBox2 (seznam databází)

                    // Čtení výsledků a přidání jednotlivých databází do listBox2
                    while (dataReader.Read())
                    {
                        databasesList.Items.Add(dataReader[0].ToString());  // Přidání názvu každé databáze do listBox2
                    }
                    dataReader.Close();  // Zavření čtečky dat
                    connection.Close();  // Zavření připojení k databázi
                }
            }
            catch (Exception ex)
            {
                // Pokud dojde k chybě při připojování nebo vykonávání dotazu, zobrazí se chybová zpráva
                msgLabel.Text = "Chyba" + ex.Message;  // Zobrazení chybové zprávy
            }
        }

        private void LoadData()
        {
          

        }


        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBoxPage_SelectedIndexChanged(object sender, EventArgs e)
        {
     

        }

        private void databasesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(databasesList.SelectedIndex != -1)
            {
                string selectedDatabese = databasesList.SelectedItem.ToString();

                string finalConnection = serverName + serverUser + serverPass + ";DATABASE=" + selectedDatabese;
                
                MySqlConnection connection = new MySqlConnection(finalConnection);

                try
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        msgLabel.Text = "Úspěšné načteno";
                        string commandSQL = "SHOW TABLES";
                        MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);
                        MySqlDataReader dataReader = dataSQL.ExecuteReader();
                        tablesList.Items.Clear();
                        while (dataReader.Read())
                        {
                            tablesList.Items.Add(dataReader[0].ToString());
                        }
                        dataReader.Close();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    msgLabel.Text = "Chyba" + ex.Message;
                }
            }
        }

        private void tablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesList.SelectedIndex != -1)
            {
                string selectedTable = tablesList.SelectedItem.ToString();
                string selectedDatabese = databasesList.SelectedItem.ToString();
                string finalConnection = serverName + serverUser + serverPass + ";DATABASE=" + selectedDatabese;
                MySqlConnection connection = new MySqlConnection(finalConnection);


                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open) ;
                    {
                        string commandSQL = "SELECT * FROM " + selectedTable;
                        MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);
                        MySqlDataReader dataReader = dataSQL.ExecuteReader();
                        tableData.Items.Clear();
                        tableData.Columns.Clear();
                        for(int i = 0; i< dataReader.FieldCount; i++)
                        {
                            tableData.Columns.Add(dataReader.GetName(i));
                        }
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem(dataReader[0].ToString());
                            for (int x = 1; x < dataReader.FieldCount; x++)
                            {
                                item.SubItems.Add(dataReader[x].ToString());
                            }
                            tableData.Items.Add(item);

                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GG" + ex);
                    throw;
                }
            }
        }
    }
}
