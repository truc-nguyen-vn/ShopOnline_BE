﻿using System.ComponentModel.DataAnnotations;
using static ShopOnline.Core.Models.Enum.AppEnum;

namespace ShopOnline.Core.Models.Account
{
    public class AccessTokenModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public TypeAcc RoleType { get; set; }
    }
    public class AccountLoginModel
    {
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class BaseInforAccountModel : AccountLoginModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public TypeAcc TypeAcc { get; set; }
    }

    public class AccountRegisterModel : AccountLoginModel
    {
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }

    public class ResetPasswordModel
    {
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }

    public class InforAccount
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
    }
}
