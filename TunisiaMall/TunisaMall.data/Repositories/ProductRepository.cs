using Data.Infrastructure;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisaMall.data.Models;
using TunisaMall.domain.Entities;

namespace TunisaMall.data.Repositories
{
    public class ProductRepository : RepositoryBase<product>, IProductRepository
    {
        public ProductRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IProductRepository: IRepository<product>
    {

    }
}
