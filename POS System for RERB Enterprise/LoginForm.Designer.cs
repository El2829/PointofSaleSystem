namespace POS_System_for_RERB_Enterprise
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Menulbl = new ns1.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password_Txt = new ns1.BunifuMetroTextbox();
            this.Login_txt = new ns1.BunifuMetroTextbox();
            this.ForgetPasslbl = new ns1.BunifuCustomLabel();
            this.Login_btn = new ns1.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseImageButton = new ns1.BunifuImageButton();
            this.MinimizeImageButton = new ns1.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeImageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Menulbl
            // 
            this.Menulbl.AutoSize = true;
            this.Menulbl.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menulbl.ForeColor = System.Drawing.Color.White;
            this.Menulbl.Location = new System.Drawing.Point(79, 233);
            this.Menulbl.Name = "Menulbl";
            this.Menulbl.Size = new System.Drawing.Size(185, 23);
            this.Menulbl.TabIndex = 70;
            this.Menulbl.Text = "RERB Enterprise";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.CloseImageButton);
            this.panel1.Controls.Add(this.MinimizeImageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 41);
            this.panel1.TabIndex = 64;
            // 
            // Password_Txt
            // 
            this.Password_Txt.BackColor = System.Drawing.Color.White;
            this.Password_Txt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.Password_Txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.Password_Txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.Password_Txt.BorderThickness = 3;
            this.Password_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password_Txt.ForeColor = System.Drawing.Color.Silver;
            this.Password_Txt.isPassword = false;
            this.Password_Txt.Location = new System.Drawing.Point(50, 324);
            this.Password_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.Size = new System.Drawing.Size(250, 44);
            this.Password_Txt.TabIndex = 72;
            this.Password_Txt.Text = "Enter Password";
            this.Password_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_Txt.Enter += new System.EventHandler(this.Password_Txt_Enter);
            this.Password_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_Txt_KeyDown);
            this.Password_Txt.Leave += new System.EventHandler(this.Password_Txt_Leave);
            // 
            // Login_txt
            // 
            this.Login_txt.BackColor = System.Drawing.Color.White;
            this.Login_txt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.Login_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.Login_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.Login_txt.BorderThickness = 3;
            this.Login_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Login_txt.ForeColor = System.Drawing.Color.Silver;
            this.Login_txt.isPassword = false;
            this.Login_txt.Location = new System.Drawing.Point(50, 271);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(250, 44);
            this.Login_txt.TabIndex = 71;
            this.Login_txt.Text = "Enter Username";
            this.Login_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login_txt.Enter += new System.EventHandler(this.Login_txt_Enter);
            this.Login_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_txt_KeyDown);
            this.Login_txt.Leave += new System.EventHandler(this.Login_txt_Leave);
            // 
            // ForgetPasslbl
            // 
            this.ForgetPasslbl.AutoSize = true;
            this.ForgetPasslbl.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPasslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ForgetPasslbl.Location = new System.Drawing.Point(105, 457);
            this.ForgetPasslbl.Name = "ForgetPasslbl";
            this.ForgetPasslbl.Size = new System.Drawing.Size(141, 19);
            this.ForgetPasslbl.TabIndex = 76;
            this.ForgetPasslbl.Text = "Forget Password?";
            this.ForgetPasslbl.Click += new System.EventHandler(this.ForgetPasslbl_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.ActiveBorderThickness = 1;
            this.Login_btn.ActiveCornerRadius = 20;
            this.Login_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.Login_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Login_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.Login_btn.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_btn.BackgroundImage")));
            this.Login_btn.ButtonText = "Login";
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Login_btn.IdleBorderThickness = 1;
            this.Login_btn.IdleCornerRadius = 20;
            this.Login_btn.IdleFillColor = System.Drawing.Color.White;
            this.Login_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Login_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Login_btn.Location = new System.Drawing.Point(50, 412);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(250, 41);
            this.Login_btn.TabIndex = 65;
            this.Login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::POS_System_for_RERB_Enterprise.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(30, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // CloseImageButton
            // 
            this.CloseImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.CloseImageButton.Image = global::POS_System_for_RERB_Enterprise.Properties.Resources._211651_128;
            this.CloseImageButton.ImageActive = null;
            this.CloseImageButton.Location = new System.Drawing.Point(321, 12);
            this.CloseImageButton.Name = "CloseImageButton";
            this.CloseImageButton.Size = new System.Drawing.Size(20, 20);
            this.CloseImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseImageButton.TabIndex = 9;
            this.CloseImageButton.TabStop = false;
            this.CloseImageButton.Zoom = 10;
            this.CloseImageButton.Click += new System.EventHandler(this.CloseImageButton_Click);
            // 
            // MinimizeImageButton
            // 
            this.MinimizeImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.MinimizeImageButton.Image = global::POS_System_for_RERB_Enterprise.Properties.Resources._1954552_128;
            this.MinimizeImageButton.ImageActive = null;
            this.MinimizeImageButton.Location = new System.Drawing.Point(300, 12);
            this.MinimizeImageButton.Name = "MinimizeImageButton";
            this.MinimizeImageButton.Size = new System.Drawing.Size(20, 20);
            this.MinimizeImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeImageButton.TabIndex = 8;
            this.MinimizeImageButton.TabStop = false;
            this.MinimizeImageButton.Zoom = 10;
            this.MinimizeImageButton.Click += new System.EventHandler(this.MinimizeImageButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(349, 490);
            this.Controls.Add(this.ForgetPasslbl);
            this.Controls.Add(this.Password_Txt);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Menulbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeImageButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuThinButton2 Login_btn;
        private ns1.BunifuCustomLabel Menulbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuImageButton CloseImageButton;
        private ns1.BunifuImageButton MinimizeImageButton;
        private ns1.BunifuMetroTextbox Password_Txt;
        private ns1.BunifuMetroTextbox Login_txt;
        private ns1.BunifuCustomLabel ForgetPasslbl;
    }
}

