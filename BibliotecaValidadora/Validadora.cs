using System;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaValidadora
{
    public static class Validadora
    {
        public static bool ValidarNumerosEnRango(int valor, int min, int max)
        {
            bool retorno;

            retorno = false;

            if(valor <= max && valor >= min)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool ValidarRespuesta(char letraIngresada)
        {
            bool retorno;

            retorno = false;

            if(letraIngresada == 's' || letraIngresada == 'S')
            {
                retorno = true;
            }

            return retorno;
        }

    }
}
