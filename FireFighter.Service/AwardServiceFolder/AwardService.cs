using Autofac.Core;
using AutoMapper;
using FireFighter.Core.Domain;
using FireFighter.Data;
using FireFighter.Service.AwardServiceFolder;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.AwardService
{
    public class AwardService : IAwardService
    {
        #region Fields
        private readonly IRepository<Award> _awardRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="awardRepository"></param>
        /// <param name="mapper"></param>
        public AwardService(IRepository<Award> awardRepository,IMapper mapper)
        {
            this._awardRepository = awardRepository;
            this._mapper = mapper;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Delete Award
        /// </summary>
        /// <param name="award"></param>
        public void DeleteAward(PlayerAwardNamesDTO award)
        {
            if (award == null)
                throw new ArgumentNullException("Parameter is null");
            _awardRepository.Delete(_mapper.Map<Award>(award));
        }


        /// <summary>
        /// Get All Awards
        /// </summary>
        /// <param name="name"></param>
        /// <param name="point"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public List<PlayerAwardNamesDTO> GetAllAwards(string name = null, int point = 0, string description = null)
        {
            var query = _awardRepository.Table;
            if (!String.IsNullOrEmpty(name))
                query = query.Where(x => x.Name.Contains(name));
            if (point != 0)
                query = query.Where(x => x.Point.Equals(point));
            if (!String.IsNullOrEmpty(description))
                query = query.Where(x => x.Description.Contains(description));

            return _mapper.Map<List<PlayerAwardNamesDTO>>(query).ToList();
        }

        /// <summary>
        /// Get Awards with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PlayerAwardNamesDTO GetById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("Parameter is null");
            return _mapper.Map<PlayerAwardNamesDTO>(_awardRepository.GetById(id));
        }

        /// <summary>
        /// Insert Award
        /// </summary>
        /// <param name="award"></param>
        public void InsertAward(PlayerAwardNamesDTO award)
        {
            if (award == null)
                throw new ArgumentNullException("Parameter is null");
            _awardRepository.Insert(_mapper.Map<Award>(award));
        }

        /// <summary>
        /// Update Award
        /// </summary>
        /// <param name="award"></param>
        public void UpdateAward(PlayerAwardNamesDTO award)
        {
            if (award == null)
                throw new ArgumentNullException("Parameter is null");
            _awardRepository.Update(_mapper.Map<Award>(award));
        }
        #endregion
    }
}
