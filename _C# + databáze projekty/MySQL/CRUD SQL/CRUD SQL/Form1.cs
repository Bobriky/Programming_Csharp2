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

        int currentPage = 20; // Aktuální stránka

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Zkontrolujeme, jestli je nějaká položka vybrána
            if (listView1.SelectedItems.Count > 0)
            {
                // Získáme ID záznamu z vybrané položky
                string selectedId = listView1.SelectedItems[0].SubItems[0].Text;  // Předpokládáme, že ID je v prvním sloupci
                // Dynamické sestavení SQL dotazu pro smazání záznamu podle ID
                string selectedTable = listBox1.SelectedItem.ToString();  // Získáme název tabulky
                string commandSQL = $"DELETE FROM {selectedTable} WHERE pkAuto = {selectedId}";  // Sestavíme SQL dotaz

                // Připojení k databázi
                string serverName = "SERVER=localhost";
                string serverUser = ";UID=root";
                string serverPass = ";PASSWORD=";
                string selectedDatabase = listBox2.SelectedItem.ToString();
                string finalConnection = serverName + serverUser + serverPass + ";DATABASE=" + selectedDatabase;

                MySqlConnection connection = new MySqlConnection(finalConnection);
                MySqlCommand deleteCommand = new MySqlCommand(commandSQL, connection);

                try
                {
                    connection.Open();
                    int result = deleteCommand.ExecuteNonQuery();  // Spustíme příkaz pro smazání

                    // Pokud byl záznam úspěšně smazán, aktualizujeme ListView
                    if (result > 0)
                    {
                        MessageBox.Show("Záznam byl úspěšně odstraněn.");
                        listView1.Items.Clear();  // Vymažeme položky z ListView
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Chyba při odstraňování záznamu.");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při odstraňování: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vyberte záznam k odstranění.");
            }
        }

     

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Nastavení proměnných pro připojení k databázi MySQL
            string serverName = "SERVER=localhost";  // Určuje server, na kterém je databáze (v tomto případě localhost)
            string serverUser = ";UID=root";         // Nastavuje uživatelské jméno pro připojení k databázi (root)
            string serverPass = ";PASSWORD=";        // Určuje heslo (v tomto případě není nastaveno žádné heslo)

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
                    listBox2.Items.Clear();  // Vyčištění listBox2 (seznam databází)

                    // Čtení výsledků a přidání jednotlivých databází do listBox2
                    while (dataReader.Read())
                    {
                        listBox2.Items.Add(dataReader[0].ToString());  // Přidání názvu každé databáze do listBox2
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
     

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

                deleteButton.Enabled = false;

                LoadData();
            }

          
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pokud je vybraná databáze v listBox2
            if (listBox2.SelectedIndex != -1)
            {
                string selectedDatabase = listBox2.SelectedItem.ToString();  // Získání názvu vybrané databáze
                string serverName = "SERVER=localhost";  // Server zůstává "localhost"
                string serverUser = ";UID=root";  // Uživatelské jméno stále "root"
                string serverPass = ";PASSWORD=";  // Heslo zůstává prázdné

                // Sestavení připojovacího řetězce pro konkrétní databázi
                string finalConnection = serverName + serverUser + serverPass + ";DATABASE=" + selectedDatabase;
                MySqlConnection connection = new MySqlConnection(finalConnection);  // Vytvoření připojení k databázi

                try
                {
                    // Pokus o otevření připojení k databázi
                    connection.Open();

                    // Pokud je připojení úspěšně otevřeno
                    if (connection.State == ConnectionState.Open)
                    {
                        msgLabel.Text = "Databáze " + selectedDatabase + " otevřena";  // Zobrazení zprávy, že databáze byla otevřena
                        string commandSQL = "SHOW TABLES";  // SQL příkaz pro získání seznamu tabulek
                        MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);  // Vytvoření příkazu pro vykonání SQL dotazu
                        MySqlDataReader dataReader = dataSQL.ExecuteReader();  // Vykonání dotazu a získání výsledků
                        listBox1.Items.Clear();  // Vyčištění listBox1 (seznam tabulek)

                        // Čtení výsledků a přidání jednotlivých tabulek do listBox1
                        while (dataReader.Read())
                        {
                            listBox1.Items.Add(dataReader[0].ToString());  // Přidání názvu každé tabulky do listBox1
                        }
                        dataReader.Close();  // Zavření čtečky dat
                        connection.Close();  // Zavření připojení k databázi
                    }
                }
                catch (Exception ex)
                {
                    // Pokud dojde k chybě při připojování nebo vykonávání dotazu, zobrazí se chybová zpráva
                    msgLabel.Text = "Chyba při načítání tabulek: " + ex.Message;  // Zobrazení chybové zprávy
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Zkontrolujeme, jestli je vybraná nějaká položka
            if (listView1.SelectedItems.Count > 0)
            {
                // Pokud je položka vybrána, povolíme tlačítko pro smazání
                deleteButton.Enabled = true;
            }
            else
            {
                // Pokud není položka vybrána, tlačítko bude deaktivováno
                deleteButton.Enabled = false;
            }
        }

        private void LoadData()
        {
            string selectedTable = listBox1.SelectedItem.ToString();
            string serverName = "SERVER=localhost";
            string serverUser = ";UID=root";
            string serverPass = ";PASSWORD=";
            string selectedDatabase = listBox2.SelectedItem.ToString();
            string finalConnection = serverName + serverUser + serverPass + ";DATABASE=" + selectedDatabase;

            MySqlConnection connection = new MySqlConnection(finalConnection);
            string commandSQL = "SELECT * FROM " + selectedTable + " LIMIT 20 OFFSET " + currentPage;
            MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);

            try
            {
                connection.Open();
                MySqlDataReader dataReader = dataSQL.ExecuteReader();

                listView1.Items.Clear();
                listView1.Columns.Clear();  // Vymazání sloupců

                // Přidání sloupců do ListView
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    listView1.Columns.Add(dataReader.GetName(i));  // Přidání názvů sloupců
                }

                listView1.View = View.Details;

                // Přidání datových řádků do ListView
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader[0].ToString());  // První položka (např. id) je hlavní položka
                    for (int i = 1; i < dataReader.FieldCount; i++)
                    {
                        item.SubItems.Add(dataReader[i].ToString());  // Přidání hodnot pro ostatní sloupce
                    }
                    listView1.Items.Add(item);
                }

          

                dataReader.Close();
                connection.Close();

                connection.Open();

                comboBoxPage.Items.Clear();
                string query = $"SELECT COUNT(*) FROM {selectedTable}"; // Získání celkového počtu záznamů
                MySqlCommand command = new MySqlCommand(query, connection);
                int totalRecords = Convert.ToInt32(command.ExecuteScalar()); // Načteme celkový počet záznamů

                // Spočítáme počet stránek na základě počtu záznamů a velikosti stránky
                int totalPages = (int)Math.Ceiling((double)totalRecords / 20); // Zaokrouhlení nahoru pro počet stránek


                msgLabel.Text = totalPages.ToString();

                // Naplníme ComboBox stránkami
                for (int i = 1; i <= totalPages; i++)
                {
                    comboBoxPage.Items.Add("Stránka " + i); // Přidáme stránku jako "Stránka 1", "Stránka 2", ...
                }

                // Nastavení výchozí hodnoty pomocí SelectedItem


                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }

           
          

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
            string selectedTable = listBox1.SelectedItem.ToString();
            string serverName = "SERVER=localhost";
            string serverUser = ";UID=root";
            string serverPass = ";PASSWORD=";
            string selectedDatabase = listBox2.SelectedItem.ToString();
            string finalConnection = serverName + serverUser + serverPass + ";DATABASE=" + selectedDatabase;

            string commandSQL = "SELECT * FROM " + selectedTable;  // Default query without sorting

            MySqlConnection connection = new MySqlConnection(finalConnection);

            try
            {
                connection.Open();

                // Step 1: Get the first column name from the table
                MySqlCommand columnCommand = new MySqlCommand("SHOW COLUMNS FROM " + selectedTable, connection);
                MySqlDataReader columnReader = columnCommand.ExecuteReader();
                string firstColumnName = string.Empty;
                if (columnReader.Read())
                {
                    firstColumnName = columnReader["Field"].ToString();  // Get the first column name
                }
                columnReader.Close();

                // Step 2: If the first column exists, add ORDER BY DESC to the query
                if (!string.IsNullOrEmpty(firstColumnName))
                {
                    commandSQL = "SELECT * FROM " + selectedTable + " ORDER BY " + firstColumnName + " DESC";
                }

                // Step 3: Execute the query to get the data
                MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);
                MySqlDataReader dataReader = dataSQL.ExecuteReader();

                // Step 4: Prepare the ListView
                listView1.Items.Clear();
                listView1.Columns.Clear();  // Clear previous columns

                // Add columns to ListView
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    listView1.Columns.Add(dataReader.GetName(i));  // Add column names
                }

                listView1.View = View.Details;

                // Add data rows to ListView
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader[0].ToString());  // The first item (ID) is the main item
                    for (int i = 1; i < dataReader.FieldCount; i++)
                    {
                        item.SubItems.Add(dataReader[i].ToString());  // Add values for other columns
                    }
                    listView1.Items.Add(item);
                }

                // Close data reader and connection
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();  // Ensure the connection is closed in any case
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedTable = listBox1.SelectedItem.ToString();
            string serverName = "SERVER=localhost";
            string serverUser = ";UID=root";
            string serverPass = ";PASSWORD=";
            string selectedDatabase = listBox2.SelectedItem.ToString();
            string finalConnection = serverName + serverUser + serverPass + ";DATABASE=" + selectedDatabase;

            string commandSQL = "SELECT * FROM " + selectedTable;  // Default query without sorting

            MySqlConnection connection = new MySqlConnection(finalConnection);

            try
            {
                connection.Open();

                // Step 1: Get the first column name from the table
                MySqlCommand columnCommand = new MySqlCommand("SHOW COLUMNS FROM " + selectedTable, connection);
                MySqlDataReader columnReader = columnCommand.ExecuteReader();
                string firstColumnName = string.Empty;
                if (columnReader.Read())
                {
                    firstColumnName = columnReader["Field"].ToString();  // Get the first column name
                }
                columnReader.Close();

                // Step 2: If the first column exists, add ORDER BY DESC to the query
                if (!string.IsNullOrEmpty(firstColumnName))
                {
                    commandSQL = "SELECT * FROM " + selectedTable + " ORDER BY " + firstColumnName + " ASC";
                }

                // Step 3: Execute the query to get the data
                MySqlCommand dataSQL = new MySqlCommand(commandSQL, connection);
                MySqlDataReader dataReader = dataSQL.ExecuteReader();

                // Step 4: Prepare the ListView
                listView1.Items.Clear();
                listView1.Columns.Clear();  // Clear previous columns

                // Add columns to ListView
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    listView1.Columns.Add(dataReader.GetName(i));  // Add column names
                }

                listView1.View = View.Details;

                // Add data rows to ListView
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader[0].ToString());  // The first item (ID) is the main item
                    for (int i = 1; i < dataReader.FieldCount; i++)
                    {
                        item.SubItems.Add(dataReader[i].ToString());  // Add values for other columns
                    }
                    listView1.Items.Add(item);
                }

                // Close data reader and connection
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat: " + ex.Message);
            }
            finally
            {
                connection.Close();  // Ensure the connection is closed in any case
            }
        }

        private void comboBoxPage_SelectedIndexChanged(object sender, EventArgs e)
        {
     

        }




    }
}
