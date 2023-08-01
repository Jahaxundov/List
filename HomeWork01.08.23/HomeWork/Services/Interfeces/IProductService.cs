using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Services.Interfeces
{
    internal interface IProductService
    {
        string SearchByName(string searchText);
        List<Product> GetProducts();
    }
}
