using System;
using BibliotecaValidadora;

namespace Ejercicio_I02____Desea_continuar
{
    internal class Program
    {
        /*
         Consigna
        Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

        Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
         */
        static void Main(string[] args)
        {
            int numeroIngresado;
            char respuesta;

            do
            {
                Console.WriteLine("Ingrese un numero por favor!");
                numeroIngresado = int.Parse(Console.ReadLine());

                while(!Validadora.ValidarNumerosEnRango(numeroIngresado, -200,200))
                {
                    Console.WriteLine("Ingrese un numero por favor!");
                    numeroIngresado = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Quiere seguir ingresado numeros?");
                respuesta = char.Parse(Console.ReadLine());

            }while(Validadora.ValidarRespuesta(respuesta));

        }
    }
}
