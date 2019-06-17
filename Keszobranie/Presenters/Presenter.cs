using Keszobranie.Models;
using Keszobranie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Presenters
{
    public class Presenter
    {
        IView view;
        Model model;

        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            view.loadMaps += laodMaps;
        }

        public void laodMaps()
        {
            Map map = Map.getInstance();
            map.loadMap(view.Map);
            view.Map = map.getMap();
        }
    }
}
