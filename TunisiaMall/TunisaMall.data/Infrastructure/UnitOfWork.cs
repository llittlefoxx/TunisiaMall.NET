using Data;
using Data.Interfaces;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisaMall.data.Models;

namespace  Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private pidevtunisiamallContext dataContext;
        protected pidevtunisiamallContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }


        private IPromotionRepository promotionRepository;
     
        public IPromotionRepository PromotionRepository
        {
            get { return promotionRepository = new PromotionRepository(dbFactory); }
        }

        private ICategoryRepository categoryRepository;
        public ICategoryRepository CategoryRepository
        {
            get { return categoryRepository = new CategoryRepository(dbFactory); ; }
        }

         

        
        public void Dispose()
        {
            DataContext.Dispose();
        }
        
    }
}
