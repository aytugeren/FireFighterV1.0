using FireFighter.Core.Domain;
using FireFighter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.ItemServiceFolder
{
    public class ItemService : IItemService
    {
        #region Fields
        private readonly IRepository<Item> _itemRepository;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="itemRepository"></param>
        public ItemService(IRepository<Item> itemRepository)
        {
            this._itemRepository = itemRepository;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Delete item
        /// </summary>
        /// <param name="item"></param>
        public void DeleteItem(Item item)
        {
            if (item == null)
                throw new ArgumentNullException("Parameter is null");
            this._itemRepository.Delete(item);
        }

        /// <summary>
        /// List All Items
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="size"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public List<Item> GetAllItem(string name = null, string description = null, 
            int size = 0, int point = 0)
        {
            var query = this._itemRepository.Table;
            if (!String.IsNullOrEmpty(name))
                query = query.Where(x => x.Name.Contains(name));
            if (!String.IsNullOrEmpty(description))
                query = query.Where(x => x.Description.Contains(description));
            if (size != 0)
                query = query.Where(x => x.Size.Equals(size));
            if (point != 0)
                query = query.Where(x => x.Point.Equals(point));

            return query.ToList();
        }

        /// <summary>
        /// Get Item with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Item GetById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("Parameter is null!");
            return this._itemRepository.GetById(id);
        }

        /// <summary>
        /// Insert Item
        /// </summary>
        /// <param name="item"></param>
        public void InsertItem(Item item)
        {
            if (item == null)
                throw new ArgumentNullException("Parameter is null!");
            this._itemRepository.Insert(item);
        }
        #endregion
    }
}
