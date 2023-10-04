using System.Text;

namespace Entidades
{
    public class Numeracion
    {
        //campos(atributos)
        private ESistema sistema;
        private double valorNumerico;

        //propiedades
        public ESistema Sistema{get;}
        public string Valor{get;}

        //CONSTRUCTORES
        public Numeracion(ESistema sistema, double valorNumerico)
        {
            this.sistema = sistema;
            this.valorNumerico = valorNumerico;
        }
        public Numeracion(ESistema sistema, string valorNumerico)
        {
            InicializarValores(valorNumerico, sistema);
        }

        //tipo anidado
        public enum ESistema
        {
            Decimal,
            Binario
        }

        //METODOS
        private void InicializarValores(string valor, ESistema sistema)
        {
            if (EsBinario(valor))
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if(int.TryParse(valor, out int valorEntero))
            {
                this.valorNumerico = valorEntero;
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }
        }

        public string ConvertirA(ESistema sistema)
        {

            if (sistema == ESistema.Binario)
            {
                //this.valorNumerico = (int)this.valorNumerico;
                string valorNumericoStr = (this.valorNumerico).ToString();
                string retorno = DecimalABinario(valorNumericoStr);
                return retorno;
            }
            else
            {
                return this.valorNumerico.ToString();
            }
            //operador terniario --> si la condicion es true, retorna lo que está a al derecha del ?, sino retorna lo que está dsp del :
            //return sistema == ESistema.Decimal ? DecimalABinario(this.valorNumerico.ToString()).ToString() : this.valorNumerico.ToString();

        }

        private bool EsBinario(string numero) //OK
        {
            for (int i = 0; i < numero.Length; i++)
            {
                if (!(numero[i] == '0' || numero[i] == '1')) 
                {
                    return false;
                }
            }
            return true;
        }

        private double BinarioADecimal(string numero)
        {
            if (EsBinario(numero))
            {
                if (!(numero.Length % 4 == 0)) //para completar el numero binario
                {
                    int longitud = numero.Length;
                    for (int i = 0; (longitud + i) % 4 != 0; i++)
                    {
                        numero = "0" + numero;
                    }
                }

                char[] caracteres = numero.ToCharArray();//creo una lista con los caracteres del numero binario
                Array.Reverse(caracteres);//doy vuelta la lista
                string numeroDadoVuelta = new string(caracteres);//uso el constructor del string q toma un arreglo de caracteres y crea una nueva cadena con esos caracteres

                double acumulador = 0;
                for(int j = 0; numero.Length - j != 1; j++)
                {
                    if (numeroDadoVuelta[j] == 1)
                    {
                        double numeroElevado = Math.Pow(2, j);  
                        acumulador += numeroElevado;
                    }
                }

                return acumulador;
            }
            else 
            {
                return 0; 
            }
        }

        private string DecimalABinario(int numero)
        {
            List<int> lista = new List<int>();

            if (numero == 0)
            {
                return "0";
            }
            
            
            while(numero > 0)
            {
                int resto = numero % 2;
                lista.Insert(0, resto);
                numero = numero / 2;
            }
            lista.Insert(0, numero); //! OBSERVAR

            StringBuilder mensajeRetorno = new StringBuilder();
            foreach (int i in lista)
            {
                mensajeRetorno.Append(i);
            }
            return mensajeRetorno.ToString();
        }
        private string DecimalABinario(string numero)
        {
            if(int.TryParse(numero, out int numeroEntero))
            {
                return DecimalABinario(numeroEntero);
            }
            return "Numero Invalido";
        }

        //Sobrecargas de operadores
        public static double operator +(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return double.Parse(primerOperador.ConvertirA(ESistema.Decimal)) + double.Parse(segundoOperador.ConvertirA(ESistema.Decimal));
        }
        public static double operator -(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return double.Parse(primerOperador.ConvertirA(ESistema.Decimal)) - double.Parse(segundoOperador.ConvertirA(ESistema.Decimal));
        }
        //--
        public static double operator *(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return double.Parse(primerOperador.ConvertirA(ESistema.Decimal)) * double.Parse(segundoOperador.ConvertirA(ESistema.Decimal));
        }
        public static double operator /(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return double.Parse(primerOperador.ConvertirA(ESistema.Decimal)) / double.Parse(segundoOperador.ConvertirA(ESistema.Decimal));
        }
        //--
        public static bool operator ==(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return primerOperador.sistema == segundoOperador.sistema ? true : false; 
        }
        public static bool operator !=(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return primerOperador.sistema != segundoOperador.sistema ? true : false;
        }
        //--
        public static bool operator ==(ESistema sistema, Numeracion primerOperador)
        {
            return primerOperador.sistema == sistema? true : false;
        }
        public static bool operator !=(ESistema sistema, Numeracion primerOperador)
        {
            return primerOperador.sistema != sistema ? true : false;
        }

















    }
}