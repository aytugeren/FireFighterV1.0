    using AutoMapper;
using FireFighter.Core.Domain;
using FireFighter.Data;
using FireFighter.Data.UnitOfWork;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlayerServiceFolder
{
    public class PlayerService : IPlayerService
    {
        #region Fields
        private readonly IRepository<Player> _playerRepository;
        private FireFighterDBContext _fireFighterDBContext;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="playerRepository"></param>
        public PlayerService(IRepository<Player> playerRepository,IMapper mapper,FireFighterDBContext fireFighterDBContext)
        {
            this._playerRepository = playerRepository;
            this._fireFighterDBContext = fireFighterDBContext;
            this._mapper = mapper;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Delete Plauer
        /// </summary>
        /// <param name="player"></param>
        public void DeletePlayer(PlayerDTO player)
        {
            if (player == null)
                throw new ArgumentNullException("Parameter is null!");
            player.IsDeleted = true;
            UpdatePlayer(player);
        }

        /// <summary>
        /// List All Players
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<PlayerDTO> GetAllPlayers()
        {
            var query = _playerRepository.GetAll().OrderByDescending(x => x.Point);
            List<PlayerDTO> playerDTOs = new List<PlayerDTO>();
            foreach(var item in query)
            {
                playerDTOs.Add(_mapper.Map<PlayerDTO>(item));
            }
            return playerDTOs;
        }

        /// <summary>
        /// Get Player with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PlayerDTO GetById(int id)
        {
            if (id != 0)
                throw new ArgumentNullException("Id is 0");
            var i = _playerRepository.GetById(id);
            return _mapper.Map<PlayerDTO>(i);
        }

        /// <summary>
        /// Insert Player
        /// </summary>
        /// <param name="player"></param>
        public void InsertPlayer(PlayerDTO player)
        {
            if (player == null)
                throw new ArgumentNullException("Parameter is null");
            _playerRepository.Insert(_mapper.Map<Player>(player));
        }
        /// <summary>
        /// Update Player
        /// </summary>
        /// <param name="player"></param>
        public void UpdatePlayer(PlayerDTO player)
        {
            if (player == null)
                throw new ArgumentNullException("Parameter is null!");
            var p = _fireFighterDBContext.Players.FirstOrDefault(x => x.Id == player.Id);
            p.Email = player.Email;
            p.Username = player.Username;
            _playerRepository.Update(p);
        }
        #endregion
    }
}
