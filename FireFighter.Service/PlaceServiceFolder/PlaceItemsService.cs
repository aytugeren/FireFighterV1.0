using FireFighter.Core.Domain;
using FireFighter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlaceServiceFolder
{
    public class PlaceItemsService : IPlaceItemService
    {
        #region Fields
        private readonly IRepository<PlayerItems> _placeItemsRepository;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="placeItemsRepository"></param>
        public PlaceItemsService(IRepository<PlayerItems> placeItemsRepository)
        {
            this._placeItemsRepository = placeItemsRepository;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Delete placeItem
        /// </summary>
        /// <param name="placeItems"></param>
        public void DeletePlaceItems(PlayerItems placeItems)
        {
            if (placeItems == null)
                throw new ArgumentNullException("Parameter is null");
            _placeItemsRepository.Delete(placeItems);
        }

        /// <summary>
        /// Get All PlaceItems
        /// </summary>
        /// <param name="placeId"></param>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public List<PlayerItems> GetAllPlaceItems(int playerId = 0, int itemId = 0)
        {
            var query = _placeItemsRepository.Table;
            if (playerId != 0)
                query = query.Where(x => x.PlayerId.Equals(playerId));
            if (itemId != 0)
                query = query.Where(x => x.ItemId.Equals(itemId));

            return query.ToList();
        }

        /// <summary>
        /// Get PlaceItems with ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PlayerItems GetById(int id)
        {
            if (id != 0)
                throw new ArgumentNullException("Parameter is null");
            return _placeItemsRepository.GetById(id);
        }

        /// <summary>
        /// Insert Place Items
        /// </summary>
        /// <param name="placeItems"></param>
        public void InsertPlaceItems(PlayerItems placeItems)
        {
            if (placeItems == null)
                throw new ArgumentNullException("Parameter is null");
            _placeItemsRepository.Insert(placeItems);
        }

        /// <summary>
        /// Update PlaceItems
        /// </summary>
        /// <param name="placeItems"></param>
        public void UpdatePlaceItems(PlayerItems placeItems)
        {
            if (placeItems == null)
                throw new ArgumentNullException("Parameter is null");
            _placeItemsRepository.Update(placeItems);
        }
        #endregion
    }
}
