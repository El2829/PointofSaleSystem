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
    public partial class LoginForm : Form
    {
        Database dbconnection;
        int trials = 3;
        string name = System.Environment.MachineName;
        public LoginForm()
        {
            InitializeComponent();
            Connection.setServer("127.0.0.1");
            Connection.setPort("3307");
            Connection.setUser("personal");
            Connection.setDatabase("pos");
            Connection.setPassword("borinaga09");

            dbconnection = new Database(Connection.getConnectionStr());
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void registerToLogHistory(string accid)
        {
            if (dbconnection.openConnection())
            {
                string query = "INSERT INTO `tblloghistory`(`AccountID`, `PC_Name`, `LoggedIN`, `LoggedOut`) VALUES (@id, @name, @now, '--------')";
                MySqlCommand cmd = new MySqlCommand(query, dbconnection.getConnection());
                cmd.Parameters.AddWithValue("id", accid);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("now", DateTime.Now);
                cmd.ExecuteNonQuery();
                dbconnection.closeConnection();
            }
        }
        private void CloseImageButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Close the Application?", "Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dr == DialogResult.No)
            {

            }
        }

        private void MinimizeImageButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string user = Login_txt.Text; //variable for Username
            string pass = Password_Txt.Text; //variable for Password
            if (user == "Enter Username" || pass == "Enter Password")
            {

                MessageBox.Show("Username / Password can't be blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (trials == 0 || trials <= 0)
                {
                    MessageBox.Show("You have used all your trials!, Please restart the application!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    Variable.userlogged = Login_txt.Text;
                    Variable.userpass = Password_Txt.Text;
                    if (dbconnection.openConnection())
                    {
                        try
                        {
                            string query = "SELECT UserStatus, AccountID FROM tblaccount WHERE username = @user AND password = @pass";
                            MySqlCommand cmd = new MySqlCommand(query, dbconnection.getConnection());
                            cmd.Parameters.AddWithValue("@user", Login_txt.Text); 
                            cmd.Parameters.AddWithValue("@pass",MD5Hasher.GetMd5Hash(Password_Txt.Text));
                            MySqlDataReader reader = cmd.ExecuteReader();
                            int count = 0;

                            while (reader.Read())
                            {
                                count++;
                                Variable.userStatus = reader["UserStatus"].ToString();
                                Variable.userid = reader["AccountID"].ToString();
                            }

                            dbconnection.closeConnection();
                            if (count == 1)
                            {
                                trials = 3;
                                if (Variable.userStatus == "Staff")
                                {
                                    registerToLogHistory(Variable.userid);
                                }
                                else if (Variable.userStatus == "Admin")
                                {
                                    registerToLogHistory(Variable.userid);
                                    MainForm admin = new MainForm();
                                    admin.ShowDialog();
                                }
                                else if (Variable.userStatus == "Manager")
                                {
                                    registerToLogHistory(Variable.userid);
                                }
                                else if (Variable.userStatus == "Cashier")
                                {
                                    registerToLogHistory(Variable.userid);
                                }

                                Login_txt.Text = "Enter Username";
                                Password_Txt.Text = "Enter Password";
                            }
                            else if (count == 0)
                            {
                                MessageBox.Show("Incorrect Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                trials--;
                                if (trials == 0 || trials <= 0)
                                {
                                    MessageBox.Show("You have used all your trials!, Please restart the application!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    dbconnection.closeConnection();

                }
            }
        }

        private void Login_txt_Enter(object sender, EventArgs e)
        {
            if (Login_txt.Text == "Enter Username")
            {
                Login_txt.Text = string.Empty;
                Login_txt.ForeColor = Color.Black;
            }
        }

        private void Login_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //enter key press
            {
                Password_Txt.Focus();//focusing the next txtbox after keypress
            }
        }

        private void Password_Txt_Leave(object sender, EventArgs e)
        {
            if (Password_Txt.Text == string.Empty)
            {
                Password_Txt.Text = "Enter Password";
                Password_Txt.ForeColor = Color.Silver;
                Password_Txt.isPassword = false;
            }
        }

        private void Login_txt_Leave(object sender, EventArgs e)
        {
            if (Login_txt.Text == string.Empty)
            {
                Login_txt.Text = "Enter Username";
                Login_txt.ForeColor = Color.Silver;
            }
        }

        private void Password_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //enter key press
            {
                Login_btn_Click(sender, e);//focusing the next txtbox after keypress
            }
        }

        private void Password_Txt_Enter(object sender, EventArgs e)
        {
            if (Password_Txt.Text == "Enter Password")
            {
                Password_Txt.Text = string.Empty;
                Password_Txt.ForeColor = Color.Black;
                Password_Txt.isPassword = true;
            }
        }

        private void ForgetPasslbl_Click(object sender, EventArgs e)
        {
             //showing new form
            ForgetForm.ShowDialog(); //for form not to be executed twice after done
        }
    }
}
