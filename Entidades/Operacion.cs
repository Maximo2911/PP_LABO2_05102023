using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        //campos privados((el profe lo llama atributo))
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        //Propiedades
        public Numeracion PrimerOperando { get;set; } 
        public Numeracion SegundoOperando { get;set; }

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }



        //METODOS
        public int OperacionNumeros(Numeracion primerOperando, Numeracion segundoOperando, char caracter) //caracter para poder llamar a la funcion Operar 
        {
            int resultado = 0; // Numeracion resultado
            char operador = Operar(caracter);
            switch(operador)
            {
                case '+':
                    resultado = (int)(primerOperando + segundoOperando); 
                    break;
                case '-':
                    resultado = (int)(primerOperando - segundoOperando); 
                    break;
                case '*':
                    resultado = (int)(primerOperando * segundoOperando); 
                    break;
                case '/':
                    resultado = (int)(primerOperando / segundoOperando); 
                    break;
            }
            return resultado;
        }
        public char Operar(char operador) //puede ser tambien con cadenas de caracteres(string)
        {
            if (!(operador.ToString() == "")) 
            {
                return operador;
            }
            return '+';
        }



    }
}
