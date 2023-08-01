using HomeWork.Models;
using HomeWork.Services.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Services
{
    internal class AccountService : IAccountService
    {
        public List<User> GetUsers()
        {
            List<User> list = new()
            {
                new User {Id=1,Email="cahangir@gmail",Password="caha12"},
                new User {Id=1,Email="sharaf@gmail",Password="sharaf12"},
                new User {Id=1,Email="pervin@gmail",Password="pervin12"},
            };
            return list;
        }

        public bool Login(string username, string password)
        {
            var users = GetUsers();
            foreach (var item in users)
            {
                if(username==item.Email && password == item.Password)
                {
                    return true;

                }
            }
            return false;
        }

        public void ShowMenu()
        {
            Console.WriteLine("1.Show product list");
            Console.WriteLine("2.Search product");
            Console.WriteLine("0. Exit");
        }

    }
}
