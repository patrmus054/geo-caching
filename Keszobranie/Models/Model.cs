﻿using GMap.NET.WindowsForms;
using Keszobranie.DataBase;
using Keszobranie.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keszobranie.Models
{
    public class Model
    {
        public User auth(string email, string password)
        {
            //var dataAccess = DBConnection.getInstance();
            // dataAccess.ExecuteCommand(uint.Parse(DBResources.port), DBResources.server, DBResources.user, DBResources.password, DBResources.database);

            var user = DataBaseHelper.findUser(email, password);
            if (user is null)
            {
                MessageBox.Show("Invalid email or password");
            }
            //MessageBox.Show(user.email, user.password);
            return user;
        }

        public void register(string name, string surname, string email, string password, string password2)
        {
           if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(password2))
            {
                MessageBox.Show(" Please fill all the fields ! ");
            }
           if(password2 == password)
            {
                User user = new User();
                user.name = name;
                user.surname = surname;
                user.email = email;
                user.password = password;
                DataBaseHelper.newUser(user);
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

        public void newCache(double  latitude, double longituge)
        {
            var newCacheWindow = new NewCachePresenter(new form_new_cache(), this);
            newCacheWindow.showDialog();
            if(newCacheWindow.AllowNewCache)
            {
                if (String.IsNullOrEmpty(newCacheWindow.name) || String.IsNullOrEmpty(newCacheWindow.description) || String.IsNullOrEmpty(newCacheWindow.hint))
                {
                    MessageBox.Show(" Please fill all the fields ! ");
                }
                else
                {
                    var cache = new Kesz();
                    var location = new Location();
                    cache.name = newCacheWindow.name;
                    cache.description = newCacheWindow.description;
                    cache.hint = newCacheWindow.hint;
                    location.latitude = latitude;
                    location.longitude = longituge;
                    cache.location = location;
                    DataBaseHelper.newCache(cache);
                }
            }
        }

        internal void loadUserCaches(User user, GMapControl map)
        {
            if (user != null)
            {
                var userCaches = DataBaseHelper.userCaches(user.id);
                foreach (var cacheId in userCaches)
                {
                    var cache = DataBaseHelper.getCache(cacheId);
                    Map.addMarkerToMap(Map.overlay, map, Map.newMarker(cache.location.latitude, cache.location.longitude, PinColor.YELLOW));
                }
            }
        }

        internal void addCachesToUserAccount(User user, List<Kesz> caches)
        {
            if(user != null && caches != null) { 
                foreach(Kesz cache in caches)
                {
                    DataBaseHelper.newCache(user.id, cache.Id);
                }
                    MessageBox.Show($"{caches.Count} Caches added");
            }
        }

        internal Kesz cacheClicked(double lat, double lng, GMapControl map)
        {
            Map.addMarkerToMap(Map.overlay, map, Map.newMarker(lat, lng, PinColor.RED));

            return DataBaseHelper.findCacheByLocation(lat, lng);
        }

        public void loadCaches(GMapControl map)
        {
            List<GMapMarker> markers = new List<GMapMarker>();
            var caches = DataBaseHelper.getCaches();
            foreach (var cache in caches)
            {
                var location = DataBaseHelper.cacheLocation(cache.locationId);
                markers.Add(Map.newMarker(location.latitude, location.longitude, PinColor.BLUE));
            }

            Map.addMarkersToMap(Map.overlay,map, markers);
        }
        //public Map loadMap()
        //{
        //    //Map map = Map.getInstance();
        //    //map.loadMap(view.Map);
        //    //return map.getMap();
        //}

    }
}
