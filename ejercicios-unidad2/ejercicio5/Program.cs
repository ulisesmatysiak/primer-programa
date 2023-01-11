using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // consigna: Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

            // declarar

            float n1, n2, n3;
            float promedio ;


            // pedir

            Console.WriteLine("Ingrese la primera nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota: ");
            n3 = float.Parse(Console.ReadLine());

            // hacer

            promedio = (n1 + n2 + n3) / 3;

            // mostrar

            Console.WriteLine("El promedio es: " + promedio.ToString("0.00"));


        }
    }
}
