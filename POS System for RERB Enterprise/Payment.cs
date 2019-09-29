using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_for_RERB_Enterprise
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            
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
    }
}
