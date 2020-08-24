using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.DTOs
{
    public class PlayerDTO : BaseEntityDTO
    {
        [Required(ErrorMessage = "Boş Bırakılamaz!")]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "{0} Isim 3 karakterden kısa olamaz. 35 Harften büyük olamaz!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Boş Bırakılamaz!")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[\w~@#$%^&*+=`|{}:;!.?\'""()\[\]-]{8,30}$", ErrorMessage = "{0} Şifre 8 karakterden kısa olamaz. En az bir küçük/büyük harf ve rakam içermelidir !")]
        [Compare("PasswordConfirm", ErrorMessage = "Parolalar ayni olmalidir!")]
        public string Password { get; set; }
        public long Point { get; set; }
        public int NumberOfExtinguished { get; set; }

        [StringLength(35, MinimumLength = 3, ErrorMessage = "{0} Isim 3 karakterden kısa olamaz. 35 Harften büyük olamaz!")]
        public string Email { get; set; }
        public string Photo { get; set; }
        public bool RememberMe { get; set; }

        [Required(ErrorMessage = "Boş Bırakılamaz!")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[\w~@#$%^&*+=`|{}:;!.?\'""()\[\]-]{8,30}$", ErrorMessage = "{0} Şifre 8 karakterden kısa olamaz. En az bir küçük/büyük harf ve rakam içermelidir !")]
        [Compare("Password", ErrorMessage = "Parolalar ayni olmalidir!")]
        public string PasswordConfirm { get; set; }


    }
}
