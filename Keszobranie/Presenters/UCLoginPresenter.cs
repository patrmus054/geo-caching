using Keszobranie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keszobranie.Views;
namespace Keszobranie.Presenters
{
    class UCLoginPresenter
    {
        ILoginView view;
        Model model;

        public UCLoginPresenter(Model model, ILoginView view)
        {
            this.model = model;
            this.view = view;
            this.view.authorize += authorize;
        }

        void authorize()
        {

        }
    }
}
