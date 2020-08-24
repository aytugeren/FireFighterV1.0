using FireFighter.Core.Domain;
using FireFighter.Data;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace FireFighter.Service.AnimalServiceFolder
{
    public class AnimalService : IAnimalService
    {

        #region Fields
        private readonly IRepository<Animal> _animalRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="animalRepository"></param>
        public AnimalService(IRepository<Animal> animalRepository, IMapper mapper)
        {
            this._animalRepository = animalRepository;
            this._mapper = mapper;
        }

        #endregion

        /// <summary>
        /// Delete Animal
        /// </summary>
        /// <param name="animal"></param>
        public void DeleteAnimal(AnimalDTO animal)
        {
            if (animal == null)
                throw new ArgumentNullException("Parameter is null!");
            animal.IsDeleted = true;
            UpdateAnimal(animal);
        }
        /// <summary>
        /// List Animals
        /// </summary>
        /// <returns></returns>
        public List<AnimalDTO> GetAllAnimals()
        {
            var animals = _animalRepository.GetAll();
            List<AnimalDTO> animalDTOs = new List<AnimalDTO>();
            foreach(var item in animals)
            {
                animalDTOs.Add(_mapper.Map<AnimalDTO>(item));
            }
            return animalDTOs;
        }

        /// <summary>
        /// Get Animal with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AnimalDTO GetById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("ID is 0");
            var animal = _animalRepository.GetById(id);
            var animalDTO = _mapper.Map<AnimalDTO>(animal);
            return animalDTO;
        }

        /// <summary>
        /// Insert Animal
        /// </summary>
        /// <param name="animal"></param>
        public void InsertAnimal(AnimalDTO animal)
        {
            if (animal == null)
                throw new ArgumentNullException("Parameter is null!");
            _animalRepository.Insert(_mapper.Map<Animal>(animal));
        }

        public void UpdateAnimal(AnimalDTO animal)
        {
            if (animal == null)
                throw new ArgumentNullException("Parameter is null!");
            _animalRepository.Update(_mapper.Map<Animal>(animal));
        }
    }
}
