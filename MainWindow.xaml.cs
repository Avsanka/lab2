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

namespace Lab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AppViewModel appvm = new AppViewModel();
        Binding amountofbuttons = new Binding();
        Binding usermovecounter = new Binding();

        public MainWindow()
        {
            InitializeComponent();
            amountofbuttons.Path = new PropertyPath("AmountContent");
            AmountOfButtons.SetBinding(Label.ContentProperty, amountofbuttons);
            usermovecounter.Path = new PropertyPath("UserMoveContent");
            UserMoveCounter.SetBinding(Label.ContentProperty, amountofbuttons);
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Char.IsDigit((char)KeyInterop.VirtualKeyFromKey(e.Key)) & e.Key != Key.Back | e.Key == Key.Space)
            {
                e.Handled = true;
                MessageBox.Show("В этом текстбоксе можно использовать только числа");
            }
        }

        private void EndGame_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //UserMoveCounter.Items.Add(button1.Content);
        }
    }

}
