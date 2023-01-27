namespace NewForm
{
    partial class frmnewform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblforgot = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(56, 135);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(205, 27);
            this.txtusername.TabIndex = 2;
            this.txtusername.Text = "User Name";
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(56, 179);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(205, 27);
            this.txtpwd.TabIndex = 3;
            this.txtpwd.Text = "Password";
            this.txtpwd.TextChanged += new System.EventHandler(this.txtpwd_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(140, 253);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(121, 29);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(94, 199);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox1.Image = global::NewForm.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(94, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblforgot
            // 
            this.lblforgot.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblforgot.AutoSize = true;
            this.lblforgot.LinkColor = System.Drawing.Color.Red;
            this.lblforgot.Location = new System.Drawing.Point(56, 219);
            this.lblforgot.Name = "lblforgot";
            this.lblforgot.Size = new System.Drawing.Size(125, 20);
            this.lblforgot.TabIndex = 7;
            this.lblforgot.TabStop = true;
            this.lblforgot.Text = "Forgot Password?";
            // 
            // frmnewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(306, 370);
            this.Controls.Add(this.lblforgot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtusername);
            this.Name = "frmnewform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Form";
            this.Load += new System.EventHandler(this.frmnewform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtusername;
        private TextBox txtpwd;
        private Button btnlogin;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private LinkLabel lblforgot;
    }
}