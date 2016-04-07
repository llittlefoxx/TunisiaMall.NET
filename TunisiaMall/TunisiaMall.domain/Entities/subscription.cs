using System;
using System.Collections.Generic;

namespace TunisaMall.domain.Entities
{
    public partial class subscription
    {
        public int idEvent { get; set; }
        public int idSubscription { get; set; }
        public int idUser { get; set; }
        public virtual @events @events { get; set; }
        public virtual user user { get; set; }
    }
}
