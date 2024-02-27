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

namespace WPF_Aula_27_01
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

        private void TextBox_Valor_1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Mover_1_Click(object sender, RoutedEventArgs e)
        {
            string texto1 = TextBox_Valor_1.Text;
            TextBox_Valor_2.Text = texto1;

            TextBox_Valor_1.Clear();

            MessageBox.Show("Movido com sucesso", "Transação com Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);


        }
    }
}