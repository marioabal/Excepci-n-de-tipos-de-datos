using System;

namespace Operaciones_aritméticas
{
    class Program
    {
        static void Main(string[] args)
        {

            char op = 's';
            int menu = 0;
            int valor1 = 0;
            int valor2 = 0;
            int total = 0;

            string linea;

            while (op == 's')
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");

                Console.Write("Opción: ");
                menu = int.Parse(Console.ReadLine());

                if (menu == 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("<< Suma >>");
                    
                    Console.Write("Ingresar primer valor: ");

                    try
                    {
                        linea = Console.ReadLine();
                        valor1 = int.Parse(linea);
                    }
                    catch
                    {
                        Console.WriteLine("Error. Dato inválido.");
                        Console.Write("Ingresar primer valor: ");
                        linea = Console.ReadLine();
                        valor1 = int.Parse(linea);
                    }

                    Console.Write("Ingresar segundo valor: ");

                    try
                    {
                        linea = Console.ReadLine();
                        valor2 = int.Parse(linea);
                    }
                    catch
                    {
                        Console.WriteLine("Error. Dato inválido.");
                        Console.Write("Ingresar segundo valor: ");
                        linea = Console.ReadLine();
                        valor2 = int.Parse(linea);
                    }

                    total = valor1 + valor2;

                    Console.WriteLine("Total: " + total);
                    Console.WriteLine(" ");
                }
                else if (menu == 2)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("<< Resta >>");

                    Console.Write("Ingresar primer valor: ");

                    try
                    {
                        linea = Console.ReadLine();
                        valor1 = int.Parse(linea);
                    }
                    catch
                    {
                        Console.WriteLine("Error. Dato inválido.");
                        Console.Write("Ingresar primer valor: ");
                        linea = Console.ReadLine();
                        valor1 = int.Parse(linea);
                    }

                    Console.Write("Ingresar segundo valor: ");

                    try
                    {
                        linea = Console.ReadLine();
                        valor2 = int.Parse(linea);
                    }
                    catch
                    {
                        Console.WriteLine("Error. Dato inválido.");
                        Console.Write("Ingresar segundo valor: ");
                        linea = Console.ReadLine();
                        valor2 = int.Parse(linea);
                    }

                    total = valor1 - valor2;

                    Console.WriteLine("Total: " + total);
                    Console.WriteLine(" ");
                }
                else if (menu == 3)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("<< Multiplicación >>");

                    Console.Write("Ingresar primer valor: ");

                    try
                    {
                        linea = Console.ReadLine();
                        valor1 = int.Parse(linea);
                    }
                    catch
                    {
                        Console.WriteLine("Error. Dato inválido.");
                        Console.Write("Ingresar primer valor: ");
                        linea = Console.ReadLine();
                        valor1 = int.Parse(linea);
                    }

                    Console.Write("Ingresar segundo valor: ");

                    try
                    {
                        linea = Console.ReadLine();
                        valor2 = int.Parse(linea);
                    }
                    catch
                    {
                        Console.WriteLine("Error. Dato inválido.");
                        Console.Write("Ingresar segundo valor: ");
                        linea = Console.ReadLine();
                        valor2 = int.Parse(linea);
                    }

                    total = valor1 * valor2;

                    Console.WriteLine("Total: " + total);
                    Console.WriteLine(" ");
                }
                else if (menu == 4)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("<< División >>");

                    Console.Write("Ingresar primer valor: ");

                    try
                    {
                        linea = Console.ReadLine();
                        valor1 = int.Parse(linea);
                    }
                    catch
                    {
                        Console.WriteLine("Error. Dato inválido.");
                        Console.Write("Ingresar primer valor: ");
                        linea = Console.ReadLine();
                        valor1 = int.Parse(linea);
                    }

                    Console.Write("Ingresar segundo valor: ");

                    try
                    {
                        linea = Console.ReadLine();
                        valor2 = int.Parse(linea);
                    }
                    catch
                    {
                        Console.WriteLine("Error. Dato inválido.");
                        Console.Write("Ingresar segundo valor: ");
                        linea = Console.ReadLine();
                        valor2 = int.Parse(linea);
                    }

                    total = valor1 / valor2;

                    Console.WriteLine("Total: " + total);
                    Console.WriteLine(" ");
                }
                else if (menu == 5)
                {
                    op = 'n';
                }

            }
        }
    }
}
