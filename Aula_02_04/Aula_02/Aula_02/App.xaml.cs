using System.Configuration;
using System.Data;
using System.Windows;

namespace Aula_02
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Nesta class vão estar declarados/instanciados todos os models e todas as views

        //Criar propriedades para os models

        //Criar as propriedades para as views

        public ListarNotas ListarNotas { get; set; }

        public ListarClassificação ListarClassificação { get; set; }

        public ModelarClassificacao ModelarClassificacao { get; set; }

        //Criar um construtor -> para inicializar as propriedades 
        public App()
        {
            //Instanciar primeiros os Models e só depois as Views 
            ModelarClassificacao = new ModelarClassificacao();



            //Views
            ListarNotas = new ListarNotas();    //inicializar
            ListarClassificação = new ListarClassificação();

        }
    }

}
