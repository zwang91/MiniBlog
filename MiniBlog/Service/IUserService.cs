﻿using MiniBlog.Model;
using MiniBlog.Stores;

namespace MiniBlog.Service;

public interface IUserService
{
    public User Register(User user);
    public List<User> GetAll();
    public User Update(User user);
    public User Delete(string name);
    public User GetByName(string name);
}