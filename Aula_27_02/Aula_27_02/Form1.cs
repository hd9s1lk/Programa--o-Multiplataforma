using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_27_02
{
    //definição da class em C#
    public partial class Form1 : Form
    {
        //constructor por default sem parametros
        public Form1()
        {
            InitializeComponent();
        }

        //criação de uma função em c#
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Calcula_Click(object sender, EventArgs e)
        {
            string texto1 = Caixa_Valor_1.Text;
            Caixa_Valor_2.Text = texto1;
            Caixa_Valor_1.Clear();



            //get dos valores das caixas
            //set -> valor caixa 1 -> valor caixa 2
            //apagar valor caixa 1
            //tpc: condição para não trocar se a caixa 2 tiver preenchida

        }
    }
}
