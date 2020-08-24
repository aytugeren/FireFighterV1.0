using FireFighter.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlaceServiceFolder
{
    public interface IPlaceAnimalService
    {
        /// <summary>
        /// Get PlaceAnimal with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PlaceAnimal GetById(int id);

        /// <summary>
        /// Delete PlaceAnimal
        /// </summary>
        /// <param name="placeAnimal"></param>
        void DeletePlaceAnimal(PlaceAnimal placeAnimal);

        /// <summary>
        /// List All PlaceAnimals
        /// </summary>
        /// <param name="placeId"></param>
        /// <param name="animalId"></param>
        /// <returns></returns>
        List<PlaceAnimal> GetAllPlaceAnimals(int placeId = 0, int animalId = 0);

        /// <summary>
        /// Insert PlaceAnimals
        /// </summary>
        /// <param name="placeAnimal"></param>
        void InsertPlaceAnimal(PlaceAnimal placeAnimal);

        /// <summary>
        /// Update PlaceAnimals
        /// </summary>
        /// <param name="placeAnimal"></param>
        void UpdatePlaceAnimal(PlaceAnimal placeAnimal);
    }
}
