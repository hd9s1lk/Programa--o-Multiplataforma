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

namespace Aula_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Relação entre a class App 
        //Conseguimos aceder às views e aos Models 
        //Propriedade do Tipo App
        private App app;
        public MainWindow()
        {
            InitializeComponent();

            //Aceder à aplicação corrente 
            app = App.Current as App;
        }

        private void BtnInserir_CLICK(object sender, RoutedEventArgs e)
        {
            //Guardar a nota inserida
            //Respondabilidade de guardar dados, tratar é do Model
            //e não da View 
            //View vai chamar um método do Model, para guardar a nota inserida
            //View -> Model

            //Chamar o método Inserir Nota com a nota na caixa de texto
            app.ModelarClassificacao.InserirNota(txtNota.Text);
        }

        //Evento lançado quando a janela é carregada
        private void WindowMain_LOADED(object sender, RoutedEventArgs e)
        {
            //Abrir as outras janelas
            //Aceder às views através da class App
            app.ListarNotas.Show();
            app.ListarClassificação.Show();


        }


        //Evento lançado quando a janela é fechada
        private void WindowMain_CLOSED(object sender, EventArgs e)
        {
            //Fechas as outras janelas
            app.ListarClassificação.Close();
            app.ListarNotas.Close();

        }
    }
}