using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisaMall.data.Models;
using TunisaMall.domain.Entities;

namespace TunisiaMall.service.services
{
    public class PromotionService: IPromotionService
    {
        static public DatabaseFactory dbFactory = new DatabaseFactory();
        UnitOfWork utwk = new UnitOfWork(dbFactory);

        public List<promotion> GetAllPromo()
        {
            return utwk.PromotionRepository.GetAll().ToList();
        }

       public void AddPromotion(promotion promo)
        {
            utwk.PromotionRepository.Add(promo);
            utwk.Commit();
        }

    }
    public interface IPromotionService
    {
         void AddPromotion (promotion promo);
        List<promotion> GetAllPromo();
    }
}
