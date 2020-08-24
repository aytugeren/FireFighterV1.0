using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data
{
    public class EfRepository<T> : IRepository<T> where T : class,new()
    {
        #region Fields
        private readonly FireFighterDBContext _fireFighterDBContext;
        private DbSet<T> _dbSet;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="fireFighterDBContext"></param>
        public EfRepository(FireFighterDBContext fireFighterDBContext)
        {
            this._fireFighterDBContext = fireFighterDBContext;
            _dbSet = _fireFighterDBContext.Set<T>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get datas as queryable
        /// </summary>
        public IQueryable<T> Table
        {
            get { return this._dbSet; }
        }

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            try
            {
                if(entity == null)
                {
                    throw new ArgumentNullException("Entity is null!");
                }
                this._dbSet.Remove(entity);
                this._fireFighterDBContext.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception("It cannot removed!", e);
            }
        }

        /// <summary>
        /// Delete Entities
        /// </summary>
        /// <param name="entities"></param>
        public void Delete(IEnumerable<T> entities)
        {
            try
            {
                if(entities == null)
                {
                    throw new ArgumentNullException("Entities are null!");
                }
                foreach(var item in entities)
                {
                    this._dbSet.Remove(item);
                    this._fireFighterDBContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// List All Elements
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return this._dbSet.ToList();
        }

        /// <summary>
        /// Get Element with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            if(id == 0)
            {
                throw new ArgumentNullException("Entity is null!");
            }
            return this._dbSet.Find(id);
        }

        /// <summary>
        /// Insert Entity
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Entity is null!");
            this._dbSet.Add(entity);
            this._fireFighterDBContext.SaveChanges();
        }

        /// <summary>
        /// Insert Entities
        /// </summary>
        /// <param name="entities"></param>
        public void Insert(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("Entities are null!");
                foreach(var item in entities)
                {
                    this._dbSet.Add(item);
                }
                this._fireFighterDBContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("Entity is null");
                
                _fireFighterDBContext.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Update Entities
        /// </summary>
        /// <param name="entities"></param>
        public void Update(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("Entities are null!");
                foreach(var item in entities)
                {
                    _fireFighterDBContext.Entry(item).State = EntityState.Modified;
                }
                this._fireFighterDBContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Create DbSet
        /// </summary>
  
        #endregion
    }
}
