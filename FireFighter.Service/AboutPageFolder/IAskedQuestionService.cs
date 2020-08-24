using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.AboutPageFolder
{
    public interface IAskedQuestionService
    {
        /// <summary>
        /// Get an AskedQuestion with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AskedQuestionDTO GetById(int id);

        /// <summary>
        /// Delete AskedQuestion
        /// </summary>
        /// <param name="askedQuestionDTO"></param>
        void DeleteAskedQuestion(AskedQuestionDTO askedQuestionDTO);

        /// <summary>
        /// Get All Questions
        /// </summary>
        /// <returns></returns>
        List<AskedQuestionDTO> GetAllQuestion();

        /// <summary>
        /// Insert AskedQuestion
        /// </summary>
        /// <param name="askedQuestionDTO"></param>
        void InsertAskedQuestion(AskedQuestionDTO askedQuestionDTO);

        /// <summary>
        /// Update AskedQuestion
        /// </summary>
        /// <param name="askedQuestionDTO"></param>
        void UpdateAskedQuestion(AskedQuestionDTO askedQuestionDTO);

    }
}
