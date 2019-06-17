using Keszobranie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keszobranie.Views;
namespace Keszobranie.Presenters
{
    class UserControlPresenter
    {
        IUserControlPanelView view;
        Model model;

        public UserControlPresenter(Model model, IUserControlPanelView view)
        {
            this.model = model;
            this.view = view;
        }
    }
}
