using System.Text;

namespace BibliotecaRegistrate
{
    public class Ingresante
    {
        private string cursos = string.Empty;
        private string direccion = string.Empty;
        private int edad;
        private string genero = string.Empty;
        private string nombre = string.Empty;
        private string pais = string.Empty;

        public Ingresante(string nombre,string direccion, int edad, string genero, string pais,string cursos)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder @string = new StringBuilder();

            @string.AppendLine($"Nombre: {nombre}");
            @string.AppendLine($"Dirección: {direccion}");
            @string.AppendLine($"Edad: {edad}");
            @string.AppendLine($"Genero: {genero}");
            @string.AppendLine($"Pais: {pais}");
            @string.AppendLine($"Curso/s: {cursos}");

            return @string.ToString();
        }
    }
}