using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> IRepository<T>() where T : class,new();
        int saveChanges();
    }
}
