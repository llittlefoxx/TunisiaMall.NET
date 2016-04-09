using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.domain.Entities;

namespace TunisiaMall.service.services
{
    public class PointsService : IPonitsService
    {
        static public DatabaseFactory dbFactory = new DatabaseFactory();
        UnitOfWork utwk = new UnitOfWork(dbFactory);
        public void addPointsToUser(user u, int points)
        {
            user x = new user();
            x=utwk.PointstRepository.GetById(u.idUser);
            System.Diagnostics.Debug.WriteLine("user "+x.login);


        }

        public void removePointsFromUser(user u, int points)
        {
            throw new NotImplementedException();
        }
    }
    public interface IPonitsService
    {
        void addPointsToUser(user u, int points);
        void removePointsFromUser(user u, int points);
    }
}
