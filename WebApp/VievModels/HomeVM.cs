using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.VievModels
{
    public class HomeVM
    {
        public Banner Banner { get; set; }
        public List<Product> Prodact{ get; set; }
        
    }
}