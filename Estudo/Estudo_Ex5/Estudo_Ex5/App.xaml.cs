using System.Configuration;
using System.Data;
using System.Windows;

namespace Estudo_Ex5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ModelFicheiro ModelFicheiro { get; set; }

        public App()
        {
            ModelFicheiro = new ModelFicheiro();
        }
    }

}
