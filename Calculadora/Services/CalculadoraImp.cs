using System;
using System.Collections.Generic;

namespace Calculadora.Services
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            listahistorico.Insert(0, "Res: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listahistorico.Insert(0, "Res: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listahistorico.Insert(0, "Res: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
                
            int resultado = num1 / num2;
            listahistorico.Insert(0, "Res: " + resultado + " - data: " + data);
            return resultado;
        }

        public List<string> Historico()
        {
            if (listahistorico.Count > 3)
            {
                listahistorico.RemoveRange(3, listahistorico.Count - 3);
            }
            return listahistorico;
        }
    }
}
