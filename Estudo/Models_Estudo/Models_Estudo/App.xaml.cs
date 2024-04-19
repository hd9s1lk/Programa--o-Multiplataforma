using System.Configuration;
using System.Data;
using System.Windows;

namespace Models_Estudo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //model
        public ModelNotas ModelNotas { get; set; }

        //view
        public ListarNotas ListarNotas { get; set; }

        public App()
        {
            InitializeComponent();
            ListarNotas = new ListarNotas();

            ModelNotas = new ModelNotas();
        }

    }

}
