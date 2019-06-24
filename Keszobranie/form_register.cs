using Keszobranie.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keszobranie
{
    public partial class form_register : Form, IRegisterView
    {
        public form_register()
        {
            InitializeComponent();
        }
        public string UserName => tb_name.Text;
        public string Surname => tb_surname.Text;

        public string Email => tb_email.Text;

        public string Password => tb_password.Text;

        public string Password2 => tb_password_repeat.Text;

        public event Action SuccesfulRegistration;
        public event Action TerminateDialog;

        private void Bt_submit_Click(object sender, EventArgs e)
        {
            SuccesfulRegistration?.Invoke();
        }

        private void Lb_back_to_login_Click(object sender, EventArgs e)
        {
            TerminateDialog?.Invoke();
        }
    }
}
