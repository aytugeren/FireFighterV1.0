using AutoMapper;
using FireFighter.Core.Domain;
using FireFighter.Data;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.AboutPageFolder
{
    public class AboutUsService : IAboutUsService
    {
        #region Fields
        private readonly IRepository<AboutUs> _aboutUsRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="aboutUsRepository"></param>
        /// <param name="mapper"></param>
        public AboutUsService(IRepository<AboutUs> aboutUsRepository, IMapper mapper)
        {
            this._aboutUsRepository = aboutUsRepository;
            this._mapper = mapper;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Delete the article
        /// </summary>
        /// <param name="aboutUs"></param>
        public void DeleteAboutUs(AboutUsDTO aboutUs)
        {
            if (aboutUs == null)
                throw new ArgumentNullException("Parameter is null!");
            aboutUs.IsDeleted = true;
            UpdateArticle(aboutUs);
        }

        /// <summary>
        /// Get All Articles
        /// </summary>
        /// <returns></returns>
        public List<AboutUsDTO> GetAllArticle()
        {
            var articles = _aboutUsRepository.GetAll();
            if (articles == null)
                throw new ArgumentNullException("Parameter is null!");
            List<AboutUsDTO> aboutUsDTOs = new List<AboutUsDTO>();
            foreach (var item in articles)
            {
                aboutUsDTOs.Add(_mapper.Map<AboutUsDTO>(item));
            }
            return aboutUsDTOs;
        }

        /// <summary>
        /// Get article with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AboutUsDTO GetById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("Parameter is null");
            var article = _aboutUsRepository.GetById(id);
            var articleDto = _mapper.Map<AboutUsDTO>(article);
            return articleDto;
        }

        /// <summary>
        /// Insert Article
        /// </summary>
        /// <param name="aboutUs"></param>
        public void InsertArticle(AboutUsDTO aboutUs)
        {
            if (aboutUs == null)
                throw new ArgumentNullException("Parameter is null");
            _aboutUsRepository.Insert(_mapper.Map<AboutUs>(aboutUs));
        }

        /// <summary>
        /// Update Article
        /// </summary>
        /// <param name="aboutUs"></param>
        public void UpdateArticle(AboutUsDTO aboutUs)
        {
            if (aboutUs == null)
                throw new ArgumentNullException("Parameter is null");
            _aboutUsRepository.Update(_mapper.Map<AboutUs>(aboutUs));
        }
        #endregion
    }
}
