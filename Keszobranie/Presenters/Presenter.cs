using Keszobranie.DataBase;
using Keszobranie.Models;
using Keszobranie.Properties;
using Keszobranie.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Presenters
{
    public class Presenter
    {
        IView view;
        Model model;
        LoginPresenter loginPresenter;
        public Presenter(Model model, IView view)
        {
            
            this.model = model;
            this.view = view;
            view.loadMaps += laodMaps;
            view.LoadLoginWindow += loadLoginWindow;
            view.addNewCache += newCache;
            view.loadAllCaches += loadAllCaches;
            view.updateCacheInfo += updateCacheInfo;
        }
        private void loadLoginWindow()
        {
            loginPresenter = new LoginPresenter(new form_login(), model);
            loginPresenter.showDialog();
            view.LogINOUT = Resources.icons8_logout_rounded_left_50;
            var user = loginPresenter.user;
            view.userName = user.name;
            view.userSurname = user.surname;
            view.userCachesFound = DataBaseHelper.userCachesFound(user.id).ToString();
            view.userCachesNotFound = (DataBaseHelper.allCachesCount() - DataBaseHelper.userCachesFound(user.id)).ToString();

        }

        public void laodMaps()
        {
            Map map = Map.getInstance();
            map.loadMap(view.Map);
            view.Map = map.getMap();

        }

        public void newCache()
        {
            model.newCache(view.X, view.Y);
            view.ImageNewCacheColor = Color.Yellow;
            view.newCache = false;
            loadAllCaches();
        }

        public void loadAllCaches()
        {
            model.loadCaches(view.Map);
        }
        public void updateCacheInfo()
        {
            var marker = view.marker;
            var cache = DataBaseHelper.findCacheByLocation(marker.Position.Lat, marker.Position.Lng);
            view.cacheName = cache.name;
            view.cacheDescription = cache.description;
            view.cachceHint = cache.hint;
        }
    }
}
