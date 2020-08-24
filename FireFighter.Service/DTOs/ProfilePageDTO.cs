using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.DTOs
{
    public class ProfilePageDTO
    {
        public PlayerDTO playerDTOs { get; set; }
        public IEnumerable<PlayerAwardDTO> playerAwardDTOs { get; set; }
        public List<PlayerAwardNamesDTO> playerAwardNamesDTOs { get; set; }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public bool IsDeleted { get; set; }
    }
}
