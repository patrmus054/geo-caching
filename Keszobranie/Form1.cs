using GMap.NET;
using GMap.NET.WindowsForms;
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
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public GMapControl Map
        {
            get => map;
            set
            {
                map = value;
            }
        }

        public event Action loadMaps;

        private void Map_Load(object sender, EventArgs e)
        {
            loadMaps?.Invoke();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
