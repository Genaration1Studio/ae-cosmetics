namespace AE_Cosmetics
{
    partial class HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.bunifuElipse_Home = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bg_form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.card_logo = new Bunifu.Framework.UI.BunifuCards();
            this.txb_passsWord = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lbl_notFound = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_password = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txb_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_username = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txb_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_aboutMe = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_purchase = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_mini = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_report = new Bunifu.Framework.UI.BunifuThinButton2();
            this.aeCosmeticsDataSet = new AE_Cosmetics.aeCosmeticsDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new AE_Cosmetics.aeCosmeticsDataSetTableAdapters.userTableAdapter();
            this.card_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeCosmeticsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse_Home
            // 
            this.bunifuElipse_Home.ElipseRadius = 15;
            this.bunifuElipse_Home.TargetControl = this;
            // 
            // bg_form
            // 
            this.bg_form.ElipseRadius = 15;
            this.bg_form.TargetControl = this;
            // 
            // card_logo
            // 
            this.card_logo.BackColor = System.Drawing.Color.White;
            this.card_logo.BorderRadius = 40;
            this.card_logo.BottomSahddow = true;
            this.card_logo.color = System.Drawing.Color.White;
            this.card_logo.Controls.Add(this.txb_passsWord);
            this.card_logo.Controls.Add(this.lbl_notFound);
            this.card_logo.Controls.Add(this.lbl_password);
            this.card_logo.Controls.Add(this.txb_password);
            this.card_logo.Controls.Add(this.lbl_username);
            this.card_logo.Controls.Add(this.txb_username);
            this.card_logo.Controls.Add(this.btn_login);
            this.card_logo.Controls.Add(this.logo);
            this.card_logo.LeftSahddow = false;
            this.card_logo.Location = new System.Drawing.Point(107, 217);
            this.card_logo.Name = "card_logo";
            this.card_logo.RightSahddow = true;
            this.card_logo.ShadowDepth = 20;
            this.card_logo.Size = new System.Drawing.Size(1151, 440);
            this.card_logo.TabIndex = 7;
            // 
            // txb_passsWord
            // 
            this.txb_passsWord.BorderColor = System.Drawing.Color.SeaGreen;
            this.txb_passsWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_passsWord.Font = new System.Drawing.Font("RSU", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txb_passsWord.Location = new System.Drawing.Point(690, 223);
            this.txb_passsWord.Name = "txb_passsWord";
            this.txb_passsWord.Size = new System.Drawing.Size(344, 25);
            this.txb_passsWord.TabIndex = 2;
            this.txb_passsWord.Click += new System.EventHandler(this.txb_passsWord_Click);
            // 
            // lbl_notFound
            // 
            this.lbl_notFound.AutoSize = true;
            this.lbl_notFound.Font = new System.Drawing.Font("RSU", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_notFound.ForeColor = System.Drawing.Color.Red;
            this.lbl_notFound.Location = new System.Drawing.Point(700, 274);
            this.lbl_notFound.Name = "lbl_notFound";
            this.lbl_notFound.Size = new System.Drawing.Size(334, 35);
            this.lbl_notFound.TabIndex = 28;
            this.lbl_notFound.Text = "ชื่อบัญชีผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง !";
            this.lbl_notFound.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("RSU", 17.82178F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_password.Location = new System.Drawing.Point(682, 176);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(93, 37);
            this.lbl_password.TabIndex = 27;
            this.lbl_password.Text = "รหัสผ่าน";
            // 
            // txb_password
            // 
            this.txb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_password.Font = new System.Drawing.Font("RSU", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_password.HintForeColor = System.Drawing.Color.Empty;
            this.txb_password.HintText = "";
            this.txb_password.isPassword = true;
            this.txb_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(223)))));
            this.txb_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txb_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(223)))));
            this.txb_password.LineThickness = 4;
            this.txb_password.Location = new System.Drawing.Point(687, 224);
            this.txb_password.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(346, 37);
            this.txb_password.TabIndex = 26;
            this.txb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("RSU", 17.82178F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_username.Location = new System.Drawing.Point(682, 57);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(155, 37);
            this.lbl_username.TabIndex = 25;
            this.lbl_username.Text = "ชื่อบัญชีผู้ใช้งาน";
            // 
            // txb_username
            // 
            this.txb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_username.Font = new System.Drawing.Font("RSU", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_username.HintForeColor = System.Drawing.Color.Empty;
            this.txb_username.HintText = "";
            this.txb_username.isPassword = false;
            this.txb_username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(223)))));
            this.txb_username.LineIdleColor = System.Drawing.Color.Gray;
            this.txb_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(223)))));
            this.txb_username.LineThickness = 4;
            this.txb_username.Location = new System.Drawing.Point(687, 105);
            this.txb_username.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(346, 37);
            this.txb_username.TabIndex = 1;
            this.txb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 70;
            this.btn_login.ActiveFillColor = System.Drawing.Color.Empty;
            this.btn_login.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(223)))));
            this.btn_login.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(223)))));
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "เข้าสู่ระบบ";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(70)))));
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 70;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(223)))));
            this.btn_login.IdleForecolor = System.Drawing.Color.White;
            this.btn_login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(223)))));
            this.btn_login.Location = new System.Drawing.Point(687, 316);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(342, 80);
            this.btn_login.TabIndex = 3;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::AE_Cosmetics.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(29, -6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(556, 443);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.ActiveBorderThickness = 1;
            this.btn_update.ActiveCornerRadius = 70;
            this.btn_update.ActiveFillColor = System.Drawing.Color.Empty;
            this.btn_update.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            this.btn_update.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            this.btn_update.BackColor = System.Drawing.SystemColors.Control;
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.ButtonText = "คลังสินค้า ";
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(70)))));
            this.btn_update.IdleBorderThickness = 1;
            this.btn_update.IdleCornerRadius = 70;
            this.btn_update.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            this.btn_update.IdleForecolor = System.Drawing.Color.White;
            this.btn_update.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            this.btn_update.Location = new System.Drawing.Point(897, 250);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(309, 81);
            this.btn_update.TabIndex = 5;
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_aboutMe
            // 
            this.btn_aboutMe.ActiveBorderThickness = 1;
            this.btn_aboutMe.ActiveCornerRadius = 70;
            this.btn_aboutMe.ActiveFillColor = System.Drawing.Color.Empty;
            this.btn_aboutMe.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(193)))), ((int)(((byte)(235)))));
            this.btn_aboutMe.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(193)))), ((int)(((byte)(235)))));
            this.btn_aboutMe.BackColor = System.Drawing.SystemColors.Control;
            this.btn_aboutMe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aboutMe.BackgroundImage")));
            this.btn_aboutMe.ButtonText = "เกี่ยวกับ";
            this.btn_aboutMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aboutMe.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aboutMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(70)))));
            this.btn_aboutMe.IdleBorderThickness = 1;
            this.btn_aboutMe.IdleCornerRadius = 70;
            this.btn_aboutMe.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(193)))), ((int)(((byte)(235)))));
            this.btn_aboutMe.IdleForecolor = System.Drawing.Color.White;
            this.btn_aboutMe.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(193)))), ((int)(((byte)(235)))));
            this.btn_aboutMe.Location = new System.Drawing.Point(897, 523);
            this.btn_aboutMe.Margin = new System.Windows.Forms.Padding(5);
            this.btn_aboutMe.Name = "btn_aboutMe";
            this.btn_aboutMe.Size = new System.Drawing.Size(309, 81);
            this.btn_aboutMe.TabIndex = 4;
            this.btn_aboutMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_aboutMe.Visible = false;
            this.btn_aboutMe.Click += new System.EventHandler(this.btn_aboutMe_Click);
            // 
            // btn_search
            // 
            this.btn_search.ActiveBorderThickness = 1;
            this.btn_search.ActiveCornerRadius = 70;
            this.btn_search.ActiveFillColor = System.Drawing.Color.Empty;
            this.btn_search.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btn_search.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btn_search.BackColor = System.Drawing.SystemColors.Control;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.ButtonText = "ค้นหาสินค้า";
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(70)))));
            this.btn_search.IdleBorderThickness = 1;
            this.btn_search.IdleCornerRadius = 70;
            this.btn_search.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btn_search.IdleForecolor = System.Drawing.Color.White;
            this.btn_search.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btn_search.Location = new System.Drawing.Point(897, 341);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(309, 81);
            this.btn_search.TabIndex = 3;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.ActiveBorderThickness = 1;
            this.btn_purchase.ActiveCornerRadius = 70;
            this.btn_purchase.ActiveFillColor = System.Drawing.Color.Empty;
            this.btn_purchase.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_purchase.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_purchase.BackColor = System.Drawing.SystemColors.Control;
            this.btn_purchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_purchase.BackgroundImage")));
            this.btn_purchase.ButtonText = "ขายสินค้า";
            this.btn_purchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchase.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.ForeColor = System.Drawing.Color.White;
            this.btn_purchase.IdleBorderThickness = 1;
            this.btn_purchase.IdleCornerRadius = 70;
            this.btn_purchase.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_purchase.IdleForecolor = System.Drawing.Color.White;
            this.btn_purchase.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_purchase.Location = new System.Drawing.Point(897, 159);
            this.btn_purchase.Margin = new System.Windows.Forms.Padding(5);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(309, 81);
            this.btn_purchase.TabIndex = 2;
            this.btn_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_purchase.Visible = false;
            this.btn_purchase.Click += new System.EventHandler(this.Btn_purchase_Click);
            // 
            // Header
            // 
            this.Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header.BackgroundImage")));
            this.Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header.Controls.Add(this.btn_mini);
            this.Header.Controls.Add(this.btn_exit);
            this.Header.Controls.Add(this.lbl_Header);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Header.GradientBottomRight = System.Drawing.Color.White;
            this.Header.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.Header.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(123)))));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Quality = 10;
            this.Header.Size = new System.Drawing.Size(1366, 78);
            this.Header.TabIndex = 1;
            // 
            // btn_mini
            // 
            this.btn_mini.BackColor = System.Drawing.Color.Transparent;
            this.btn_mini.Image = global::AE_Cosmetics.Properties.Resources.minus_500px;
            this.btn_mini.Location = new System.Drawing.Point(1282, 9);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(29, 43);
            this.btn_mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_mini.TabIndex = 3;
            this.btn_mini.TabStop = false;
            this.btn_mini.Click += new System.EventHandler(this.Btn_mini_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = global::AE_Cosmetics.Properties.Resources.cancel_500px;
            this.btn_exit.Location = new System.Drawing.Point(1317, 10);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(31, 42);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 2;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Header.Font = new System.Drawing.Font("RSU", 27.80198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(25, 12);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(638, 57);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "ระบบร้านขายเครื่องสำอาง ( AE COSMETICS )";
            // 
            // btn_logout
            // 
            this.btn_logout.ActiveBorderThickness = 1;
            this.btn_logout.ActiveCornerRadius = 70;
            this.btn_logout.ActiveFillColor = System.Drawing.Color.Empty;
            this.btn_logout.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.btn_logout.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.btn_logout.BackColor = System.Drawing.SystemColors.Control;
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.ButtonText = "ออกจากระบบ";
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(70)))));
            this.btn_logout.IdleBorderThickness = 1;
            this.btn_logout.IdleCornerRadius = 70;
            this.btn_logout.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.btn_logout.IdleForecolor = System.Drawing.Color.White;
            this.btn_logout.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.btn_logout.Location = new System.Drawing.Point(897, 614);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(309, 81);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_logout.Visible = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_report
            // 
            this.btn_report.ActiveBorderThickness = 1;
            this.btn_report.ActiveCornerRadius = 70;
            this.btn_report.ActiveFillColor = System.Drawing.Color.Empty;
            this.btn_report.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_report.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_report.BackColor = System.Drawing.SystemColors.Control;
            this.btn_report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_report.BackgroundImage")));
            this.btn_report.ButtonText = "รายงานการขาย";
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_report.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.IdleBorderThickness = 1;
            this.btn_report.IdleCornerRadius = 70;
            this.btn_report.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_report.IdleForecolor = System.Drawing.Color.White;
            this.btn_report.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_report.Location = new System.Drawing.Point(897, 432);
            this.btn_report.Margin = new System.Windows.Forms.Padding(5);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(309, 81);
            this.btn_report.TabIndex = 9;
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_report.Visible = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // aeCosmeticsDataSet
            // 
            this.aeCosmeticsDataSet.DataSetName = "aeCosmeticsDataSet";
            this.aeCosmeticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.aeCosmeticsDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.card_logo);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_aboutMe);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_purchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AE COMETICS";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.card_logo.ResumeLayout(false);
            this.card_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeCosmeticsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Home;
        private Bunifu.Framework.UI.BunifuGradientPanel Header;
        private System.Windows.Forms.PictureBox btn_mini;
        private System.Windows.Forms.PictureBox btn_exit;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Header;
        private Bunifu.Framework.UI.BunifuElipse bg_form;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_update;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_aboutMe;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_search;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_purchase;
        private Bunifu.Framework.UI.BunifuCards card_logo;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_logout;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_report;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_username;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_password;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_notFound;
        private aeCosmeticsDataSet aeCosmeticsDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private aeCosmeticsDataSetTableAdapters.userTableAdapter userTableAdapter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txb_passsWord;
    }
}

