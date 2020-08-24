using FireFighter.Core.Domain;
using FireFighter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlaceServiceFolder
{
    public class PlaceService : IPlaceService
    {
        #region Fields
        private readonly IRepository<Place> _placeRepository;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="placeRepository"></param>
        public PlaceService(IRepository<Place> placeRepository)
        {
            this._placeRepository = placeRepository;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Delete Place
        /// </summary>
        /// <param name="place"></param>
        public void DeletePlace(Place place)
        {
            if (place == null)
                throw new ArgumentNullException("Parameter is null");
            this._placeRepository.Delete(place);
        }

        /// <summary>
        /// Get All Places
        /// </summary>
        /// <param name="location"></param>
        /// <param name="size"></param>
        /// <param name="possibility"></param>
        /// <returns></returns>
        public List<Place> GetAllPlaces(string location = null, decimal size = 0, decimal possibility = 0)
        {
            var query = _placeRepository.Table;
            if (!String.IsNullOrEmpty(location))
                query = query.Where(x => x.Location.Contains(location));
            if (size != 0)
                query = query.Where(x => x.Size.Equals(size));
            if (possibility != 0)
                query = query.Where(x => x.Possibility.Equals(possibility));

            return query.ToList();
        }

        /// <summary>
        /// Get Place with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Place GetById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("Parameter is null");
            return _placeRepository.GetById(id);
        }

        /// <summary>
        /// Insert Place
        /// </summary>
        /// <param name="place"></param>
        public void InsertPlace(Place place)
        {
            if (place == null)
                throw new ArgumentNullException("Parameter is null!");
            _placeRepository.Insert(place);
        }

        /// <summary>
        /// Update Place
        /// </summary>
        /// <param name="place"></param>
        public void UpdatePlace(Place place)
        {
            if (place == null)
                throw new ArgumentNullException("Parameter is null!");
            _placeRepository.Update(place);
        }
        #endregion
    }
}
