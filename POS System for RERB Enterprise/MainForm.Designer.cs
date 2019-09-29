namespace POS_System_for_RERB_Enterprise
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseImageButton = new ns1.BunifuImageButton();
            this.MinimizeImageButton = new ns1.BunifuImageButton();
            this.Menulbl = new ns1.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.POSbtn = new ns1.BunifuFlatButton();
            this.Supplierbtn = new ns1.BunifuFlatButton();
            this.Categorybtn = new ns1.BunifuFlatButton();
            this.Productbtn = new ns1.BunifuFlatButton();
            this.Userbtn = new ns1.BunifuFlatButton();
            this.Audittrialbtn = new ns1.BunifuFlatButton();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.Dashboardbtn = new ns1.BunifuFlatButton();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.product1 = new POS_System_for_RERB_Enterprise.Product();
            this.category1 = new POS_System_for_RERB_Enterprise.Category();
            this.users1 = new POS_System_for_RERB_Enterprise.Pages.Users();
            this.adminLoginHistory1 = new POS_System_for_RERB_Enterprise.AdminLoginHistory();
            this.dashboard1 = new POS_System_for_RERB_Enterprise.Pages.Dashboard();
            this.pointofSale1 = new POS_System_for_RERB_Enterprise.PointofSale();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeImageButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.CloseImageButton);
            this.panel2.Controls.Add(this.MinimizeImageButton);
            this.panel2.Controls.Add(this.Menulbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 53);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CloseImageButton
            // 
            this.CloseImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.CloseImageButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseImageButton.Image")));
            this.CloseImageButton.ImageActive = null;
            this.CloseImageButton.Location = new System.Drawing.Point(1201, 17);
            this.CloseImageButton.Name = "CloseImageButton";
            this.CloseImageButton.Size = new System.Drawing.Size(20, 20);
            this.CloseImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseImageButton.TabIndex = 73;
            this.CloseImageButton.TabStop = false;
            this.CloseImageButton.Zoom = 10;
            this.CloseImageButton.Click += new System.EventHandler(this.CloseImageButton_Click);
            // 
            // MinimizeImageButton
            // 
            this.MinimizeImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.MinimizeImageButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeImageButton.Image")));
            this.MinimizeImageButton.ImageActive = null;
            this.MinimizeImageButton.Location = new System.Drawing.Point(1180, 17);
            this.MinimizeImageButton.Name = "MinimizeImageButton";
            this.MinimizeImageButton.Size = new System.Drawing.Size(20, 20);
            this.MinimizeImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeImageButton.TabIndex = 72;
            this.MinimizeImageButton.TabStop = false;
            this.MinimizeImageButton.Zoom = 10;
            this.MinimizeImageButton.Click += new System.EventHandler(this.MinimizeImageButton_Click);
            // 
            // Menulbl
            // 
            this.Menulbl.AutoSize = true;
            this.Menulbl.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menulbl.ForeColor = System.Drawing.Color.White;
            this.Menulbl.Location = new System.Drawing.Point(12, 17);
            this.Menulbl.Name = "Menulbl";
            this.Menulbl.Size = new System.Drawing.Size(396, 23);
            this.Menulbl.TabIndex = 71;
            this.Menulbl.Text = "RERB Enterprise Point of Sale System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.POSbtn);
            this.panel3.Controls.Add(this.Supplierbtn);
            this.panel3.Controls.Add(this.Categorybtn);
            this.panel3.Controls.Add(this.Productbtn);
            this.panel3.Controls.Add(this.Userbtn);
            this.panel3.Controls.Add(this.Audittrialbtn);
            this.panel3.Controls.Add(this.bunifuSeparator1);
            this.panel3.Controls.Add(this.Dashboardbtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 605);
            this.panel3.TabIndex = 3;
            // 
            // POSbtn
            // 
            this.POSbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.POSbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.POSbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.POSbtn.BorderRadius = 0;
            this.POSbtn.ButtonText = "   Point of Sale";
            this.POSbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POSbtn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.POSbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.POSbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.POSbtn.Iconimage = global::POS_System_for_RERB_Enterprise.Properties.Resources.payment;
            this.POSbtn.Iconimage_right = null;
            this.POSbtn.Iconimage_right_Selected = null;
            this.POSbtn.Iconimage_Selected = null;
            this.POSbtn.IconMarginLeft = 0;
            this.POSbtn.IconMarginRight = 0;
            this.POSbtn.IconRightVisible = true;
            this.POSbtn.IconRightZoom = 0D;
            this.POSbtn.IconVisible = true;
            this.POSbtn.IconZoom = 65D;
            this.POSbtn.IsTab = true;
            this.POSbtn.Location = new System.Drawing.Point(0, 230);
            this.POSbtn.Margin = new System.Windows.Forms.Padding(0);
            this.POSbtn.Name = "POSbtn";
            this.POSbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.POSbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.POSbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.POSbtn.selected = false;
            this.POSbtn.Size = new System.Drawing.Size(223, 46);
            this.POSbtn.TabIndex = 16;
            this.POSbtn.Text = "   Point of Sale";
            this.POSbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.POSbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.POSbtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSbtn.Click += new System.EventHandler(this.POSbtn_Click);
            // 
            // Supplierbtn
            // 
            this.Supplierbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Supplierbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Supplierbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Supplierbtn.BorderRadius = 0;
            this.Supplierbtn.ButtonText = "   Supplier";
            this.Supplierbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Supplierbtn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Supplierbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Supplierbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Supplierbtn.Iconimage = global::POS_System_for_RERB_Enterprise.Properties.Resources.supplier;
            this.Supplierbtn.Iconimage_right = null;
            this.Supplierbtn.Iconimage_right_Selected = null;
            this.Supplierbtn.Iconimage_Selected = null;
            this.Supplierbtn.IconMarginLeft = 0;
            this.Supplierbtn.IconMarginRight = 0;
            this.Supplierbtn.IconRightVisible = true;
            this.Supplierbtn.IconRightZoom = 0D;
            this.Supplierbtn.IconVisible = true;
            this.Supplierbtn.IconZoom = 65D;
            this.Supplierbtn.IsTab = true;
            this.Supplierbtn.Location = new System.Drawing.Point(0, 184);
            this.Supplierbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Supplierbtn.Name = "Supplierbtn";
            this.Supplierbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Supplierbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Supplierbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Supplierbtn.selected = false;
            this.Supplierbtn.Size = new System.Drawing.Size(223, 46);
            this.Supplierbtn.TabIndex = 15;
            this.Supplierbtn.Text = "   Supplier";
            this.Supplierbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Supplierbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Supplierbtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbtn.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // Categorybtn
            // 
            this.Categorybtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Categorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Categorybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Categorybtn.BorderRadius = 0;
            this.Categorybtn.ButtonText = "   Category";
            this.Categorybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Categorybtn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Categorybtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Categorybtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Categorybtn.Iconimage = global::POS_System_for_RERB_Enterprise.Properties.Resources.category;
            this.Categorybtn.Iconimage_right = null;
            this.Categorybtn.Iconimage_right_Selected = null;
            this.Categorybtn.Iconimage_Selected = null;
            this.Categorybtn.IconMarginLeft = 0;
            this.Categorybtn.IconMarginRight = 0;
            this.Categorybtn.IconRightVisible = true;
            this.Categorybtn.IconRightZoom = 0D;
            this.Categorybtn.IconVisible = true;
            this.Categorybtn.IconZoom = 65D;
            this.Categorybtn.IsTab = true;
            this.Categorybtn.Location = new System.Drawing.Point(0, 92);
            this.Categorybtn.Margin = new System.Windows.Forms.Padding(0);
            this.Categorybtn.Name = "Categorybtn";
            this.Categorybtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Categorybtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Categorybtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Categorybtn.selected = false;
            this.Categorybtn.Size = new System.Drawing.Size(223, 46);
            this.Categorybtn.TabIndex = 14;
            this.Categorybtn.Text = "   Category";
            this.Categorybtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categorybtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Categorybtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorybtn.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // Productbtn
            // 
            this.Productbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Productbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Productbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Productbtn.BorderRadius = 0;
            this.Productbtn.ButtonText = "   Product";
            this.Productbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Productbtn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Productbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Productbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Productbtn.Iconimage = global::POS_System_for_RERB_Enterprise.Properties.Resources.product1;
            this.Productbtn.Iconimage_right = null;
            this.Productbtn.Iconimage_right_Selected = null;
            this.Productbtn.Iconimage_Selected = null;
            this.Productbtn.IconMarginLeft = 0;
            this.Productbtn.IconMarginRight = 0;
            this.Productbtn.IconRightVisible = true;
            this.Productbtn.IconRightZoom = 0D;
            this.Productbtn.IconVisible = true;
            this.Productbtn.IconZoom = 65D;
            this.Productbtn.IsTab = true;
            this.Productbtn.Location = new System.Drawing.Point(0, 138);
            this.Productbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Productbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Productbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Productbtn.selected = false;
            this.Productbtn.Size = new System.Drawing.Size(223, 46);
            this.Productbtn.TabIndex = 13;
            this.Productbtn.Text = "   Product";
            this.Productbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Productbtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productbtn.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Userbtn
            // 
            this.Userbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Userbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Userbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Userbtn.BorderRadius = 0;
            this.Userbtn.ButtonText = "   Users";
            this.Userbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Userbtn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Userbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Userbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Userbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Userbtn.Iconimage")));
            this.Userbtn.Iconimage_right = null;
            this.Userbtn.Iconimage_right_Selected = null;
            this.Userbtn.Iconimage_Selected = null;
            this.Userbtn.IconMarginLeft = 0;
            this.Userbtn.IconMarginRight = 0;
            this.Userbtn.IconRightVisible = true;
            this.Userbtn.IconRightZoom = 0D;
            this.Userbtn.IconVisible = true;
            this.Userbtn.IconZoom = 65D;
            this.Userbtn.IsTab = true;
            this.Userbtn.Location = new System.Drawing.Point(0, 46);
            this.Userbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Userbtn.Name = "Userbtn";
            this.Userbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Userbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Userbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Userbtn.selected = false;
            this.Userbtn.Size = new System.Drawing.Size(223, 46);
            this.Userbtn.TabIndex = 12;
            this.Userbtn.Text = "   Users";
            this.Userbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Userbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Userbtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userbtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Audittrialbtn
            // 
            this.Audittrialbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Audittrialbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Audittrialbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Audittrialbtn.BorderRadius = 0;
            this.Audittrialbtn.ButtonText = "  Login History";
            this.Audittrialbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Audittrialbtn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Audittrialbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Audittrialbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Audittrialbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Audittrialbtn.Iconimage")));
            this.Audittrialbtn.Iconimage_right = null;
            this.Audittrialbtn.Iconimage_right_Selected = null;
            this.Audittrialbtn.Iconimage_Selected = null;
            this.Audittrialbtn.IconMarginLeft = 0;
            this.Audittrialbtn.IconMarginRight = 0;
            this.Audittrialbtn.IconRightVisible = true;
            this.Audittrialbtn.IconRightZoom = 0D;
            this.Audittrialbtn.IconVisible = true;
            this.Audittrialbtn.IconZoom = 80D;
            this.Audittrialbtn.IsTab = true;
            this.Audittrialbtn.Location = new System.Drawing.Point(1, 561);
            this.Audittrialbtn.Name = "Audittrialbtn";
            this.Audittrialbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Audittrialbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Audittrialbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Audittrialbtn.selected = false;
            this.Audittrialbtn.Size = new System.Drawing.Size(223, 43);
            this.Audittrialbtn.TabIndex = 6;
            this.Audittrialbtn.Text = "  Login History";
            this.Audittrialbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Audittrialbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Audittrialbtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Audittrialbtn.Click += new System.EventHandler(this.Audittrialbtn_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 519);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(198, 35);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Dashboardbtn
            // 
            this.Dashboardbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Dashboardbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Dashboardbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dashboardbtn.BorderRadius = 0;
            this.Dashboardbtn.ButtonText = "   DashBoard";
            this.Dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboardbtn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Dashboardbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Dashboardbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Dashboardbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Dashboardbtn.Iconimage")));
            this.Dashboardbtn.Iconimage_right = null;
            this.Dashboardbtn.Iconimage_right_Selected = null;
            this.Dashboardbtn.Iconimage_Selected = null;
            this.Dashboardbtn.IconMarginLeft = 0;
            this.Dashboardbtn.IconMarginRight = 0;
            this.Dashboardbtn.IconRightVisible = true;
            this.Dashboardbtn.IconRightZoom = 0D;
            this.Dashboardbtn.IconVisible = true;
            this.Dashboardbtn.IconZoom = 65D;
            this.Dashboardbtn.IsTab = true;
            this.Dashboardbtn.Location = new System.Drawing.Point(0, 0);
            this.Dashboardbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Dashboardbtn.Name = "Dashboardbtn";
            this.Dashboardbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.Dashboardbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.Dashboardbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Dashboardbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dashboardbtn.selected = true;
            this.Dashboardbtn.Size = new System.Drawing.Size(223, 46);
            this.Dashboardbtn.TabIndex = 0;
            this.Dashboardbtn.Text = "   DashBoard";
            this.Dashboardbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.Dashboardbtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardbtn.Click += new System.EventHandler(this.Dashboardbtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // product1
            // 
            this.product1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.product1.Location = new System.Drawing.Point(225, 55);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(1011, 607);
            this.product1.TabIndex = 4;
            // 
            // category1
            // 
            this.category1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.category1.Location = new System.Drawing.Point(225, 55);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(1011, 607);
            this.category1.TabIndex = 5;
            // 
            // users1
            // 
            this.users1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.users1.Location = new System.Drawing.Point(225, 55);
            this.users1.Name = "users1";
            this.users1.Size = new System.Drawing.Size(1011, 607);
            this.users1.TabIndex = 6;
            // 
            // adminLoginHistory1
            // 
            this.adminLoginHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.adminLoginHistory1.Location = new System.Drawing.Point(225, 55);
            this.adminLoginHistory1.Name = "adminLoginHistory1";
            this.adminLoginHistory1.Size = new System.Drawing.Size(1012, 516);
            this.adminLoginHistory1.TabIndex = 7;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.dashboard1.Location = new System.Drawing.Point(224, 55);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1011, 607);
            this.dashboard1.TabIndex = 8;
            // 
            // pointofSale1
            // 
            this.pointofSale1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.pointofSale1.Location = new System.Drawing.Point(225, 53);
            this.pointofSale1.Name = "pointofSale1";
            this.pointofSale1.Size = new System.Drawing.Size(1011, 607);
            this.pointofSale1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1235, 658);
            this.Controls.Add(this.pointofSale1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.adminLoginHistory1);
            this.Controls.Add(this.users1);
            this.Controls.Add(this.category1);
            this.Controls.Add(this.product1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeImageButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuFlatButton Audittrialbtn;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuFlatButton Dashboardbtn;
        private ns1.BunifuCustomLabel Menulbl;
        private ns1.BunifuFlatButton Userbtn;
        private ns1.BunifuImageButton CloseImageButton;
        private ns1.BunifuImageButton MinimizeImageButton;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuFlatButton Categorybtn;
        private ns1.BunifuFlatButton Productbtn;
        private ns1.BunifuFlatButton Supplierbtn;
        private ns1.BunifuFlatButton POSbtn;
        private PointofSale pointofSale1;
        private Pages.Dashboard dashboard1;
        private AdminLoginHistory adminLoginHistory1;
        private Pages.Users users1;
        private Category category1;
        private Product product1;
    }
}