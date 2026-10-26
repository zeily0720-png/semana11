using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana11
{
    internal class validador
    {
        public static int leerEnteros(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    if (valor < 1 || valor > 5)
                    {
                        Console.WriteLine("Error:de rango(1-5)");
                        continue;
                    }
                    return valor;
                }
                Console.WriteLine("Error:Ingresar un valor numerico entero");
            }
        }
        public static double LeerDecimal(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.WriteLine(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    if (valor < 1 || valor > 20)
                    {
                        Console.WriteLine("Error:Las notas deben ser enteros(0-20)");
                        continue;

                    }
                    return valor;
                }
                Console.WriteLine("Error:El valor debe ser numerico decimal");
            }
        }
        public static string Leertexto(string mensaje)
        {
            while (true)
            {
                Console.WriteLine(mensaje);
                string valor = Console.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(valor))
                    return valor;
                Console.WriteLine("Error:este campo no puede estar vacio");

            }
        }
    }
}
