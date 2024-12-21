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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Close();

        }

        
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btn7_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            popup1.IsOpen = true;
        }
    }
}
