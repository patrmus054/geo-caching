using Keszobranie.Models;
using Keszobranie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Presenters
{
    class RegisterPresenter
    {
        IRegisterView view;
        Model model;

        public RegisterPresenter(IRegisterView view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.SuccesfulRegistration += performRegistration;
            this.view.TerminateDialog += hideDialog;
        }

        void performRegistration()
        {
            model.register(view.UserName, view.Surname, view.Email, view.Password, view.Password2);
            hideDialog();
        }
        public void showDialog()
        {
            ((form_register)view).ShowDialog();
        }
        public void hideDialog()
        {
            ((form_register)view).Hide();
        }
        
    }
}
