using HomeWork.Services;
using HomeWork.Services.Helpers;
using HomeWork.Services.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;
        private readonly IProductService _productService;
        public AccountController()
        {
            _accountService = new AccountService();
            _productService = new ProductService();
        }

        public void Login()
        {
            Console.WriteLine("Add email :");
            Email: string email = Console.ReadLine();

            Console.WriteLine("Add password :");
            string password = Console.ReadLine();

            bool isLogin = _accountService.Login(email, password);
            if (isLogin)
            {
                string opt;
                do
                {
                    Console.WriteLine(AccountMessage.LoginSucsses);
                    _accountService.ShowMenu();
                    Console.WriteLine(" Enter :");
                    opt = Console.ReadLine();
                    switch (opt)
                    {
                        case "1":
                            var products = _productService.GetProducts();
                            foreach (var item in products)
                            {
                                Console.WriteLine($"{item.Name} - {item.Price} ");
                            }
                            break;
                        case "2":

                            Console.WriteLine("Enter search text :");
                            string searchText = Console.ReadLine();
                            var products2 = _productService.SearchByName(searchText);
                            break;
                        case "0":
                            Console.WriteLine("End!");
                            break;
                        default:
                            Console.WriteLine("Something is wrong!");
                            break;
                    }

                } while (opt != "0");

            }
            else
            {
                Console.WriteLine(AccountMessage.LoginFailed);
                goto Email;
            }
        }
    }
}
