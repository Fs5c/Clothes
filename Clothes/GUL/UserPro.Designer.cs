namespace Clothes.GUL
{
    partial class UserPro
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
            this.btnAddPic = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Label();
            this.btnPhone = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnloign = new System.Windows.Forms.Button();
            this.picUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(30, 23);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(30, 23);
            this.btnAddPic.TabIndex = 1;
            this.btnAddPic.Text = "+";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(25, 132);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "UserName";
            // 
            // btnPassword
            // 
            this.btnPassword.AutoSize = true;
            this.btnPassword.Location = new System.Drawing.Point(27, 159);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(53, 13);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.Text = "Password";
            // 
            // btnPhone
            // 
            this.btnPhone.AutoSize = true;
            this.btnPhone.Location = new System.Drawing.Point(43, 188);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(37, 13);
            this.btnPhone.TabIndex = 4;
            this.btnPhone.Text = "Phone";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(85, 129);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 5;
        
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(87, 188);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 7;
      
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // btnloign
            // 
            this.btnloign.Location = new System.Drawing.Point(66, 229);
            this.btnloign.Name = "btnloign";
            this.btnloign.Size = new System.Drawing.Size(75, 23);
            this.btnloign.TabIndex = 8;
            this.btnloign.Text = "Loign";
            this.btnloign.UseVisualStyleBackColor = true;
            this.btnloign.Click += new System.EventHandler(this.btnloign_Click);
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(66, 12);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(119, 99);
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
        
            // 
            // UserPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 264);
            this.Controls.Add(this.btnloign);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.picUser);
            this.Name = "UserPro";
            this.Text = "UserPro";
            this.Load += new System.EventHandler(this.UserPro_Load);

            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label btnPassword;
        private System.Windows.Forms.Label btnPhone;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnloign;
    }
}