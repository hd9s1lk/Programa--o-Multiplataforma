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

namespace Aula_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private App A;

        public MainWindow()
        {
            InitializeComponent();

            A = (App)App.Current;

            A.BateriaA.Carregar();
            A.BateriaA.Descarregar();
            A.BateriaA.CargaAtualizada += BateriaA_CargaAtualizada;
        }

        private void BateriaA_CargaAtualizada(int valor)
        {
            pbBateria.Value = valor;

        }

        private void btnCarregar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //chamar um método que permite aumentar a carga da bateria
                A.BateriaA.Carregar();
            } catch (OperacaoInvalidaException ex)
            {
                
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            


        }

        private void btnDescarregar_CLICK(object sender, RoutedEventArgs e)
        {
            try
            {
                //chamar um método que permite descarregar a carga da bateria
                A.BateriaA.Descarregar();
            } catch (OperacaoInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

//Exercício 8 para fazer