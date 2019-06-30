namespace Keszobranie
{
    partial class form_update_user_data
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
            this.bt_update = new System.Windows.Forms.Button();
            this.lb_password_repeat = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_surname = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_password_repeat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(331, 265);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(153, 23);
            this.bt_update.TabIndex = 30;
            this.bt_update.Text = "UPDATE";
            this.bt_update.UseMnemonic = false;
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.Bt_submit_Click);
            // 
            // lb_password_repeat
            // 
            this.lb_password_repeat.AutoSize = true;
            this.lb_password_repeat.Location = new System.Drawing.Point(32, 232);
            this.lb_password_repeat.Name = "lb_password_repeat";
            this.lb_password_repeat.Size = new System.Drawing.Size(69, 17);
            this.lb_password_repeat.TabIndex = 29;
            this.lb_password_repeat.Text = "Password";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(32, 183);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(69, 17);
            this.lb_password.TabIndex = 28;
            this.lb_password.Text = "Password";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(32, 137);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(42, 17);
            this.lb_email.TabIndex = 27;
            this.lb_email.Text = "Email";
            // 
            // lb_surname
            // 
            this.lb_surname.AutoSize = true;
            this.lb_surname.Location = new System.Drawing.Point(32, 91);
            this.lb_surname.Name = "lb_surname";
            this.lb_surname.Size = new System.Drawing.Size(65, 17);
            this.lb_surname.TabIndex = 26;
            this.lb_surname.Text = "Surname";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(32, 41);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(45, 17);
            this.lb_name.TabIndex = 25;
            this.lb_name.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_name.Location = new System.Drawing.Point(169, 31);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(331, 30);
            this.tb_name.TabIndex = 24;
            // 
            // tb_surname
            // 
            this.tb_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_surname.Location = new System.Drawing.Point(169, 78);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(331, 30);
            this.tb_surname.TabIndex = 23;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_email.Location = new System.Drawing.Point(169, 127);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(331, 30);
            this.tb_email.TabIndex = 22;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_password.Location = new System.Drawing.Point(169, 173);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(331, 30);
            this.tb_password.TabIndex = 21;
            // 
            // tb_password_repeat
            // 
            this.tb_password_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_password_repeat.Location = new System.Drawing.Point(169, 222);
            this.tb_password_repeat.Name = "tb_password_repeat";
            this.tb_password_repeat.PasswordChar = '*';
            this.tb_password_repeat.Size = new System.Drawing.Size(331, 30);
            this.tb_password_repeat.TabIndex = 20;
            // 
            // form_update_user_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 320);
            this.Controls.Add(this.bt_update);
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
            this.MinimizeBox = false;
            this.Name = "form_update_user_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label lb_password_repeat;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_surname;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_password_repeat;
    }
}