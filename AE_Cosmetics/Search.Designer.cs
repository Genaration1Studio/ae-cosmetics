namespace AE_Cosmetics
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.bunifuElipse_Home = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bg_form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txb_search2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txb_search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeCosmeticsDataSet = new AE_Cosmetics.aeCosmeticsDataSet();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.progessSearch = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.dtg_productList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_mini = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.productTableAdapter = new AE_Cosmetics.aeCosmeticsDataSetTableAdapters.productTableAdapter();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuCards6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeCosmeticsDataSet)).BeginInit();
            this.bunifuCards4.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productList)).BeginInit();
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
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(178)))), ((int)(((byte)(133)))));
            this.bunifuCards1.Controls.Add(this.txb_search2);
            this.bunifuCards1.Controls.Add(this.pictureBox2);
            this.bunifuCards1.Controls.Add(this.txb_search);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(26, 140);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(909, 89);
            this.bunifuCards1.TabIndex = 2;
            // 
            // txb_search2
            // 
            this.txb_search2.BorderColor = System.Drawing.Color.SeaGreen;
            this.txb_search2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_search2.Font = new System.Drawing.Font("Sukhumvit Set", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txb_search2.Location = new System.Drawing.Point(102, 32);
            this.txb_search2.Name = "txb_search2";
            this.txb_search2.Size = new System.Drawing.Size(781, 27);
            this.txb_search2.TabIndex = 1;
            this.txb_search2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_search2_KeyUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AE_Cosmetics.Properties.Resources.search_more_400px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(20, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 57);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // txb_search
            // 
            this.txb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_search.Font = new System.Drawing.Font("Sukhumvit Set", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_search.HintForeColor = System.Drawing.Color.Empty;
            this.txb_search.HintText = "";
            this.txb_search.isPassword = false;
            this.txb_search.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(183)))), ((int)(((byte)(121)))));
            this.txb_search.LineIdleColor = System.Drawing.Color.Gray;
            this.txb_search.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(183)))), ((int)(((byte)(121)))));
            this.txb_search.LineThickness = 2;
            this.txb_search.Location = new System.Drawing.Point(102, 34);
            this.txb_search.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(781, 32);
            this.txb_search.TabIndex = 12;
            this.txb_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Sukhumvit Set", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(22, 249);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(119, 23);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Product List";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Sukhumvit Set", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(22, 102);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(71, 23);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Search";
            // 
            // bunifuCards6
            // 
            this.bunifuCards6.BackColor = System.Drawing.Color.White;
            this.bunifuCards6.BorderRadius = 5;
            this.bunifuCards6.BottomSahddow = true;
            this.bunifuCards6.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.bunifuCards6.Controls.Add(this.pic_product);
            this.bunifuCards6.LeftSahddow = false;
            this.bunifuCards6.Location = new System.Drawing.Point(964, 285);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(375, 452);
            this.bunifuCards6.TabIndex = 22;
            // 
            // pic_product
            // 
            this.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_product.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "productImage", true));
            this.pic_product.Location = new System.Drawing.Point(38, 41);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(296, 362);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_product.TabIndex = 1;
            this.pic_product.TabStop = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.aeCosmeticsDataSet;
            // 
            // aeCosmeticsDataSet
            // 
            this.aeCosmeticsDataSet.DataSetName = "aeCosmeticsDataSet";
            this.aeCosmeticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Sukhumvit Set", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(960, 246);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(140, 23);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.Text = "Product Image";
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.bunifuCards4.Controls.Add(this.progessSearch);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(964, 140);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(375, 89);
            this.bunifuCards4.TabIndex = 24;
            // 
            // progessSearch
            // 
            this.progessSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.progessSearch.BorderRadius = 10;
            this.progessSearch.Location = new System.Drawing.Point(21, 28);
            this.progessSearch.MaximumValue = 100;
            this.progessSearch.Name = "progessSearch";
            this.progessSearch.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.progessSearch.Size = new System.Drawing.Size(326, 32);
            this.progessSearch.TabIndex = 1;
            this.progessSearch.Value = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Sukhumvit Set", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(960, 102);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(89, 23);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Progress";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.bunifuCards2.Controls.Add(this.dtg_productList);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(26, 285);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(909, 452);
            this.bunifuCards2.TabIndex = 26;
            // 
            // dtg_productList
            // 
            this.dtg_productList.AllowUserToAddRows = false;
            this.dtg_productList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_productList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_productList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_productList.AutoGenerateColumns = false;
            this.dtg_productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_productList.BackgroundColor = System.Drawing.Color.White;
            this.dtg_productList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_productList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_productList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn});
            this.dtg_productList.DataSource = this.productBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_productList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_productList.DoubleBuffered = true;
            this.dtg_productList.EnableHeadersVisualStyles = false;
            this.dtg_productList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.dtg_productList.HeaderForeColor = System.Drawing.Color.Black;
            this.dtg_productList.Location = new System.Drawing.Point(0, 3);
            this.dtg_productList.Name = "dtg_productList";
            this.dtg_productList.ReadOnly = true;
            this.dtg_productList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_productList.RowHeadersVisible = false;
            this.dtg_productList.RowHeadersWidth = 43;
            this.dtg_productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_productList.Size = new System.Drawing.Size(909, 446);
            this.dtg_productList.TabIndex = 21;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "unitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "unitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "inStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "inStock";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.lbl_Header.Location = new System.Drawing.Point(24, 12);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(286, 57);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "SEARCH PRODUCT";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCards6);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AE COMETICS";
            this.Load += new System.EventHandler(this.Search_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuCards6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeCosmeticsDataSet)).EndInit();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productList)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Home;
        private Bunifu.Framework.UI.BunifuGradientPanel Header;
        private System.Windows.Forms.PictureBox btn_mini;
        private System.Windows.Forms.PictureBox btn_exit;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Header;
        private Bunifu.Framework.UI.BunifuElipse bg_form;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_search;
        private Bunifu.Framework.UI.BunifuCards bunifuCards6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox pic_product;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txb_search2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtg_productList;
        private Bunifu.Framework.UI.BunifuProgressBar progessSearch;
        private System.Windows.Forms.Timer timer;
        private aeCosmeticsDataSet aeCosmeticsDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private aeCosmeticsDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
    }
}

