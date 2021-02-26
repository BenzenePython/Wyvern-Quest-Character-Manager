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

namespace CharacterManager
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

        private void Create_click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test successful.");
        }

        private void Load_click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test successful.");

        }

        private void DM_click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test successful.");

        }
        //test button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
               
        }
    }
}
