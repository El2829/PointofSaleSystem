namespace POS_System_for_RERB_Enterprise
{
    partial class Payment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            this.CloseImageButton = new ns1.BunifuImageButton();
            this.txtcategory = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label3 = new Ambiance.Ambiance_Label();
            this.Add_btn = new ns1.BunifuThinButton2();
            this.Cancel_btn = new ns1.BunifuThinButton2();
            this.ambiance_TextBox1 = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.ambiance_TextBox2 = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 291);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(298, 18);
            this.bunifuSeparator2.TabIndex = 182;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.monoFlat_HeaderLabel2);
            this.panel1.Controls.Add(this.CloseImageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 59);
            this.panel1.TabIndex = 181;
            // 
            // monoFlat_HeaderLabel2
            // 
            this.monoFlat_HeaderLabel2.AutoSize = true;
            this.monoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.monoFlat_HeaderLabel2.Location = new System.Drawing.Point(8, 16);
            this.monoFlat_HeaderLabel2.Name = "monoFlat_HeaderLabel2";
            this.monoFlat_HeaderLabel2.Size = new System.Drawing.Size(98, 30);
            this.monoFlat_HeaderLabel2.TabIndex = 87;
            this.monoFlat_HeaderLabel2.Text = "Payment";
            // 
            // CloseImageButton
            // 
            this.CloseImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.CloseImageButton.Image = global::POS_System_for_RERB_Enterprise.Properties.Resources._211651_128;
            this.CloseImageButton.ImageActive = null;
            this.CloseImageButton.Location = new System.Drawing.Point(267, 22);
            this.CloseImageButton.Name = "CloseImageButton";
            this.CloseImageButton.Size = new System.Drawing.Size(20, 20);
            this.CloseImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseImageButton.TabIndex = 9;
            this.CloseImageButton.TabStop = false;
            this.CloseImageButton.Zoom = 10;
            this.CloseImageButton.Click += new System.EventHandler(this.CloseImageButton_Click);
            // 
            // txtcategory
            // 
            this.txtcategory.BackColor = System.Drawing.Color.Transparent;
            this.txtcategory.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtcategory.ForeColor = System.Drawing.Color.DimGray;
            this.txtcategory.Location = new System.Drawing.Point(12, 182);
            this.txtcategory.MaxLength = 32767;
            this.txtcategory.Multiline = false;
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.ReadOnly = false;
            this.txtcategory.Size = new System.Drawing.Size(275, 28);
            this.txtcategory.TabIndex = 183;
            this.txtcategory.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcategory.UseSystemPasswordChar = false;
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ambiance_Label3.Location = new System.Drawing.Point(8, 152);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(46, 20);
            this.ambiance_Label3.TabIndex = 184;
            this.ambiance_Label3.Text = "Cash:";
            // 
            // Add_btn
            // 
            this.Add_btn.ActiveBorderThickness = 1;
            this.Add_btn.ActiveCornerRadius = 20;
            this.Add_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(169)))));
            this.Add_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Add_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(169)))));
            this.Add_btn.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.Add_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_btn.BackgroundImage")));
            this.Add_btn.ButtonText = "Proceed";
            this.Add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.IdleBorderThickness = 1;
            this.Add_btn.IdleCornerRadius = 20;
            this.Add_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.Add_btn.IdleForecolor = System.Drawing.Color.White;
            this.Add_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.Add_btn.Location = new System.Drawing.Point(150, 308);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(136, 41);
            this.Add_btn.TabIndex = 179;
            this.Add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.ActiveBorderThickness = 1;
            this.Cancel_btn.ActiveCornerRadius = 20;
            this.Cancel_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(84)))), ((int)(((byte)(60)))));
            this.Cancel_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Cancel_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(84)))), ((int)(((byte)(60)))));
            this.Cancel_btn.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.Cancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel_btn.BackgroundImage")));
            this.Cancel_btn.ButtonText = "Cancel";
            this.Cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btn.IdleBorderThickness = 1;
            this.Cancel_btn.IdleCornerRadius = 20;
            this.Cancel_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(105)))), ((int)(((byte)(84)))));
            this.Cancel_btn.IdleForecolor = System.Drawing.Color.White;
            this.Cancel_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(105)))), ((int)(((byte)(84)))));
            this.Cancel_btn.Location = new System.Drawing.Point(55, 308);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(91, 41);
            this.Cancel_btn.TabIndex = 180;
            this.Cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // ambiance_TextBox1
            // 
            this.ambiance_TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_TextBox1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ambiance_TextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_TextBox1.Location = new System.Drawing.Point(13, 105);
            this.ambiance_TextBox1.MaxLength = 32767;
            this.ambiance_TextBox1.Multiline = false;
            this.ambiance_TextBox1.Name = "ambiance_TextBox1";
            this.ambiance_TextBox1.ReadOnly = false;
            this.ambiance_TextBox1.Size = new System.Drawing.Size(275, 28);
            this.ambiance_TextBox1.TabIndex = 185;
            this.ambiance_TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ambiance_TextBox1.UseSystemPasswordChar = false;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(9, 75);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(110, 20);
            this.ambiance_Label1.TabIndex = 186;
            this.ambiance_Label1.Text = "Total Amount:";
            // 
            // ambiance_TextBox2
            // 
            this.ambiance_TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_TextBox2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ambiance_TextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_TextBox2.Location = new System.Drawing.Point(13, 256);
            this.ambiance_TextBox2.MaxLength = 32767;
            this.ambiance_TextBox2.Multiline = false;
            this.ambiance_TextBox2.Name = "ambiance_TextBox2";
            this.ambiance_TextBox2.ReadOnly = false;
            this.ambiance_TextBox2.Size = new System.Drawing.Size(275, 28);
            this.ambiance_TextBox2.TabIndex = 187;
            this.ambiance_TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ambiance_TextBox2.UseSystemPasswordChar = false;
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(9, 226);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(65, 20);
            this.ambiance_Label2.TabIndex = 188;
            this.ambiance_Label2.Text = "Change:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(300, 354);
            this.Controls.Add(this.ambiance_TextBox2);
            this.Controls.Add(this.ambiance_Label2);
            this.Controls.Add(this.ambiance_TextBox1);
            this.Controls.Add(this.ambiance_Label1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.ambiance_Label3);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Cancel_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImageButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel1;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel2;
        private ns1.BunifuImageButton CloseImageButton;
        internal Ambiance.Ambiance_TextBox txtcategory;
        private Ambiance.Ambiance_Label ambiance_Label3;
        internal ns1.BunifuThinButton2 Add_btn;
        private ns1.BunifuThinButton2 Cancel_btn;
        internal Ambiance.Ambiance_TextBox ambiance_TextBox2;
        private Ambiance.Ambiance_Label ambiance_Label2;
        internal Ambiance.Ambiance_TextBox ambiance_TextBox1;
        private Ambiance.Ambiance_Label ambiance_Label1;
    }
}