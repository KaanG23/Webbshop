﻿using DataAccess.Entities;
using DataAccess.Models;

namespace DataAccess.Repositories
{
    public interface IUserRepository
    {
        void AddUserInfo(UserInfoModel model);
        void CheckForAdmin();
        void CreateUser(UserRegisterModel model);
        User GetUserByEmail(string? email);
        User LoginUser(UserLoginModel userLogin);
    }
}