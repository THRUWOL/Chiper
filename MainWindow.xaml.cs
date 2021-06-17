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

/*
    Прощу прощения у каждого (даже у себя), кто увидит данный код...
    Стыдно ли мне? Нет...
    Мне Ю... ПОХ*Ю
    😎🤙
 */


namespace Cipher_Шифер_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() { 
            InitializeComponent();
        }

        // Перемещение окна с помощью мышки
        private void Window_MouseLeftButtonDown(object sender, RoutedEventArgs e) => this.DragMove();

        // Закрытые программы
        private void Button_Close_Click(object sender, RoutedEventArgs e) 
        {
            Dialog dialog = new Dialog();
            dialog.ShowDialog();
        }

        // Сворачивание окна
        private void Button_MInimize_Click(object sender, RoutedEventArgs e) => this.WindowState = WindowState.Minimized;

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            string Input = TextBox_Input.Text;

            try
            {
                if (Base64.IsEnabled && Base64_Code.IsChecked == true)
                {
                    var Input_byte = System.Text.Encoding.UTF8.GetBytes(Input);
                    TextBox_Output.Text = System.Convert.ToBase64String(Input_byte);
                }

                else if (Base64.IsEnabled && Base64_Decode.IsChecked == true)
                {
                    var Input_byte = System.Convert.FromBase64String(Input);
                    TextBox_Output.Text = System.Text.Encoding.UTF8.GetString(Input_byte);
                }
            }
            catch (Exception) 
            {
                string 
                    error_name = "Base64",
                    error_info = "Произошла предвиденная ошибка при дешифровании текста. \nМы понимаем всю вашу боль и предлагаем вам смириться с этим. \n\"Ошибки делают нас сильнее\"";

                Error error = new Error(error_name, error_info);
                error.ShowDialog();
            };
        }

        /*  Взаимодействие с кнопками 
            При нажатии на кнопку открывается соответсвующее окно параметров для метода шифрования.
        */

        private void Button_Click(object sender, RoutedEventArgs e) // BASE64
        {
            Base64.Visibility = Visibility.Visible;
            Base64.IsEnabled = true;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // ROT (Caesar)
        {


            Base64.Visibility = Visibility.Hidden;
            Base64.IsEnabled = false;
        }

    }
}
