using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.domain.Entities;

namespace TunisiaMall.domain.Entities
{
   public class shopOwner:user
    {
        public Nullable<System.DateTime> dateActivation { get; set; }
    }
}
