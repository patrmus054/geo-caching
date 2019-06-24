using Keszobranie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keszobranie.Views;
using Keszobranie.DataBase;
using System.Windows.Forms;

namespace Keszobranie.Presenters
{
    class LoginPresenter
    {
        ILoginView view;
        Model model;
        public User user { get; set; }

        public LoginPresenter(ILoginView view, Model model )
        {
            this.model = model;
            this.view = view;
            this.view.authorize += authorize;
            this.view.registerNewAccount += newAccount;
        }

        void newAccount()
        {
            var registerWindow = new RegisterPresenter(new form_register(), model);
            registerWindow.showDialog();
        }
        void authorize()
        {
            this.user = model.auth(view.Email, view.password);
            hideDialog();
                
        }

        public void showDialog()
        {
            ((form_login)view).ShowDialog();
            
        }
        public void hideDialog()
        {
            ((form_login)view).Hide();
        }
    }
}
