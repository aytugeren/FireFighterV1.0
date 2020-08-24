using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class PlayerItems
    {
        //Entities
        public int PlayerId { get; set; }
        public int ItemId { get; set; }

        //Connections
        public Player Player { get; set; }
        public Item Item { get; set; }
    }
}
