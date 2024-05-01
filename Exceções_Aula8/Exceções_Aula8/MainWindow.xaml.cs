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

namespace Exceções_Aula8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ter acesso à App
        private App A;
        public MainWindow()
        {
            InitializeComponent();


            //Queremos é utilizar o que já foi criado e não criar um novo como A = new App();
            A = (App)App.Current;

            A.ModelTexto.TextoValido += ModelTexto_TextoValido;
        }

        private void ModelTexto_TextoValido(string valor)
        {
            lbTexto.Items.Add(valor);
        }


        //Lança a exceção 
        private void btnInserir_CLICK(object sender, RoutedEventArgs e)
        {
            var texto = txtTexto.Text;

            //Tem de estar preparado para tratar a exceção
            //vai tentar executar a função
            try
            {
                //Responsável por guardar informação é o Model
                A.ModelTexto.InserirValidarTexto(texto);
            }
            //caso ele falhe vai ser apanhada no catch
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //Model lança a exceção e a view apanha-a
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch(TextoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            //FAZER EX 7 MEU REI 


        }
    }
}