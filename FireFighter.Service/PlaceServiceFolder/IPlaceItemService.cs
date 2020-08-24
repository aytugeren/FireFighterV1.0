using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlaceServiceFolder
{
    public interface IPlaceItemService
    {
        /// <summary>
        /// Get PlaceItems with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PlayerItems GetById(int id);

        /// <summary>
        /// Delete PlaceItems
        /// </summary>
        /// <param name="placeItems"></param>
        void DeletePlaceItems(PlayerItems placeItems);

        /// <summary>
        /// Get All PlaceItems
        /// </summary>
        /// <param name="placeId"></param>
        /// <param name="itemId"></param>
        /// <returns></returns>
        List<PlayerItems> GetAllPlaceItems(int playerId = 0, int itemId = 0);

        /// <summary>
        /// Insert PlaceItems
        /// </summary>
        /// <param name="placeItems"></param>
        void InsertPlaceItems(PlayerItems placeItems);

        /// <summary>
        /// Update PlaceItems
        /// </summary>
        /// <param name="placeItems"></param>
        void UpdatePlaceItems(PlayerItems placeItems);

    }
}
