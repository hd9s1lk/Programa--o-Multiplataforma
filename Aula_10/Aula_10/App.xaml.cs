using System.Configuration;
using System.Data;
using System.Windows;

namespace Aula_10
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Inicializar o model para poder ser usado pela View

        public ModelBateria BateriaA { get; set; }
        
        public App()
        {
            BateriaA = new ModelBateria(); 
        }
    }

}
