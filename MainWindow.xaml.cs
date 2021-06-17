using System;
using System.Windows;

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
        private void Button_Close_Click(object sender, RoutedEventArgs e) 
        {
            Dialog dialog = new Dialog();
            dialog.ShowDialog();
        }
        private void Button_MInimize_Click(object sender, RoutedEventArgs e) => this.WindowState = WindowState.Minimized;
        private void Button_Info_Click(object sender, RoutedEventArgs e)
        {
            AboutApp about = new AboutApp();
            about.ShowDialog();
        }
        #endregion

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            string Input = TextBox_Input.Text;

            #region Base64
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
                    error_info = "Произошла предвиденная ошибка при дешифровки текста. \nМы понимаем всю вашу боль и предлагаем вам смириться с этим. \n\"Ошибки делают нас сильнее\"";

                Error error = new Error(error_name, error_info);
                error.ShowDialog();
            };
            #endregion

        }

        /*  Взаимодействие с кнопками 
            При нажатии на кнопку открывается соответсвующее окно параметров для метода шифрования.
        */
        #region Chiper Methods
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
        #endregion
    }
}
