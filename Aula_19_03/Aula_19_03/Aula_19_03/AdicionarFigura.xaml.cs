using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Aula_19_03
{
    /// <summary>
    /// Lógica interna para AdicionarFigura.xaml
    /// </summary>
    public partial class AdicionarFigura : Window
    {
        //Usar a class criada para guardar os dados de uma figura
        public Figura Figura { get; private set; }

        public AdicionarFigura()
        {
            InitializeComponent();

            //Inicializar a Figura
            //sem isto, o objeto era NULL
            Figura = new Figura();
        }

        private void buttonGuardar_CLICK(object sender, RoutedEventArgs e)
        {
            //obter o nome da figura selecionada
            //se botao quadrado é selecionado
            string nome;
            if(rbQuadrado.IsChecked == true)
            {
                nome = "Quadrado";
            } else
            {
                if(rbRetangulo.IsChecked == true)
                {
                    nome = "Retangulo";
                } else
                {
                    nome = "Desconhecido";
                }
            }
            //obter altura
            string altura = txtAltura.Text;
            //obter a largura
            string largura = txtLargura.Text;

            //atualizar o objeto Figura com os dados selecionados
            Figura.Nome = nome;
            Figura.Largura = Convert.ToInt32(largura);
            Figura.Altura = Convert.ToInt32(altura);

            //Operação terminou
            //Pode fechar a janela
            // O showDialog associado fica a saber que os dados estão guardados
            this.DialogResult = true;

        }
    }
}
