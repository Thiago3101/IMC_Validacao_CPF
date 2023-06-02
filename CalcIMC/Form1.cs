using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Imc.Text = "";
            label7.Text = "";
            string Nome = nome.Text;
            string Cpf = cpf.Text;
            int Idade = Convert.ToInt32(idade.Text);
            string Sexo = sexo.Text;
            double Altura = Convert.ToDouble(altura.Text);
            double Peso = Convert.ToDouble(peso.Text);
            Pessoa pessoa = new Pessoa(Nome, Cpf, Idade, Sexo, Altura, Peso);

            if (Validacao.ValidaCPF(Cpf) == false)
            {
                label7.Text = "CPF inválido";
            }
            else
            {
                (double imc, string classficacao, string grau) = pessoa.CalcIMC();
                Imc.Text = $"Imc = {imc.ToString("F2")} ; Classificação = {classficacao} ; Grau = {grau}";
            }
        }
    }
}
