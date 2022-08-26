using System;
using System.Runtime.ConstrainedExecution;
using BibliotecaDeClases;

/*
     Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

    Deberá tener los atributos:

    titular que contendrá la razón social del titular de la cuenta.
    cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
    Construir los siguientes métodos para la clase:

    Un constructor que permita inicializar todos los atributos.
    Un método getter para cada atributo.
    mostrar retornará una cadena de texto con todos los datos de la cuenta.
    ingresar recibirá un monto para acreditar a la cuenta, Si el monto ingresado es negativo, no se hará nada.
    retirar recibirá un monto para debitar de la cuenta.La cuenta puede quedar en negativo.
    En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
*/
namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta Gonchalito = new Cuenta("Gatos Sociales", 2000000);
            Cuenta MauroForense = new Cuenta("Asociación La Plata", 5000000);
            Cuenta Maximiliano = new Cuenta("El Gobierno de La Pampa", 10000000);

            Console.WriteLine(Gonchalito.MostrarDatosCuenta());

            Gonchalito.IngresarDinero(500000);

            Console.WriteLine(Gonchalito.MostrarDatosCuenta());

            Gonchalito.RetirarDinero(2500000);

            Console.WriteLine(Gonchalito.MostrarDatosCuenta());

            Gonchalito.RetirarDinero(200000);

            Console.WriteLine(Gonchalito.MostrarDatosCuenta());


        }
    }
}
