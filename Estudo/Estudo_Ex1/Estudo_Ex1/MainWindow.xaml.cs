using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Estudo_Ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Valor1_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }

        private void Valor2_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Opearacao_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void BUTTON_CLICK(object sender, RoutedEventArgs e)
        {
            string valor1 = Valor1_TextBox.Text;
            string valor2 = Valor1_TextBox.Text;

            int Intvalor1 = Convert.ToInt32(valor1);
            int Intvalor2 = Convert.ToInt32(valor2);

            string op = Operacao_TextBox.Text;
            if(op == "+")
            {
                int resultado = Intvalor1 + Intvalor2;
                string Resultado = Convert.ToString(resultado);
                Resultado_TextBox.Text = Resultado;
            } else if (op == "-")
            {
                int resultado = Intvalor1 - Intvalor2;
                string Resultado = Convert.ToString(resultado);
                Resultado_TextBox.Text = Resultado;
            } else if (op == "*")
            {
                int resultado = Intvalor1 * Intvalor2;
                string Resultado = Convert.ToString(resultado);
                Resultado_TextBox.Text = Resultado;
            } else if (op == "/")
            {
                int resultado = Intvalor1 / Intvalor2;
                if(Valor2_TextBox.Text == "0")
                {
                    Resultado_TextBox.Text = "Divisão por Zero";
                } else
                {
                    string Resultado = Convert.ToString(resultado);
                    Resultado_TextBox.Text = Resultado;
                }
                
            } else
            {
                Resultado_TextBox.Text = "Operação Inválida";
            }



        }
    }
}