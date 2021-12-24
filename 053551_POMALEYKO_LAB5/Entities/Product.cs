using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053551_POMALEYKO_LAB5
{
    


    public class Product
    {
        
        
        public string Name { get;set; }
        public int Cost { get; set; }
        public string NameOfCustromer { get; set; }

        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
        
        
    }
}
