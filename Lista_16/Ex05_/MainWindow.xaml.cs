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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex05_
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Numeros x = new Numeros();
            x.SetInicio(int.Parse(i.Text));
            x.SetFim(int.Parse(f.Text));
            bool bp, bi;
            if (par.IsChecked == true) bp = true;
            else
                bp = false;
            if (impar.IsChecked == true) bi = true;
            else
                bi = false;
            lista.ItemsSource = x.Calcular(bp, bi);
            //bp = par.IsChecked.Value;
            //bi = impar.IsChecked.Value;
            //lista.ItemsSource = x.Calcular(par.IsChecked.Value, impar.IsChecked.Value);
        }
    }
}