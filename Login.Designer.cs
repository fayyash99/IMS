namespace Inventory_Management_System
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.UnameErrorLabel = new System.Windows.Forms.Label();
            this.passErrorLabell = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.textBox1);
            this.leftpanel.Controls.Add(this.loginBtn);
            this.leftpanel.Controls.Add(this.Passwordtxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.Usernametxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.UnameErrorLabel);
            this.leftpanel.Controls.Add(this.passErrorLabell);
            this.leftpanel.Size = new System.Drawing.Size(250, 450);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            this.leftpanel.Controls.SetChildIndex(this.passErrorLabell, 0);
            this.leftpanel.Controls.SetChildIndex(this.UnameErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.Usernametxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.Passwordtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.loginBtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.textBox1, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(550, 450);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "username";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(9, 169);
            this.Usernametxt.MaxLength = 30;
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(216, 23);
            this.Usernametxt.TabIndex = 3;
            this.Usernametxt.Text = "admin";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(9, 213);
            this.Passwordtxt.MaxLength = 30;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(219, 23);
            this.Passwordtxt.TabIndex = 5;
            this.Passwordtxt.Text = "admin123";
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "password";
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(9, 242);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(219, 29);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // UnameErrorLabel
            // 
            this.UnameErrorLabel.AutoSize = true;
            this.UnameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.UnameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.UnameErrorLabel.Location = new System.Drawing.Point(69, 148);
            this.UnameErrorLabel.Name = "UnameErrorLabel";
            this.UnameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.UnameErrorLabel.TabIndex = 15;
            this.UnameErrorLabel.Text = "*";
            this.UnameErrorLabel.Visible = false;
            // 
            // passErrorLabell
            // 
            this.passErrorLabell.AutoSize = true;
            this.passErrorLabell.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.passErrorLabell.ForeColor = System.Drawing.Color.Salmon;
            this.passErrorLabell.Location = new System.Drawing.Point(69, 192);
            this.passErrorLabell.Name = "passErrorLabell";
            this.passErrorLabell.Size = new System.Drawing.Size(20, 28);
            this.passErrorLabell.TabIndex = 16;
            this.passErrorLabell.Text = "*";
            this.passErrorLabell.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "SB Baby House";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Login";
            this.Text = "Login";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label UnameErrorLabel;
        private System.Windows.Forms.Label passErrorLabell;
        private System.Windows.Forms.TextBox textBox1;
    }
}