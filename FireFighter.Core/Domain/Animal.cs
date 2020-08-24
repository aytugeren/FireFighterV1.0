using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class Animal : BaseEntity
    {
        //Entities
        public string Name { get; set; }
        public int Population { get; set; }
        public string Description { get; set; }

        //Connections
        public ICollection<PlaceAnimal> PlaceAnimals { get; set; }
    }
}
