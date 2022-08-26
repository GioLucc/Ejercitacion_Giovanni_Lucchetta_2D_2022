using System;

namespace BibliotecaDeClases
{
    public class Cuenta
    {
        public string razonSocialDelTitular;
        public int cantidadDineroEnCuenta;

        public Cuenta(string titularDeLaCuenta, int cantidadDineroEnCuenta)
        {
            this.razonSocialDelTitular = titularDeLaCuenta;
            this.cantidadDineroEnCuenta = cantidadDineroEnCuenta;
        }

        public int GetDineroEnCuenta()
        {
            return cantidadDineroEnCuenta;
        }

        public string GetRazonSocial()
        {
            return razonSocialDelTitular;
        }

        public string MostrarDatosCuenta()
        {
            return $"La razón social de esta cuenta es {razonSocialDelTitular} y la cantidad de dinero que posee es {cantidadDineroEnCuenta}";
        }

        public int IngresarDinero(int dineroAIngresar)
        {
            int retorno = 0;

            if(dineroAIngresar > 0)
            {
                cantidadDineroEnCuenta += dineroAIngresar;
                retorno = 1;
            }
               
            return retorno;
        }       
        public int RetirarDinero(int dineroARetirar)
        {
            int retorno = 0;

            if(dineroARetirar > 0)
            {
                cantidadDineroEnCuenta -= dineroARetirar;
                retorno = 1;
            }

            return retorno;


        }
    }
}
