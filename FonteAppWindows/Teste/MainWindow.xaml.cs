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
using PicUSB;

namespace Teste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PicUSBAPI api = new PicUSBAPI();

        private uint zero = 0x00;
        private uint um = 0x01;
        private uint dois = 0x02;

        public MainWindow()
        {
            InitializeComponent();            
        }

        private void left_Click_1(object sender, RoutedEventArgs e)
        {
            api.ControleMP(dois, um, zero, zero, zero);
        }

        private void right_Click_1(object sender, RoutedEventArgs e)
        {
            api.ControleMP(um, um, zero, zero, zero);
        }

        private void back_Click_1(object sender, RoutedEventArgs e)
        {
            api.ControleMP(zero, zero, dois, um, zero);
        }

        private void front_Click_1(object sender, RoutedEventArgs e)
        {
            api.ControleMP(zero, zero, um, um, zero);
        }

        private void MainWindow_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void leftback_Click_1(object sender, RoutedEventArgs e)
        {
            api.ControleMP(dois, um, dois, um, zero);
        }

        private void backright_Click_1(object sender, RoutedEventArgs e)
        {
            api.ControleMP(um, um, dois, um, zero);
        }

        private void rightfront_Click_1(object sender, RoutedEventArgs e)
        {
            api.ControleMP(um, um, um, um, zero);
        }

        private void frontleft_Click_1(object sender, RoutedEventArgs e)
        {
            api.ControleMP(dois, um, um, um, zero);
        }
    }
}
