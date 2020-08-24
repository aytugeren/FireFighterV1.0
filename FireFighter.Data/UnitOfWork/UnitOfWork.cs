using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FireFighterDBContext _context;
        private Dictionary<string, object> repositories;
        public UnitOfWork(FireFighterDBContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int saveChanges()
        {
            return _context.SaveChanges();
        }
        public IRepository<T> IRepository<T>() where T : class,new()
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }
            var type = typeof(T).Name;
            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(IRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                repositories.Add(type, repositoryInstance);
            }
            return (IRepository<T>)repositories[type];
        }

    }
}
