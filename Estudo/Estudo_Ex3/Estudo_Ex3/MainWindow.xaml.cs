﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Estudo_Ex3
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

        private void btn_Register_CLICK(object sender, RoutedEventArgs e)
        {
            

            Window1 register = new Window1();
            if(register.ShowDialog() == true)
            {
                string date = register.date;
                listView_Dados.Items.Add(date);

                int quantity = register.quantity;
                listView_Dados.Items.Add(quantity);

                string desc = register.desc;
                listView_Dados.Items.Add(desc);


            }

            
        }
    }
}