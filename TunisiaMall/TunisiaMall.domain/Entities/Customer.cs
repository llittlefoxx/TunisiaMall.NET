using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunisaMall.data.Models
{
   public class Customer :user
    {
        public string facturationAddr { get; set; }
        public string shipementAddr { get; set; }
    }
}
