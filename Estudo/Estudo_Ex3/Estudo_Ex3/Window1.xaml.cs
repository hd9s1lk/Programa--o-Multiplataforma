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

namespace Estudo_Ex3
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public List<string> ItemList = new List<string>();
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_Registar_CLICK(object sender, RoutedEventArgs e)
        {
            String data = Data_TextBox.Text;
            String desc = Descrição_TextBox.Text;
            string qtd = Quantia_TextBox.Text;
            int quantia = Convert.ToInt32(qtd);

            ItemList.Add(data);
        }
    }
}
