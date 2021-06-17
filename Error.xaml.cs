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
    /// Interaction logic for Error.xaml
    /// </summary>
    public partial class Error : Window
    {
        public Error(string error_name, string error_info) 
        { 
            InitializeComponent();
            TextBlock_ErrorName.Text = error_name;
            TextBlock_ErrorInfo.Text = error_info;
        }

        // Перемещение окна с помощью мышки
        private void Window_MouseLeftButtonDown(object sender, RoutedEventArgs e) => this.DragMove();

        private void Button_ErrorClose_Click(object sender, RoutedEventArgs e) => this.Close();
        // Закрытие окна ошибки

    }
}
