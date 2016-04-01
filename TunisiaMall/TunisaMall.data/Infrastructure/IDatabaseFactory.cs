using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisaMall.data.Models;

namespace  Data.Interfaces
{
    public interface IDatabaseFactory : IDisposable 
    {
        pidevtunisiamallContext DataContext { get; } 
    }
}
