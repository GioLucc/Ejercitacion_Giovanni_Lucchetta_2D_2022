using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotaciones__Clase_2_
{
    public class Guitarra
    {
        //atributos

        public string marca;
        public int precio;
        public string material;
        public bool estaAfinada; // Por defecto es false
        public int cantidadCuerdas;

        // ctor


        public Guitarra(string marca)
        { 
            this.marca = marca;
            material = "No cargado";
        }

        public Guitarra(string marca, int precio, bool estaAfinada) : this(marca)
        {
            this.precio = precio;
            this.estaAfinada = estaAfinada;
        }

        public Guitarra(string marca, int precio, string material, bool estaAfinada, int cantidadCuerdas):this(marca,precio,estaAfinada)
        {
            ////this.cantidadCuerdas = cantidadCuerdas;
        }


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
            if(marca == "Gibson" || marca == "Fender" || material != "Roble")
            {
                precio *= aumento;
            }
        }

    }
}
