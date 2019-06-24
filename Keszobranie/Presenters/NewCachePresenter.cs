using Keszobranie.Models;
using Keszobranie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Presenters
{
    class NewCachePresenter
    {
        INewCacheView view;
        Model model;
        public string name, description, hint;
        public NewCachePresenter(INewCacheView view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.addNewCache += newCache;
        }
        public void showDialog()
        {
            ((form_new_cache)view).ShowDialog();
        }
        public void hideDialog()
        {
            ((form_new_cache)view).Hide();
        }
        public void newCache()
        {
            this.name = view.name;
            this.description = view.description;
            this.hint = view.hint;
            hideDialog();
        }
    }
}
