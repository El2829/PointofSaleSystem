using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace POS_System_for_RERB_Enterprise.Pages
{
    public partial class Dashboard : UserControl
    {
        Database db;
        public Dashboard()
        {
            Connection.setServer("127.0.0.1");
            Connection.setPort("3307");
            Connection.setUser("personal");
            Connection.setDatabase("pos");
            Connection.setPassword("borinaga09");
            InitializeComponent();
            try
            {
                db = new Database(Connection.getConnectionStr());
                load_userlabel();
                load_userlabel1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void load_userlabel()
        {
           
            if (db.openConnection())
            {
                int noOfusers = 0;
                string query = "Select COUNT(*) as AccountID from usersview";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    noOfusers = int.Parse(reader["AccountID"].ToString());
                }
                db.closeConnection();
                userlabel.Text = noOfusers.ToString();
            }
        }

        public void load_userlabel1()
        {

            if (db.openConnection())
            {
                int noOfusers = 0;
                string query = "Select COUNT(*) as LogID from tblloghistory";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    noOfusers = int.Parse(reader["LogID"].ToString());
                }
                db.closeConnection();
                monoFlat_HeaderLabel22.Text = noOfusers.ToString();
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
