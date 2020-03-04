namespace AE_Cosmetics
{
    partial class MSG_SaveOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSG_SaveOrder));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_ok = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picMoney = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Header.Font = new System.Drawing.Font("RSU", 22.09901F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(39, 222);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(339, 47);
            this.lbl_Header.TabIndex = 19;
            this.lbl_Header.Text = "บันทึกรายการเรียบร้อยแล้วค่ะ";
            // 
            // btn_ok
            // 
            this.btn_ok.ActiveBorderThickness = 1;
            this.btn_ok.ActiveCornerRadius = 45;
            this.btn_ok.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_ok.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.ButtonText = "OK";
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.Font = new System.Drawing.Font("RSU", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.IdleBorderThickness = 1;
            this.btn_ok.IdleCornerRadius = 45;
            this.btn_ok.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_ok.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.Location = new System.Drawing.Point(103, 274);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(176, 59);
            this.btn_ok.TabIndex = 20;
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // picMoney
            // 
            this.picMoney.BackgroundImage = global::AE_Cosmetics.Properties.Resources.ok_500px;
            this.picMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMoney.Location = new System.Drawing.Point(61, 20);
            this.picMoney.Name = "picMoney";
            this.picMoney.Size = new System.Drawing.Size(265, 189);
            this.picMoney.TabIndex = 18;
            this.picMoney.TabStop = false;
            // 
            // MSG_SaveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.picMoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSG_SaveOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSG_SaveOrder";
            ((System.ComponentModel.ISupportInitialize)(this.picMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox picMoney;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Header;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ok;
    }
}