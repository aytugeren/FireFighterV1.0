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
    public class AskedQuestionService : IAskedQuestionService
    {
        #region Fields
        private readonly IRepository<AskedQuestion> _askedQuestionRepo;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="askedQuestionRepo"></param>
        /// <param name="mapper"></param>
        public AskedQuestionService(IRepository<AskedQuestion> askedQuestionRepo,IMapper mapper)
        {
            this._askedQuestionRepo = askedQuestionRepo;
            this._mapper = mapper;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Delete AskedQuestion
        /// </summary>
        /// <param name="askedQuestionDTO"></param>
        public void DeleteAskedQuestion(AskedQuestionDTO askedQuestionDTO)
        {
            if (askedQuestionDTO == null)
                throw new ArgumentNullException("Parameter is null!");
            askedQuestionDTO.IsDeleted = true;
            UpdateAskedQuestion(askedQuestionDTO);
        }

        /// <summary>
        /// Get All Asked Questions
        /// </summary>
        /// <returns></returns>
        public List<AskedQuestionDTO> GetAllQuestion()
        {
            var query = _askedQuestionRepo.GetAll().Where(x => x.IsDeleted == false);
            List<AskedQuestionDTO> askedQuestions = new List<AskedQuestionDTO>();
            foreach(var item in query)
            {
                askedQuestions.Add(_mapper.Map<AskedQuestionDTO>(item));
            }
            return askedQuestions;

        }
        /// <summary>
        /// Get Asked Question with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AskedQuestionDTO GetById(int id)
        {
            var askedQ = _askedQuestionRepo.GetById(id);
            return _mapper.Map<AskedQuestionDTO>(askedQ);
        }

        /// <summary>
        /// Insert Asked Questions
        /// </summary>
        /// <param name="askedQuestionDTO"></param>
        public void InsertAskedQuestion(AskedQuestionDTO askedQuestionDTO)
        {
            _askedQuestionRepo.Insert(_mapper.Map<AskedQuestion>(askedQuestionDTO));
        }

        /// <summary>
        /// Update Questions
        /// </summary>
        /// <param name="askedQuestionDTO"></param>
        public void UpdateAskedQuestion(AskedQuestionDTO askedQuestionDTO)
        {
            _askedQuestionRepo.Update(_mapper.Map<AskedQuestion>(askedQuestionDTO));
        }
        #endregion
    }
}
