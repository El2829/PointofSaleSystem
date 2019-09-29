using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_System_for_RERB_Enterprise
{
    public partial class AddProduct : Form
    {
        Database dbhelper;
        public AddProduct()
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
                GenerateID();
                cmbcat();
                cmbsup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GenerateID()
        {

        }

        void cmbcat()
        {
            if (dbhelper.openConnection())
            {
                string query = "select `Category` from `tblcategory`;";
                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString("Category");
                    cmbcategory.Items.Add(sname);
                }
            }
            dbhelper.closeConnection();
        }

        void cmbsup()
        {
            if (dbhelper.openConnection())
            {
                string query = "select `CompanyName` from `tblsupplier`;";
                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString("CompanyName");
                    cmbsupplier.Items.Add(sname);
                }
            }
            dbhelper.closeConnection();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Add_btn.ButtonText == "Edit")
            {
                if (txtproductname.Text == "" || cmbcategory.Text == "" || cmbsupplier.Text == "" || txtquantity.Text == "" || txtquantity.Text == "" || txtdescription.Text == "" || txtprize.Text == "")
                {
                    MessageBox.Show("Fields Can't be blank!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "UPDATE tblproduct set CategoryID = (SELECT tblcategory.categoryID FROM tblcategory WHERE category=CONVERT(@cname USING utf8)), AccountID = @accid, SupplierID = (SELECT tblsupplier.SupplierID FROM tblsupplier WHERE CompanyName=CONVERT(@sname USING utf8)), ProductName = @pname, Quantity = @qty, ProductDescription = @pdesc, ProductPrize = @prize ,`DateAdded` = @now WHERE productID = @id";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("cname", cmbcategory.Text);
                        cmd.Parameters.AddWithValue("sname", cmbsupplier.Text);
                        cmd.Parameters.AddWithValue("pname", txtproductname.Text);
                        cmd.Parameters.AddWithValue("qty", txtquantity.Text);
                        cmd.Parameters.AddWithValue("pdesc", txtdescription.Text);
                        cmd.Parameters.AddWithValue("prize", txtprize.Text);
                        cmd.Parameters.AddWithValue("now", DateTime.Now);
                        cmd.Parameters.AddWithValue("id", Variable.productid);
                        cmd.Parameters.AddWithValue("accid", Variable.userid);
                        cmd.ExecuteNonQuery();
                    }
                    dbhelper.closeConnection();
                    MessageBox.Show("Product information updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MainForm Form = new MainForm();
                    Form.BringToFront();
                }
            }

            else if (Add_btn.ButtonText == "Add Product")

            {
                if (txtproductname.Text == "" || cmbcategory.Text == "" || cmbsupplier.Text == "" || txtquantity.Text == "" || txtquantity.Text == "" || txtdescription.Text == "" || txtprize.Text == "")
                {
                    MessageBox.Show("Fields Can't be blank!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "INSERT INTO `tblproduct`( `CategoryID`,`SupplierID`, `ProductName`, `Quantity`, `ProductDescription`, `ProductPrize`,`DateAdded`,`AccountID`) VALUES((SELECT tblcategory.categoryID FROM tblcategory WHERE category=CONVERT(@cname USING utf8))," +
                            "(SELECT tblsupplier.supplierID FROM tblsupplier WHERE CompanyName=CONVERT(@sname USING utf8)), @pname, @qty, @pdesc, @prize,@now, @id)";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("cname", cmbcategory.Text);
                        cmd.Parameters.AddWithValue("sname", cmbsupplier.Text);
                        cmd.Parameters.AddWithValue("pname", txtproductname.Text);
                        cmd.Parameters.AddWithValue("qty", txtquantity.Text);
                        cmd.Parameters.AddWithValue("pdesc", txtdescription.Text);
                        cmd.Parameters.AddWithValue("prize", txtprize.Text);
                        cmd.Parameters.AddWithValue("id", Variable.userid);
                        cmd.Parameters.AddWithValue("now", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    dbhelper.closeConnection();
                    MessageBox.Show("New Product Added!");
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

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtprize.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
