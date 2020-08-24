using FireFighter.Core.Domain;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.AwardServiceFolder
{
    public interface IAwardService
    {
        /// <summary>
        /// Get a Animal with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PlayerAwardNamesDTO GetById(int id);

        /// <summary>
        /// Delete Award    
        /// </summary>
        /// <param name="award"></param>
        void DeleteAward(PlayerAwardNamesDTO award);

        /// <summary>
        /// List All Animals
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        List<PlayerAwardNamesDTO> GetAllAwards(string name = null, int point = 0, string description = null);

        /// <summary>
        /// Insert Award
        /// </summary>
        /// <param name="award"></param>
        void InsertAward(PlayerAwardNamesDTO award);

        /// <summary>
        /// Update Award
        /// </summary>
        /// <param name="award"></param>
        void UpdateAward(PlayerAwardNamesDTO award);
    }
}
