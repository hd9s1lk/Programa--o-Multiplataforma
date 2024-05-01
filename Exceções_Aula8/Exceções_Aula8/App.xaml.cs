using System.Configuration;
using System.Data;
using System.Windows;

namespace Exceções_Aula8
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Camada de ligação entre as views e o model
        //instanciar o model
        public ModelTexto ModelTexto { get; set; }

        public App()
        {
            //inicializar o model
            ModelTexto = new ModelTexto();
        }
    }

}
