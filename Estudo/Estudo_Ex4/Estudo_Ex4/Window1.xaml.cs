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

namespace Estudo_Ex4
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Window janela;
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_CLICK(object sender, RoutedEventArgs e)
        {
            janela.Close();
        }
    }
}
