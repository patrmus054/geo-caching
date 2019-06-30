using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Keszobranie.Models;
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
        private  GMapControl map = null;
        public static GMapOverlay overlay;
        


        private Map() {
            overlay = new GMap.NET.WindowsForms.GMapOverlay("markers");
        }

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

            GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            map.ShowCenter = false;
            map.MinZoom = 4;                                                                           
            map.MaxZoom = 20;
            map.Zoom = 1;
            map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;               
            map.CanDragMap = true;                                                                      
            map.DragButton = MouseButtons.Left;
            map.Position = new PointLatLng(50.287195, 18.677615);
            //map.Zoom = 20;

            this.map = map;
        }
        public GMapControl getMap()
        {
            return map;
        }

        public static GMapMarker newMarker(double latitude, double longitude, PinColor color)
        {
            PointLatLng point = new PointLatLng(latitude, longitude);
            switch (color)
            {
                case PinColor.BLUE:
                    return new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
                case PinColor.RED:
                    return new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                case PinColor.YELLOW:
                    return new GMarkerGoogle(point, GMarkerGoogleType.yellow_dot);
                default:
                    return new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            }
        }

        //public static void addMarkersToMap(GMapControl map, List<GMapMarker> markers)
        //{
            
        //    GMapOverlay mapOverlay = new GMapOverlay("markers");
        //    foreach(var marker in markers)
        //    { 
        //        mapOverlay.Markers.Add(marker);
        //    }
        //    map.Overlays.Add(mapOverlay);
        //    map.Refresh();
        //}
        public static void addMarkersToMap(GMapOverlay gMapOverlay, GMapControl map, List<GMapMarker> markers )
        {
            if(gMapOverlay != null) {
                gMapOverlay.Markers.Clear();
            }

            foreach (var marker in markers)
            {
                marker.IsVisible = true;
                gMapOverlay.Markers.Add(marker);
            }

            //   Clear old overlay
            map.Overlays.Clear();
            map.Overlays.Add(gMapOverlay);

            //   Zoom the map to show all drawn markers
            map.ZoomAndCenterMarkers(gMapOverlay.Id);
            map.Refresh();
        }

        public static void addMarkerToMap(GMapOverlay gMapOverlay, GMapControl map, GMapMarker marker)
        {
            marker.IsVisible = true;
            gMapOverlay.Markers.Add(marker);
            map.ZoomAndCenterMarkers(gMapOverlay.Id);
            map.Refresh();
        }
    }
}
