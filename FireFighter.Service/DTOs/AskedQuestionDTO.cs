using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.DTOs
{
    public class AskedQuestionDTO :BaseEntityDTO
    {
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
    }
}
