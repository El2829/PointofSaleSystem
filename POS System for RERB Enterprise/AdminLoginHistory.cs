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

namespace POS_System_for_RERB_Enterprise
{
    public partial class AdminLoginHistory : UserControl
    {
        Database dbhelper;
        public AdminLoginHistory()
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
                loadLogin(Variable.userid, logindgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void loadLogin(string accid, DataGridView view)
        {
            if (dbhelper.openConnection())
            {
                string query = "SELECT PC_Name, LoggedIN , LoggedOut from tblloghistory WHERE AccountID=@id";
                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                cmd.Parameters.AddWithValue("id", accid);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable log = new DataTable();
                da.Fill(log);
                view.DataSource = log;
                dbhelper.closeConnection();
            }
        }

        private void AdminLoginHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
