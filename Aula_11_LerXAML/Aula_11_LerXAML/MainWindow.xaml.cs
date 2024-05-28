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

namespace Aula_11_LerXAML
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

            A.ModelInscricoes.AlunosChanged += ModelInscricoes_AlunosChanged;
            A.ModelInscricoes.FicheiroGuardado += ModelInscricoes_FicheiroGuardado;
        }

        private void ModelInscricoes_FicheiroGuardado()
        {
            MessageBox.Show("Ficheiro guardado com sucesso!", "Informação", MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void ModelInscricoes_AlunosChanged()
        {
            TreeViewItem inscritos = new TreeViewItem();
            inscritos.Header = "Inscritos";

            TreeViewItem nInscritos = new TreeViewItem();
            nInscritos.Header = "Nao inscritos";

            //Percorrer a lista toda dos alunos
            //Queremos os valores todos no dicionário -> lista de alunos
            foreach(Aluno al in A.ModelInscricoes.Alunos.Values)
            {
                if (al.Inscrito)
                {
                    inscritos.Items.Add(al.Numero + ";" + al.Nome + ";" + al.Curso);
                } else
                {
                    nInscritos.Items.Add(al.Numero + ";" + al.Nome + ";" + al.Curso);
                }
            }

            tvAlunos.Items.Clear();
            tvAlunos.Items.Add(inscritos);
            tvAlunos.Items.Add(nInscritos);


        }

        private void AbrirTxt_CLICK(object sender, RoutedEventArgs e)
        {
            //Permitir ao user selecionar o ficheiro que quer ler
            OpenFileDialog openFile = new OpenFileDialog();

            //Filtrar os ficheiros
            //1->0 o que o user vê
            //2-> Filtro
            openFile.Filter = "Ficheiro txt|*.txt";

            //Abrir a janela
            if(openFile.ShowDialog() == true)
            {
                //chamar o model para ler o ficheiro selecionado
                //Guardar os dados em memória
                A.ModelInscricoes.LerTxt(openFile.FileName);

            }
        }

        private void GuardarXML_CLICK(object sender, RoutedEventArgs e)
        {
            //Guardar um ficheiro
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Ficheiro XML|*.xml";

            if(saveFile.ShowDialog() == true)
            {
                //chamar os model para guardar os dados que ter armazenados em memória
                A.ModelInscricoes.GuardarXML(saveFile.FileName);
            }
        }

        private void GuardarJSON_CLICK(object sender, RoutedEventArgs e)
        {
            //Guardar um ficheiro
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Ficheiro JSON|*.json";

            if (saveFile.ShowDialog() == true)
            {
                //chamar os model para guardar os dados que ter armazenados em memória
                A.ModelInscricoes.SaveJson(saveFile.FileName);
            }
        }

        private void AbrirXml_CLICK(object sender, RoutedEventArgs e)
        {
            //Permitir ao user selecionar o ficheiro que quer ler
            OpenFileDialog openFile = new OpenFileDialog();

            //Filtrar os ficheiros
            //1->0 o que o user vê
            //2-> Filtro
            openFile.Filter = "Ficheiro XML|*.xml";

            //Abrir a janela
            if (openFile.ShowDialog() == true)
            {
                //chamar o model para ler o ficheiro selecionado
                //Guardar os dados em memória
                A.ModelInscricoes.LerXml(openFile.FileName);

            }
        }

        private void GuardarTxt_CLICK(object sender, RoutedEventArgs e)
        {
            //Guardar um ficheiro
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Ficheiro Txt|*.txt";

            if (saveFile.ShowDialog() == true)
            {
                //chamar os model para guardar os dados que ter armazenados em memória
                A.ModelInscricoes.GuardarTxt(saveFile.FileName);
            }
        }

        private void tvAlunos_SELECTEDITEMCHANGED(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var item = tvAlunos.SelectedValue;

            if(item != null)
            {
                A.ModelInscricoes.AlterarInscricao(item.ToString().Split(" ; ")[0]);
            }
        }
    }
}