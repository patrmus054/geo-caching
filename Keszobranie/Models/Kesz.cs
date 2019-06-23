using Keszobranie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie
{
    class Kesz
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string hint { get; set; }

        public Location location { get; set; }
        public int locationId { get; set; }

    }
}
