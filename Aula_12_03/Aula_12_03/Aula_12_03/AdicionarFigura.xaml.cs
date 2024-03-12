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

namespace Aula_12_03
{
    /// <summary>
    /// Lógica interna para AdicionarFigura.xaml
    /// </summary>
    public partial class AdicionarFigura : Window
    {

        //Propriedades -> Atributos
        //Para a janela principal conseguir aceder
        //Encapsulamento igual
        //Get e Set 
        //get publico e set privado -> só a própria class consegue usar
        public string Figura { get; private set; }

        public AdicionarFigura()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Guardar_Click(object sender, RoutedEventArgs e)
        {
            //obter o texto selecionado
            //cbFigura é a combobox
            //é o texto selecionado
            //variável local da função
            string fig = cbFigura.Text;

            //2-> Guardar a figura na propriedade global
            //Estamos a usar o set privado
            Figura = fig;

            //Para fazer a janela principal já possa aceder à propriedade do ShowDialog
            //A janela fecha automaticamente 
            this.DialogResult = true;

        }
    }
}
