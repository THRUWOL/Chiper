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
using System.Windows.Shapes;

namespace Cipher_Шифер_
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public Dialog() => InitializeComponent();

        // Перемещение окна с помощью мышки
        private void Window_MouseLeftButtonDown(object sender, RoutedEventArgs e) => this.DragMove();
        // Закрытые диалогового окна
        private void Button_FalseExit_Click(object sender, RoutedEventArgs e) => this.Close();
        // Закрытые всей программы
        private void Button_TrueExit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
        // Закрытые диалогового окна
        private void Button_Close_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}
