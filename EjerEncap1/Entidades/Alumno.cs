using System;

namespace Entidades
{
    public class Alumno
    {
        public int nota1;
        public int nota2; 
        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public int CalcularNotaFinal()
        {
            if(this.nota1 > 4 && this.nota2 > 4)
            {
                return (this.nota1 + this.nota2) / 2; 
            }
            else
            {
                return 2; 
            }
        }
    }
}
