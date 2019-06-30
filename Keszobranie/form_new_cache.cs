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
    public partial class form_new_cache : Form, INewCacheView
    {
        public form_new_cache()
        {
            InitializeComponent();
        }

        public string name => tb_name.Text;

        public string description => tb_description.Text;

        public string hint => tb_hint.Text;

        public event Action addNewCache;
        public event Action onExit;

        private void Bt_submit_Click(object sender, EventArgs e)
        {
            addNewCache?.Invoke();
        }

        private void Form_new_cache_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form_new_cache_FormClosed(object sender, FormClosedEventArgs e)
        {
            onExit?.Invoke();

        }
    }
}
