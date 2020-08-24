using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.DTOs
{
    public class AnimalDTO : BaseEntityDTO
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string Description { get; set; }
    }
}
