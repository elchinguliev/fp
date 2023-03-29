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

namespace WpfApp8.Views
{
    /// <summary>
    /// Interaction logic for CreateRide.xaml
    /// </summary>
    public partial class CreateRide : UserControl
    {
        public CreateRide()
        {
            InitializeComponent();
        }



        private void plusStudents_Click(object sender, RoutedEventArgs e)
        {
            int digit = int.Parse(studentsTxtblck.Text);
            digit--;

            if (digit < 1)
            {
                digit = 30;
            }
            studentsTxtblck.Text = digit.ToString();
        }

        private void minusStudent_Click(object sender, RoutedEventArgs e)
        {
            int digit = int.Parse(studentsTxtblck.Text);
            digit++;
            if (digit > 30)
            {
                digit = 1;
            }
            studentsTxtblck.Text=digit.ToString();
        }

        private void plusParent_Click(object sender, RoutedEventArgs e)
        {
            int digit = int.Parse(parentsTxtblck.Text);
            digit++;
            if (digit > 4)
            {
                digit = 1;
            }
            parentsTxtblck.Text = digit.ToString();
        }

        private void minusParent_Click(object sender, RoutedEventArgs e)
        {
            int digit = int.Parse(parentsTxtblck.Text);
            digit++;
            if (digit > 30)
            {
                digit = 1;
            }
            parentsTxtblck.Text = digit.ToString();
        }

 

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            SimulationMap simulation = new();
            simulation.ShowDialog();
        }
    }
}
