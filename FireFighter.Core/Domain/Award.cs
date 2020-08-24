using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class Award : BaseEntity
    {
        //Entities
        public string Name { get; set; }
        public decimal Point { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }


        //Connections
        public ICollection<PlayerAward> PlayerAwards { get; set; }
    }
}
