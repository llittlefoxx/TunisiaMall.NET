 

using  Data.Infrastructure;
using  Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisaMall.data.Models;

namespace  Data.Repositories
{
    public class PromotionRepository : RepositoryBase<promotion>, IPromotionRepository
    {
        public PromotionRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IPromotionRepository : IRepository<promotion>
    {

    }
}
