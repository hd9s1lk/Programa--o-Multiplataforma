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

namespace Aula_12_03
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

        private void Button_Add(object sender, RoutedEventArgs e)
        {

        }

        private void ButaoAdicionar_Click(object sender, RoutedEventArgs e)
        {
            //abrir janela
            //selecioanr a figura desejada
            //carregamos num botão "Inserir"
            //Aplicação principal acedemos ao que foi selecionado
            //Guardamos na listbox

            //Sempre que abrir a nova janela vai limpar o canvas
            canvasFigura.Children.Clear();

            //criar objeto da janela Adicionar Figura
            AdicionarFigura adicionarFigura = new AdicionarFigura();

            //abrir janela
            //Show Dialog -> vai abrir a janela
            //verificamos se o retorno é true -> o que dizer que já podemos aceder ao conteudo
            //aceder à propriedade Figura
            if(adicionarFigura.ShowDialog() == true)
            {
                string fig = adicionarFigura.Figura;

                lbFiguras.Items.Add(fig);

                //Desenhar no canvas as figuras
                switch (fig)
                {
                    case "Quadrado":
                        {
                            Rectangle quadrado = new Rectangle();
                            quadrado.Width = 20;
                            quadrado.Height = 20;
                            quadrado.Stroke = Brushes.Crimson;
                            canvasFigura.Children.Add(quadrado);
                            break;
                        }
                    case "Retangulo":
                        {
                            Rectangle rectangle = new Rectangle();
                            rectangle.Width = 25;
                            rectangle.Height = 30;
                            rectangle.Stroke = Brushes.Aqua;

                            //Mostrar a figura
                            canvasFigura.Children.Add(rectangle);
                            break;
                        }
                    case "Triangulo":
                        {
                            break;
                        }

                }
            }
        }

        private void ButaoSair_Click(object sender, RoutedEventArgs e)
        {
            //Fechar aplicação
            this.Close();
        }
    }
}