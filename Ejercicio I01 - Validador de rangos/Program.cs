using System;
using BibliotecaValidadora;

namespace Ejercicio_I01___Validador_de_rangos
{
    /*
     Consigna
    Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

    bool Validar(int valor, int min, int max)

    valor: dato a validar.
    min: mínimo valor incluido.
    max: máximo valor incluido.
    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

    Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

    IMPORTANTE
    Utilizar variables escalares, NO utilizar vectores/arrays.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int promedio;
            int valorMinimoIngresado;
            int valorMaximoIngresado;
            int acumulador;

            acumulador = 0;
            valorMinimoIngresado = 0;
            valorMaximoIngresado = 0;

            for(int i = 0; i < 10; i++)
            {

                Console.WriteLine("Ingrese un numero");
                numeroIngresado = int.Parse(Console.ReadLine());

                while(!Validadora.ValidarNumerosEnRango(numeroIngresado, -100, 100))
                {
                    Console.WriteLine("Error Ingrese un numero correcto");
                    numeroIngresado = int.Parse(Console.ReadLine());
                }

                if (i == 0)
                {
                    valorMinimoIngresado = numeroIngresado;
                    valorMaximoIngresado = numeroIngresado;
                }
                else
                {
                    if(numeroIngresado < valorMinimoIngresado)
                    {
                        valorMinimoIngresado = numeroIngresado;
                    }
                    else
                    {
                        if(numeroIngresado > valorMaximoIngresado)
                        {
                            valorMaximoIngresado = numeroIngresado;
                        }
                    } 
                }

                acumulador += numeroIngresado;
            }

            promedio = acumulador / 10;

            Console.WriteLine($"El numero mas alto ingresado fue {valorMaximoIngresado}");
            Console.WriteLine($"El numero mas bajo ingresado fue {valorMinimoIngresado}");
            Console.WriteLine($"El promedio fue {promedio}");


        }
    }
}
