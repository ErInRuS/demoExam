using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp35
{
    internal class Product
    {
        public Product(string name = "unknow")
        {
            Name = name;
            this.id = Id;
            Id++;
        }
        static int Id = 0;
        public string Name { get; set; }
        public int id { get; set; }

        public static List<Product> Products = new List<Product>();

        public string Show()
        {
            return $"id: {this.id} name: {this.Name}";
        }

        

    }
}
