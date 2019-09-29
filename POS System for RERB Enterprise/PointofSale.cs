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
    public partial class PointofSale : UserControl
    {
        Database dbhelper;
        DataTable dtable;
        public PointofSale()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            load_producttbl();
        }

        private void PointofSale_Load(object sender, EventArgs e)
        {

        }
        public void load_producttbl()
        {
            if (dbhelper.openConnection())
            {
                string query = "select * from product ";
                MySqlCommand cmd = new MySqlCommand(query, dbhelper.getConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                dtable = new DataTable();
                da.Fill(dtable);
                dgv.DataSource = dtable;

                dbhelper.closeConnection();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int quantity=0;
            //if txtquantity.Value > quantity;
            //else txtquantity.Value > 0;
            //quantity = int.Parse(row2.Cells["Total Quantity"].Value.ToString());
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            string accid = string.Empty;
            string productid = string.Empty;
            int quantity = 0;
            if (dgv.Rows.Count > 1)
            {

                if (dgv.CurrentRow.Index == dgv.Rows.Count - 1)
                {
                    MessageBox.Show("Please re-select desired product.");
                }
                else
                {
                    DataGridViewRow row2 = this.dgv.Rows[dgv.CurrentRow.Index];
                    productid = row2.Cells["ProductID"].Value.ToString();
                    quantity = int.Parse(row2.Cells["Quantity"].Value.ToString());


                    if (numquantity2.Value > quantity)
                    {
                        MessageBox.Show("Desired quantity is greater than the number of product in stock!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (numquantity2.Value > 0)
                        {
                            for(int i = dgv.RowCount - 1; i >= 0; i--)
                            {
                                DataGridViewRow row = dgv1.Rows[i];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please order atleast 1 (one) item!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
