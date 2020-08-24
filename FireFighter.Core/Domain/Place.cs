using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class Place : BaseEntity
    {
        ///Entities
        public string Location { get; set; }
        public decimal Size { get; set; }
        public decimal Possibility { get; set; }

        //Connections
        public ICollection<PlaceAnimal> PlaceAnimals { get; set; }
    }
}
