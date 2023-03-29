using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;
using WpfApp8.Models;

namespace WpfApp8.Views
{
    /// <summary>
    /// Interaction logic for BusDriver.xaml
    /// </summary>
    public partial class BusDriver : UserControl
    {
        public BusDriver()
        {
            InitializeComponent();
        }
        List<BusDrivers> drivers = new();
        int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        private void tickBtn_Click(object sender, RoutedEventArgs e)
        {
            BusDrivers driver = new();
            driver.Name = nameTxt.Text;
            driver.Surname = surnameTxt.Text;
            driver.Adress = adressTxt.Text;
            driver.Age = ageTxt.Text;
            drivers.Add(driver);
            comboBox.Items.Add(driver.Name);
            driver.Id++;
            WpfApp8.FileHelper.FileHelper.WriteDriver(drivers);
            nameTxt.Text = "";
            adressTxt.Text = "";
            surnameTxt.Text = "";
            ageTxt.Text = "";
        }
        private void relay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
