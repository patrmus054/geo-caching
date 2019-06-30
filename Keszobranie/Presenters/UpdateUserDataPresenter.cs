using Keszobranie.DataBase;
using Keszobranie.Models;
using Keszobranie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keszobranie.Presenters
{
    public class UpdateUserDataPresenter
    {
        IUpdateUserDataView view;
        Model model;
        public User user;

        public UpdateUserDataPresenter(IUpdateUserDataView view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.Update += updateUserData;
        }



        public void updateUserData()
        {
            if (view.Password == view.Password2)
            {
                DataBaseHelper.updateUserData(user.id, view.UserName, view.Surname, view.Email, view.Password);
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
            hideDialog();
        }
        public void showDialog()
        {
            ((form_update_user_data)view).Show();
        }
        public void hideDialog()
        {
            ((form_update_user_data )view).Hide();
        }
    }
}
