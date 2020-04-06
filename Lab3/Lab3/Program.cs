using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Supermercado.");
            Console.WriteLine("Para comenzar, defina la composición del supermercado.");
            Console.WriteLine("¿Cuántos clientes desea crear?");
            string numClients = Console.ReadLine();
            Console.WriteLine("Asegúrese que los clientes que ingrese puedan ser claramente diferenciables.");
            int clients = Int32.Parse(numClients);
            List<Client> clientList = new List<Client>();
            int i = 0;
            while(i < clients)
            {
                Console.WriteLine("Datos del cliente" + i + ":");
                Console.WriteLine("¿Cuál es su rut?");
                string rut = Console.ReadLine();
                Console.WriteLine("¿Cuál es su nombre?");
                string firstName = Console.ReadLine();
                Console.WriteLine("¿Cuál es su apellido?");
                string lastName = Console.ReadLine();
                Console.WriteLine("¿Cuál es su fecha de nacimiento? (DD/MM/AAAA)");
                string birth = Console.ReadLine();
                Console.WriteLine("¿Cuál es su nacionalidad?");
                string nacionality = Console.ReadLine();
                Console.WriteLine("¿De cuánto dinero dispone?");
                string Income = Console.ReadLine();
                int income = Int32.Parse(Income);
                Client c = new Client(rut, firstName, lastName, birth, nacionality, income);
                clientList.Add(c);

                ++i;
            }
            Console.WriteLine("¿Cuántos empleados desea agregar?");
            string numEmployees = Console.ReadLine();
            Console.WriteLine("Asegúrese que los empleados que ingrese puedan ser claramente diferenciables.");
            int employees = Int32.Parse(numEmployees);
            List<Employee> employeeList = new List<Employee>();
            while (i < employees)
            {
                Console.WriteLine("Datos del empleado" + i + ":");
                Console.WriteLine("¿Cuál es su rut?");
                string rut = Console.ReadLine();
                Console.WriteLine("¿Cuál es su nombre?");
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                Console.WriteLine("¿Cuál es su fecha de nacimiento? (DD/MM/AAAA)");
                string birth = Console.ReadLine();
                Console.WriteLine("¿Cuál es su nacionalidad?");
                string nacionality = Console.ReadLine();
                Console.WriteLine("¿Cuál es su lugar de trabajo?");
                string workplace = Console.ReadLine();
                Console.WriteLine("¿Cuál es su salario?");
                string Salary = Console.ReadLine();
                int salary = Int32.Parse(Salary);
                Console.WriteLine("¿A qué hora empieza a trabajar?");
                string startTime = Console.ReadLine();
                Console.WriteLine("¿A qué hora termina de trabajar?");
                string endTime = Console.ReadLine();
                Employee e = new Employee(rut, firstName, lastName, birth, nacionality, workplace, salary, startTime, endTime);
                employeeList.Add(e);
            }

            //Console.WriteLine("¿Qué desea realizar a continuación?:");
            //string option = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
