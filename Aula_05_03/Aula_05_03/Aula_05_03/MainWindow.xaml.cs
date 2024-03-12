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

namespace Aula_05_03
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

        //função associada ao click do botão
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string valor1 = Valor1_TextBox.Text;
            string valor2 = Valor2_TextBox.Text;

            int valor1Int = Convert.ToInt32(valor1);
            int valor2Int = Convert.ToInt32(valor2);
            int resultado = valor1Int + valor2Int;
            string resultadoString = Convert.ToString(resultado);
            

            Resultado_TextBox.Text = resultado.ToString();

            ComboBox_Logs.Items.Add(resultado);

            ListBox_Logs.Items.Add(resultado);

            ListView.Items.Add(resultado);

            TreeView.Items.Add(resultado);

            //criar um item da treeView
            //criar um objeto do tipo TreeViewItem

            TreeViewItem pai = new TreeViewItem();
            //criar uma string com o formato que queremos
            pai.Header = String.Format(" {0} + {1} ", valor1, valor2);

            TreeViewItem filho = new TreeViewItem();
            filho.Header = resultadoString;

            pai.Items.Add(filho);

            TreeView.Items.Add(pai);


        }

   
    }
}