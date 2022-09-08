using System.Globalization;

internal class Program
{
    /*
     Crear e instanciar el Dictionary<TKey,TValue> llamado
    maquinaExpendedora.

    Cargar por lo menos 10 elementos en formato clave-valor
    (clave=numero de posición, valor=nombre del producto)

    Una vez cargado, desarrollar el flujo del proyecto de consola de
    modo que:

    Al iniciarse muestre al usuario todos los productos con sus
    respectivos códigos.

    Pida al usuario elegir el número del producto que quiere

    Al seleccionar número, informar al usuario que recibió ese producto
    y volver a mostrar todos los productos SIN el producto que ya eligió

    El programa se repetirá indefinidamente hasta que el usuario elija la
    opción “S”.

    BONUS: Refactorizar el programa para que en vez de tener un
    diccionario INT – STRING, tengamos un diccionario INT – PRODUCTO
    (que contenga nombre y precio del producto)
     
     */

    private static void Main(string[] args)
    {

        Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();
        Dictionary<string,int > precioProductos = new Dictionary<string, int>();

        maquinaExpendedora.Add(2421, "Cafe");
        maquinaExpendedora.Add(2343, "Galletitas");
        maquinaExpendedora.Add(3333, "PapasPapas");
        maquinaExpendedora.Add(5554, "Bizcochitos");
        maquinaExpendedora.Add(4355, "Bizcochitos");
        maquinaExpendedora.Add(3536, "Bizcochitos");
        maquinaExpendedora.Add(5537, "Bizcochitos1");
        maquinaExpendedora.Add(2228, "Bizcochitos5");
        maquinaExpendedora.Add(2119, "PapasPapas13");
        maquinaExpendedora.Add(4210, "Galletitas");

        precioProductos.Add("Galletitas", 40);
        precioProductos.Add("Bizcochitos", 200);
        precioProductos.Add("Papas", 300);
        precioProductos.Add("Almendras", 400);
        precioProductos.Add("Caramelos", 555);





        // Para los diccionarios se usa KeyValuePair
        foreach (KeyValuePair<int,string> item in maquinaExpendedora)
        {
            Console.WriteLine($"El codigo del producto es {item.Key}, bajo el nombre de {item.Value}");
        } 
        
        foreach (KeyValuePair<int,string> item in maquinaExpendedora)
        {
           // Console.WriteLine($"El codigo del producto es {item.Key}, bajo el nombre de {item.Value}");

            if (item.Key == 2228)
            {
                Console.WriteLine(item.Value);
            }
        }

        maquinaExpendedora.Remove(2228);

        foreach (KeyValuePair<int, string> item in maquinaExpendedora)
        {
            Console.WriteLine($"El codigo del producto es {item.Key}, bajo el nombre de {item.Value}");
        }


    }
}