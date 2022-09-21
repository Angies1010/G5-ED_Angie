//definir variable y hacer operaciones basicas resultado con console
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    public class Calculadora
    {
        static int suma(int a, int b)
        {
            int suma = a + b;
            return suma;
        }

        static int resta(int a, int b)
        {
            int resta = a - b;
            return resta;
        }

        static int multiplicacion(int a, int b)
        {
            int multi = a * b;
            return multi;
        }

        static int division(int a, int b)
        {
            int divi = a / b;
            return divi;

            static void Main(string[] args)
            {
                int a, b;
                Console.Write("\n" + "Introduce un número: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("\n" + "Introduce otro número: ");
                b = int.Parse(Console.ReadLine());

                Console.Write("\n" + "Seleccione una opción: " + "\n" + "\n");
                Console.Write("\n" + "     1º) Suma" + "\n" + "     2º) Resta" + "\n" + "     3º) Multiplicación" + "\n" + "     4º) División" + "\n" + "     5º) Salir del Programa" + "\n" + "\n");

                switch (Console.Read())

                {
                    case '1':
                        Console.Write("\n" + "    Suma = " + suma(a, b));
                        break;

                    case '2':
                        Console.Write("\n" + "    Resta = " + resta(a, b));
                        break;

                    case '3':
                        Console.Write("\n" + "    Multiplicación = " + multiplicacion(a, b));
                        break;

                    case '4':
                        Console.Write("\n" + "    División = " + division(a, b));
                        break;

                    case '5':
                        Console.Write("\n" + "     ( A darleeeee));
                        break;
                }
                Console.ReadKey();

            }
        }
    }
}