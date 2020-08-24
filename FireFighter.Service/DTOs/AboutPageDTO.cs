using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.DTOs
{
    public class AboutPageDTO
    {
        public virtual List<AboutUsDTO>  AboutUsDTOs{get; set;}
        public virtual List<AskedQuestionDTO> AskedQuestionDTOs { get; set; }
    }
}
