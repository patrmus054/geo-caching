using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Models
{
    class Reputation
    {
       public Reputation()
        {
            location = new Location();
        }
        public int id { get; set; }
        public Kesz kesz { get; set; }
        public int keszId { get; set; }
        public User user { get; set; }
        public int userId { get; set; }
        public Location location { get; set; }
        public int locationId { get; set; }
        public string data { get; set; }
        public string opinion { get; set; }
    }
}
