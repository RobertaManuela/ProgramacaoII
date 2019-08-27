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

namespace Ex07
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
        private void Button_Click (object sender, RoutedEventArgs)
        {
            Historico h = new Historico("Roberta");
            h.Inserir( new Disciplina("POO",80));
            h.Inserir( new Disciplina("Design",70));
            h.Inserir( new Disciplina("Física",95));
            List.ItemsSource = h.disc;
            txt.Text = h.IRA().ToString();
        }
    }
}
