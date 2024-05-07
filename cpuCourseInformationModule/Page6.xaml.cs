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

namespace cpuCourseInformationModule
{
    /// <summary>
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page2 p2 = new Page2();
            this.Content = p2;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page3 p3 = new Page3();
            this.Content = p3;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page5 p5 = new Page5();
            this.Content = p5;
        }
    }
}
