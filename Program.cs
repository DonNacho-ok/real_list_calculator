using System;
using System.Linq;

namespace lista_reales
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float total = 0;
            Console.WriteLine("Bienvenido a la calculadora de listas de numeros reales");
            Console.WriteLine("Debera ingresar 10 numeros reales entre el 1 y el 100");
            float[] ListaNumeros = new float[10];
            int contador = 0;
            while(contador < 10)
            {
                try
                {
                    Console.WriteLine($"Ingrese el {contador + 1}º numero: ");
                    int aux = Convert.ToInt32(Console.ReadLine());
                    while (aux > 100)
                    {
                        Console.WriteLine("Ha ingresado un numero mas grande que 100, intente devuelta");
                        aux = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                    ListaNumeros[contador] = aux;
                    contador++;
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Error, intente denuevo.");
                }
            }
            Console.WriteLine("Ok, vamos a calcular.");
            Console.WriteLine("El numero mas alto es el "+ListaNumeros.Max());
            Console.WriteLine("El Numero mas bajo es el " + ListaNumeros.Min());
            foreach(float num in ListaNumeros)
            {
                total += num;
            }
            Console.WriteLine("La suma total de todos los numeros es de " + total);
            float prom = total / 10;
            Console.WriteLine("El promedio del total es de " + prom);
        }
    }
}
