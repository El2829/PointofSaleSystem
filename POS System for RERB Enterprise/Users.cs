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
    public partial class Users : UserControl
    {
        Database dbhelper;
        DataTable dtable;
        string userid = "";
        public Users()
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
                load_tbluser();
                addEditButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void load_tbluser()
        {
            if (dbhelper.openConnection())
            {
                string query = "SELECT * FROM usersview";
                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                dtable = new DataTable();
                da.Fill(dtable);
                dgv.DataSource = dtable;

                dbhelper.closeConnection();
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            AddUser User = new AddUser();
            User.ShowDialog();
        }
        private void addEditButton()
        {
            dgv.Columns[0].Width = 40;
            DataGridViewButtonColumn btnx = new DataGridViewButtonColumn();
            dgv.Columns.Add(btnx);
            btnx.HeaderText = "Edit Data";
            btnx.Text = "Edit";
            btnx.Name = "btn";
            btnx.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btny = new DataGridViewButtonColumn();
            dgv.Columns.Add(btny);
            btny.HeaderText = "Delete Data";
            btny.Text = "Delete";
            btny.Name = "btndel";
            btny.UseColumnTextForButtonValue = true;
        }

        private  void userdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                Variable.algoid = row.Cells["#"].Value.ToString();
                string fullname = row.Cells["FullName"].Value.ToString();
                EditUser1 user = new EditUser1();
                DialogResult dr = MessageBox.Show("Are you sure you want to edit the account of " + fullname + " ? ", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "SELECT * FROM tblUserInfo WHERE AccountID=@id";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("id", Variable.algoid);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            user.Fnametxt.Text = reader["U_Fname"].ToString();
                            user.Mnametxt.Text = reader["U_Mname"].ToString();
                            user.Lnametxt.Text = reader["U_Lname"].ToString();
                            user.Enametxt.Text = reader["U_Suffix"].ToString();
                            //user.EmailAddtxt.Text = reader["U_EmailAdd"].ToString();
                            //user.Contactnotxt.Text = reader["U_ContactNo"].ToString();
                            user.Add_btn.Text = "Edit";
                        }
                        dbhelper.closeConnection();
                    }
                }
                if (dbhelper.openConnection())
                {
                    string query = "SELECT * FROM tblaccount WHERE AccountID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                    cmd.Parameters.AddWithValue("Password", Variable.algopass);
                    cmd.Parameters.AddWithValue("id", Variable.algoid);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //user.AccTypecmb.Text = reader["UserStatus"].ToString();
                        user.Usernametxt.Text = reader["Username"].ToString();
                    }
                    dbhelper.closeConnection();
                }
            }
            else if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                userid = row.Cells["#"].Value.ToString();
                string fullname = row.Cells["FullName"].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure you want to delete the account of " + fullname + " ? ", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "Delete from tblaccount where AccountID=@id; Delete From tbluserinfo Where AccountID=@id; Delete from tblloghistory where AccountID=@id";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("id", userid);
                        cmd.ExecuteNonQuery();
                        dbhelper.closeConnection();
                    }
                    MessageBox.Show("Deleted User!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_tbluser();
                }
                else if (dr == DialogResult.No)
                {

                }
            }
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(dtable);
                DV.RowFilter = string.Format("[Username] LIKE '%{0}%' OR [Fullname] LIKE '%{0}%' OR [ContactNo] LIKE '%{0}%' OR [EmailAdd] LIKE '%{0}%'", Searchtxt.Text);
                dgv.DataSource = DV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input!" + ex.ToString());
            }
        }
    }
}
