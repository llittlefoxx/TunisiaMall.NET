using Data.Infrastructure;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.domain.Entities;

namespace TunisaMall.data.Repositories
{
    public class OrderLineRepository: RepositoryBase<orderline>,IOrderLineRepository
    {
        public OrderLineRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IOrderLineRepository : IRepository<orderline>
    {

    }
}
