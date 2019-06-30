using GMap.NET.WindowsForms;
using Keszobranie.DataBase;
using Keszobranie.Properties;
using Keszobranie.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Keszobranie
{
    public partial class bt_stats_info : Form, IView
    {

        private Boolean panelUserInfoIsCallapsed = true;
        private Boolean panelCacheInfoIsCallapsed = true;
        private Boolean panelUserStatisticsIsCallapsed = true;
        public Boolean newCache = false;
        private GMapMarker marker;
        private Boolean LogedIn = false;

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

        bool IView.newCache { set => this.newCache = value; }
        public Color ImageNewCacheColor { set => this.img_newCache.BackColor = value; }

        public double X { get;  set; }

        public double Y { get;  set; }
        public Image LogINOUT { set => img_login.Image = value; }
        GMapMarker IView.marker { get => marker; set => this.marker = value; }

        public string userName { get => lb_user_name.Text; set => lb_user_name.Text = value; }
        public string userSurname { get => lb_user_surename.Text; set => lb_user_surename.Text = value; }
        public string userCachesFound { get =>lb_user_cache_found.Text; set => lb_user_cache_found.Text = value; }
        public string userCachesNotFound { get => lb_user_cache_not_found.Text; set => lb_user_cache_not_found.Text = value; }
        public string cacheName { get => lb_cache_name.Text; set => lb_cache_name.Text = value; }
        public string cacheDescription { get => lb_cache_description.Text; set => lb_cache_description.Text = value; }
        public string cachceHint { get => lb_cache_difficulty.Text; set => lb_cache_difficulty.Text = value; }
        public bool logedIn { get => LogedIn; set => LogedIn = value; }

        public event Action loadMaps;
        public event Action LoadLoginWindow;
        public event Action addNewCache;
        public event Action loadAllCaches;
        public event Action updateCacheInfo;
        public event Action addFoundCaches;
        public event Action logOut;
        public event Action removeClickedCaches;
        public event Action updateUser;

        private void Map_Load(object sender, EventArgs e)
        {
            loadMaps?.Invoke();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadAllCaches?.Invoke();
        }

        private void UserControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_submit_Click(object sender, EventArgs e)
        {
            //DataBaseCRUD.insertUser();
        }

        private void Bt_cache_info_Click(object sender, EventArgs e)
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

        private void Img_login_Click(object sender, EventArgs e)
        {
            if (!LogedIn)
            {
                LoadLoginWindow?.Invoke();
            }
            else
            {
                LogedIn = false;
                logOut?.Invoke();
            }
        }

        private void Img_newCache_Click(object sender, EventArgs e)
        {
            newCache = true;
            ImageNewCacheColor = Color.Red;
        }


        public void DissableAll()
        {
            throw new NotImplementedException();
        }

        private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var pt = map.FromLocalToLatLng(e.X, e.Y);

            map.Position = pt;

            if(e.Button.Equals(MouseButtons.Left))
            {
                map.Zoom += 1;
            }
            else if(e.Button.Equals(MouseButtons.Right))
        {
                map.Zoom -= 1;
            }
        }

        public void Map_MouseClick_1(object sender, MouseEventArgs e)
        {
            if(newCache)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                this.X = point.Lat;
                this.Y = point.Lng;
                addNewCache?.Invoke();
            }
        }

        private void Map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            this.marker = item;
            updateCacheInfo?.Invoke();
        }

        private void Bt_add_user_cache_Click(object sender, EventArgs e)
        {
            addFoundCaches?.Invoke();
        }

        private void Img_bin_Click(object sender, EventArgs e)
        {
            removeClickedCaches?.Invoke();
        }

        private void Img_settings_Click(object sender, EventArgs e)
        {
            updateUser?.Invoke();
        }
    }
}
