using FireFighter.Core.Domain;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.AnimalServiceFolder
{
    public interface IAnimalService
    {
        /// <summary>
        /// Get an Animal with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AnimalDTO GetById(int id);

        /// <summary>
        /// Delete Animal
        /// </summary>
        /// <param name="animal"></param>
        void DeleteAnimal(AnimalDTO animal);

        /// <summary>
        /// Get All Animals
        /// </summary>
        /// <returns></returns>
        List<AnimalDTO> GetAllAnimals();

        /// <summary>
        /// Insert Animal
        /// </summary>
        /// <param name="animal"></param>
        void InsertAnimal(AnimalDTO animal);

        /// <summary>
        /// Update Customer
        /// </summary>
        /// <param name="animal"></param>
        void UpdateAnimal(AnimalDTO animal);
    }
}
