using GMap.NET.WindowsForms;
using Keszobranie.DataBase;
using Keszobranie.Properties;
using Keszobranie.Views;
using System;
using System.Windows.Forms;

namespace Keszobranie
{
    public partial class bt_stats_info : Form, IView
    {

        private Boolean panelUserInfoIsCallapsed = true;
        private Boolean panelCacheInfoIsCallapsed = true;
        private Boolean panelUserStatisticsIsCallapsed = true;
        public bt_stats_info()
        {
            InitializeComponent();
        }

        public GMapControl Map
        {
            get => map;
            set
            {
                map = value;
            }
        }

        public event Action loadMaps;

        private void Map_Load(object sender, EventArgs e)
        {
            loadMaps?.Invoke();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UserControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_submit_Click(object sender, EventArgs e)
        {
            
        }

        private void Bt_cache_info_Click(object sender, EventArgs e)
        {

        }

        private void Bt_user_Click(object sender, EventArgs e)
        {
            if (panelUserInfoIsCallapsed)
            {
                expandPanel(panel_user_info);
                panelUserInfoIsCallapsed = false;
                bt_user.Image = Resources.icons8_collapse_arrow_50;
            }
            else
            {
                callapsePanel(panel_user_info);
                panelUserInfoIsCallapsed = true;
                bt_user.Image = Resources.icons8_expand_arrow_50;
            }
        }

        private void Bt_cache_info_Click_1(object sender, EventArgs e)
        {
            if (panelCacheInfoIsCallapsed)
            {
                expandPanel(panel_cache_info);
                panelCacheInfoIsCallapsed = false;
                bt_cache_info.Image = Resources.icons8_collapse_arrow_50;
            }
            else
            {
                callapsePanel(panel_cache_info);
                panelCacheInfoIsCallapsed = true;
                bt_cache_info.Image = Resources.icons8_expand_arrow_50;
            }
        }


        private void Bt_user_statistics_Click(object sender, EventArgs e)
        {
            if (panelUserStatisticsIsCallapsed)
            {
                expandPanel(panel_user_stats);
                panelUserStatisticsIsCallapsed = false;
                bt_user_statistics.Image = Resources.icons8_collapse_arrow_50;
            }
            else
            {
                callapsePanel(panel_cache_info);
                panelUserStatisticsIsCallapsed = true;
                bt_user_statistics.Image = Resources.icons8_expand_arrow_50;
            }
        }

            private void expandPanel(Panel panel)
        {
            while (panel.Size != panel.MaximumSize)
            {
                panel.Height += 1;
            }

        }
        private void callapsePanel(Panel panel)
        {
            while (panel.Size != panel.MinimumSize)
            {
                panel.Height -= 1;
            }
        }

    }
}
