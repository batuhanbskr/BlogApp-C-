using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSıgnInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }
    }
}
