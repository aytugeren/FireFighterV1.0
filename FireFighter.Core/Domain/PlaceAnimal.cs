using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class PlaceAnimal
    {
        //Entities
        public int AnimalId { get; set; }
        public int PlaceId { get; set; }

        //Connections
        public Place Place { get; set; }
        public Animal Animal { get; set; }
    }
}
