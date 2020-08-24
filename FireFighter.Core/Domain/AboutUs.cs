using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Core.Domain
{
    public class AboutUs : BaseEntity
    {
        public string Caption  { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
    }
}
