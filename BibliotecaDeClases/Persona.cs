using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Persona
    {
       public string nombre;
       public string fechaDeNacimiento;
       public int dni;
       public int edadActual;

        public Persona(string nombre, string fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public int SetNombre(string nombre)
        {
            int retorno = 0;

            if(nombre is not null)
            {
                this.nombre = nombre;
                retorno = 1;
            }

            return retorno;
        } 
        public int SetFechaDeNacimiento(string fechaDeNacimiento)
        {
            int retorno = 0;

            if(fechaDeNacimiento is not null)
            {
                this.fechaDeNacimiento = fechaDeNacimiento;
                retorno = 1;
            }

            return retorno;
        }
        public int SetDNI(int dni)
        {
            int retorno = 0;

            if(dni > 0)
            {
                this.dni = dni;
                retorno = 1;
            }

            return retorno;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetFechaDeNacimiento()
        {
            return fechaDeNacimiento;
        }

        public int GetDNI()
        {
            return dni;
        }

        internal double CalcularEdad(string fechaNacimientoRecibida)
        {
            DateTime fechaNacimiento;
            DateTime fechaActual;
            TimeSpan diferenciaDeDias;
            double diasDeVida;
            double añosDeEdad;

            fechaNacimiento = DateTime.ParseExact(fechaDeNacimiento, "dd/MM/yyyy", null);
            fechaActual = DateTime.Now;

            diferenciaDeDias = fechaActual - fechaNacimiento;
            diasDeVida = diferenciaDeDias.TotalDays;
            añosDeEdad = Math.Floor(diasDeVida / 365);

            return añosDeEdad;
        }

        public string MostrarDatos()
        {
           return $"El nombre de la persona es: {nombre}, su edad es: {CalcularEdad(fechaDeNacimiento)}, su DNI es: {dni}! ";
        }

        public string EsMayorDeEdad()
        {
            string esMayor;

            esMayor = "No es mayor de edad";

            if(CalcularEdad(fechaDeNacimiento) > 17)
            {
                esMayor = "Es mayor de edad";
            }
            return esMayor;
        }


    }
}
