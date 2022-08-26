using System;

namespace Anotaciones__Clase_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guitarra guitarraNazi = new Guitarra("Gibson");
            Guitarra guitarraHeidenreicheana = new Guitarra("Heidenrecih", 1200, "Titanio", true, 24);
        }
    }
}
