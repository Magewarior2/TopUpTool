using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TopUpTool
{
    public partial class Form1 : Form
    {
        private string ip = String.Empty;
        private string database = String.Empty;
        private string database2 = String.Empty;
        private string username = String.Empty;
        private string password = String.Empty;
        private string AccountID = String.Empty;

        private string connectinfochar = String.Empty;
        private string connectinfoaccount = String.Empty;

        public Form1()
        {
            InitializeComponent();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = $"Top up tool v{version} by MW2 (old db)";
            TxtBIP.Text = Properties.Settings.Default.IP;
            TxtBDBNAME.Text = Properties.Settings.Default.DBNAME;
            TxtBUSERNAME.Text = Properties.Settings.Default.USERNAME;
            TxtBPASSWORD.Text = Properties.Settings.Default.PASSWORD;
            TxtBAccDB.Text = Properties.Settings.Default.ACCDBNAME;
            comboBox1.Enabled = false;
            TxtBTOPUP270.Enabled = false;
            TxtBTOPUO1380.Enabled = false;
            BtnDisconnect.Enabled = false;
            LblLoadingPercentage.Text = $"Awaiting database information...";
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            LblLoadingPercentage.Text = $"Connecting to the database...";
            ip = TxtBIP.Text;
            database = TxtBDBNAME.Text;
            username = TxtBUSERNAME.Text;
            password = TxtBPASSWORD.Text;

            database2 = TxtBAccDB.Text;

            // Construct the connection string
            connectinfochar = $"SERVER={ip};DATABASE={database};UID={username};PASSWORD={password};";
            connectinfoaccount = $"SERVER={ip};DATABASE={database2};UID={username};PASSWORD={password};";

            TryToConnect();
        }

        private void TryToConnect()
        {
            Task.Delay(100).Wait(); 

            this.Cursor = Cursors.WaitCursor;

            using (MySqlConnection dataConnection = new MySqlConnection(connectinfochar))
            {
                try
                {
                    BtnConnect.Enabled = false;
                    TxtBIP.Enabled = false;
                    TxtBDBNAME.Enabled = false;
                    TxtBUSERNAME.Enabled = false;
                    TxtBPASSWORD.Enabled = false;
                    TxtBAccDB.Enabled = false;


                    dataConnection.Open();

                    // Set settings
                    Properties.Settings.Default.IP = TxtBIP.Text;
                    Properties.Settings.Default.DBNAME = TxtBDBNAME.Text;
                    Properties.Settings.Default.USERNAME = TxtBUSERNAME.Text;
                    Properties.Settings.Default.PASSWORD = TxtBPASSWORD.Text;
                    Properties.Settings.Default.ACCDBNAME = TxtBAccDB.Text;

                    // Save the settings
                    Properties.Settings.Default.Save();

                    LoadInfo();
                }
                catch (MySqlException ex) when (ex.Number == 0)
                {
                    // Can't connect to server
                    MessageBox.Show($"Can't connect to the server: {ex.Message}", "CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnConnect.Enabled = true;
                    TxtBIP.Enabled = true;
                    TxtBDBNAME.Enabled = true;
                    TxtBUSERNAME.Enabled = true;
                    TxtBPASSWORD.Enabled = true;
                    TxtBAccDB.Enabled = true;
                }
                catch (MySqlException ex)
                {
                    // Other exceptions
                    MessageBox.Show($"Error: {ex.Message}", "CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnConnect.Enabled = true;
                    TxtBIP.Enabled = true;
                    TxtBDBNAME.Enabled = true;
                    TxtBUSERNAME.Enabled = true;
                    TxtBPASSWORD.Enabled = true;
                    TxtBAccDB.Enabled = true;
                }
                finally
                {
                    LblLoadingPercentage.Text = $"Data loaded successfully!";
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void LoadInfo()
        {
            using (MySqlConnection dataConnection = new MySqlConnection(connectinfoaccount))
            {
                LblLoadingPercentage.Text = $"Loading data from database...";
                try
                {
                    dataConnection.Open();

                    Dictionary<string, string> userAccIdMap = new Dictionary<string, string>();

                    MySqlCommand countCommand = new MySqlCommand("SELECT COUNT(*) FROM account;", dataConnection);
                    int totalCount = Convert.ToInt32(countCommand.ExecuteScalar());

                    int currentCount = 0;

                    using (MySqlCommand command = new MySqlCommand("SELECT name, id FROM account;", dataConnection))
                    using (MySqlDataReader myReader = command.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            string username = myReader["name"].ToString();
                            string accid = myReader["id"].ToString();
                            comboBox1.Items.Add(username);
                            userAccIdMap[username] = accid;

                            currentCount++;


                            int progressPercentage = (int)(((double)currentCount / totalCount) * 100);

                            ProgressBar.Value = progressPercentage;

                        }
                    }

                    comboBox1.SelectedIndexChanged += (sender, args) =>
                    {
                        //if (comboBox1.Text == "")
                        //    { MessageBox.Show("No username selected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        // Retrieve selected username
                        string selectedUsername = comboBox1.SelectedItem.ToString();

                        string selectedAccid = userAccIdMap[selectedUsername];

                        AccountID = selectedAccid;
                    };  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            BtnTopup.Enabled = true;
            BtnTopup2.Enabled = true;
            comboBox1.Enabled = true;
            TxtBTOPUP270.Enabled = true;
            TxtBTOPUO1380.Enabled = true;
            BtnDisconnect.Enabled = true;
        }

        private void BtnTopup_Click(object sender, EventArgs e)
        {
            if (AccountID == null) { MessageBox.Show("No account ID found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (comboBox1.Text == "") { MessageBox.Show("No username selected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            PerformTopup(780000);
        }

        private void BtnTopup2_Click(object sender, EventArgs e)
        {
            if (AccountID == null) { MessageBox.Show("No account ID found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (comboBox1.Text == "") { MessageBox.Show("No username selected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            PerformTopup(780001);
        }

        private void PerformTopup(int baseChkSum)
        {

            int account_id;

            try
            {
                account_id = Convert.ToInt32(AccountID);

            }catch (Exception ex)
            {
                MessageBox.Show("No account ID found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }


           

            // Static values
            int ref_id = 1;
            int time_stamp = 0;
            int used = 0;
            int flag = 3;
            int ordernumber = 0;
            int card_in_time = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;

            // Calculate the checksum using bitwise XOR
            int chk_sum = baseChkSum ^ account_id;

            // Determine table based on baseChkSum
            string table = baseChkSum == 780000 ? "cq_card" : "cq_card2";

            string sqlQuery = $"INSERT INTO `{table}` (`id`, `type`, `account_id`, `ref_id`, `chk_sum`, `time_stamp`, `used`, `flag`, `ordernumber`, `card_in_time`) " +
                              $"VALUES (NULL, {baseChkSum}, {account_id}, {ref_id}, {chk_sum}, {time_stamp}, {used}, {flag}, {ordernumber}, {card_in_time});";

            using (MySqlConnection connection = new MySqlConnection(connectinfochar))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                    int amount = 1;
                    int CalculatedEPS = 0;
                    if (table == "cq_card") 
                    { amount = Convert.ToInt32(TxtBTOPUP270.Text); CalculatedEPS = 270; }

                    if (table == "cq_card2") 
                    { amount = Convert.ToInt32(TxtBTOPUO1380.Text); CalculatedEPS = 1380; }

                    for (int i = 0; i < amount; i++)
                    {
                        command.ExecuteNonQuery();
                    }
                    //int rowsAffected = command.ExecuteNonQuery(); 

                    CalculatedEPS = CalculatedEPS * amount;
                    string EPS = CalculatedEPS.ToString();

                    MessageBox.Show("Topup Player completed ( Added: " + EPS + " EPS )");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding top up: " + ex.Message);
                }
            }
        }

        private void LLbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mw2.vpsdata.be/");
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8) { e.Handled = true; }
        }

        private void TxtBTOPUP270_TextChanged(object sender, EventArgs e)
        {
            if (TxtBTOPUP270.Text == "") { return; }
            int amount = Convert.ToInt32(TxtBTOPUP270.Text);
            int CalculatedEPS = 270 * amount;
            string EPS = CalculatedEPS.ToString();
            LblTotalEP270.Text = $"Total: {EPS} EPS";
        }

        private void TxtBTOPUO1380_TextChanged(object sender, EventArgs e)
        {
            if (TxtBTOPUO1380.Text == "") { return; }
            int amount = Convert.ToInt32(TxtBTOPUO1380.Text);
            int CalculatedEPS = 1380 * amount;
            string EPS = CalculatedEPS.ToString();
            LblTotalEP1380.Text = $"Total: {EPS} EPS";
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AccountID = null;
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            TxtBIP.Text = Properties.Settings.Default.IP;
            TxtBDBNAME.Text = Properties.Settings.Default.DBNAME;
            TxtBUSERNAME.Text = Properties.Settings.Default.USERNAME;
            TxtBPASSWORD.Text = Properties.Settings.Default.PASSWORD;
            TxtBAccDB.Text = Properties.Settings.Default.ACCDBNAME;
            comboBox1.Enabled = false;
            TxtBTOPUP270.Enabled = false;
            TxtBTOPUO1380.Enabled = false;
            BtnDisconnect.Enabled = false;

            BtnConnect.Enabled = true;
            TxtBIP.Enabled = true;
            TxtBDBNAME.Enabled = true;
            TxtBUSERNAME.Enabled = true;
            TxtBPASSWORD.Enabled = true;
            TxtBAccDB.Enabled = true;
            ProgressBar.Value = 0;
            LblLoadingPercentage.Text = $"Awaiting database information...";
            comboBox1.Items.Clear();
        }
    }
}
