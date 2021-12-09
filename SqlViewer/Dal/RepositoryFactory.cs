using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlViewer.Dal
{
    static class RepositoryFactory
    {
        private readonly static Lazy<IRepository> repository = new Lazy<IRepository>(() => new Repository());

        public static IRepository GetRepository() => repository.Value;
    }
}
