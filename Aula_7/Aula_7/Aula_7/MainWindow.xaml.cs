using Microsoft.Win32;
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

namespace Aula_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //View principal precisa de aceder ao Model
        private App MyApplication;

        public MainWindow()
        {
            InitializeComponent();

            //App.Current -> retorna a class Aplication
            //A class App deriva da Application
            //Podemos fazer cast direto da Application para a App
            MyApplication = (App)App.Current; // ou então new App();

            MyApplication.ModelFicheiro.EventoFicheiroGuardado += ModelFicheiro_EventoFicheiroGuardado;

            MyApplication.ModelFicheiro.EventoFicheiroLido += ModelFicheiro_EventoFicheiroLido;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModelFicheiro_EventoFicheiroGuardado()
        {
            //Mostrar uma informação 
            MessageBox.Show("Ficheiro guardado com sucesso!", "Informação", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ModelFicheiro_EventoFicheiroLido()
        {
            //Mostrar uma informação 
            //Está guardado na propriedade Texto do Model
            txtLido.Text = MyApplication.ModelFicheiro.Texto;
        }



        private void btnAbrir_Click(object sender, RoutedEventArgs e)
        {
            //Abrir a janela para abrir arquivos
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt";

            if(openFile.ShowDialog() == true)
            {
                //Chamar o Model para ler ficheiros
                MyApplication.ModelFicheiro.LerFicheiro(openFile.FileName);

            }


        }

        private void btnGuardar_CLICK(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();


            //All files (*.*)|*.* -> todos os ficheiros
            //Nome do ficheiro tem de acabar em .txt
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            //guardar o ficheiro

            //showDialog -> vai abrir a janela que permite guardar o ficheiro
            //veriificar se o DialogResult está a true
            
            if(saveFile.ShowDialog() == true)
            {
                //obter o texto da textbos
                string texto = txtFicheiro.Text;

                //Temos de chamar o Model para tratar de guardar o texto no ficheiro

                //SaveFileDialog vai ter a informação da localização do ficheiro
                MyApplication.ModelFicheiro.GuardarTexto(saveFile.FileName, texto);


            }
        }
    }
}