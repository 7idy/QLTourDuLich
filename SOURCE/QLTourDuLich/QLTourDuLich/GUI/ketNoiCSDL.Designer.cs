namespace QLTourDuLich.GUI
{
    partial class ketNoiCSDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ketNoiCSDL));
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.Location = new System.Drawing.Point(0, 509);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(800, 35);
            this.lblTime.TabIndex = 13;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picHide
            // 
            this.picHide.Image = global::QLTourDuLich.Properties.Resources.hide;
            this.picHide.Location = new System.Drawing.Point(567, 330);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(24, 24);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHide.TabIndex = 23;
            this.picHide.TabStop = false;
            // 
            // picShow
            // 
            this.picShow.Image = global::QLTourDuLich.Properties.Resources.show;
            this.picShow.Location = new System.Drawing.Point(567, 330);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(24, 24);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picShow.TabIndex = 22;
            this.picShow.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Image = global::QLTourDuLich.Properties.Resources.login;
            this.btnDangNhap.Location = new System.Drawing.Point(388, 372);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(151, 49);
            this.btnDangNhap.TabIndex = 20;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::QLTourDuLich.Properties.Resources.circular_arows;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(242, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 49);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(319, 327);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(242, 26);
            this.txtMK.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(207, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(319, 284);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(242, 26);
            this.txtUserName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(207, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Server name";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "KẾT NỐI CSDL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::QLTourDuLich.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ketNoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picHide);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ketNoiCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KẾT NỐI CSDL";
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}