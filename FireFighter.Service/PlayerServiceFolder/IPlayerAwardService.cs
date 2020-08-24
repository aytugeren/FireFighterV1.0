using FireFighter.Core.Domain;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlayerServiceFolder
{
    public interface IPlayerAwardService
    {
        /// <summary>
        /// Get PlayerAward with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PlayerAwardDTO GetById(int id);

        /// <summary>
        /// Delete Player Award
        /// </summary>
        /// <param name="playerAward"></param>
        void DeletePlayerAward(PlayerAwardDTO playerAward);

        /// <summary>
        /// Get All PlayerAwards
        /// </summary>
        /// <returns></returns>
        List<PlayerAwardDTO> GetAllPlayerAwards();

        /// <summary>
        /// Insert PlayerAward
        /// </summary>
        /// <param name="playerAward"></param>
        void InsertPlayerAward(PlayerAwardDTO playerAward);

        /// <summary>
        /// Update PlayerAward
        /// </summary>
        /// <param name="playerAward"></param>
        void UpdatePlayerAward(PlayerAwardDTO playerAward);
        
        /// <summary>
        /// Get Awards that have connection with players
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<PlayerAwardNamesDTO> GetPlayerAwardNames(int id);

    }
}
