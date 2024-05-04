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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox course = (ComboBox)sender;
            string selectedItem = (string)course.SelectedItem;

            // Add items to the ComboBox
            course.Items.Add("BS Digital Media Interactive Arts");
            course.Items.Add("BS Computer Science");
            course.Items.Add("BS Information Technology");
            course.Items.Add("BS Library Information Science");

            // Do something with the selected item
            MessageBox.Show("You selected: " + selectedItem);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedItem = (string)comboBox.SelectedItem;

            // Add items to the ComboBox
            comboBox.Items.Add("First Year");
            comboBox.Items.Add("Second Year");
            comboBox.Items.Add("Third Year");
            comboBox.Items.Add("Fourth Year");

            // Do something with the selected item
            MessageBox.Show("You selected: " + selectedItem);
        }
    }
}
