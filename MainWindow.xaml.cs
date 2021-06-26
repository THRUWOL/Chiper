using System;
using System.Windows;

// Данная программа будет переделана иначе в будущем, сейчас проект заморожен

namespace Cipher_Шифер_
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
        #region SMTH Buttons
        private void Window_MouseLeftButtonDown(object sender, RoutedEventArgs e) => this.DragMove();
        #endregion

    }
}
