using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string Data;
        public Calculadora(string data) 
        {
            listaHistorico = new List<string>();
            Data = data;
        }

        public int Somar(int n1, int n2)
        {
            int res = n1 + n2;
            listaHistorico.Insert(0, "res: " + res +" - Data: "+ Data);
            return res;

        }
        public int Subtrair(int n1, int n2)
        {
            int res = n1 - n2;
            listaHistorico.Insert(0, "res: " + res + " - Data: " + Data);
            return res;
        }
        public int Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;
            listaHistorico.Insert(0, "res: " + res + " - Data: " + Data);
            return res;
        }
        public int Dividir(int n1, int n2)
        {
            int res = n1 / n2;
            listaHistorico.Insert(0, "res: " + res + " - Data: " + Data);
            return res;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3,listaHistorico.Count-3);
            return listaHistorico;
        }
    }
}
