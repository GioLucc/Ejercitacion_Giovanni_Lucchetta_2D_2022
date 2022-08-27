using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaDeClases
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;

        //Crear atributo privado no pude
        // No se como hacer el constructor estatico
        // Porque no se puede inicializar acá y solo se puede ne la función
       
        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void setNotaPrimerParcial(int nota)
        {
            if(nota > 0)
            {
                notaPrimerParcial = nota;

            }
        }
        public void setNotaSegundoParcial(int nota)
        {
            if(nota > 0)
            {
                notaSegundoParcial = nota;
            }
        }

        private float CalcularPromedio()
        {
            int sumaDeNotas;
            float promedio;
            promedio = 0;

            if (notaPrimerParcial > 0 && notaPrimerParcial > 0)
            {
                sumaDeNotas = notaPrimerParcial + notaSegundoParcial;
                promedio = sumaDeNotas / 2;
            }
            return promedio;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal;
            notaFinal = -1;
            Random rand = new Random();

            if(notaPrimerParcial > 3 && notaSegundoParcial > 3)
            {
                notaFinal = rand.Next(4, 11);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"El nombre del alumno es: {nombre}.\n El apellido del alumno es: {apellido}.\nEl Legajo del alumno es: {legajo}.\n");
            sb.Append($"La nota de primer parcial es: {notaPrimerParcial} y la nota del segundo parcial es: {notaSegundoParcial}");
            if(CalcularNotaFinal() != -1)
            {
                sb.Append($"\n\nLa nota del FINAL ES: {CalcularNotaFinal()}\n\n");

            }
            else
            {
                sb.Append($"\n\nAlumno desaprobado\n\n");
            }

            return sb.ToString();
        }

        


    }

}
