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
    public partial class AddUser : Form
    {
        Database dbhelper;
        DataSet ds;
        public AddUser()
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
                loadsecurity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadsecurity()
        {
            if (Securityquescmb.Items.Count > 0)
            {
                Securityquescmb.Items.Clear();
            }
            if (dbhelper.openConnection())
            {
                string query = "SELECT * from tblquestion";
                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Securityquescmb.Items.Add(reader.GetString(1));
                }
            }
            dbhelper.closeConnection();

        }
        private void AddUser_Load(object sender, EventArgs e)
        {

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

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Add_btn.ButtonText == "Edit")
            {
               
                if (AccTypecmb.Text == "" || Usernametxt.Text == "" || Passwordtxt.Text == "" || Fnametxt.Text == "" || Mnametxt.Text == "" || Lnametxt.Text == "" || Enametxt.Text == "" || EmailAddtxt.Text == "" || Contactnotxt.Text == "" || Securityquescmb.Text == "" || Answertxt.Text == "")
                {
                    MessageBox.Show("Fields Can't be blank!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "Update tblaccount set Username = @user, Password = @pass, UserStatus = @type, DateRegistered = @now WHERE AccountID=@id;" +
                            "Update tbluserinfo set U_Fname =  @fname, U_Mname =  @mname, U_Lname =  @lname, U_Suffix = @ename, U_EmailAdd = @emailadd, U_ContactNo = @contactno WHERE AccountID=@id;" +
                            "Update tblanswer set QuestionID = (SELECT tblquestion.QuestionID FROM tblquestion WHERE Question = CONVERT(@question USING utf8)), Answer = @answer WHERE AccountID = @id";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("type", AccTypecmb.Text);
                        cmd.Parameters.AddWithValue("user", Usernametxt.Text);
                        cmd.Parameters.AddWithValue("pass", MD5Hasher.GetMd5Hash(Passwordtxt.Text));
                        cmd.Parameters.AddWithValue("fname", Fnametxt.Text);
                        cmd.Parameters.AddWithValue("mname", Mnametxt.Text);
                        cmd.Parameters.AddWithValue("lname", Lnametxt.Text);
                        cmd.Parameters.AddWithValue("ename", Enametxt.Text);
                        cmd.Parameters.AddWithValue("emailadd", EmailAddtxt.Text);
                        cmd.Parameters.AddWithValue("contactno", Contactnotxt.Text);
                        cmd.Parameters.AddWithValue("question", Securityquescmb.Text);
                        cmd.Parameters.AddWithValue("answer", Answertxt.Text);
                        cmd.Parameters.AddWithValue("now", DateTime.Now);
                        cmd.Parameters.AddWithValue("id", Variable.algoid);
                        cmd.ExecuteNonQuery();
                    }

                    dbhelper.closeConnection();
                    MessageBox.Show("Updated new Account!");
                    this.Close();
                    MainForm Form = new MainForm();
                    Form.BringToFront();
                }
            }
            else if (Add_btn.ButtonText == "Add User")
            {
                if (Passwordtxt.Text == CPasswordtxt.Text)
                {
                    string query1 = "Select * From tblaccount where Username ='" + Usernametxt.Text + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, dbhelper.getConnection());
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                    da.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                        MessageBox.Show("Username " + Usernametxt.Text + " Already Exists");
                        ds.Clear();
                    }
                    else if (AccTypecmb.Text == "" || Usernametxt.Text == "" || Passwordtxt.Text == "" || Fnametxt.Text == "" || Mnametxt.Text == "" || Lnametxt.Text == "" || Enametxt.Text == "" || EmailAddtxt.Text == "" || Contactnotxt.Text == "" || Securityquescmb.Text == "" || Answertxt.Text == "")
                    {
                        MessageBox.Show("Fields Can't be blank!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dbhelper.openConnection();
                        if (AccTypecmb.Text == "Cashier")
                        {
                            string query = "Insert into tblaccount(Username, Password, UserStatus, DateRegistered) VALUES (@user, @pass, @type,@now);Insert into tbluserinfo(AccountID, U_Fname, U_Mname, U_Lname, U_Suffix, U_EmailAdd, U_ContactNo) VALUES (LAST_INSERT_ID(), @fname , @mname, @lname , @ename, @emailadd, @contactno)";
                            MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                            cmd.Parameters.AddWithValue("type", AccTypecmb.Text);
                            cmd.Parameters.AddWithValue("user", Usernametxt.Text);
                            cmd.Parameters.AddWithValue("pass", MD5Hasher.GetMd5Hash(Passwordtxt.Text));
                            cmd.Parameters.AddWithValue("fname", Fnametxt.Text);
                            cmd.Parameters.AddWithValue("mname", Mnametxt.Text);
                            cmd.Parameters.AddWithValue("lname", Lnametxt.Text);
                            cmd.Parameters.AddWithValue("ename", Enametxt.Text);
                            cmd.Parameters.AddWithValue("emailadd", EmailAddtxt.Text);
                            cmd.Parameters.AddWithValue("contactno", Contactnotxt.Text);
                            cmd.Parameters.AddWithValue("now", DateTime.Now);
                            cmd.ExecuteNonQuery();

                        }
                        else if (AccTypecmb.Text == "Admin")
                        {
                            string query = "Insert into tblaccount(Username, Password, UserStatus, DateRegistered) VALUES (@user, @pass, @type,@now);Insert into tbluserinfo(AccountID, U_Fname, U_Mname, U_Lname, U_Suffix, U_EmailAdd, U_ContactNo) VALUES (LAST_INSERT_ID(), @fname , @mname, @lname , @ename, @emailadd, @contactno)";


                            MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                            cmd.Parameters.AddWithValue("type", AccTypecmb.Text);
                            cmd.Parameters.AddWithValue("user", Usernametxt.Text);
                            cmd.Parameters.AddWithValue("pass", MD5Hasher.GetMd5Hash(Passwordtxt.Text));
                            cmd.Parameters.AddWithValue("fname", Fnametxt.Text);
                            cmd.Parameters.AddWithValue("mname", Mnametxt.Text);
                            cmd.Parameters.AddWithValue("lname", Lnametxt.Text);
                            cmd.Parameters.AddWithValue("ename", Enametxt.Text);
                            cmd.Parameters.AddWithValue("emailadd", EmailAddtxt.Text);
                            cmd.Parameters.AddWithValue("contactno", Contactnotxt.Text);
                            cmd.Parameters.AddWithValue("now", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                        else if (AccTypecmb.Text == "Staff")
                        {
                            string query = "Insert into tblaccount(Username, Password, UserStatus, DateRegistered) VALUES (@user, @pass, @type,@now);Insert into tbluserinfo(AccountID, U_Fname, U_Mname, U_Lname, U_Suffix, U_EmailAdd, U_ContactNo) VALUES (LAST_INSERT_ID(), @fname , @mname, @lname , @ename, @emailadd, @contactno)";


                            MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                            cmd.Parameters.AddWithValue("type", AccTypecmb.Text);
                            cmd.Parameters.AddWithValue("user", Usernametxt.Text);
                            cmd.Parameters.AddWithValue("pass", MD5Hasher.GetMd5Hash(Passwordtxt.Text));
                            cmd.Parameters.AddWithValue("fname", Fnametxt.Text);
                            cmd.Parameters.AddWithValue("mname", Mnametxt.Text);
                            cmd.Parameters.AddWithValue("lname", Lnametxt.Text);
                            cmd.Parameters.AddWithValue("ename", Enametxt.Text);
                            cmd.Parameters.AddWithValue("emailadd", EmailAddtxt.Text);
                            cmd.Parameters.AddWithValue("contactno", Contactnotxt.Text);
                            cmd.Parameters.AddWithValue("now", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }

                        else if (AccTypecmb.Text == "Manager")
                        {
                            string query = "Insert into tblaccount(Username, Password, UserStatus, DateRegistered) VALUES (@user, @pass, @type,@now);Insert into tbluserinfo(AccountID, U_Fname, U_Mname, U_Lname, U_Suffix, U_EmailAdd, U_ContactNo) VALUES (LAST_INSERT_ID(), @fname , @mname, @lname , @ename, @emailadd, @contactno)";


                            MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                            cmd.Parameters.AddWithValue("type", AccTypecmb.Text);
                            cmd.Parameters.AddWithValue("user", Usernametxt.Text);
                            cmd.Parameters.AddWithValue("pass", MD5Hasher.GetMd5Hash(Passwordtxt.Text));
                            cmd.Parameters.AddWithValue("fname", Fnametxt.Text);
                            cmd.Parameters.AddWithValue("mname", Mnametxt.Text);
                            cmd.Parameters.AddWithValue("lname", Lnametxt.Text);
                            cmd.Parameters.AddWithValue("ename", Enametxt.Text);
                            cmd.Parameters.AddWithValue("emailadd", EmailAddtxt.Text);
                            cmd.Parameters.AddWithValue("contactno", Contactnotxt.Text);
                            cmd.Parameters.AddWithValue("now", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }

                        string query2 = "INSERT INTO tblanswer(AccountID, QuestionID, Answer) VALUES (LAST_INSERT_ID(), (SELECT tblquestion.QuestionID FROM tblquestion WHERE Question=CONVERT(@question USING utf8)), @answer)";
                        MySqlCommand cmd2 = new MySqlCommand(query2, dbhelper.getConnection());
                        cmd2.Parameters.AddWithValue("question", Securityquescmb.Text);
                        cmd2.Parameters.AddWithValue("answer", Answertxt.Text);
                        cmd2.ExecuteNonQuery();


                        dbhelper.closeConnection();
                        MessageBox.Show("Added new Account!");
                        this.Close();
                        MainForm Form = new MainForm();
                        Form.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("Password do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
