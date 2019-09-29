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
    public partial class EditUser1 : Form
    {
        Database dbhelper;
        public EditUser1()
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
                Enametxt.MaxLength = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Add_btn.Text == "Edit")
            {
                //enable text fields for modification
                Fnametxt.ReadOnly = false;
                Mnametxt.ReadOnly = false;
                Lnametxt.ReadOnly = false;
                Enametxt.ReadOnly = false;

                Add_btn.Text = "Save";
            }
            else if (Add_btn.Text == "Save")
            {
                //change account info
                if (Fnametxt.Text == "" || Mnametxt.Text == "" || Lnametxt.Text == "" || Enametxt.Text == "")
                {
                    MessageBox.Show("Please fill up necessary fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "Update tbluserinfo set U_Fname =  @fname, U_Mname =  @mname, U_Lname =  @lname, U_Suffix = @ename WHERE AccountID=@id;";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("fname", Fnametxt.Text);
                        cmd.Parameters.AddWithValue("mname", Mnametxt.Text);
                        cmd.Parameters.AddWithValue("lname", Lnametxt.Text);
                        cmd.Parameters.AddWithValue("ename", Enametxt.Text);
                        cmd.Parameters.AddWithValue("id", Variable.algoid);
                        cmd.ExecuteNonQuery();
                        dbhelper.closeConnection();
                    }
                    MessageBox.Show("Updated new Account!");
                    this.Close();
                    MainForm Form = new MainForm();
                    Form.BringToFront();
                }

            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changepass_Click(object sender, EventArgs e)
        {
            changePassword(Passwordtxt.Text, NPasswordtxt.Text, CPasswordtxt.Text);
        }

        private void changeuser_Click(object sender, EventArgs e)
        {
            changeUsername(Usernametxt.Text);
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

        private void changePassword(string currpass, string newpass, string confirmpass)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to change your password?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (currpass == "" || newpass == "" || confirmpass == "")
                {
                    MessageBox.Show("Fields Can\'t be blank!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (currpass == Variable.algopass)
                    {
                        if (newpass == confirmpass)
                        {
                            if (dbhelper.openConnection())
                            {
                                string query = "UPDATE tblaccount set password = @newpass WHERE AccountID=@id";
                                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                                cmd.Parameters.AddWithValue("newpass", MD5Hasher.GetMd5Hash(newpass));
                                cmd.Parameters.AddWithValue("id", Variable.algoid);
                                cmd.ExecuteNonQuery();
                                dbhelper.closeConnection();

                            }
                            MessageBox.Show("You have successfully changed your password!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Passwordtxt.Text = "";
                            CPasswordtxt.Text = "";
                            NPasswordtxt.Text = "";
                            this.Close();
                            MainForm Form = new MainForm();
                            Form.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("New password mismatched! Please Retype your new password!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current password mismatched! Please Retype your current password!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void EditUser1_Load(object sender, EventArgs e)
        {

        }

        private void changeUsername(string newusername)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to change your username?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //check if there is duplicate
                int count = 0;
                if (dbhelper.openConnection())
                {
                    string query = "Select COUNT(*) as Total from tblaccount WHERE username=@user";
                    MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                    cmd.Parameters.AddWithValue("user", newusername);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count = int.Parse(reader["Total"].ToString());
                    }
                    dbhelper.closeConnection();
                }
                if (count == 0)
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "UPDATE tblaccount set username = @newuser WHERE AccountID=@id";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("id", Variable.algoid);
                        cmd.Parameters.AddWithValue("newuser", newusername);
                        cmd.ExecuteNonQuery();
                        dbhelper.closeConnection();

                    }
                    MessageBox.Show("You have successfully changed your username!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Variable.userlogged = Usernametxt.Text;
                    Usernametxt.Text = "";
                    this.Close();
                    MainForm Form = new MainForm();
                    Form.BringToFront();
                }
                else
                {
                    MessageBox.Show("It seems that your preferred username is already taken!", "Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
