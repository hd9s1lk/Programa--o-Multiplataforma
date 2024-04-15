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
        public string date {  get; private set; }
        public string desc {  get; private set; }
        public int quantity { get; private set; }
        
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_Registar_CLICK(object sender, RoutedEventArgs e)
        {
            
            String data = Data_TextBox.Text;
            String description = Descrição_TextBox.Text;
            string qtd = Quantia_TextBox.Text;
            int quantia = Convert.ToInt32(qtd);

            date = data;
            desc = description;
            quantity = quantia;



            this.DialogResult = true;

           
        }
    }
}
