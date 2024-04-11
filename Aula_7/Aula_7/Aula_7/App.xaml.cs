using System.Configuration;
using System.Data;
using System.Windows;

namespace Aula_7
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Esta é a classe que faz a ligação em Views e Models
        //Vai ter todas as views e models

        //Temos propriedades
        public ModelFicheiro ModelFicheiro { get; set; }
        public App()
        {
            ModelFicheiro = new ModelFicheiro();
        }
    }

}
