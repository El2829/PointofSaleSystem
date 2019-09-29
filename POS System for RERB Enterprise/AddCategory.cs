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
    public partial class AddCategory : Form
    {
        Database dbhelper;
        DataSet ds;
        public AddCategory()
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
                ds = new DataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Add_btn.ButtonText == "Edit")
            {
                string query1 = "Select * From tblcategory where category ='" + txtcategory.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, dbhelper.getConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Category " + txtcategory.Text + " Already Exists");
                    ds.Clear();
                }

                else if (txtcategory.Text == "")
                {
                    MessageBox.Show("Fields Can't be blank!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "UPDATE tblcategory set category = @cname, AccountID = @accid, DateAdded =@now WHERE categoryID = @id ";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("cname", txtcategory.Text);
                        cmd.Parameters.AddWithValue("id", Variable.categoryid);
                        cmd.Parameters.AddWithValue("accid", Variable.userid);
                        cmd.Parameters.AddWithValue("now", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    dbhelper.closeConnection();
                    MessageBox.Show("Category information updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MainForm Form = new MainForm();
                    Form.BringToFront();
                }
            }

            else if (Add_btn.ButtonText == "Add Category")

            {
                string query1 = "Select * From tblcategory where category ='" + txtcategory.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, dbhelper.getConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Category " + txtcategory.Text + " Already Exists");
                    ds.Clear();
                }

                else if (txtcategory.Text == "")
                {
                    MessageBox.Show("Fields Can't be blank!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "INSERT INTO `tblcategory`(`category`,`AccountID`,`DateAdded`) VALUES(@cname,@id,@now)";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("cname", txtcategory.Text);
                        cmd.Parameters.AddWithValue("id", Variable.userid);
                        cmd.Parameters.AddWithValue("now", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    dbhelper.closeConnection();
                    MessageBox.Show("New Category Added!");
                    this.Close();
                    MainForm Form = new MainForm();
                    Form.BringToFront();
                }
            }
        }

        private void CloseImageButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want Exit?", "Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dr == DialogResult.No)
            {

            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
