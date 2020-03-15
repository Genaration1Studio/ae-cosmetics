namespace AE_Cosmetics
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.bunifuElipse_Report = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_mini = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.Header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cb_orderDate = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeCosmeticsDataSet = new AE_Cosmetics.aeCosmeticsDataSet();
            this.orderTableAdapter = new AE_Cosmetics.aeCosmeticsDataSetTableAdapters.orderTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new AE_Cosmetics.aeCosmeticsDataSetTableAdapters.productTableAdapter();
            this.productorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_orderTableAdapter = new AE_Cosmetics.aeCosmeticsDataSetTableAdapters.product_orderTableAdapter();
            this.orderListReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.Header.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeCosmeticsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse_Report
            // 
            this.bunifuElipse_Report.ElipseRadius = 15;
            this.bunifuElipse_Report.TargetControl = this;
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
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
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
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.Header.TabIndex = 2;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Header.Font = new System.Drawing.Font("RSU", 27.80198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(24, 12);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(239, 57);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "รายงานการขาย";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.bunifuCards1.Controls.Add(this.reportViewer);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(46, 291);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1271, 434);
            this.bunifuCards1.TabIndex = 3;
            // 
            // reportViewer
            // 
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "AE_Cosmetics.receipt.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 3);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1271, 428);
            this.reportViewer.TabIndex = 1;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(178)))), ((int)(((byte)(133)))));
            this.bunifuCards2.Controls.Add(this.pictureBox2);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel18);
            this.bunifuCards2.Controls.Add(this.cb_orderDate);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(46, 160);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1271, 73);
            this.bunifuCards2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AE_Cosmetics.Properties.Resources.today_480px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(23, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("supermarket", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(71, 20);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(99, 30);
            this.bunifuCustomLabel18.TabIndex = 34;
            this.bunifuCustomLabel18.Text = "วันที่ทำการขาย :";
            // 
            // cb_orderDate
            // 
            this.cb_orderDate.DataSource = this.orderBindingSource;
            this.cb_orderDate.DisplayMember = "orderDate";
            this.cb_orderDate.Font = new System.Drawing.Font("supermarket", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_orderDate.FormattingEnabled = true;
            this.cb_orderDate.Location = new System.Drawing.Point(176, 17);
            this.cb_orderDate.Name = "cb_orderDate";
            this.cb_orderDate.Size = new System.Drawing.Size(149, 33);
            this.cb_orderDate.TabIndex = 2;
            this.cb_orderDate.ValueMember = "orderDate";
            this.cb_orderDate.SelectedIndexChanged += new System.EventHandler(this.cb_orderDate_SelectedIndexChanged);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.aeCosmeticsDataSet;
            // 
            // aeCosmeticsDataSet
            // 
            this.aeCosmeticsDataSet.DataSetName = "aeCosmeticsDataSet";
            this.aeCosmeticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.aeCosmeticsDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productorderBindingSource
            // 
            this.productorderBindingSource.DataMember = "product_order";
            this.productorderBindingSource.DataSource = this.aeCosmeticsDataSet;
            // 
            // product_orderTableAdapter
            // 
            this.product_orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderListReportBindingSource
            // 
            this.orderListReportBindingSource.DataSource = typeof(AE_Cosmetics.orderListReport);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("supermarket", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(39, 107);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(188, 41);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "ค้นหารายงานการขาย";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("supermarket", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(39, 247);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(173, 41);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "รายละเอียดการขาย";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeCosmeticsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Report;
        private Bunifu.Framework.UI.BunifuGradientPanel Header;
        private System.Windows.Forms.PictureBox btn_mini;
        private System.Windows.Forms.PictureBox btn_exit;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Header;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private aeCosmeticsDataSet aeCosmeticsDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private aeCosmeticsDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private aeCosmeticsDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productorderBindingSource;
        private aeCosmeticsDataSetTableAdapters.product_orderTableAdapter product_orderTableAdapter;
        private System.Windows.Forms.BindingSource orderListReportBindingSource;
        private System.Windows.Forms.ComboBox cb_orderDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}