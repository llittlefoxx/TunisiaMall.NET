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
        public void addPointsToCustomer(customer u, int points)
        {
            u = utwk.PointsRepository.GetById(u.idUser);
            u.points = u.points + points;
            utwk.PointsRepository.Update(u);
            utwk.Commit();
        }

        public void convertPoints(customer u, int points)
        {
            throw new NotImplementedException();
        }

        //getBestClient method takes the number of best clients you want to get
        //the clients are OrderByDescending by points number 
        public Dictionary<customer, int> getBestClient(int number)
        {
            Dictionary<customer, int> CustomerDic = new Dictionary<customer, int>();
            IEnumerable<customer> customers = utwk.PointsRepository.GetAll().OrderByDescending(c => c.points).Take(number);
            foreach (var c in customers)
            {
                CustomerDic.Add(c, c.points);
            }

            return CustomerDic;
        }

        //this method removes Points From Customer
        public void removePointsFromCustomer(customer u, int points)
        {
            u = utwk.PointsRepository.GetById(u.idUser);

            if (u.points > 0 && u.points > points)
            {
                // System.Diagnostics.Debug.WriteLine("points before---- + " + u.points);
                u.points = u.points - points;
                utwk.PointsRepository.Update(u);
                utwk.Commit();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("points insuffisant");
            }

        }

        public void showAffordableGifts(customer u)
        {
            throw new NotImplementedException();
        }
    }
    public interface IPonitsService
    {
        void addPointsToCustomer(customer u, int points);
        void removePointsFromCustomer(customer u, int points);
        void showAffordableGifts(customer u);
        // Normally :  void convertPointsToGift(customer u, gift g);
        void convertPoints(customer u, int points);
        Dictionary<customer, int> getBestClient(int number);

    }
}
