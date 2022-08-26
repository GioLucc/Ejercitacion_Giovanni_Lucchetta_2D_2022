using System;
using BibliotecaDeClases;

/* 
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

    Deberá tener los atributos:

    nombre
    fechaDeNacimiento
    dni
    Deberá tener un constructor que inicialice todos los atributos.

    Construir los siguientes métodos para la clase:

    Setter y getter para cada uno de los atributos.
    CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
    Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
    EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
    Instanciar 3 objetos de tipo Persona en el método Main.
    Mostrar quiénes son mayores de edad y quiénes no.

*/

namespace Ejercicio_I02___Vos_cuántas_primaveras_tenés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Silvia", "08/08/1962", 19898234);
            Persona personaDos = new Persona("Eride", "25/09/1935", 19754756);
            Persona personaTres = new Persona("Stefano", "15/02/2010", 12321321);

            Console.WriteLine(personaUno.MostrarDatos());
            Console.WriteLine(personaDos.MostrarDatos());
            Console.WriteLine(personaTres.MostrarDatos());

            Console.WriteLine(personaTres.EsMayorDeEdad());
            Console.WriteLine(personaUno.EsMayorDeEdad());



        }
    }
}
