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

namespace PickACardUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //(int) converte o valor de numberOfCards.Value para um inteiro
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            listOfCards.Items.Clear();

            foreach (string card in pickedCards)
            {
                listOfCards.Items.Add(card);
            }
        }
    }
}
