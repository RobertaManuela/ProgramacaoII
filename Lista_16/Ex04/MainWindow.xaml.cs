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

namespace Ex04
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
        private void CalcularClick (object sender, RoutedEventArgs e)
        {
            Equacao x = new Equacao();
            x.SetABC(double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtC.Text));
            txtD.Text = x.Delta().ToString();
            double r, s;
            if (x.X1(out r))
            {
                x.X2(out s);
                txtX1.Text = r.ToString();
                txtX2.Text = s.ToString();

            }
            else
            {
                txtX1.Text = "Raiz complexa";
                txtX2.Text = "Raiz complexa";
                MessageBox.Show("A equacao não é do segundo grau ou não possui raízes reais");
            }
        }
    }
}
