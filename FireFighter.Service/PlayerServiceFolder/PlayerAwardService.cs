using AutoMapper;
using FireFighter.Core.Domain;
using FireFighter.Data;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.PlayerServiceFolder
{
    public class PlayerAwardService : IPlayerAwardService
    {
        #region Fields
        private readonly IRepository<PlayerAward> _playerAwardRepository;
        private readonly IRepository<Player> _playerRepository;
        private readonly IRepository<Award> _awardRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="playerAwardRepository"></param>
        /// <param name="awardRepository"></param>
        /// <param name="mapper"></param>
        /// <param name="playerRepository"></param>
        public PlayerAwardService(IRepository<PlayerAward> playerAwardRepository,
            IRepository<Player> playerRepository,
            IRepository<Award> awardRepository,
            IMapper mapper)
        {
            this._playerAwardRepository = playerAwardRepository;
            this._playerRepository = playerRepository;
            this._awardRepository = awardRepository;
            this._mapper = mapper;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Delete PlayerAward
        /// </summary>
        /// <param name="playerAward"></param>
        public void DeletePlayerAward(PlayerAwardDTO playerAward)
        {
            if (playerAward == null)
                throw new ArgumentNullException("Parameter is null!");
            _playerAwardRepository.Delete(_mapper.Map<PlayerAward>(playerAward));
        }

        /// <summary>
        /// GetAllPlayerAwards
        /// </summary>
        /// <returns></returns>
        public List<PlayerAwardDTO> GetAllPlayerAwards()
        {
            var playerAwards = _playerAwardRepository.GetAll();
            var players = _playerRepository.GetAll();
            var awards = _awardRepository.GetAll();

            var query = from playerandAwards in playerAwards
                        join player in players on playerandAwards.PlayerId equals player.Id
                        join award in awards on playerandAwards.AwardId equals award.Id
                        select new
                        {
                            award.Description,
                            award.Name
                        };
            return _mapper.Map<List<PlayerAwardDTO>>(playerAwards);
        }
        /// <summary>
        /// Get the Name of Awards that have connection with Players
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<PlayerAwardNamesDTO> GetPlayerAwardNames(int id)
        {
            var playerAwards = _playerAwardRepository.GetAll();
            var awards = _awardRepository.GetAll();
            List<PlayerAwardNamesDTO> playerAward = new List<PlayerAwardNamesDTO>();
            
            if (id == 0)
            {
                var players = _playerRepository.GetAll();

                var query = from playerandAwards in playerAwards
                            join player in players on playerandAwards.PlayerId equals player.Id
                            join award in awards on playerandAwards.AwardId equals award.Id
                            select new
                            {
                                award.Description,
                                award.Name
                            };
                foreach (var item in query)
                {
                    playerAward.Add(new PlayerAwardNamesDTO { AwardNames = item.Name, Description = item.Description });
                }
            }

            else
            {
                var players = _playerRepository.GetAll().Where(x => x.Id == id);


                var query = from playerandAwards in playerAwards
                            join player in players on playerandAwards.PlayerId equals player.Id
                            join award in awards on playerandAwards.AwardId equals award.Id
                            select new
                            {
                                award.Description,
                                award.Point,
                                award.Name
                            };
                foreach (var item in query)
                {
                    playerAward.Add(new PlayerAwardNamesDTO { AwardNames = item.Name, Description = item.Description, Point =item.Point });
                }
            }
            return playerAward;
        }
        /// <summary>
        /// Get PlayerAward with Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PlayerAwardDTO GetById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("Parameter is null");
            var quer = _playerAwardRepository.GetById(id);
            return _mapper.Map<PlayerAwardDTO>(quer);
        }

        /// <summary>
        /// Insert PlayerAward
        /// </summary>
        /// <param name="playerAward"></param>
        public void InsertPlayerAward(PlayerAwardDTO playerAward)
        {
            if (playerAward == null)
                throw new ArgumentNullException("Parameter is null");
            _playerAwardRepository.Insert(_mapper.Map<PlayerAward>(playerAward));
        }

        /// <summary>
        /// pdate PlayerAward
        /// </summary>
        /// <param name="playerAward"></param>
        public void UpdatePlayerAward(PlayerAwardDTO playerAward)
        {
            if (playerAward == null)
                throw new ArgumentNullException("Paramter is null!");
            _playerAwardRepository.Update(_mapper.Map<PlayerAward>(playerAward));
        }
        #endregion
    }
}
