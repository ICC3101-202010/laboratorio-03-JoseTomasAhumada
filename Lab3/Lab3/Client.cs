using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab3
{
    class Client : Persona
    {
        private int income;
        public Client(string rut, string firstName, string lastName, string birth, string nacionality, int income) : base(rut, firstName, lastName, birth, nacionality)
        {
            this.income = income;
        }
        public int Income()
        {
            return income;
        }
        public void setIncome(int income)
        {
            this.income = income;
        }
        public void Purchase(int income, List<Producto> shoppingCart, Employee e)
        {
            int sumProduct = 0;
            foreach(Producto prod in shoppingCart)
            {
                sumProduct = sumProduct + prod.Price();
            }
            if (sumProduct > income)
            {
                Console.WriteLine("ERROR: este cliente no posee el dinero suficiente para efectuar la compra solicitada.");
            }
            else
            {
                int result = income - sumProduct;
                setIncome(result);
                DateTime today = DateTime.Now;
                Console.WriteLine("Compra realizada con éxito");
                Console.WriteLine("");
                Console.WriteLine("Detalles de la compra:");
                Console.WriteLine("FECHA Y HORA: " + today);
                Console.WriteLine("Nombre del cliente:" + " " + FirstName() + " " + LastName());
                Console.WriteLine("Nombre del cajero:" + " " + e.FirstName() + " " + e.LastName());
                foreach (Producto product in shoppingCart)
                {
                    Console.WriteLine(product.Name() + " $" + product.Price());
                }
                Console.WriteLine("Monto de la compra: $" + sumProduct);
                Console.WriteLine("Nuevo ingreso: $" + result);
                shoppingCart.Clear();
            }
        }
    }
}
