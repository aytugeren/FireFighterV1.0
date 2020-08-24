using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class Player : BaseEntity
    {
        //Entities
        public string Username { get; set; }
        public string Password { get; set; }
        public long Point { get; set; }
        public int NumberOfExtinguished { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }

        //Connections
        public ICollection<PlayerAward> PlayerAwards { get; set; }
        public ICollection<PlayerItems> PlayerItems { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
