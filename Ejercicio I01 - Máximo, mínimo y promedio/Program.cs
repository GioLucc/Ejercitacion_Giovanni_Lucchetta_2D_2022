using System;

// Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
// Giovanni Lucchetta

namespace Ejercicio_I01___Máximo__mínimo_y_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber;
            int acumulator;
            int highestNumber;
            int lowestNumber;
            int averageNumber;

            highestNumber = 0;
            lowestNumber = 0;
            acumulator = 0;

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Enter a number please: ");
                enteredNumber = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    highestNumber = enteredNumber;
                    lowestNumber = enteredNumber;
                }
                else
                {
                    if (highestNumber < enteredNumber)
                    {
                        highestNumber = enteredNumber;
                    }
                    else
                    {
                        if (lowestNumber > enteredNumber)
                        {
                            lowestNumber = enteredNumber;
                        }
                    }
                }

                acumulator += enteredNumber;
            }

            averageNumber = acumulator / 5;

            Console.WriteLine("El valor maximo es: {0}\n El valor minimo es: {1}\n El promedio es: {2}", highestNumber, lowestNumber, averageNumber);
            Console.WriteLine($"El valor maximo es: {highestNumber}\n El valor minimo es: {lowestNumber}\n El promedio es: {averageNumber}");


        }
    }
}
