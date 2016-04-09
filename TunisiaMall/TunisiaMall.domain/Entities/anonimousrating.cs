using System;
using System.Collections.Generic;

namespace TunisiaMall.domain.Entities
{
    public partial class anonimousrating
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public int idProd { get; set; }
        public int rate { get; set; }
    }
}
