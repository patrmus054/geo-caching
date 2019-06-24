using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Views
{
    public interface IView
    {
        void DissableAll();
        Color ImageNewCacheColor { set; }
        GMapControl Map { get; set; }
        GMapMarker marker { get; set; }
        Boolean newCache { set; }
        Image LogINOUT { set; }
        string userName { get; set; }
        string userSurname { get; set; }
        string userCachesFound { set; get; }
        string userCachesNotFound { set; get; }
        string cacheName { get; set; }
        string cacheDescription { get; set; }
        string cachceHint { get; set; }
        double X { get; }
        double Y { get; }
        event Action loadMaps;
        event Action LoadLoginWindow;
        event Action addNewCache;
        event Action loadAllCaches;
        event Action updateCacheInfo;
    }
}
