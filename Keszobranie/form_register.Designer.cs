namespace Keszobranie
{
    partial class form_register
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
            this.tb_password_repeat = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_surname = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_password_repeat = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.lb_back_to_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_password_repeat
            // 
            this.tb_password_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_password_repeat.Location = new System.Drawing.Point(162, 203);
            this.tb_password_repeat.Name = "tb_password_repeat";
            this.tb_password_repeat.PasswordChar = '*';
            this.tb_password_repeat.Size = new System.Drawing.Size(331, 30);
            this.tb_password_repeat.TabIndex = 7;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_password.Location = new System.Drawing.Point(162, 154);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(331, 30);
            this.tb_password.TabIndex = 8;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_email.Location = new System.Drawing.Point(162, 108);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(331, 30);
            this.tb_email.TabIndex = 9;
            // 
            // tb_surname
            // 
            this.tb_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_surname.Location = new System.Drawing.Point(162, 59);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(331, 30);
            this.tb_surname.TabIndex = 10;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_name.Location = new System.Drawing.Point(162, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(331, 30);
            this.tb_name.TabIndex = 11;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(25, 22);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(45, 17);
            this.lb_name.TabIndex = 12;
            this.lb_name.Text = "Name";
            // 
            // lb_surname
            // 
            this.lb_surname.AutoSize = true;
            this.lb_surname.Location = new System.Drawing.Point(25, 72);
            this.lb_surname.Name = "lb_surname";
            this.lb_surname.Size = new System.Drawing.Size(65, 17);
            this.lb_surname.TabIndex = 14;
            this.lb_surname.Text = "Surname";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(25, 118);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(42, 17);
            this.lb_email.TabIndex = 15;
            this.lb_email.Text = "Email";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(25, 164);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(69, 17);
            this.lb_password.TabIndex = 16;
            this.lb_password.Text = "Password";
            // 
            // lb_password_repeat
            // 
            this.lb_password_repeat.AutoSize = true;
            this.lb_password_repeat.Location = new System.Drawing.Point(25, 213);
            this.lb_password_repeat.Name = "lb_password_repeat";
            this.lb_password_repeat.Size = new System.Drawing.Size(69, 17);
            this.lb_password_repeat.TabIndex = 17;
            this.lb_password_repeat.Text = "Password";
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(324, 246);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(153, 23);
            this.bt_submit.TabIndex = 18;
            this.bt_submit.Text = "SUBMIT";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.Bt_submit_Click);
            // 
            // lb_back_to_login
            // 
            this.lb_back_to_login.AutoSize = true;
            this.lb_back_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_back_to_login.Location = new System.Drawing.Point(115, 247);
            this.lb_back_to_login.Name = "lb_back_to_login";
            this.lb_back_to_login.Size = new System.Drawing.Size(123, 25);
            this.lb_back_to_login.TabIndex = 19;
            this.lb_back_to_login.Text = "Back to login";
            this.lb_back_to_login.Click += new System.EventHandler(this.Lb_back_to_login_Click);
            // 
            // form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.lb_back_to_login);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.lb_password_repeat);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_surname);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_password_repeat);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "form_register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REGISTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_password_repeat;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_surname;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_password_repeat;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Label lb_back_to_login;
    }
}