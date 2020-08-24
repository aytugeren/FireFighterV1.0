using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Data
{
    public interface IRepository<T> where T : new()
    {
        /// <summary>
        /// Get Entities by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Get All Information of Entities
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        List<T> GetAll();

        /// <summary>
        /// To Insert Entity
        /// </summary>
        /// <param name="entity"></param>
        void Insert(T entity);

        /// <summary>
        /// To Insert Entities
        /// </summary>
        /// <param name="entities"></param>
        void Insert(IEnumerable<T> entities);

        /// <summary>
        /// To Update Entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Update Entities
        /// </summary>
        /// <param name="entities"></param>
        void Update(IEnumerable<T> entities);

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Delete Entities
        /// </summary>
        /// <param name="entities"></param>
        void Delete(IEnumerable<T> entities);

        IQueryable<T> Table { get; }

    }
}
