using Keszobranie.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.DataBase
{
    class DataBaseHelper
    {
        private static GeoCacheContext _context = new GeoCacheContext();
        
        public static User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public static List<int> userCaches (int UserId)
        {
            var caches = _context.Founds.Where(c => c.userId == UserId);
            List<int> cachesId = new List<int>();
            foreach(var cache in caches)
            {
                cachesId.Add(cache.keszId);
            }
            return cachesId;
        }

        public static void updateUserData(int userId, string name, string surname, string email, string password)
        {
            var user = GetUserById(userId);
            if(!String.IsNullOrEmpty(name)) user.name = name;
            if (!String.IsNullOrEmpty(surname)) user.surname = surname;
            if (!String.IsNullOrEmpty(email)) user.email = email;
            if (!String.IsNullOrEmpty(password)) user.password = password;
            _context.SaveChanges();

        }
        public static void newCache(int userId, int cacheId)
        {
            var found = new Found();
            found.userId = userId;
            found.keszId = cacheId;
            _context.Founds.Add(found);
            _context.SaveChanges(); ;
        }

        public static List<User> getUsers()
        {
            return _context.Users.ToList();
        }
        public static List<Kesz> getCaches()
        {
            return _context.Caches.ToList();
        }
        public static void newUser(User user)
        {
            user.regDate = DateTime.Now.ToString();
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public static void newCache(Kesz cache)
        {
            _context.Caches.Add(cache);
            _context.SaveChanges();
        }

        public static User findUser(string email, string password)
        {
            List<User> users = getUsers();

            foreach( var user in users)
            {
                if (user.email == email && user.password == password)
                    return user;

            }
            return null;
        }
        public static Location cacheLocation(int cacheId)
        {
            var location = _context.Locations.Find(cacheId);
            return location;
        }
        public static Kesz getCache(int cacheId)
        {
            return _context.Caches.FirstOrDefault(c => c.Id == cacheId);
        }
        public static int userCachesFound(int userId)
        {
            int i = 0;
            var caches = _context.Founds.Where(c => c.userId == userId);
            foreach(var cache in caches)
            {
                i++;
            }
            return i;
        }

        public static int allCachesCount()
        {
            int i = 0;
            var caches = getCaches();
            foreach (var cache in caches)
            {
                i++;
            }
            return i;
        }

        public static Kesz findCacheByLocation(double latitude, double longitude)
        {
            var location = _context.Locations.FirstOrDefault((c) => c.latitude == latitude && c.longitude == longitude);
            return _context.Caches.Find(location.id);
        }
    }
}
