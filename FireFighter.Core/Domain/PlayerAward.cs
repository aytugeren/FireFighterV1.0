using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class PlayerAward
    {
        //Entities
        public int PlayerId { get; set; }
        public int AwardId { get; set; }

        //Connections
        public Player Player { get; set; }
        public Award Award { get; set; }
    }
}
