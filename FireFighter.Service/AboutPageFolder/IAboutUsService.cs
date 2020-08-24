using FireFighter.Core.Domain;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.AboutPageFolder
{
    public interface IAboutUsService
    {
        /// <summary>
        /// Get Article with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AboutUsDTO GetById(int id);

        /// <summary>
        /// Delete Article
        /// </summary>
        /// <param name="aboutUs"></param>
        void DeleteAboutUs(AboutUsDTO aboutUs);

        /// <summary>
        /// Get All Articles
        /// </summary>
        /// <returns></returns>
        List<AboutUsDTO> GetAllArticle();

        /// <summary>
        /// Insert an Article
        /// </summary>
        /// <param name="aboutUs"></param>
        void InsertArticle(AboutUsDTO aboutUs);

        /// <summary>
        /// Update the Article
        /// </summary>
        /// <param name="aboutUs"></param>
        void UpdateArticle(AboutUsDTO aboutUs);
    }
}
