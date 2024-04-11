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

namespace Aula_02
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

            //Subscrever os eventos
            app.ModelarClassificacao.NotaInserida += ModelarClassificacao_NotaInserida;
        }

        private void ModelarClassificacao_NotaInserida(int valor)
        {
            //Adicionar à list box a nota
            
        }
    }
}
