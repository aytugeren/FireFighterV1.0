using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class Item : BaseEntity
    {
        //Entities
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public int Point { get; set; }

        //Connections
        public ICollection<PlayerItems> PlayerItems { get; set; }
    }
}
