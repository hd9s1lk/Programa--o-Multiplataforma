using System.Configuration;
using System.Data;
using System.Windows;

namespace Aula_9
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Precisamos de chamar o Model através da View
        //Temos de ter o Model inicializado

        public ModelEscola ModelEscola { get; set; }

        public App()
        {
            ModelEscola = new ModelEscola();

        }
    }

}
