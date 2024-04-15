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

namespace Estudo_Ex2
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


        private void btn_CLUBE1_CLICK(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Escolheu o Clube 1", "Votação", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
        }

        private void btn_CLICK2_CLICK(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Escolheu o Clube 1", "Votação", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
        }

        private void btn_CLICK3_CLICK(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Escolheu o Clube 1", "Votação", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.Yes);
        }

        private void btn_CLUBE2_MOUSEENTER(object sender, MouseEventArgs e)
        {
            btn_CLUBE2.Content = "Clube 1";
        }

        private void btn_CLUBE3_MOUSEENTER(object sender, MouseEventArgs e)
        {
            btn_CLUBE3.Content = "Clube 1";

        }

        private void btn_CLUBE2_MOUSELEAVE(object sender, MouseEventArgs e)
        {
            btn_CLUBE2.Content = "Clube 2";
        }

        private void btn_CLUBE3_MOUSELEAVE(object sender, MouseEventArgs e)
        {
            btn_CLUBE3.Content = "Clube 3";
        }
    }
}