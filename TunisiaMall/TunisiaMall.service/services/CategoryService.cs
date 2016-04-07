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
    public class CategoryService : ICategoryService
    {
        static public DatabaseFactory dbFactory = new DatabaseFactory();
        UnitOfWork utwk = new UnitOfWork(dbFactory);

        public void AddCategory(category category)
        {
            utwk.CategoryRepository.Add(category);
            utwk.Commit();
            
        }

        public List<category> getAllCategorys()
        {
            return utwk.CategoryRepository.GetAll().ToList();
        }
    }
    public interface ICategoryService
    {
        void AddCategory(category category);
        List<category> getAllCategorys();
    }
}
