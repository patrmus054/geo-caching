using Keszobranie.Views;
using System;
using System.Windows.Forms;

namespace Keszobranie
{
    public partial class form_update_user_data : Form, IUpdateUserDataView
    {
        public form_update_user_data()
        {
            InitializeComponent();
        }

        public string UserName => tb_name.Text;

        public string Surname => tb_surname.Text;

        public string Email => tb_email.Text;

        public string Password => tb_password.Text;

        public string Password2 => tb_password_repeat.Text;

        public event Action Update;


        private void Bt_submit_Click(object sender, EventArgs e)
        {
            Update?.Invoke();
        }
    }
}
