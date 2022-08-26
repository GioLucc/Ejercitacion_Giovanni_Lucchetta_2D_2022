namespace Anotaciones__Clase_2_
{
    public class GuitarraBase
    {
        //atributos

        public string marca;
        public int precio;
        public string material;
        public bool estaAfinada; // Por defecto es false
        public int cantidadCuerdas;

        // comportamientos

        public bool AfinarGuitarra()
        {
            estaAfinada = true;
            return estaAfinada;
        }

        // Sobrecarga: agregarle una nueva funcionalidad a algo ya definido

        public void SubirDePrecio(int aumento, int cantidadCuerdas = 6) // parametro opcional
        {
            precio *= aumento;
        }

        public void SubirDePrecio(string marca, int aumento)
        {
            if (marca == "Gibson" || marca == "Fender" || material != "Roble")
            {
                precio *= aumento;
            }
        }
    }
}