

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
    public class CategoryRepository : RepositoryBase<category>, ICategoryRepository
    {
        public CategoryRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface ICategoryRepository : IRepository<category>
    {

    }
}
