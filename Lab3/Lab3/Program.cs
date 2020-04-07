using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
            int i = 1;
            while(i <= clients)
            {
                Console.WriteLine("Datos del cliente" + " " + i + ":");
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
            int n = 1;
            while (n <= employees)
            {
                Console.WriteLine("Datos del empleado" + " " + n + ":");
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
                Console.WriteLine("¿Cuál es su lugar de trabajo?");
                string workplace = Console.ReadLine();
                Console.WriteLine("¿Cuál es su salario?");
                string Salary = Console.ReadLine();
                int salary = Int32.Parse(Salary);
                Console.WriteLine("¿A qué hora empieza a trabajar? (HH:MM)");
                string startTime = Console.ReadLine();
                Console.WriteLine("¿A qué hora termina de trabajar? (HH:MM)");
                string endTime = Console.ReadLine();
                Employee e = new Employee(rut, firstName, lastName, birth, nacionality, workplace, salary, startTime, endTime);
                employeeList.Add(e);

                ++n;
            }
            Console.WriteLine("¿Cuántos productos desea agregar?");
            string numProduct = Console.ReadLine();
            Console.WriteLine("Asegúrese que los productos que ingrese puedan ser claramente diferenciables.");
            int products = Int32.Parse(numProduct);
            List<Producto> productList = new List<Producto>();
            int m = 1;
            while (m <= products)
            {
                Console.WriteLine("Datos del producto" + " " + m + ":");
                Console.WriteLine("¿Cuál es su nombre?");
                string name = Console.ReadLine();
                Console.WriteLine("¿Cuál es su precio?");
                string Price = Console.ReadLine();
                int price = Int32.Parse(Price);
                Console.WriteLine("¿Cuál es su marca?");
                string brand = Console.ReadLine();
                Console.WriteLine("¿cuál es su stock?");
                string Stock = Console.ReadLine();
                int stock = Int32.Parse(Stock);
                Producto p = new Producto(name, price, brand, stock);
                productList.Add(p);

                ++m;
            }
            List<Producto> shoppingCart = new List<Producto>();
            int C = 1;
            while (C == 1)
            {
                Console.WriteLine("¿Qué desea realizar a continuación?:");
                Console.WriteLine("[1]Cambiar puesto de trabajo de un empleado");
                Console.WriteLine("[2]Cambiar sueldo de un empleado");
                Console.WriteLine("[3]Cambiar horario de trabajo de un empleado");
                Console.WriteLine("[4]Agregar clientes");
                Console.WriteLine("[5]Agregar trabajadores");
                Console.WriteLine("[6]Agregar productos");
                Console.WriteLine("[7]Ver productos");
                Console.WriteLine("[8]Agregar productos al carro");
                Console.WriteLine("[9]Realizar compra");
                Console.WriteLine("[10]Salir del supermercado");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("¿A quién desea cambiar de puesto?");
                    string person = Console.ReadLine();
                    Console.WriteLine("¿En qué quiere que trabaje ahora " + person + "?");
                    string workplace = Console.ReadLine();
                    foreach (Employee employee in employeeList)
                    {
                        if (person == employee.FirstName())
                        {
                            employee.changeWorkplace(workplace);
                        }
                    }
                    Console.WriteLine("Ahora " + person + " trabaja de " + workplace);
                }
                else if (option == "2")
                {
                    Console.WriteLine("¿A quién desea cambiarle el sueldo?");
                    string person = Console.ReadLine();
                    Console.WriteLine("¿Cuánto quiere que gane " + person + "?");
                    string Salary = Console.ReadLine();
                    int salary = Int32.Parse(Salary);
                    foreach (Employee employee in employeeList)
                    {
                        if (person == employee.FirstName())
                        {
                            employee.changeSalary(salary);
                        }

                    }
                    Console.WriteLine("Ahora " + person + " tiene un sueldo de $" + salary);
                }
                else if (option == "3")
                {
                    Console.WriteLine("¿A quién desea cambiar el horario de trabajo?");
                    string person = Console.ReadLine();
                    Console.WriteLine("¿A qué hora debe comenzar a trabajar " + person + "(HH/MM)?");
                    string startTime = Console.ReadLine();
                    Console.WriteLine("¿A qué hora debe terminar de trabajar " + person + "(HH/MM)?");
                    string endTime = Console.ReadLine();
                    foreach(Employee employee in employeeList)
                    {
                        if (person == employee.FirstName())
                        {
                            employee.changeworkingHours(startTime, endTime);
                        }
                    }
                    Console.WriteLine("Ahora " + person + " trabaja desde las " + startTime + " hasta las " + endTime);
                }
                else if (option == "4")
                {
                    Console.WriteLine("¿Cuántos clientes desea agregar?");
                    string Answer = Console.ReadLine();
                    int answer = Int32.Parse(Answer);
                    clients = clients + answer;
                    while (i <= clients)
                    {
                        Console.WriteLine("Datos del cliente" + " " + i + ":");
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
                    Console.WriteLine("El nuevo total de clientes es " + clients);
                }
                else if (option == "5")
                {
                    Console.WriteLine("¿Cuántos trabajadores desea agregar?");
                    string Answer = Console.ReadLine();
                    int answer = Int32.Parse(Answer);
                    employees = employees + answer;
                    while (n <= employees)
                    {
                        Console.WriteLine("Datos del empleado" + " " + n + ":");
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
                        Console.WriteLine("¿Cuál es su lugar de trabajo?");
                        string workplace = Console.ReadLine();
                        Console.WriteLine("¿Cuál es su salario?");
                        string Salary = Console.ReadLine();
                        int salary = Int32.Parse(Salary);
                        Console.WriteLine("¿A qué hora empieza a trabajar? (HH:MM)");
                        string startTime = Console.ReadLine();
                        Console.WriteLine("¿A qué hora termina de trabajar? (HH:MM)");
                        string endTime = Console.ReadLine();
                        Employee e = new Employee(rut, firstName, lastName, birth, nacionality, workplace, salary, startTime, endTime);
                        employeeList.Add(e);

                        ++n;
                    }
                    Console.WriteLine("El nuevo total de trabajadores es " + employees);
                }
                else if (option == "6")
                {
                    Console.WriteLine("¿Cuántos productos desea agregar?");
                    string Answer = Console.ReadLine();
                    int answer = Int32.Parse(Answer);
                    products = products + answer;
                    while (m <= products)
                    {
                        Console.WriteLine("Datos del producto" + " " + m + ":");
                        Console.WriteLine("¿Cuál es su nombre?");
                        string name = Console.ReadLine();
                        Console.WriteLine("¿Cuál es su precio?");
                        string Price = Console.ReadLine();
                        int price = Int32.Parse(Price);
                        Console.WriteLine("¿Cuál es su marca?");
                        string brand = Console.ReadLine();
                        Console.WriteLine("¿cuál es su stock?");
                        string Stock = Console.ReadLine();
                        int stock = Int32.Parse(Stock);
                        Producto p = new Producto(name, price, brand, stock);
                        productList.Add(p);

                        ++m;
                    }
                    Console.WriteLine("El nuevo total de productos es " + products);
                }
                else if (option == "7")
                {
                    Console.WriteLine("NOMBRE PRECIO MARCA STOCK");
                    foreach (Producto product in productList)
                    {
                        Console.WriteLine(product.Name() + " " + product.Price() + " " + product.Brand() + " " + product.Stock());
                        Console.WriteLine("");
                    }
                }
                else if (option == "8")
                {
                    Console.WriteLine("¿Qué producto desea agregar al carro?");
                    string product = Console.ReadLine();
                    Console.WriteLine("¿Cuántas unidades de este producto desea llevar?");
                    string Number = Console.ReadLine();
                    int number = Int32.Parse(Number);
                    foreach(Producto prod in productList)
                    {
                        if (product == prod.Name())
                        {
                            if (prod.Stock() < number)
                            {
                                Console.WriteLine("Lo sentimos, no nos quedan las unidades solicitadas.");
                                break;
                            }
                            else
                            {
                                prod.NewStock(number);
                                Console.WriteLine("Se agregaron " + number + " unidades de " + product + " al carro con éxito.");
                                Console.WriteLine("Quedan " + prod.Stock() + " unidades de " + product + " disponibles.");
                                shoppingCart.Add(prod);
                            }
                        }
                    }
                }
                else if (option == "9")
                {
                    Console.WriteLine("¿Cuál cliente va a comprar?");
                    string person = Console.ReadLine();
                    Console.WriteLine("¿Quién atenderá la caja?");
                    string cashier = Console.ReadLine();
                    foreach(Employee employee in employeeList)
                    {
                        foreach(Client c in clientList)
                        {
                            if (cashier == employee.FirstName() && "cajero" == employee.Workplace() && person == c.FirstName())
                            {
                                c.Purchase(c.Income(), shoppingCart, employee);
                            }
                        }
                        
                    }
                }
                else if (option == "10")
                {
                    Console.WriteLine("Hasta luego. Vuelva pronto.");
                    ++C;
                }
                else
                {
                    Console.WriteLine("ERROR: La opción ingresada no es válida. Intente de nuevo.");
                }
            }
            Console.ReadKey();
        }
    }
}
