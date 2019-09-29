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
    public partial class ForgetForm : Form
    {
        Database dbhelper;
        private string answer = "";
        public ForgetForm()
        {
            Connection.setServer("127.0.0.1");
            Connection.setPort("3307");
            Connection.setUser("personal");
            Connection.setDatabase("pos");
            Connection.setPassword("borinaga09");
            dbhelper = new Database(Connection.getConnectionStr());
            InitializeComponent();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (txtanswer.Text == answer)
            {
                if (txtpassword.Text == txtnewpassword.Text)
                {
                    if (txtpassword.Text != "")
                    {
                        if (dbhelper.openConnection())
                        {
                            try
                            {

                                string query = "UPDATE tblaccount SET password = @pass WHERE username = @user";
                                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                                cmd.Parameters.AddWithValue("user", txtusername.Text);
                                cmd.Parameters.AddWithValue("pass", MD5Hasher.GetMd5Hash(txtnewpassword.Text));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Your password is changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("New password cant\'t be blank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                }
                else
                {
                    MessageBox.Show("New password mismatched!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dbhelper.closeConnection();
            }
            else
            {
                MessageBox.Show("Answer mismatched!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseImageButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want Exit?", "Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                LoginForm Form = new LoginForm();
                Form.BringToFront();
            }
            else if (dr == DialogResult.No)
            {

            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            dbhelper.openConnection();
            string query = "SELECT Question, Answer from tblanswerview WHERE username=@user";
            MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
            cmd.Parameters.AddWithValue("user", txtusername.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
                if (count == 1)
                {
                    txtquestion.Text = "Question: " + reader["Question"].ToString();
                    answer = reader["Answer"].ToString();
                }
            }
            if (count == 0)
            {
                txtquestion.Text = "Username: " + txtusername.Text + " doesn't exist!";
                answer = "";
            }
            dbhelper.closeConnection();
        }

        private void ForgotForm_Load(object sender, EventArgs e)
        {

        }
    }
}
