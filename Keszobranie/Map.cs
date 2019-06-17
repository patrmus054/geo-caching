using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keszobranie
{
    public class Map
    {
        private static Map INSTANCE = null;
        private GMapControl map = null;
        private double latitude;
        private double longitude;
        private Map() {}

        public static Map getInstance()
        {
            if (INSTANCE is null)
            {
                INSTANCE = new Map();
            }
            return INSTANCE;
        }

        public void loadMap(GMapControl map)
        {
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            map.DragButton = MouseButtons.Left;
            GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            map.Position = new PointLatLng(50.287195, 18.677615);
            map.Zoom = 20;

            
            this.map = map;
        }
        public GMapControl getMap()
        {
            return map;
        }

    }
}
