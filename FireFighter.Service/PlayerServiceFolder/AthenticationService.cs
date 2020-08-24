using AutoMapper;
using FireFighter.Core.Domain;
using FireFighter.Data;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI;

namespace FireFighter.Service.PlayerServiceFolder
{
    public class AthenticationService : Page, IAuthenticationService
    {
        #region Fields
        private readonly string saltPassword = "encryptKey";
        private readonly IRepository<Player> _playerRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="playerRepository"></param>
        /// <param name="mapper"></param>
        public AthenticationService(IRepository<Player> playerRepository,IMapper mapper)
        {
            this._playerRepository = playerRepository;
            this._mapper = mapper;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Hashing Password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string HashPassword(string password)
        {
            SHA1 encrypt = new SHA1CryptoServiceProvider();
            var encrypted = encrypt.ComputeHash(Encoding.UTF8.GetBytes(password + saltPassword));
            var sb = new StringBuilder(encrypted.Length * 2);
            foreach (byte b in encrypted)
            {
                sb.Append(b.ToString("x2"));
            }
            string encryptedPassword = sb.ToString();
            return encryptedPassword;
        }
        /// <summary>
        /// Check the user
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool IsUserValid(PlayerDTO player)
        {
            bool isValid = false;
            player.Password = HashPassword(player.Password);
            var result = _playerRepository.GetAll().FirstOrDefault(x => (x.Email == player.Username || x.Username == player.Username) && x.Password == player.Password);
            if (result != null)
            {
                if (player.Username.Contains("@"))
                {
                    var players = _playerRepository.GetAll().FirstOrDefault(x => x.Email == player.Username);
                    player.Email = players.Email;
                    player.Username = players.Username;

                }
                
                FormsAuthentication.SetAuthCookie(result.Username + "|"+result.Id, player.RememberMe);
                return isValid = true;
            }
            else
            {
                return isValid;
            }
        }

        /// <summary>
        /// Save user
        /// </summary>
        /// <param name="player"></param>
        public void SaveUser(PlayerDTO player)
        {
            player.Password = HashPassword(player.Password);
            _playerRepository.Insert(_mapper.Map<Player>(player));
        }
        #endregion
    }
}
