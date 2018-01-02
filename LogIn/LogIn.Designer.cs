namespace LogIn
{
    partial class LogIn
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
            this.login_groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pw_txt = new System.Windows.Forms.TextBox();
            this.user_txt = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.Label();
            this.user_name_txt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_bt = new System.Windows.Forms.Button();
            this.login_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_groupBox
            // 
            this.login_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.login_groupBox.Controls.Add(this.pictureBox1);
            this.login_groupBox.Controls.Add(this.label1);
            this.login_groupBox.Controls.Add(this.login_bt);
            this.login_groupBox.Controls.Add(this.pw_txt);
            this.login_groupBox.Controls.Add(this.user_txt);
            this.login_groupBox.Controls.Add(this.pass_txt);
            this.login_groupBox.Controls.Add(this.user_name_txt);
            this.login_groupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_groupBox.Font = new System.Drawing.Font("Aparajita", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.login_groupBox.Location = new System.Drawing.Point(0, 0);
            this.login_groupBox.Name = "login_groupBox";
            this.login_groupBox.Size = new System.Drawing.Size(520, 314);
            this.login_groupBox.TabIndex = 9;
            this.login_groupBox.TabStop = false;
            this.login_groupBox.Text = "Sign In";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(101, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to my cms software!";
            // 
            // pw_txt
            // 
            this.pw_txt.AcceptsTab = true;
            this.pw_txt.Location = new System.Drawing.Point(348, 142);
            this.pw_txt.Name = "pw_txt";
            this.pw_txt.Size = new System.Drawing.Size(164, 32);
            this.pw_txt.TabIndex = 7;
            this.pw_txt.TextChanged += new System.EventHandler(this.pw_txt_TextChanged);
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.user_txt.Location = new System.Drawing.Point(250, 98);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(86, 25);
            this.user_txt.TabIndex = 0;
            this.user_txt.Text = "UserName";
            // 
            // pass_txt
            // 
            this.pass_txt.AutoSize = true;
            this.pass_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pass_txt.Location = new System.Drawing.Point(250, 145);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(77, 25);
            this.pass_txt.TabIndex = 1;
            this.pass_txt.Text = "Password";
            // 
            // user_name_txt
            // 
            this.user_name_txt.Location = new System.Drawing.Point(348, 91);
            this.user_name_txt.Name = "user_name_txt";
            this.user_name_txt.Size = new System.Drawing.Size(164, 32);
            this.user_name_txt.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Sign In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.BackgroundImage = global::LogIn.Properties.Resources._lock;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login_bt
            // 
            this.login_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.login_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_bt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.login_bt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.login_bt.Image = global::LogIn.Properties.Resources.Ok_icon;
            this.login_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_bt.Location = new System.Drawing.Point(348, 190);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(96, 55);
            this.login_bt.TabIndex = 8;
            this.login_bt.Text = "Sign In";
            this.login_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_bt.UseVisualStyleBackColor = false;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 314);
            this.Controls.Add(this.login_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_groupBox.ResumeLayout(false);
            this.login_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login_groupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.TextBox pw_txt;
        private System.Windows.Forms.Label user_txt;
        private System.Windows.Forms.Label pass_txt;
        private System.Windows.Forms.TextBox user_name_txt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

