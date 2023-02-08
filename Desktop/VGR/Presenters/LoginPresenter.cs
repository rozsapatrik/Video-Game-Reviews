using CryptSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGR.Models;
using VGR.Repositories;
using VGR.Services;
using VGR.ViewInterfaces;

namespace VGR.Presenters
{
    class LoginPresenter
    {
        private ILoginView view;
        private UserRepository repo;
        public LoginPresenter(ILoginView param)
        {
            view = param;
            repo = new UserRepository();
        }

        public bool Belepes()
        {
            view.ErrorUserName = null;
            view.ErrorPassword = null;

            if(string.IsNullOrWhiteSpace(view.UserName))
            {
                view.ErrorUserName = "Enter your username!";
            }
            if(string.IsNullOrWhiteSpace(view.Password))
            {
                view.ErrorPassword = "Wrong password!";
            }

            if(!string.IsNullOrWhiteSpace(view.UserName) && !string.IsNullOrWhiteSpace(view.Password))
            {
                if(repo.UsernameExists(view.UserName))
                {
                    var UserID = repo.GetId(view.UserName);
                    var userPwd = repo.getPwd(view.UserName);
                    if(Crypter.CheckPassword(view.Password, userPwd))
                    {
                        CurrentUser.Id = UserID;
                        CurrentUser.UserName = view.UserName;
                        return true;
                    }
                    else
                    {
                        view.ErrorPassword = "Wrong password!";
                    }
                }
                else
                {
                    view.ErrorUserName = "User doesn't exist";
                }
            }
            return false;
        }
    }
}
