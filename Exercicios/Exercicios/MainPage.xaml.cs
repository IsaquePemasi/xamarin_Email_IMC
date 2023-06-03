using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicios
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btGerar_Clicked(object sender, EventArgs e)
        {
            string nomeCompleto = etName.Text.Trim();
            string[] partesNome = nomeCompleto.Split(' ');

            if (partesNome.Length < 2)
            {
                throw new ArgumentException("O nome completo deve conter pelo menos um nome e um sobrenome.");
            }

            string sobrenome = partesNome[partesNome.Length - 1];
            string nome = string.Join(" ", partesNome, 0, partesNome.Length - 1);
            // Gere o email no formato desejado
            string email = $"{sobrenome.ToLower()}{nome.ToLower()}@ufn.edu.br";
            lbRespostaEmail.Text = email;
        }

        private void btIMC_Clicked(object sender, EventArgs e)
        {
            Double altura = 0, peso = 0, imc = 0;
            altura = double.Parse(etAltura.Text);
            peso = double.Parse(etPeso.Text);
            imc = peso / (altura * altura);
            string res = $"O seu IMC é {imc}\n ";
            if (imc < 17)
            {
                res += "\nMagreza grave: muito abaixo do peso\nPode apresentar: insuficiencia cardiaca, anemia grave e enfraquecimento do sistema imunologico"; 
            }
            if (imc > 17 && imc < 18.5)
            {
                res += "\nMagreza leve: abaixo do peso\nPode apresentar: problemas de saude ligados a desnutricao";
            }
            if (imc > 18.5 && imc < 24.9)
            {
                res += "\nEutrofico: peso normal\nSaudavel";
            }
            if (imc > 25 && imc < 29.9)
            {
                res += "\nSobrepeso: acima do peso\nPode apresentar: fadiga, varizes e ma circulacao";
            }
            if (imc > 30 && imc < 34.9)
            {
                res += "\nObesidade 1\nPode apresentar: diabetes, infarto, angina e aterosclerose";
            }
            if (imc > 35 && imc < 39.9)
            {
                res += "\nObesidade 2: severa\nPode apresentar: falta de ar e apneia do sono";
            }
            if (imc > 40)
            {
                res += "\nObesidade 3: morbida\nPode apresentar: refluxo infarto, avc e dificuldade de locomocao";
            }
            lbRespostaIMC.Text = res.ToString();
        }
    }
}
