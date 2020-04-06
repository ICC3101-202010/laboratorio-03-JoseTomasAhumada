using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Producto
    {
        protected string name;
        protected int price;
        protected string brand;
        protected int stock;
        public Producto(string name, int price, string brand, int stock)
        {
            this.name = name;
            this.price = price;
            this.brand = brand;
            this.stock = stock;
        }
    }
}
