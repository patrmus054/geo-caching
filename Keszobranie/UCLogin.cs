using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keszobranie.Views;

namespace Keszobranie
{
    public partial class UCLogin : UserControl, ILoginView
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        public string login => tb_login_login.Text;

        public string password => tb_login_password.Text;

        public event Action authorize;

        private void btLogin_Click(object sender, EventArgs e)
        {
            authorize?.Invoke();
        }
    }
}
