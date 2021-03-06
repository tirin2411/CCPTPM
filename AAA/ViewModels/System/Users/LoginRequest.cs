using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModels.System.Users
{
    public class LoginRequest
    {
        [Display(Name = "Tên tài khoản")]
        public string UserName { get; set; }

        //public string Email { get; set; }
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}