using FireFighter.Core.Domain;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlayerServiceFolder
{
    public interface IPlayerService
    {
        /// <summary>
        /// Get Player with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PlayerDTO GetById(int id);

        /// <summary>
        /// Delete Player
        /// </summary>
        /// <param name="player"></param>
        void DeletePlayer(PlayerDTO player);

        /// <summary>
        /// Get All Players
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        List<PlayerDTO> GetAllPlayers();

        /// <summary>
        /// Insert Player
        /// </summary>
        /// <param name="player"></param>
        void InsertPlayer(PlayerDTO player);

        /// <summary>
        /// Update Player
        /// </summary>
        /// <param name="player"></param>
        void UpdatePlayer(PlayerDTO player);
    }
}
