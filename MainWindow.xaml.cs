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
            string Output;
            int key = Convert.ToInt32(TextBox_Key.Text);

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

            #region ROT
            if (ROT.IsEnabled && ROT_Code.IsChecked == true)
            {
                if (ComboBox_Language.SelectedItem == Item_Russian)
                {
                    const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                    Output = ROT_CODE_ENCODE(alfabet, Input, key);
                    TextBox_Output.Text = Output;
                }
                else if (ComboBox_Language.SelectedItem == Item_English)
                {
                    const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    Output = ROT_CODE_ENCODE(alfabet, Input, key);
                    TextBox_Output.Text = Output;
                }
            }
            else if (ROT.IsEnabled && ROT_Decode.IsChecked == true)
            {
                if (ComboBox_Language.SelectedItem == Item_Russian)
                {
                    const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                    Output = ROT_CODE_ENCODE(alfabet, Input, -key);
                    TextBox_Output.Text = Output;
                }
                else if (ComboBox_Language.SelectedItem == Item_English)
                {
                    const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    Output = ROT_CODE_ENCODE(alfabet, Input, -key);
                    TextBox_Output.Text = Output;
                }
            }
            #endregion ROT

        }

        // ШИФР ROT
        private string ROT_CODE_ENCODE(string alfabet, string text, int k)
        {
            //добавляем в алфавит маленькие буквы
            var fullAlfabet = alfabet + alfabet.ToLower();
            var letterQty = fullAlfabet.Length;
            var retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + k) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }

            return retVal;
        }

        /*  Взаимодействие с кнопками 
            При нажатии на кнопку открывается соответсвующее окно параметров для метода шифрования.
        */
        #region Chiper Methods
        private void Button_Click(object sender, RoutedEventArgs e) // BASE64
        {
            Base64.Visibility = Visibility.Visible;
            Base64.IsEnabled = true;

            ROT.Visibility = Visibility.Hidden;
            ROT.IsEnabled = false;


        }
        private void Button_Click_1(object sender, RoutedEventArgs e) // ROT (Caesar)
        {
            ROT.Visibility = Visibility.Visible;
            ROT.IsEnabled = true;

            Base64.Visibility = Visibility.Hidden;
            Base64.IsEnabled = false;
        }
        #endregion
    }
}
