using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class Comment : BaseEntity
    {
        public int PlayerId { get; set; }
        public string CommentDes { get; set; }
        public string Page { get; set; }

        public Player Player { get; set; }
    }
}
