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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_aboutMe = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_purchase = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_mini = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
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
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 40;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.White;
            this.bunifuCards1.Controls.Add(this.logo);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(107, 217);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(648, 440);
            this.bunifuCards1.TabIndex = 7;
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
            this.btn_update.ButtonText = "Update ";
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(70)))));
            this.btn_update.IdleBorderThickness = 1;
            this.btn_update.IdleCornerRadius = 70;
            this.btn_update.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            this.btn_update.IdleForecolor = System.Drawing.Color.White;
            this.btn_update.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            this.btn_update.Location = new System.Drawing.Point(897, 330);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(309, 81);
            this.btn_update.TabIndex = 5;
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_aboutMe.ButtonText = "About";
            this.btn_aboutMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aboutMe.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aboutMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(70)))));
            this.btn_aboutMe.IdleBorderThickness = 1;
            this.btn_aboutMe.IdleCornerRadius = 70;
            this.btn_aboutMe.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(193)))), ((int)(((byte)(235)))));
            this.btn_aboutMe.IdleForecolor = System.Drawing.Color.White;
            this.btn_aboutMe.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(193)))), ((int)(((byte)(235)))));
            this.btn_aboutMe.Location = new System.Drawing.Point(897, 576);
            this.btn_aboutMe.Margin = new System.Windows.Forms.Padding(5);
            this.btn_aboutMe.Name = "btn_aboutMe";
            this.btn_aboutMe.Size = new System.Drawing.Size(309, 81);
            this.btn_aboutMe.TabIndex = 4;
            this.btn_aboutMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_search.ButtonText = "Search";
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(70)))));
            this.btn_search.IdleBorderThickness = 1;
            this.btn_search.IdleCornerRadius = 70;
            this.btn_search.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btn_search.IdleForecolor = System.Drawing.Color.White;
            this.btn_search.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btn_search.Location = new System.Drawing.Point(897, 455);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(309, 81);
            this.btn_search.TabIndex = 3;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_purchase.ButtonText = "Purchase";
            this.btn_purchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchase.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.ForeColor = System.Drawing.Color.White;
            this.btn_purchase.IdleBorderThickness = 1;
            this.btn_purchase.IdleCornerRadius = 70;
            this.btn_purchase.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_purchase.IdleForecolor = System.Drawing.Color.White;
            this.btn_purchase.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(119)))));
            this.btn_purchase.Location = new System.Drawing.Point(897, 210);
            this.btn_purchase.Margin = new System.Windows.Forms.Padding(5);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(309, 81);
            this.btn_purchase.TabIndex = 2;
            this.btn_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_aboutMe);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AE COMETICS";
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.PictureBox logo;
    }
}

