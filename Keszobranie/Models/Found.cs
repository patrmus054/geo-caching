using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Models
{
    class Found
    {
        public int id { get; set; }
        
        public Kesz kesz { get; set; }
        public int keszId { get; set; }
        public User user { get; set; }

        public int userId { get; set; }

    }
}
