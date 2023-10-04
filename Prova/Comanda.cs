using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Comanda
    {
        string numero_Comanda, bebida, valorPrato;
        double peso, valorBebida;

        public Comanda(string numero_Comanda, string bebida, double peso, string valorPrato, double valorBebida)
        {
            this.numero_Comanda = numero_Comanda;
            this.bebida = bebida;
            this.peso = peso;
            this.valorPrato = valorPrato;
            this.valorBebida = valorBebida;
        }

        public string Numero_Comanda { get => numero_Comanda; set => numero_Comanda = value; }
        public string Bebida { get => bebida; set => bebida = value; }
        public double Peso { get => peso; set => peso = value; }
        public string ValorPrato { get => valorPrato; set => valorPrato = value; }
        public double ValorBebida { get => valorBebida; set => valorBebida = value; }
    }
}
