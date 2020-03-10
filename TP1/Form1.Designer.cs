namespace TP1
{
    partial class Form1
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
            this.L_User = new System.Windows.Forms.Label();
            this.Tb_User = new System.Windows.Forms.TextBox();
            this.L_Pass = new System.Windows.Forms.Label();
            this.Tb_Pass = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_User
            // 
            this.L_User.AutoSize = true;
            this.L_User.Location = new System.Drawing.Point(12, 27);
            this.L_User.Name = "L_User";
            this.L_User.Size = new System.Drawing.Size(55, 13);
            this.L_User.TabIndex = 1;
            this.L_User.Text = "Username";
            // 
            // Tb_User
            // 
            this.Tb_User.Location = new System.Drawing.Point(15, 43);
            this.Tb_User.Name = "Tb_User";
            this.Tb_User.Size = new System.Drawing.Size(100, 20);
            this.Tb_User.TabIndex = 2;
            // 
            // L_Pass
            // 
            this.L_Pass.AutoSize = true;
            this.L_Pass.Location = new System.Drawing.Point(12, 81);
            this.L_Pass.Name = "L_Pass";
            this.L_Pass.Size = new System.Drawing.Size(53, 13);
            this.L_Pass.TabIndex = 3;
            this.L_Pass.Text = "Password";
            // 
            // Tb_Pass
            // 
            this.Tb_Pass.Location = new System.Drawing.Point(15, 97);
            this.Tb_Pass.MaxLength = 14;
            this.Tb_Pass.Name = "Tb_Pass";
            this.Tb_Pass.PasswordChar = '*';
            this.Tb_Pass.Size = new System.Drawing.Size(100, 20);
            this.Tb_Pass.TabIndex = 4;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(15, 134);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(75, 23);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 214);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Tb_Pass);
            this.Controls.Add(this.L_Pass);
            this.Controls.Add(this.Tb_User);
            this.Controls.Add(this.L_User);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_User;
        private System.Windows.Forms.TextBox Tb_User;
        private System.Windows.Forms.Label L_Pass;
        private System.Windows.Forms.TextBox Tb_Pass;
        private System.Windows.Forms.Button Btn_Login;
    }
}

