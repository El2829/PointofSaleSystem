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
    public partial class Category : UserControl
    {
        Database dbhelper;
        DataTable dtable;
        string cid = "";
        public Category()
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
                load_categorytbl();
                addEditButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            AddCategory category = new AddCategory();
            category.ShowDialog();
        }
 
        public void load_categorytbl()
        {
            if (dbhelper.openConnection())
            {
                string query = "SELECT * FROM categoryview";
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

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //opening addcourse form
                AddCategory category = new AddCategory();
                //adding value on CourseID
                Variable.categoryid = dgv.CurrentRow.Cells[2].Value.ToString();
                //adding value on course textbox
                category.txtcategory.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                //changing the button text value
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
                        string query = "Delete from tblcategory where categoryID = @id";
                        MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                        cmd.Parameters.AddWithValue("id", cid);
                        cmd.ExecuteNonQuery();
                    }
                    dbhelper.closeConnection();
                    MessageBox.Show("Successfully Delete Data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //loadcourse
                    load_categorytbl();
                }
            }
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(dtable);
                DV.RowFilter = string.Format("[Category] LIKE '%{0}%' OR [Added By] LIKE '%{0}%'", Searchtxt.Text);
                dgv.DataSource = DV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input!" + ex.ToString());
            }
        }
    }
}
