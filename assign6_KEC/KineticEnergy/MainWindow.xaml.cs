/*Assignment 6_Group 1
 * Group Members :  1. Oleksandr Rudavka
 *                  2. Jonathan Nagata
 *                  3. Niral Gandhi
 *                  4. Tanmay Teckchandani
 *                  5. Priya Tharuman
 *                  6. Krishna Kanhaiya
 *                  7. Lucas Currah
*/
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

namespace KineticEnergy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //creating object for ViewModel class
        ViewModel vm = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
       //button click event for calculation
        private void btnCalculate(object sender, RoutedEventArgs e)
        {
            vm.calcKineticEnergy();
        }
        //validating textboxes
        private void validateTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
        //reset textboxes
        private void btnReset(object sender, RoutedEventArgs e)
        {
            vm.reset();
        }
    }
}
