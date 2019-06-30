namespace Keszobranie
{
    partial class form_new_cache
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_hint = new System.Windows.Forms.RichTextBox();
            this.tb_description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_name.Location = new System.Drawing.Point(93, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(314, 30);
            this.tb_name.TabIndex = 0;
            // 
            // tb_hint
            // 
            this.tb_hint.Location = new System.Drawing.Point(93, 150);
            this.tb_hint.Name = "tb_hint";
            this.tb_hint.Size = new System.Drawing.Size(314, 96);
            this.tb_hint.TabIndex = 1;
            this.tb_hint.Text = "";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(93, 48);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(314, 96);
            this.tb_description.TabIndex = 2;
            this.tb_description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hint";
            // 
            // bt_submit
            // 
            this.bt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_submit.Location = new System.Drawing.Point(431, 251);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(89, 40);
            this.bt_submit.TabIndex = 6;
            this.bt_submit.Text = "SUBMIT";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.Bt_submit_Click);
            // 
            // form_new_cache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.tb_hint);
            this.Controls.Add(this.tb_name);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "form_new_cache";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NEW CACHE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_new_cache_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_new_cache_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.RichTextBox tb_hint;
        private System.Windows.Forms.RichTextBox tb_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_submit;
    }
}