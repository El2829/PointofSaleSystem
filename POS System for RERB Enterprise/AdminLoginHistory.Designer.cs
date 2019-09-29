namespace POS_System_for_RERB_Enterprise
{
    partial class AdminLoginHistory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menulbl = new ns1.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logindgv = new System.Windows.Forms.DataGridView();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logindgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Menulbl
            // 
            this.Menulbl.AutoSize = true;
            this.Menulbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.Menulbl.ForeColor = System.Drawing.Color.White;
            this.Menulbl.Location = new System.Drawing.Point(16, 41);
            this.Menulbl.Name = "Menulbl";
            this.Menulbl.Size = new System.Drawing.Size(192, 37);
            this.Menulbl.TabIndex = 153;
            this.Menulbl.Text = "Login History";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.logindgv);
            this.panel1.Location = new System.Drawing.Point(1, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 422);
            this.panel1.TabIndex = 176;
            // 
            // logindgv
            // 
            this.logindgv.AllowUserToAddRows = false;
            this.logindgv.AllowUserToDeleteRows = false;
            this.logindgv.AllowUserToResizeColumns = false;
            this.logindgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.logindgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.logindgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logindgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.logindgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logindgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.logindgv.ColumnHeadersHeight = 27;
            this.logindgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logindgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.logindgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.logindgv.Location = new System.Drawing.Point(22, 14);
            this.logindgv.Name = "logindgv";
            this.logindgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logindgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.logindgv.RowHeadersVisible = false;
            this.logindgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.logindgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.logindgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logindgv.Size = new System.Drawing.Size(969, 382);
            this.logindgv.TabIndex = 142;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 81);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1012, 18);
            this.bunifuSeparator2.TabIndex = 175;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // AdminLoginHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.Menulbl);
            this.Name = "AdminLoginHistory";
            this.Size = new System.Drawing.Size(1011, 516);
            this.Load += new System.EventHandler(this.AdminLoginHistory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logindgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel Menulbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView logindgv;
        private ns1.BunifuSeparator bunifuSeparator2;
    }
}
