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

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Page1 Page1 { get; set; }
        public Page2 Page2 { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Page1 = new Page1();
            Page2 = new Page2();

            Loaded += MyWindow_Loaded;
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(Page1);
        }

        private void PageOneButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(Page1);
        }

        private void PageTwoButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(Page2);
        }
    }
}
