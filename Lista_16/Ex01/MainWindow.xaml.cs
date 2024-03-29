﻿using System;
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

namespace Ex01
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

        private void CalcularClick(object sender, RoutedEventArgs e)
        {
            Viagem x = new Viagem();
            x.SetDistancia(double.Parse(Distancia.Text));
            x.SetTempo(double.Parse(Tempo.Text));
            Velocidade.Text = x.CalcVelocidade().ToString();
        }
    }
}

