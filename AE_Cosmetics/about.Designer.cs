namespace AE_Cosmetics
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.bunifuElipse_About = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_dept = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.pic_prev = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prev)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse_About
            // 
            this.bunifuElipse_About.ElipseRadius = 15;
            this.bunifuElipse_About.TargetControl = this;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_name.Font = new System.Drawing.Font("Sukhumvit Set", 22.09901F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_name.Location = new System.Drawing.Point(232, 316);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(344, 35);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "นางสาวอัมพร สุขประเสริฐ";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_id.Font = new System.Drawing.Font("Sukhumvit Set", 17.82178F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_id.Location = new System.Drawing.Point(150, 364);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(488, 27);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "รหัสประจำตัวนักศึกษา 6132040073 กลุ่ม E.5";
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_dept.Font = new System.Drawing.Font("Sukhumvit Set", 17.82178F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_dept.Location = new System.Drawing.Point(137, 402);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(524, 27);
            this.lbl_dept.TabIndex = 4;
            this.lbl_dept.Text = "แผนกวิชาคอมพิวเตอร์ธุรกิจ วิทยาลัยเทคนิคชัยภูมิ";
            // 
            // pic_next
            // 
            this.pic_next.Image = global::AE_Cosmetics.Properties.Resources.more_than_512px;
            this.pic_next.Location = new System.Drawing.Point(558, 122);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(66, 79);
            this.pic_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_next.TabIndex = 6;
            this.pic_next.TabStop = false;
            this.pic_next.Click += new System.EventHandler(this.pic_next_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = global::AE_Cosmetics.Properties.Resources.delete_sign_512px;
            this.btn_exit.Location = new System.Drawing.Point(755, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 40);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 5;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pic_profile
            // 
            this.pic_profile.Image = ((System.Drawing.Image)(resources.GetObject("pic_profile.Image")));
            this.pic_profile.Location = new System.Drawing.Point(238, 12);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(291, 290);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_profile.TabIndex = 0;
            this.pic_profile.TabStop = false;
            // 
            // pic_prev
            // 
            this.pic_prev.Enabled = false;
            this.pic_prev.Image = global::AE_Cosmetics.Properties.Resources.last_than_soft_512px;
            this.pic_prev.Location = new System.Drawing.Point(142, 122);
            this.pic_prev.Name = "pic_prev";
            this.pic_prev.Size = new System.Drawing.Size(66, 79);
            this.pic_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_prev.TabIndex = 7;
            this.pic_prev.TabStop = false;
            this.pic_prev.Click += new System.EventHandler(this.pic_prev_Click);
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_prev);
            this.Controls.Add(this.pic_next);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pic_profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "about";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "about";
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_About;
        private System.Windows.Forms.PictureBox pic_profile;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_name;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_dept;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_id;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.PictureBox pic_prev;
    }
}