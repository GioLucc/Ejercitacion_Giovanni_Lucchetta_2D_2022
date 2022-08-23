
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        string ageString;
        int age;
        bool conversionResult;

        // Arrays

        string[] nombres = new string[3];
        nombres[0] = "Gianni";
        nombres[1] = "Giovanni";
        nombres[2] = "Esteban";

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine(nombres[i]);
        }

        string[] paises = { "\nBrasil", "Argentina", "Chile" }; // El limite está seteado por los valores dentro de las llaves

        foreach (string pais in paises)
        {
            Console.WriteLine(pais);
        }

        // Arrays

        Console.WriteLine("\nIngrese su nombre");
        name = Console.ReadLine();

        Console.WriteLine("Ingrese su edad");
        ageString = Console.ReadLine();


        // 1era manera de parsear haciendo que podamos obtener un booleano para comprobar la conversión.
        conversionResult = int.TryParse(ageString, out age);
        Console.WriteLine("Se pudo convertir? {0}", conversionResult);

        // 2da manera de parsear no contemplando si falla o no.
        age = int.Parse(ageString);


        //name = Console.ReadLine();

        Console.WriteLine("Su edad es: " + age + " Y su nombre es : " + name);

        // interpolado
        Console.WriteLine($"La edad es: {age}");

        if (conversionResult != false)
        {
            Console.WriteLine("Su nombre es: {0} y su edad es: {1}!", name, age);
        }

        // Especificadores de formato precio:C2 agrega un $
    }
}