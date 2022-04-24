using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {

            //Primeiro tratamento de erro: Impede o usuário de tentar calcular com um dos campos vazios
            if (String.IsNullOrEmpty(Weight.Text) || (String.IsNullOrEmpty(Heigth.Text)))
            {
                MessageBox.Show("Digite valores válidos para sua altura e peso!");
            }

            else
            {
                //Se estiver tudo certo com o programa, e não tiver nenhum erro, ai sim, o IMC será calculado.


                //Informações que precisamos: Peso e Altura. A variável IMC vai calcular o IMC e armazená-lo
                double peso, altura, imc;

                peso = Convert.ToDouble(Weight.Text);
                altura = Convert.ToDouble(Heigth.Text);

                imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    MessageBox.Show("Seu IMC é de: " + imc.ToString("F") + " E você está abaixo do peso!");
                }

                else if (imc < 25)
                {
                    MessageBox.Show("Seu IMC é de: " + imc.ToString("F") + " E você está com o peso normal!");
                }

                else if (imc < 30)
                {
                    MessageBox.Show("Seu IMC é de: " + imc.ToString("F") + " E você está com excesso de peso!");
                }

                else if (imc < 35)
                {
                    MessageBox.Show("Seu IMC é de: " + imc.ToString("F") + " E você está com obesidade grau 1!");
                }

                else if (imc < 40)
                {
                    MessageBox.Show("Seu IMC é de: " + imc.ToString("F") + " E você está com obesidade grau 2!");
                }

                else
                {
                    MessageBox.Show("Seu IMC é de: " + imc.ToString("F") + " E você está com obesidade grau 3!");
                }

            }
            
        }

        private void Heigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Isso aqui é a restrição da TextBox. Com isso, só números, vírgulas e backspaces podem ser digitados
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar !=44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            //Referência dessa última parte:
            //http://tutoriaiscsharp.blogspot.com/2012/05/como-fazer-o-textbox-permitir-apenas.html

            //Basicamente, é isso aqui! Muito obrigado por ler o código, ou fazer o download do programa.


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abre meu site
            System.Diagnostics.Process.Start("C:/Program Files/Google/Chrome/Application/chrome.exe", "https://welberc.github.io/CurriculoEmSite/");
        }
    }
}
