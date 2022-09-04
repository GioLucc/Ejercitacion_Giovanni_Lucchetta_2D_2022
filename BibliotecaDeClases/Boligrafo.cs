using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Boligrafo
    {
        const short CANTIDADTINTAMAXIMA = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            int posibleNuevaTinta;

            posibleNuevaTinta = this.tinta + tinta;

            if (posibleNuevaTinta > -1 && posibleNuevaTinta <= CANTIDADTINTAMAXIMA)
            {
                this.tinta = (short)posibleNuevaTinta;
            }
        }

        public void Recargar()
        {
            //preguntar que onda la reutilización del recargar, la función sobrecargaria la tinta en caso de no calcularla.
            this.tinta = CANTIDADTINTAMAXIMA;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool dibujeAlgo = false;
            dibujo = "";

            for(int i = 0; i < gasto*-1; i++)
            {
                if(this.tinta > 0)
                {
                    dibujo += "*";
                    SetTinta(-1);
                    dibujeAlgo = true;
                }
                else
                {
                    break;
                }
            }

            return dibujeAlgo;
        }

        
    }
}
