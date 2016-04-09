using Data.Infrastructure;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisaMall.data.Models;
using System.Linq.Expressions;
using TunisiaMall.domain.Entities;
using TunisaMall.data.Repositories;

namespace TunisiaMall.service.services
{
    public class ProductService : IProductService
    {
      static public  DatabaseFactory dbFactory = new DatabaseFactory();
        UnitOfWork utk = new UnitOfWork(dbFactory);
        ProductRepository pr = new ProductRepository(dbFactory);
        public void add()
        {
            pr.test();
        }

        public IEnumerable<product> getAll()
        {
            return utk.ProductRepository.GetAll();
        }

    }
    public interface IProductService
    {
         void add();
        IEnumerable<product> getAll();

    }
}
