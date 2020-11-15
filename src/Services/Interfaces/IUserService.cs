﻿using Domain;
using Services.Requests;

namespace Services
{
    public interface IUserService
    {
        CreateUserResponse AddUser(CreateUserRequest request);
        User GetUser(string username);
    }
}