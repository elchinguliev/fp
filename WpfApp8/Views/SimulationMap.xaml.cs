using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;


namespace WpfApp8.Views
{
    /// <summary>
    /// Interaction logic for SimulationMap.xaml
    /// </summary>
    public partial class SimulationMap : Window
    {
        public ApplicationIdCredentialsProvider ApiKey { get; set; } = new(ConfigurationManager.AppSettings["apikey"]);
        public SimulationMap()
        {
            InitializeComponent();
            //DataContext=this;
            //var map = new Microsoft.Maps.MapControl.WPF.Map();
            //this.Content = map;
            //var carImage = new BitmapImage(new Uri("down.png", UriKind.Relative));
            //var carMarker = new Microsoft.Maps.MapControl.WPF.Pushpin();
            //carMarker.Location = new Microsoft.Maps.MapControl.WPF.Location(47.6062, -122.3321);
            //carMarker.Background = new ImageBrush(carImage);
            //map.Children.Add(carMarker);
            //var timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(1);
            //timer.Tick += (sender, args) =>
            //{
            //    var lat = carMarker.Location.Latitude + 0.1;
            //    var lon = carMarker.Location.Longitude + 0.1;
            //    carMarker.Location = new Microsoft.Maps.MapControl.WPF.Location(lat, lon);
            //};
            //timer.Start();
        }



    }
}
