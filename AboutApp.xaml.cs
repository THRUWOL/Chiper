using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for AboutApp.xaml
    /// </summary>
    public partial class AboutApp : Window
    {
        public AboutApp()
        {
            InitializeComponent();
        }

        // Перемещение окна с помощью мышки
        private void Window_MouseLeftButtonDown(object sender, RoutedEventArgs e) => this.DragMove();
        //открытие ссылки в браузере
        void hyperlink_Click(object sender, RoutedEventArgs e) => Process.Start("https://github.com/THRUWOL/Chiper ");

        private void Button_CloseInfo_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}
