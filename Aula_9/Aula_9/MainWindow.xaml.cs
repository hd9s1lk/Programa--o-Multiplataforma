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

namespace Aula_9
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

            //subscrição do evento
            A.ModelEscola.DadosCarregados += ModelEscola_DadosCarregados;
        }

        private void ModelEscola_DadosCarregados()
        {
            txtEscola.Text = A.ModelEscola.Nome;
            var departamentos = A.ModelEscola.Departamentos;
            //for(int i=0; i < departamentos.Count(); i++)
            //{
            //    Departamentos departamento = departamentos[i];

            //    //Adicionar à cb o nome do departamento
            //    cbDepartamentos.Items.Add(departamento.Nome);
            //}

            foreach (Departamento departamento in departamentos)
            {
                cbDepartamentos.Items.Add(departamento.Nome);
            }

            //porque implementamos a interface IEnumerable
            //foreach(var item in A.ModelEscola)
            //{
                
            //}
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //carregar os dados
            //chamar o método do Model para carregar dados
            A.ModelEscola.CarregarDados();

        }

        private void cbDepartamento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //obter o index selecionado 
            int index = cbDepartamentos.SelectedIndex;
            Departamento departamento = A.ModelEscola.ObterDepartamentoByIndex(index);

            NDocentes.Text = departamento.NDocentes.ToString();



        }
    }
}