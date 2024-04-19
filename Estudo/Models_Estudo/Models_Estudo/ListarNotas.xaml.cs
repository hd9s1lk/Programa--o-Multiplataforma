using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Models_Estudo
{
    /// <summary>
    /// Lógica interna para ListarNotas.xaml
    /// </summary>
    public partial class ListarNotas : Window
    {
        private App app;
        public ListarNotas()
        {
            InitializeComponent();

            app = App.Current as App;

            app.ModelNotas.NotaInserida += ModelNotas_InserirNotas;
        }

        private void ModelNotas_InserirNotas(int valor)
        {
            lb_Notas.Items.Add(valor);
        }
    }
}
