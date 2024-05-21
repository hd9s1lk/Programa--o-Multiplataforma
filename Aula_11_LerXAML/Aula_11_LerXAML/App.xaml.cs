using System.Configuration;
using System.Data;
using System.Windows;

namespace Aula_11_LerXAML
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ModelInscricoes ModelInscricoes { get; private set; }

        public App()
        {
            ModelInscricoes = new ModelInscricoes();
        }
    }

}
