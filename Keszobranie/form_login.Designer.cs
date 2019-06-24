namespace Keszobranie
{
    partial class form_login
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
            this.lb_text = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_register = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(108, 123);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(75, 18);
            this.lb_text.TabIndex = 9;
            this.lb_text.Text = "Password";
            this.lb_text.Click += new System.EventHandler(this.Lb_text_Click);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(108, 58);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(45, 18);
            this.lb_Email.TabIndex = 8;
            this.lb_Email.Text = "Email";
            this.lb_Email.Click += new System.EventHandler(this.Lb_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_password.Location = new System.Drawing.Point(108, 143);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(331, 30);
            this.tb_password.TabIndex = 7;
            this.tb_password.TextChanged += new System.EventHandler(this.Tb_login_password_TextChanged);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_email.Location = new System.Drawing.Point(108, 81);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(331, 30);
            this.tb_email.TabIndex = 6;
            this.tb_email.TextChanged += new System.EventHandler(this.Tb_login_login_TextChanged);
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_login.Location = new System.Drawing.Point(333, 192);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(106, 34);
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.Bt_login_Click);
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_register.Location = new System.Drawing.Point(48, 206);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(180, 20);
            this.lb_register.TabIndex = 10;
            this.lb_register.Text = "Doesn\'t have account?";
            this.lb_register.Click += new System.EventHandler(this.Lb_register_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.bt_login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "form_login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_register;
    }
}