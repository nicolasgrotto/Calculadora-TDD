using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models.Calculadora
{
    public class Calculadora
    {
        private List<string> Historico;

        public Calculadora()
        {
            Historico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            Historico.Insert(0, "Resultado da soma: " + (num1 + num2));

            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            Historico.Insert(0, "Resultado da subtração: " + (num1 - num2));

            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            Historico.Insert(0, "Resultado da multiplicação: " + (num1 * num2));

            return num1 * num2;
        }

        public int Potencia(int num1, int num2)
        {
            Historico.Insert(0, "Resultado da potência: " + (Math.Pow(num1, num2)));

            return (int)Math.Pow(num1, num2);
        }

        public int Dividir(int num1, int num2)
        {
            Historico.Insert(0, "Resultado da divisão: " + (num1 / num2));

            return num1 / num2;
        }

        public List<string> LimparHistorico()
        {
            Historico.RemoveRange(3, Historico.Count - 3);
            return Historico;
        }

        public void MostrarHistorico()
        {
            if (Historico.Count > 3)
            {
                LimparHistorico();
            }

            Console.WriteLine("Histórico: ");
            foreach (string item in Historico)
            {
                Console.WriteLine(item);
            }
        }
    }
}