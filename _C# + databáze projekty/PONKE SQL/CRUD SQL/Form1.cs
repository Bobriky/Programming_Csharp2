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
using System.IO;


namespace CRUD_SQL
{
    public partial class Form1 : Form
    {

        private MySqlConnection connection;

        string serverName = "SERVER=localhost";
        string serverUser = ";UID=root";
        string serverPass = ";PASSWORD=";

        public Form1()
        {
            InitializeComponent();
            ExportDataToCSV.Enabled = false;
            ImportDataFromCSV.Enabled = false;
            orderButtonDown.Enabled = false;
            orderButtonUp.Enabled = false;
            deleteButton.Enabled = false;
            addButton.Enabled = false;
        }

        private MySqlConnection GetDatabaseConnection()
        {
            string selectedDatabase = databasesList.SelectedItem.ToString();
            string selectedTable = tablesList.SelectedItem.ToString();
            string finalConnection = $"{serverName}{serverUser}{serverPass};DATABASE={selectedDatabase}";
            return new MySqlConnection(finalConnection);
        }

        private bool isConnected = false;  // Počátečně nejsme připojeni

        private void connectButton_Click(object sender, EventArgs e)
        {
            string finalConnection = serverName + serverUser + serverPass;
            MySqlConnection connection = new MySqlConnection(finalConnection);

            try
            {
                if (!isConnected)  // Pokud nejsme připojeni
                {
                    // Otevření připojení
                    connection.Open();

                    // Kontrola, zda je připojení úspěšně otevřeno
                    if (connection.State == ConnectionState.Open)
                    {
                        msgLabel.Text = "Úspěšné připojeno";  // Zobrazíme zprávu o připojení

                        databasesList.Items.Clear();

                        // Získání seznamu databází
                        string commandSQL = "SHOW DATABASES";
                        MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);
                        MySqlDataReader dataReader = dataSQL.ExecuteReader();

                        // Naplnění listu databázemi
                        while (dataReader.Read())
                        {
                            databasesList.Items.Add(dataReader[0].ToString());
                        }

                        dataReader.Close();  // Zavřeme dataReader

                        // Nastavíme stav připojení na true
                        isConnected = true;

                        // Změníme text tlačítka na "Odpojit"
                        connectButton.Text = "Odpojit";
                    }
                }
                else  // Pokud jsme již připojeni
                {
                    // Zavření připojení
                    connection.Close();
                    msgLabel.Text = "Odpojeno";  // Zobrazíme zprávu o odpojení

                    // Nastavíme stav připojení na false
                    isConnected = false;

                    // Změníme text tlačítka na "Připojit"
                    connectButton.Text = "Připojit";
                }
            }
            catch (Exception ex)
            {
                msgLabel.Text = "Chyba: " + ex.Message;  // Zobrazíme chybu, pokud nastane
            }

        }

        private void comboBoxPage_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void databasesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(databasesList.SelectedIndex != -1)
            {
                string selectedDatabase = databasesList.SelectedItem.ToString();
                string finalConnection = serverName + serverUser + serverPass + ";DATABASE=" + selectedDatabase;
 
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

        public void loadData(string filter = "", int page = 1)
        {

            string selectedDatabase = databasesList.SelectedItem.ToString();
            string selectedTable = tablesList.SelectedItem.ToString();
            string finalConnection = serverName + serverUser + serverPass + ";DATABASE=" + selectedDatabase;
            MySqlConnection connection = new MySqlConnection(finalConnection);

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // Získání názvů sloupců (dataReaderPreset)
                    string commandSQL = "SELECT * FROM " + selectedTable;
                    MySqlCommand dataSQLPreset = new MySqlCommand(commandSQL, connection);
                    MySqlDataReader dataReaderPreset = dataSQLPreset.ExecuteReader();
                    string columnName = "";
                    if(dataReaderPreset.FieldCount > 1)
                    {
                        columnName = dataReaderPreset.GetName(1);
                    }
                    else
                    {
                        MessageBox.Show("Tabulka má méně jak 2 sloupce");
                    }

                    dataReaderPreset.Close();

                    if(filter == "DESC")
                    {
                        commandSQL = "SELECT * FROM " + selectedTable + " ORDER BY " + columnName + " DESC";
                    }else if (filter == "ASC")
                    {
                        commandSQL = "SELECT * FROM " + selectedTable + " ORDER BY " + columnName + " ASC";
                    }
                    else
                    {
                        commandSQL = "SELECT * FROM " + selectedTable;
                    }


                    MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);
                    MySqlDataReader dataReader = dataSQL.ExecuteReader();

                    // Vyčistíme předchozí data
                    databaseData.Items.Clear();
                    databaseData.Columns.Clear();

                    // Přidání názvů sloupců do ListView
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        databaseData.Columns.Add(dataReader.GetName(i));
                    }

                    databaseData.View = View.Details;

                    // Načítání dat a přidání do ListView
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader[0].ToString());
                        for (int x = 1; x < dataReader.FieldCount; x++)
                        {
                            item.SubItems.Add(dataReader[x].ToString());
                        }
                        databaseData.Items.Add(item);
                    }

                    dataReader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
        }

        private void tablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tablesList.SelectedIndex != -1)
            {
                loadData();
            }
        }

        private void ExportDataToCSV_Click(object sender, EventArgs e)
        {
         

        }

        private void ImportDataFromCSV_Click(object sender, EventArgs e)
        {
           
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void databaseData_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderButtonDown.Enabled = true;
            orderButtonUp.Enabled = true;
            deleteButton.Enabled = true;
            addButton.Enabled = true;
        }

        private void orderButtonUp_Click(object sender, EventArgs e)
        {
            if (tablesList.SelectedIndex != -1)
            {
                loadData("DESC");
            }
                
        }

        private void orderButtonDown_Click(object sender, EventArgs e)
        {
            if (tablesList.SelectedIndex != -1)
            {
                loadData("ASC");
            }
        }
    }
}
