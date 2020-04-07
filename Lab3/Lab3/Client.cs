using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Client : Persona
    {
        private int income;
        public Client(string rut, string firstName, string lastName, string birth, string nacionality, int income) : base(rut, firstName, lastName, birth, nacionality)
        {
            this.income = income;
        }
        public void setIncome(int income)
        {
            this.income = income;
        }
        public void Purchase(int income, int sumProduct, List<Producto> productList, Employee e)
        {
            if (sumProduct > income)
            {
                Console.WriteLine("ERROR: este cliente no posee el dinero suficiente para efectuar la compra solicitada.");
            }
            else
            {
                int result = sumProduct - income;
                setIncome(result);
                Console.WriteLine("Compra realizada con éxito");
                Console.WriteLine("");
                Console.WriteLine("Detalles de la compra:");
                Console.WriteLine("Nombre del cliente:" + " " + FirstName() + " " + LastName());
                Console.WriteLine("Nombre del cajero:" + " " + e.FirstName() + " " + e.LastName());
                foreach (Producto product in productList)
                {
                    Console.WriteLine(product.Name() + " " + product.Price());
                }
                Console.WriteLine("Monto de la compra:" + sumProduct);
                Console.WriteLine("Nuevo ingreso:" + income);
            }
        }
    }
}
