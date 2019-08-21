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

namespace Ex03
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

        private void CalcularClick(Object sender, RoutedEventArgs e)
        {
            Retangulo x = new Retangulo();
            x.SetBase(double.Parse(txtB.Text));
            x.SetAltura(double.Parse(txtAlt.Text));
            txtA.Text = x.CalcArea().ToString("0");
            txtD.Text = x.CalcDiagonal().ToString("0");
        }

    }
}
