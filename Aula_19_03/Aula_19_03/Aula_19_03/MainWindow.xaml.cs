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

namespace Aula_19_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Guardar a lista das figuras em memória
        List<Figura> Figuras {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            //Instanciar dentro do construtor
            Figuras = new List<Figura>();
        }

        private void lbFiguras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Querer ver que figura está selecionada
            //guardar o index
            int index = lbFiguras.SelectedIndex;
            

            //Obter os dados da figura selecionada 
            //Através do índice selecionado 
            Figura figura = Figuras[index];

            //Mudar o conteudo da statusBar
            statusbarFigura.Content = "Altura: " + figura.Altura + ", Largura: " + figura.Largura;
        }

        private void buttonAdicionar_CLICK(object sender, RoutedEventArgs e)
        {
            //criar um objeto da janela que queremos abrir
            AdicionarFigura adicionarFigura = new AdicionarFigura();

            //ShowDialog -> Abrir a janela
            //
            if(adicionarFigura.ShowDialog() == true)
            {
                lbFiguras.Items.Add(adicionarFigura.Figura.Nome);

                //Adicionar à nossa lista a figura guardada
                Figuras.Add(adicionarFigura.Figura);
            }
        }
    }
}