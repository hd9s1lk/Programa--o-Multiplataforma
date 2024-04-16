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
        public int num {  get; private set; }

        public string nome { get; private set; }

        public string curso { get; private set; }
        
        Window janela;
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_CLICK(object sender, RoutedEventArgs e)
        {
            janela.Close();
        }

      

        private void btn_ALTERAR_CLICK(object sender, RoutedEventArgs e)
        {
            string name = nome_TextBox.Text;
            nome = name;
            string nume = numero_TextBox.Text;
            int NUM = Convert.ToInt32(nume);
            num = NUM;

            string CURSO = curso_TextBox.Text;
            curso = CURSO;


            

        }
    }
}
