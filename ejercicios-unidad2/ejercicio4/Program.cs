using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // consigna: Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo. 
            // sueldo fijo: 15000 5% comision sobre total facturado

            // declarar

            float totalFacturado, comision, sueldoFinal ;



            // pedir

            Console.WriteLine("Ingrese el total facturado ");
            totalFacturado = float.Parse(Console.ReadLine());

    
            // hacer

            comision = 5 * totalFacturado / 100 ;
            sueldoFinal = comision + 15000;

            // mostrar

            Console.WriteLine("El sueldo total a pagar es: " + sueldoFinal);

        }
    }
}
