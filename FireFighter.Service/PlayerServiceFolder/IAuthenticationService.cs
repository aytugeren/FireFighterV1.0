using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlayerServiceFolder
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// Hashing Algorithm
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        string HashPassword(string password);

        /// <summary>
        /// Save Player
        /// </summary>
        /// <param name="player"></param>
        void SaveUser(PlayerDTO player);

        /// <summary>
        /// Login Algorithm
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        bool IsUserValid(PlayerDTO player);
    }
}
