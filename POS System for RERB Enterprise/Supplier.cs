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
    public partial class U_Supplier : UserControl
    {
        Database dbhelper;
        DataTable dtable;
        string cid = "";
        public U_Supplier()
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
                load_suppliertbl();
                addEditButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void load_suppliertbl()
        {
            if (dbhelper.openConnection())
            {
                string query = "SELECT * FROM supplierview";
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
            //adding edit button on datagridview
            dgv.Columns[0].Width = 50;
            DataGridViewButtonColumn btnx = new DataGridViewButtonColumn();
            dgv.Columns.Add(btnx);
            btnx.HeaderText = "Edit Data";
            btnx.Text = "Edit";
            btnx.Name = "btn";
            btnx.UseColumnTextForButtonValue = true;

            //adding delete button on datagridview
            DataGridViewButtonColumn btny = new DataGridViewButtonColumn();
            dgv.Columns.Add(btny);
            btny.HeaderText = "Delete Data";
            btny.Text = "Delete";
            btny.Name = "btndel";
            btny.UseColumnTextForButtonValue = true;
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            AddCompany company = new AddCompany();
            company.ShowDialog();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(dtable);
                DV.RowFilter = string.Format("[Company Name] LIKE '%{0}%' OR [Added By] LIKE '%{0}%'", Searchtxt.Text);
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
                AddCompany category = new AddCompany();
                Variable.companyid = dgv.CurrentRow.Cells[2].Value.ToString();
                category.txtcompanyname.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                category.txtdescription.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                category.txtcontact.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                category.txtemail.Text = dgv.CurrentRow.Cells[7].Value.ToString();
                category.Add_btn.ButtonText = "Edit";
                category.ShowDialog();
            }

            else if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                cid = row.Cells["#"].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this data", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //delete course
                if (dr == DialogResult.Yes)
                {
                    if (dbhelper.openConnection())
                    {
                        string query = "Delete from tblsupplier where supplierID = @id";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("id", cid);
                        cmd.ExecuteNonQuery();
                    }
                    dbhelper.closeConnection();
                    MessageBox.Show("Successfully Delete Data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //loadcourse
                    load_suppliertbl();
                }
            }
        }
    }
}
