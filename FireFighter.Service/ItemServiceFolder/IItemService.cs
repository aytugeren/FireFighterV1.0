using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.ItemServiceFolder
{
    public interface IItemService
    {
        /// <summary>
        /// Get a Item with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Item GetById(int id);

        /// <summary>
        /// Delete Item
        /// </summary>
        /// <param name="item"></param>
        void DeleteItem(Item item);

        /// <summary>
        /// List All Items
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="size"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        List<Item> GetAllItem(string name = null, string description = null, int size = 0, int point = 0);

        /// <summary>
        /// Insert Item
        /// </summary>
        /// <param name="item"></param>
        void InsertItem(Item item);
    }
}
