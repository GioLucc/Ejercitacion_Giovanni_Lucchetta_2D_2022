using System;
using BibliotecaDeClases;
/*
    La clase Estudiante:

    Tendrá un constructor estático que inicializará el atributo estático random.
    Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
    El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
    El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
    El método privado CalcularPromedio retornará el promedio de las dos notas.
    El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
    El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
    Nombre, apellido y legajo.
    Nota del primer y segundo parcial.
    Promedio.
    Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
    Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
    Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
    Mostrar los datos de todos los alumnos. 

 */

namespace Ejercicio_I03___El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante primerEstudiante = new Estudiante("Lucchetta","142233","Giovanni");
            Estudiante segundoEstudiante = new Estudiante("Mejias", "142535", "Thiago");
            Estudiante tercerEstudiante = new Estudiante("Taboada", "142434", "Ezequiel");

            primerEstudiante.setNotaPrimerParcial(6);
            primerEstudiante.setNotaSegundoParcial(10);
            
            segundoEstudiante.setNotaPrimerParcial(6);
            segundoEstudiante.setNotaSegundoParcial(10);

            tercerEstudiante.setNotaPrimerParcial(4);
            tercerEstudiante.setNotaSegundoParcial(3);

            Console.WriteLine(primerEstudiante.Mostrar());
            Console.WriteLine(segundoEstudiante.Mostrar());
            Console.WriteLine(tercerEstudiante.Mostrar());
        }
    }
}
