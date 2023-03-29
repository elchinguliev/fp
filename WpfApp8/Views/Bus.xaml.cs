using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp8.Views
{
    /// <summary>
    /// Interaction logic for Bus.xaml
    /// </summary>
    public partial class Bus : UserControl
    {
        public Bus()
        {
            InitializeComponent();
        }
        List<Bus> schoolBuses = new();


        private void tickBtn_Click(object sender, RoutedEventArgs e)
        {
            //Bus schoolBus = new Bus();
            //schoolBus.BR=brand.Text;
            //schoolBus.SerialNumber = seria.Text;

            //schoolBus.RelaysDate = relay.Text;
            //schoolBus.SeatCount = seat.Text;
            //schoolBuses.Add(schoolBus);
            //schoolBus.Id++;
            //carcombo.Items.Add(schoolBus.Brand);
            //WpfApp8.FileHelper.FileHelper.WriteSchoolBus(schoolBuses);
            //brand.Text = "";
            //seria.Text = "";
            //relay.Text = "";
            //seat.Text = "";
        }  
        
        
        private void relay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
