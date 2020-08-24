using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlaceServiceFolder
{
    public interface IPlaceService
    {
        /// <summary>
        /// Get a Place with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Place GetById(int id);

        /// <summary>
        /// Delete Place
        /// </summary>
        /// <param name="place"></param>
        void DeletePlace(Place place);

        /// <summary>
        /// Get All Places
        /// </summary>
        /// <param name="location"></param>
        /// <param name="size"></param>
        /// <param name="possibility"></param>
        /// <returns></returns>
        List<Place> GetAllPlaces(string location = null, decimal size = 0, decimal possibility = 0);

        /// <summary>
        /// Insert Place
        /// </summary>
        /// <param name="place"></param>
        void InsertPlace(Place place);

        /// <summary>
        /// Update Place
        /// </summary>
        /// <param name="place"></param>
        void UpdatePlace(Place place);
    }
}
