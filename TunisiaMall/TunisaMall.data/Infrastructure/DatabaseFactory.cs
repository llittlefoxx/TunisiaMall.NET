using Data;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisaMall.data.Models;

namespace Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private pidevtunisiamallContext dataContext;
        public pidevtunisiamallContext DataContext
        {
            get { return dataContext; }
        }

        public DatabaseFactory()
        {
            dataContext = new pidevtunisiamallContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }

    }
}
