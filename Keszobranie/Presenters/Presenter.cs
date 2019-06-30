using GMap.NET.WindowsForms.Markers;
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
        List<Kesz> caches = new List<Kesz>();
        User user;
        public Presenter(Model model, IView view)
        {
            
            this.model = model;
            this.view = view;
            view.loadMaps += laodMaps;
            view.LoadLoginWindow += loadLoginWindow;
            view.addNewCache += newCache;
            view.loadAllCaches += loadAllCaches;
            view.updateCacheInfo += updateCacheInfo;
            view.updateCacheInfo += onCacheClick;
            view.addFoundCaches += addUserCaches;
            view.logOut += logOut;
            view.removeClickedCaches += removeClickedCaches;
            view.updateUser += updateUser;
        }
        public void updateUser()
        {
            if(user != null)
            {
                var updateForm = new UpdateUserDataPresenter(new form_update_user_data(), model);
                updateForm.user = user;
                updateForm.showDialog();
            }
            
            
        }
        private void removeClickedCaches()
        {
            caches = new List<Kesz>();
            loadAllCaches();
            model.loadUserCaches(user, view.Map);
            view.cachceHint = "";
            view.cacheDescription = "";
            view.cacheName = "";
        }

        private void loadLoginWindow()
        {
            loginPresenter = new LoginPresenter(new form_login(), model);
            loginPresenter.showDialog();
            //if (loginPresenter.AllowLogin)
            //{
            user = loginPresenter.user;
            if(user != null)
            {
                view.LogINOUT = Resources.icons8_logout_rounded_left_50;
                view.logedIn = true;

                view.userName = user.name;
                view.userSurname = user.surname;
                view.userCachesFound = DataBaseHelper.userCachesFound(user.id).ToString();
                view.userCachesNotFound = (DataBaseHelper.allCachesCount() - DataBaseHelper.userCachesFound(user.id)).ToString();
                model.loadUserCaches(user, view.Map);
            }
            
            //}
            //loginPresenter.AllowLogin = true;
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
            if(user != null)
            {
                model.loadUserCaches(user, view.Map);
            }   
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

        public void onCacheClick()
        {
            caches.Add(model.cacheClicked(view.marker.Position.Lat, view.marker.Position.Lng, view.Map));
        }
        public void addUserCaches()
        {
            model.addCachesToUserAccount(user, caches);
        }
        public void logOut()
        {
            user = null;
            model.loadCaches(view.Map);
            view.LogINOUT = Resources.icons8_login_64;
            view.logedIn = false;
            user = null;
            view.userName = "";
            view.userSurname = "";
            view.userCachesFound = "";
            view.userCachesNotFound = "";

        }
    }
}
