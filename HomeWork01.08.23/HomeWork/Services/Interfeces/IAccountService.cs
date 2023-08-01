using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Services.Interfeces
{
    internal interface IAccountService
    {
        bool Login(string username, string password);
        List<User> GetUsers();
        void ShowMenu();
    }
}
