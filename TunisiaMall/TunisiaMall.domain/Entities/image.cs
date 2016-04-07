using System;
using System.Collections.Generic;

namespace TunisaMall.domain.Entities
{
    public partial class image
    {
        public int idImage { get; set; }
        public string imagePath { get; set; }
        public Nullable<int> idProduct { get; set; }
        public virtual product product { get; set; }
    }
}
