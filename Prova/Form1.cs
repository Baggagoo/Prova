using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comanda comanda;

        List<Comanda> comandaList = new List<Comanda>();
        private void cbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBebidas.Text == "Refrigerante")
            {
                txtValorBebida.Text = "R$" + Convert.ToString(9.50);
            }
            if (cbBebidas.Text == "Cerveja")
            {
                txtValorBebida.Text = "R$" + Convert.ToString(16.00);
            }
            if (cbBebidas.Text == "Suco Natural")
            {
                txtValorBebida.Text = "R$" + Convert.ToString(12.00);
            }
            if (cbBebidas.Text == "Água")
            {
                txtValorBebida.Text = "R$" +Convert.ToString(7.50);
            }
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
              string Numero =   txtComanda.Text; 
              string Drink =   cbBebidas.Text;
            string valorDoPrato = txtValorPrato.Text;
              double Kilo, valorDaBebida;


                if(!double.TryParse(txtPeso.Text, out Kilo) ||
                !double.TryParse(txtValorBebida.Text.Replace("R$", ""), out valorDaBebida))
                {
                   MessageBox.Show("Por favor, insira números válidos nos campos de texto.");
                   return;
                }

            new Comanda(Numero, Drink, Kilo,valorDoPrato, valorDaBebida);
            comandaList.Add(comanda);
            Limpar();
        }

        public void Limpar()
        {
            txtComanda.Clear();
            txtPeso.Clear();
            txtValorPrato.Clear();
            cbBebidas.Text = "";
            txtValorBebida.Clear();

        }

        private void txtValorPrato_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string buscador = txtComanda.Text;
            string texto = "";
           if(txtComanda.Text == buscador)
            {
                MessageBox.Show($"Comanda: {txtComanda.Text}\n Peso: {txtPeso.Text}\n Valor do Prato: " +
                    $"{txtValorPrato.Text}");
            }
        }
    }
}
