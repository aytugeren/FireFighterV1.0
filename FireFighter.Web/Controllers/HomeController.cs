using FireFighter.Core.Domain;
using FireFighter.Service;
using FireFighter.Service.AboutPageFolder;
using FireFighter.Service.AwardServiceFolder;
using FireFighter.Service.DTOs;
using FireFighter.Service.PlayerServiceFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FireFighter.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        private readonly IPlayerService _playerService;
        private readonly IAboutUsService _aboutUsService;
        private readonly IAskedQuestionService _askedQuestionService;
        private readonly IAwardService _awardService;
        #endregion
        #region Ctor
        public HomeController(IPlayerService playerService,IAboutUsService aboutUsService,IAskedQuestionService askedQuestionService, IAwardService awardService)
        {
            this._playerService = playerService;
            this._aboutUsService = aboutUsService;
            this._askedQuestionService = askedQuestionService;
            this._awardService = awardService;
        }
        #endregion

        #region Methods
        [Authorize]
        public ActionResult Index()
        {
            var list = _playerService.GetAllPlayers();
            return View(list);
        }
        [Authorize]
        public ActionResult About()
        {
            var list = _aboutUsService.GetAllArticle();
            var list1 = _askedQuestionService.GetAllQuestion();
            AboutPageDTO aboutPage = new AboutPageDTO();
            aboutPage.AboutUsDTOs = list;
            aboutPage.AskedQuestionDTOs = list1;
            return View(aboutPage);
        }
        [Authorize]
        public ActionResult Contact()
        {
            return View();
        }
        [Authorize]
        public ActionResult Gallery()
        {
            return View();
        }
        [Authorize]
        public ActionResult Awards()
        {
            var awards = _awardService.GetAllAwards();
            return View(awards);
        }
      
        #endregion
    }
}