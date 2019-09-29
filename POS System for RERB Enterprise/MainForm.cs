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

namespace POS_System_for_RERB_Enterprise
{
    public partial class MainForm : Form
    {
        Database dbhelper;
        public MainForm()
        {
            Connection.setServer("127.0.0.1");
            Connection.setPort("3307");
            Connection.setUser("personal");
            Connection.setDatabase("pos");
            Connection.setPassword("borinaga09");
            InitializeComponent();
            try
            {
                dbhelper = new Database(Connection.getConnectionStr());
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Normal;
                dashboard1.BringToFront();
                Dashboardbtn.selected = true;
                users1.load_tbluser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CloseImageButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                
            }
            else if (dr == DialogResult.Yes)
            {
                updateLoggedOut(Variable.userid);
                Application.Exit();
            }
        }

        private void updateLoggedOut(string accid)
        {
            string lastlogID = "";

            try
            {
                if (dbhelper.openConnection())
                {
                    string query = "SELECT MAX(LogID) as LogID from tblloghistory where AccountID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                    cmd.Parameters.AddWithValue("id", Variable.userid);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lastlogID = reader["LogID"].ToString();
                    }
                    dbhelper.closeConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (dbhelper.openConnection())
            {
                string query = "UPDATE tblloghistory set LoggedOut=@log WHERE AccountID=@id AND LogID=@logid";
                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                cmd.Parameters.AddWithValue("id", Variable.userid);
                cmd.Parameters.AddWithValue("log", DateTime.Now);
                cmd.Parameters.AddWithValue("logid", lastlogID);

                cmd.ExecuteNonQuery();
                dbhelper.closeConnection();
            }
        }
        private void MinimizeImageButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
            dashboard1.BringToFront();
            Dashboardbtn.selected = true;
            users1.load_tbluser();
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
        }

        private void Audittrialbtn_Click(object sender, EventArgs e)
        {
            adminLoginHistory1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            users1.BringToFront();
        }

        private void MainForm_Activated_1(object sender, EventArgs e)
        {
            users1.load_tbluser();
            dashboard1.load_userlabel();
            product1.load_producttbl();
            category1.load_categorytbl();
            supplier1.load_suppliertbl();
            pointofSale1.load_producttbl();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            product1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            category1.BringToFront();
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            supplier1.BringToFront();
        }

        private void POSbtn_Click(object sender, EventArgs e)
        {
            pointofSale1.BringToFront();
        }
    }
}
