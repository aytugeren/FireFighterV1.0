using FireFighter.Core.Domain;
using FireFighter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlaceServiceFolder
{
    public class PlaceAnimalService : IPlaceAnimalService
    {
        #region Fields
        private readonly IRepository<PlaceAnimal> _placeAnimalRepository;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="placeAnimalRepository"></param>
        public PlaceAnimalService(IRepository<PlaceAnimal> placeAnimalRepository)
        {
            this._placeAnimalRepository = placeAnimalRepository;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Delete Animal
        /// </summary>
        /// <param name="placeAnimal"></param>
        public void DeletePlaceAnimal(PlaceAnimal placeAnimal)
        {
            if (placeAnimal == null)
                throw new ArgumentNullException("Parameter is null");
            this._placeAnimalRepository.Delete(placeAnimal);
        }

        /// <summary>
        /// List All PlaceAnimals
        /// </summary>
        /// <param name="placeId"></param>
        /// <param name="animalId"></param>
        /// <returns></returns>
        public List<PlaceAnimal> GetAllPlaceAnimals(int placeId = 0, int animalId = 0)
        {
            var query = _placeAnimalRepository.Table;
            if (placeId != 0)
                query = query.Where(x => x.PlaceId.Equals(placeId));
            if (animalId != 0)
                query = query.Where(x => x.AnimalId.Equals(animalId));

            return query.ToList();
        }
        /// <summary>
        /// Get PlaceAnimal with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PlaceAnimal GetById(int id)
        {
            if (id != 0)
                throw new ArgumentNullException("Parameter is null");
            return _placeAnimalRepository.GetById(id);
        }

        /// <summary>
        /// Insert PlaceAnimal
        /// </summary>
        /// <param name="placeAnimal"></param>
        public void InsertPlaceAnimal(PlaceAnimal placeAnimal)
        {
            if (placeAnimal == null)
                throw new ArgumentNullException("Parameter is null");
            _placeAnimalRepository.Insert(placeAnimal);
        }

        /// <summary>
        /// Update PlaceAnimal
        /// </summary>
        /// <param name="placeAnimal"></param>
        public void UpdatePlaceAnimal(PlaceAnimal placeAnimal)
        {
            if (placeAnimal == null)
                throw new ArgumentNullException("Parameter is null");
            _placeAnimalRepository.Update(placeAnimal);
        }

        #endregion
    }
}
