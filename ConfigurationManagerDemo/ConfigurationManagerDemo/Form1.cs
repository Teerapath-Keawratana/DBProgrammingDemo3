using System.Data.SqlClient;
using CM = System.Configuration.ConfigurationManager;

namespace ConfigurationManagerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string? settingOne = CM.AppSettings["MyFirstSetting"]; //MyFirstSetting from app.config file
                string? settingTwo = CM.AppSettings["MyName"];
                string? settingThree = CM.AppSettings["MyNumber"];
                string? noSuchSetting = CM.AppSettings["NotASetting"];

                int myNumber = Convert.ToInt32(settingThree);
                int calculation = myNumber * 2;

                lblSetting1.Text = settingOne;
                lblSetting2.Text = settingTwo;
                lblSetting3.Text = calculation.ToString();

                MessageBox.Show(noSuchSetting);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNorthwind_Click(object sender, EventArgs e)
        {
            ConnectToDatabase("NorthwindConnection");
        }

        private void btnGEX2025_Click(object sender, EventArgs e)
        {
            ConnectToDatabase("GEXConnection");
        }

        private void ConnectToDatabase(string connectionName)
        {
            SqlConnection conn = null;

            try
            {
                string connectionString = CM.ConnectionStrings[connectionName].ConnectionString;

                conn = new(connectionString); // from new SqlConnection(connectionString);

                conn.Open();
                MessageBox.Show($"Connection state is {conn.State}");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Connection Fail.");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null) 
                {
                    conn.Close();
                    MessageBox.Show($"Connection state is {conn.State}");
                    conn.Dispose();
                }
            }
        }

        
    }
}
