using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisaMall.data.Repositories;

namespace  Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();


        ICategoryRepository CategoryRepository { get; }

        IPromotionRepository PromotionRepository { get; }

        IPointsRepepository PointsRepository { get; }
        IOrderRepository OrderRepository { get; }

        IOrderLineRepository OrderLineRepository { get; }
    }
}
