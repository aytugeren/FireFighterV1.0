using FireFighter.Data.UnitOfWork;
using FireFighter.Service.DTOs;
using FireFighter.Service.PlayerServiceFolder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FireFighter.Web.Controllers
{
    public class UserController : Controller
    {
        #region Fields
        private readonly IAuthenticationService _authenticationService;
        private readonly IPlayerService _playerService;
        private readonly IPlayerAwardService _playerAwardService;
        private IUnitOfWork _unit;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="authenticationService"></param>
        /// <param name="playerService"></param>
        /// <param name="playerAwardService"></param>
        /// <param name="unit"></param>
        public UserController(IAuthenticationService authenticationService,
            IPlayerService playerService,
            IPlayerAwardService playerAwardService,
            IUnitOfWork unit)
        {
            this._authenticationService = authenticationService;
            this._playerService = playerService;
            this._playerAwardService = playerAwardService;
            this._unit = unit;
        }
        #endregion

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(PlayerDTO player)
        {
            if (ModelState.IsValid)
            {
                _authenticationService.SaveUser(player);
                return RedirectToAction("Index", "Home");
            }
            else { 
            return View();
            }
        }
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(PlayerDTO player)
        {
            //player = _playerService.GetAllPlayers().FirstOrDefault(x => x.Username == player.Username || x.Email == player.Username);
            bool isUserValid = _authenticationService.IsUserValid(player);
            if (isUserValid)
            {
                return RedirectToAction("Index", "Home");

            }
            else
            {
                TempData["Hata"] = " <div style='color:white'>Boyle bir kullanici bulunmamaktadir! Lutfen kontrol ediniz!</div>";
                return new RedirectResult(@"~\User\SignIn\");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            HttpContext.Request.Cookies["UserCookies"].Value = null;
            return RedirectToAction("SignIn");
        }
        [HttpGet]
        public ActionResult ProfilePage(int id = 0)
        {
            var player = _playerService.GetAllPlayers().FirstOrDefault(x=>x.Id == id);
            var playerAward = _playerAwardService.GetAllPlayerAwards().Where(x => x.PlayerId == player.Id);
            var playerAwardName = _playerAwardService.GetPlayerAwardNames(player.Id);
            ProfilePageDTO profilePage = new ProfilePageDTO();
            profilePage.playerDTOs = player;
            profilePage.playerAwardDTOs = playerAward;
            profilePage.playerAwardNamesDTOs = playerAwardName;
            return View(profilePage);
        }
        [HttpPost]
        public ActionResult ProfilePage(ProfilePageDTO profilePageDTO)
        {
            //var players = _playerService.GetAllPlayers().FirstOrDefault(x => x.Username == profilePageDTO.Username || x.Email == profilePageDTO.Email);
            PlayerDTO playerDTO = new PlayerDTO();
            playerDTO.Id = profilePageDTO.Id;
            playerDTO.Email = profilePageDTO.Email;
            playerDTO.Username = profilePageDTO.Username;
            if (profilePageDTO.Password != null)
            {
                playerDTO.Password = profilePageDTO.Password;
                playerDTO.PasswordConfirm = profilePageDTO.PasswordConfirm;
            }

            _playerService.UpdatePlayer(playerDTO);
            return RedirectToAction("LogOut","User");
        }
    }
}