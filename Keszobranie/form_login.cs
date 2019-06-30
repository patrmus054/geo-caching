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
    public partial class form_login : Form, ILoginView
    {
        public form_login()
        {
            InitializeComponent();
        }

        public string Email => tb_email.Text;
        public string password => tb_password.Text;

        public event Action authorize;
        public event Action registerNewAccount;
        public event Action onExit;

        private void Bt_login_Click(object sender, EventArgs e)
        {
            authorize?.Invoke();
        }

        private void Lb_register_Click(object sender, EventArgs e)
        {
            registerNewAccount?.Invoke();
        }

        private void Lb_text_Click(object sender, EventArgs e)
        {

        }

        private void Lb_login_Click(object sender, EventArgs e)
        {

        }

        private void Tb_login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_login_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void Form_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            onExit?.Invoke();
        }
    }
}
