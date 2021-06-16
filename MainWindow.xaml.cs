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

namespace Cipher_Шифер_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        // Перемещение окна с помощью мышки
        private void Window_MouseLeftButtonDown(object sender, RoutedEventArgs e) => this.DragMove();

        // Закрытые программы
        private void Button_Close_Click(object sender, RoutedEventArgs e) => this.Close();

        // Сворачивание окна
        private void Button_MInimize_Click(object sender, RoutedEventArgs e) => this.WindowState = WindowState.Minimized;
    }
}
