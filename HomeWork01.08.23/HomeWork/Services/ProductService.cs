using HomeWork.Models;
using HomeWork.Services.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Services
{
    internal class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();
            {
                list.Add(new Product{Id=1, Name="Cola", Price=21});
                list.Add(new Product { Id = 1, Name = "Pepsi", Price = 22 }); ;
                list.Add(new Product { Id = 2, Name = "Sprite", Price = 25 });
                list.Add(new Product { Id = 3, Name = "Fanta", Price = 26 });
            };
            return list;
        }

        public string SearchByName(string searchText)
        {
            var products = GetProducts();
            foreach (var item in products)
            {
                if (item.Name.Trim().ToLower().Contains(searchText.ToLower().Trim()))
                {
                    Console.WriteLine($"{"Name of product -"+item.Name} ,{"Price -"+item.Price}");
                }
            }
            return null;
        }
    }
}
