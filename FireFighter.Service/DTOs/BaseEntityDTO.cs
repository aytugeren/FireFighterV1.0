using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.DTOs
{
    public class BaseEntityDTO
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
