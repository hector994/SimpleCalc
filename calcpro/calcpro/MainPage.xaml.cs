using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calcpro
{
    public partial class MainPage : ContentPage
    {
        double resultado, primero, segundo;
        int btn = 0;
        string operador;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn7.Text;
        }

        private void BtnC_Clicked(object sender, EventArgs e)
        {
            resulText.Text = "";
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn8.Text;
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn9.Text;
        }

        private void BtnMas_Clicked(object sender, EventArgs e)
        {
            if (btn == 1) return;
            {
                primero = Convert.ToDouble(resulText.Text);
                operador = "+";
                resulText.Text = "";
               
            }
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn6.Text;
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn5.Text;
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn4.Text;
        }

        private void BtnMen_Clicked(object sender, EventArgs e)
        {
            if (btn == 1) return;
            {
                primero = Convert.ToDouble(resulText.Text);
                operador = "-";
                resulText.Text = "";
                
            }
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn3.Text;
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn2.Text;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn1.Text;
        }

        private void BtnD_Clicked(object sender, EventArgs e)
        {
            if (btn == 1) return;
            {
                primero = Convert.ToDouble(resulText.Text);
                operador = "/";
                resulText.Text = "";
               
            }
        }

       

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            resulText.Text = resulText.Text + Btn0.Text;
        }

        private void Btnpunto_Clicked(object sender, EventArgs e)
        {
            int i = 0;
            foreach (char letra in resulText.Text)
            {
                if (letra == '.')
                    i = 1;
                {

                }
                if (i == 1)
                    return;
                else
                    resulText.Text = resulText.Text + Btnpunto.Text;
            }
        }

        private void BtnMult_Clicked(object sender, EventArgs e)
        {
            if (btn == 1) return;
            {
                primero = Convert.ToDouble(resulText.Text);
                operador = "*";
                resulText.Text = "";
                btn = 1;
            }
        }

     

      

        private void BtnIgu_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(resulText.Text) || resulText.Text == "" || resulText.Text == "0") return;

            segundo = double.Parse(resulText.Text);
            switch (operador)
            {
                case "+":
                    resultado = primero + segundo;
                    resulText.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    resulText.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    resulText.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    resulText.Text = resultado.ToString();
                    break;
                default:
                    DisplayAlert("Alerta", "Debe escribir algo o usar un signo aritmetico", "OK");
                    break;
            }
            btn = 0;
            operador = "";
        }
    }
}
