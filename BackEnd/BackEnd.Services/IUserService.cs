﻿using BackEnd.Core;
using BackEnd.Core.Models;
using System;
using System.Collections.Generic;

namespace BackEnd.Services
{
    public interface IUserService
    {
        ServiceResult<UserModel> addUser(UserModel user);

        ServiceResult<IEnumerable<UserModel>> getUsers();
    }
}
