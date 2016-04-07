using System;
using System.Collections.Generic;

namespace TunisaMall.domain.Entities
{
    public partial class events
    {
        public @events()
        {
            this.subscriptions = new List<subscription>();
            this.stores = new List<store>();
        }

        public int idEvent { get; set; }
        public Nullable<System.DateTime> dateEvent { get; set; }
        public string description { get; set; }
        public int periodEvent { get; set; }
        public string titleEvent { get; set; }
        public string typeEvent { get; set; }
        public virtual ICollection<subscription> subscriptions { get; set; }
        public virtual ICollection<store> stores { get; set; }
    }
}
