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

        Historico h;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            h = new Historico(aluno.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Disciplina x = new Disciplina(nome.Text, semestre.Text, int.Parse(media.Text),Aprovado.IsChecked.Value);
            h.Inserir(x);
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (lista.SelectedIndex != -1) 
            h.Excluir(lista.SelectedIndex); 
            lista.ItemsSource = h.Listar(); 
        }
    
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(h.IRA().ToString());
        }


    }
}
