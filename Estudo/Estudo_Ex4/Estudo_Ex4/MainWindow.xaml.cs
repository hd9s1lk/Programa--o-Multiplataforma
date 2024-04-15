using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Estudo_Ex4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Sair_CLICK(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btn_Modificar_CLICK(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();

        }
    }
}