namespace Keszobranie
{
    partial class bt_stats_info
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
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.panel_user_stats = new System.Windows.Forms.Panel();
            this.lb_user_week_sequence = new System.Windows.Forms.Label();
            this.lb_user_progress = new System.Windows.Forms.Label();
            this.lb_user_cache_not_found = new System.Windows.Forms.Label();
            this.lb_user_cache_found = new System.Windows.Forms.Label();
            this.panel_cache_info = new System.Windows.Forms.Panel();
            this.lb_location_difficulty = new System.Windows.Forms.Label();
            this.lb_cache_found = new System.Windows.Forms.Label();
            this.lb_cache_difficulty = new System.Windows.Forms.Label();
            this.lb_cache_description = new System.Windows.Forms.Label();
            this.lb_cache_name = new System.Windows.Forms.Label();
            this.panel_user_info = new System.Windows.Forms.Panel();
            this.lb_user_advancement = new System.Windows.Forms.Label();
            this.lb_user_age = new System.Windows.Forms.Label();
            this.lb_user_surename = new System.Windows.Forms.Label();
            this.lb_user_name = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.bt_user_statistics = new System.Windows.Forms.Button();
            this.bt_cache_info = new System.Windows.Forms.Button();
            this.bt_user = new System.Windows.Forms.Button();
            this.userControlPanel.SuspendLayout();
            this.panel_user_stats.SuspendLayout();
            this.panel_cache_info.SuspendLayout();
            this.panel_user_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControlPanel
            // 
            this.userControlPanel.Controls.Add(this.panel_user_stats);
            this.userControlPanel.Controls.Add(this.panel_cache_info);
            this.userControlPanel.Controls.Add(this.panel_user_info);
            this.userControlPanel.Controls.Add(this.bt_submit);
            this.userControlPanel.Location = new System.Drawing.Point(1090, 12);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(288, 781);
            this.userControlPanel.TabIndex = 0;
            this.userControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlPanel_Paint);
            // 
            // panel_user_stats
            // 
            this.panel_user_stats.Controls.Add(this.lb_user_week_sequence);
            this.panel_user_stats.Controls.Add(this.lb_user_progress);
            this.panel_user_stats.Controls.Add(this.lb_user_cache_not_found);
            this.panel_user_stats.Controls.Add(this.lb_user_cache_found);
            this.panel_user_stats.Controls.Add(this.bt_user_statistics);
            this.panel_user_stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user_stats.Location = new System.Drawing.Point(0, 121);
            this.panel_user_stats.MaximumSize = new System.Drawing.Size(288, 300);
            this.panel_user_stats.MinimumSize = new System.Drawing.Size(288, 60);
            this.panel_user_stats.Name = "panel_user_stats";
            this.panel_user_stats.Size = new System.Drawing.Size(288, 60);
            this.panel_user_stats.TabIndex = 3;
            // 
            // lb_user_week_sequence
            // 
            this.lb_user_week_sequence.AutoSize = true;
            this.lb_user_week_sequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user_week_sequence.ForeColor = System.Drawing.Color.White;
            this.lb_user_week_sequence.Location = new System.Drawing.Point(23, 250);
            this.lb_user_week_sequence.Name = "lb_user_week_sequence";
            this.lb_user_week_sequence.Size = new System.Drawing.Size(0, 18);
            this.lb_user_week_sequence.TabIndex = 6;
            // 
            // lb_user_progress
            // 
            this.lb_user_progress.AutoSize = true;
            this.lb_user_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user_progress.ForeColor = System.Drawing.Color.White;
            this.lb_user_progress.Location = new System.Drawing.Point(23, 194);
            this.lb_user_progress.Name = "lb_user_progress";
            this.lb_user_progress.Size = new System.Drawing.Size(0, 18);
            this.lb_user_progress.TabIndex = 5;
            // 
            // lb_user_cache_not_found
            // 
            this.lb_user_cache_not_found.AutoSize = true;
            this.lb_user_cache_not_found.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user_cache_not_found.ForeColor = System.Drawing.Color.White;
            this.lb_user_cache_not_found.Location = new System.Drawing.Point(23, 135);
            this.lb_user_cache_not_found.Name = "lb_user_cache_not_found";
            this.lb_user_cache_not_found.Size = new System.Drawing.Size(0, 18);
            this.lb_user_cache_not_found.TabIndex = 4;
            // 
            // lb_user_cache_found
            // 
            this.lb_user_cache_found.AutoSize = true;
            this.lb_user_cache_found.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user_cache_found.ForeColor = System.Drawing.Color.White;
            this.lb_user_cache_found.Location = new System.Drawing.Point(23, 81);
            this.lb_user_cache_found.Name = "lb_user_cache_found";
            this.lb_user_cache_found.Size = new System.Drawing.Size(0, 18);
            this.lb_user_cache_found.TabIndex = 3;
            // 
            // panel_cache_info
            // 
            this.panel_cache_info.Controls.Add(this.lb_location_difficulty);
            this.panel_cache_info.Controls.Add(this.lb_cache_found);
            this.panel_cache_info.Controls.Add(this.lb_cache_difficulty);
            this.panel_cache_info.Controls.Add(this.lb_cache_description);
            this.panel_cache_info.Controls.Add(this.lb_cache_name);
            this.panel_cache_info.Controls.Add(this.bt_cache_info);
            this.panel_cache_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cache_info.Location = new System.Drawing.Point(0, 60);
            this.panel_cache_info.MaximumSize = new System.Drawing.Size(288, 279);
            this.panel_cache_info.MinimumSize = new System.Drawing.Size(288, 60);
            this.panel_cache_info.Name = "panel_cache_info";
            this.panel_cache_info.Size = new System.Drawing.Size(288, 61);
            this.panel_cache_info.TabIndex = 4;
            // 
            // lb_location_difficulty
            // 
            this.lb_location_difficulty.AutoSize = true;
            this.lb_location_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_location_difficulty.ForeColor = System.Drawing.Color.White;
            this.lb_location_difficulty.Location = new System.Drawing.Point(13, 237);
            this.lb_location_difficulty.Name = "lb_location_difficulty";
            this.lb_location_difficulty.Size = new System.Drawing.Size(0, 18);
            this.lb_location_difficulty.TabIndex = 6;
            // 
            // lb_cache_found
            // 
            this.lb_cache_found.AutoSize = true;
            this.lb_cache_found.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_cache_found.ForeColor = System.Drawing.Color.White;
            this.lb_cache_found.Location = new System.Drawing.Point(13, 194);
            this.lb_cache_found.Name = "lb_cache_found";
            this.lb_cache_found.Size = new System.Drawing.Size(0, 18);
            this.lb_cache_found.TabIndex = 5;
            // 
            // lb_cache_difficulty
            // 
            this.lb_cache_difficulty.AutoSize = true;
            this.lb_cache_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_cache_difficulty.ForeColor = System.Drawing.Color.White;
            this.lb_cache_difficulty.Location = new System.Drawing.Point(13, 153);
            this.lb_cache_difficulty.Name = "lb_cache_difficulty";
            this.lb_cache_difficulty.Size = new System.Drawing.Size(0, 18);
            this.lb_cache_difficulty.TabIndex = 4;
            // 
            // lb_cache_description
            // 
            this.lb_cache_description.AutoSize = true;
            this.lb_cache_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_cache_description.ForeColor = System.Drawing.Color.White;
            this.lb_cache_description.Location = new System.Drawing.Point(13, 113);
            this.lb_cache_description.Name = "lb_cache_description";
            this.lb_cache_description.Size = new System.Drawing.Size(0, 18);
            this.lb_cache_description.TabIndex = 3;
            // 
            // lb_cache_name
            // 
            this.lb_cache_name.AutoSize = true;
            this.lb_cache_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_cache_name.ForeColor = System.Drawing.Color.White;
            this.lb_cache_name.Location = new System.Drawing.Point(13, 70);
            this.lb_cache_name.Name = "lb_cache_name";
            this.lb_cache_name.Size = new System.Drawing.Size(0, 18);
            this.lb_cache_name.TabIndex = 2;
            // 
            // panel_user_info
            // 
            this.panel_user_info.Controls.Add(this.lb_user_advancement);
            this.panel_user_info.Controls.Add(this.lb_user_age);
            this.panel_user_info.Controls.Add(this.lb_user_surename);
            this.panel_user_info.Controls.Add(this.lb_user_name);
            this.panel_user_info.Controls.Add(this.bt_user);
            this.panel_user_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user_info.Location = new System.Drawing.Point(0, 0);
            this.panel_user_info.MaximumSize = new System.Drawing.Size(288, 200);
            this.panel_user_info.MinimumSize = new System.Drawing.Size(288, 60);
            this.panel_user_info.Name = "panel_user_info";
            this.panel_user_info.Size = new System.Drawing.Size(288, 60);
            this.panel_user_info.TabIndex = 2;
            // 
            // lb_user_advancement
            // 
            this.lb_user_advancement.AutoSize = true;
            this.lb_user_advancement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user_advancement.ForeColor = System.Drawing.Color.White;
            this.lb_user_advancement.Location = new System.Drawing.Point(19, 163);
            this.lb_user_advancement.Name = "lb_user_advancement";
            this.lb_user_advancement.Size = new System.Drawing.Size(0, 18);
            this.lb_user_advancement.TabIndex = 4;
            // 
            // lb_user_age
            // 
            this.lb_user_age.AutoSize = true;
            this.lb_user_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user_age.ForeColor = System.Drawing.Color.White;
            this.lb_user_age.Location = new System.Drawing.Point(19, 133);
            this.lb_user_age.Name = "lb_user_age";
            this.lb_user_age.Size = new System.Drawing.Size(0, 18);
            this.lb_user_age.TabIndex = 3;
            // 
            // lb_user_surename
            // 
            this.lb_user_surename.AutoSize = true;
            this.lb_user_surename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user_surename.ForeColor = System.Drawing.Color.White;
            this.lb_user_surename.Location = new System.Drawing.Point(19, 105);
            this.lb_user_surename.Name = "lb_user_surename";
            this.lb_user_surename.Size = new System.Drawing.Size(0, 18);
            this.lb_user_surename.TabIndex = 2;
            // 
            // lb_user_name
            // 
            this.lb_user_name.AutoSize = true;
            this.lb_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user_name.ForeColor = System.Drawing.Color.White;
            this.lb_user_name.Location = new System.Drawing.Point(19, 73);
            this.lb_user_name.Name = "lb_user_name";
            this.lb_user_name.Size = new System.Drawing.Size(0, 18);
            this.lb_user_name.TabIndex = 1;
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(0, 734);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(297, 44);
            this.bt_submit.TabIndex = 0;
            this.bt_submit.Text = "SUBMIT";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.Bt_submit_Click);
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(12, 10);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1072, 780);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.Map_Load);
            // 
            // bt_user_statistics
            // 
            this.bt_user_statistics.BackColor = System.Drawing.Color.White;
            this.bt_user_statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_user_statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_user_statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_user_statistics.ForeColor = System.Drawing.Color.Black;
            this.bt_user_statistics.Image = global::Keszobranie.Properties.Resources.icons8_expand_arrow_50;
            this.bt_user_statistics.Location = new System.Drawing.Point(0, 0);
            this.bt_user_statistics.Name = "bt_user_statistics";
            this.bt_user_statistics.Size = new System.Drawing.Size(288, 60);
            this.bt_user_statistics.TabIndex = 2;
            this.bt_user_statistics.Text = "USER STATISTICS";
            this.bt_user_statistics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_user_statistics.UseVisualStyleBackColor = false;
            this.bt_user_statistics.Click += new System.EventHandler(this.Bt_user_statistics_Click);
            // 
            // bt_cache_info
            // 
            this.bt_cache_info.BackColor = System.Drawing.Color.White;
            this.bt_cache_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_cache_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cache_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_cache_info.Image = global::Keszobranie.Properties.Resources.icons8_expand_arrow_50;
            this.bt_cache_info.Location = new System.Drawing.Point(0, 0);
            this.bt_cache_info.Name = "bt_cache_info";
            this.bt_cache_info.Size = new System.Drawing.Size(288, 58);
            this.bt_cache_info.TabIndex = 1;
            this.bt_cache_info.Text = "CACHE INFO";
            this.bt_cache_info.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_cache_info.UseVisualStyleBackColor = false;
            this.bt_cache_info.Click += new System.EventHandler(this.Bt_cache_info_Click_1);
            // 
            // bt_user
            // 
            this.bt_user.BackColor = System.Drawing.Color.White;
            this.bt_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_user.Image = global::Keszobranie.Properties.Resources.icons8_expand_arrow_50;
            this.bt_user.Location = new System.Drawing.Point(0, 0);
            this.bt_user.Name = "bt_user";
            this.bt_user.Size = new System.Drawing.Size(288, 58);
            this.bt_user.TabIndex = 0;
            this.bt_user.Text = "USER INFO";
            this.bt_user.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_user.UseVisualStyleBackColor = false;
            this.bt_user.Click += new System.EventHandler(this.Bt_user_Click);
            // 
            // bt_stats_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1390, 805);
            this.Controls.Add(this.map);
            this.Controls.Add(this.userControlPanel);
            this.Name = "bt_stats_info";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.userControlPanel.ResumeLayout(false);
            this.panel_user_stats.ResumeLayout(false);
            this.panel_user_stats.PerformLayout();
            this.panel_cache_info.ResumeLayout(false);
            this.panel_cache_info.PerformLayout();
            this.panel_user_info.ResumeLayout(false);
            this.panel_user_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userControlPanel;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Panel panel_user_info;
        private System.Windows.Forms.Button bt_user;
        private System.Windows.Forms.Label lb_user_advancement;
        private System.Windows.Forms.Label lb_user_age;
        private System.Windows.Forms.Label lb_user_surename;
        private System.Windows.Forms.Label lb_user_name;
        private System.Windows.Forms.Panel panel_user_stats;
        private System.Windows.Forms.Label lb_user_week_sequence;
        private System.Windows.Forms.Label lb_user_progress;
        private System.Windows.Forms.Label lb_user_cache_not_found;
        private System.Windows.Forms.Label lb_user_cache_found;
        private System.Windows.Forms.Button bt_user_statistics;
        private System.Windows.Forms.Panel panel_cache_info;
        private System.Windows.Forms.Label lb_location_difficulty;
        private System.Windows.Forms.Label lb_cache_found;
        private System.Windows.Forms.Label lb_cache_difficulty;
        private System.Windows.Forms.Label lb_cache_description;
        private System.Windows.Forms.Label lb_cache_name;
        private System.Windows.Forms.Button bt_cache_info;
    }
}