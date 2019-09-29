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
    public partial class Product : UserControl
    {
        Database dbhelper;
        DataTable dtable;
        string accid = "";
        public Product()
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
                load_producttbl();
                addEditButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.ShowDialog();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
        public void load_producttbl()
        {
            if (dbhelper.openConnection())
            {
                string query = "SELECT * FROM productview";
                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                dtable = new DataTable();
                da.Fill(dtable);
                dgv.DataSource = dtable;

                dbhelper.closeConnection();
            }
        }

        private void addEditButton()
        {
            dgv.Columns[0].Width = 35;
            dgv.Columns[1].Width = 75;
            dgv.Columns[2].Width = 90;
            dgv.Columns[3].Width = 90;
            dgv.Columns[4].Width = 150;
            dgv.Columns[5].Width = 170;
            dgv.Columns[6].Width = 75;
            dgv.Columns[7].Width = 90;
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

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(dtable);
                DV.RowFilter = string.Format("[Company Name] LIKE '%{0}%' OR [Added By] LIKE '%{0}%' OR [Category] LIKE '%{0}%' OR [Product Name] LIKE '%{0}%' OR [Product Description] LIKE '%{0}%'", Searchtxt.Text);
                dgv.DataSource = DV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input!" + ex.ToString());
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //opening addcourse form
                AddProduct category = new AddProduct();
                //adding value on CourseID
                Variable.productid = dgv.CurrentRow.Cells[2].Value.ToString();
                //adding value on course textbox
                category.cmbcategory.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                category.cmbsupplier.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                category.txtproductname.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                category.txtquantity.Text = dgv.CurrentRow.Cells[8].Value.ToString();
                category.txtdescription.Text = dgv.CurrentRow.Cells[7].Value.ToString();
                category.txtprize.Text = dgv.CurrentRow.Cells[9].Value.ToString();
                //changing the button text value
                category.Add_btn.ButtonText = "Edit";
                category.ShowDialog();
            }

            else if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                accid = row.Cells["#"].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this data", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //delete course
                if (dr == DialogResult.Yes)
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "Delete from tblproduct where productID = @id";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("id", accid);
                        cmd.ExecuteNonQuery();
                    }
                    dbhelper.closeConnection();
                    MessageBox.Show("Successfully Delete Data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //loadcourse
                    load_producttbl();
                }
            }
        }
    }
}
