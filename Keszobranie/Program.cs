using Keszobranie.Models;
using Keszobranie.Presenters;
using Keszobranie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keszobranie
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            IView view = new Form1();
            Presenter presenter = new Presenter(model, view);
            Application.Run((Form)view);
        }
    }
}
