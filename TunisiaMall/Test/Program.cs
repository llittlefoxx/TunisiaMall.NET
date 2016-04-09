using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.domain.Entities;
using TunisiaMall.service.services;

namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            user x = new user { idUser = 1 };
            PointsService ps = new PointsService();
            ps.addPointsToUser(x,10);
        }
    }
}
