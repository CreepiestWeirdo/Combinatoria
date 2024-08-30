using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MathNet.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Combinatoria
{
    public static class Formulas
    {
        public static void PermutacionRepeticion()
        {
            Console.WriteLine("Ingrese el dato para permutacion con repeticion: ");
            string dato = Console.ReadLine();

            char[] elementos = dato.ToCharArray();

            // Crear un diccionario para contar las repeticiones de cada elemento
            Dictionary<char, int> contadorRepeticion = new Dictionary<char, int>();

            foreach (char elemento in elementos)
            {
                if (contadorRepeticion.ContainsKey(elemento))
                {
                    contadorRepeticion[elemento]++;
                }
                else
                {
                    contadorRepeticion[elemento] = 1;
                }
            }

            // Calcular el factorial del total de elementos
            double totalFactorial = SpecialFunctions.Factorial(elementos.Length);

            // Calcular el producto de los factoriales de las repeticiones
            double productoFactoriales = 1.0;
            foreach (var count in contadorRepeticion.Values)
            {
                productoFactoriales *= SpecialFunctions.Factorial(count);
            }

            // Calcular las permutaciones con repetición
            double permutacionRepeticion = totalFactorial / productoFactoriales;

            Console.WriteLine($"Permutaciones con repetición para \"{dato}\": {permutacionRepeticion}");

        }


        public static void Permutacion()
        {
            Console.WriteLine("Ingrese el dato para permutacion con repeticion: ");
            int dato = int.Parse(Console.ReadLine());

            double permutacion = SpecialFunctions.Factorial(dato);

            Console.WriteLine($"Permutaciones sin repetición para \"{dato}\": {permutacion}");

        }

        public static void Combinacion()
        {
            Console.WriteLine("Ingrese el numero de elementos  para la Combinacion sin Repeticion: ");
            int elementos = int.Parse(Console.ReadLine());

            Console.WriteLine("Escogidos de a: ");
            int escogidos = int.Parse(Console.ReadLine());

            double combinacion = Combinatorics.Combinations(elementos, escogidos);

            Console.WriteLine($"Combinacion sin repetición para \"{elementos}\" elementos tomados de \"{escogidos}\" es \"{combinacion}\".");

        }

        public static void CombinacionRepeticion()
        {
            Console.WriteLine("Ingrese el numero de elementos para la Combinacion con Repeticion: ");
            int elementos = int.Parse(Console.ReadLine());

            Console.WriteLine("Escogidos de a: ");
            int escogidos = int.Parse(Console.ReadLine());

            double combinacionRepeticion = Combinatorics.Combinations(elementos + escogidos - 1, escogidos);

            Console.WriteLine($"Combinacion con repetición para \"{elementos}\" elementos tomados de \"{escogidos}\" es \"{combinacionRepeticion}\".");

        }

        public static void Variacion()
        {
            Console.WriteLine("Ingrese el numero de elementos  para la Variacion sin Repeticion: ");
            int elementos = int.Parse(Console.ReadLine());

            Console.WriteLine("Escogidos de a: ");
            int escogidos = int.Parse(Console.ReadLine());

            double variacion = SpecialFunctions.Factorial(elementos) / SpecialFunctions.Factorial(elementos - escogidos);   

            Console.WriteLine($"Variacion sin repetición para \"{elementos}\" elementos tomados de \"{escogidos}\" es \"{variacion}\".");
        }

        public static void VariacionRepeticion()
        {
            Console.WriteLine("Ingrese el numero de elementos  para la Variacion con Repeticion: ");
            int elementos = int.Parse(Console.ReadLine());

            Console.WriteLine("Escogidos de a: ");
            int escogidos = int.Parse(Console.ReadLine());

            double variacionRepeticion = SpecialFunctions.Factorial(elementos) / SpecialFunctions.Factorial(elementos - escogidos);

            Console.WriteLine($"Variacion sin repetición para \"{elementos}\" elementos tomados de \"{escogidos}\" es \"{variacionRepeticion}\".");
        }

    }
}
