using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Views
{
    public interface IView
    {
        GMapControl Map { get; set; }
        event Action loadMaps;
    }
}
