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
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        public Student()
        {
            InitializeComponent();
        }
        List<Student> students;

        private void schoolTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tickBtn_Click(object sender, RoutedEventArgs e)
        {
            WpfApp8.Models.Student student = new();
            student.Name = nameTxt.Text;
            student.Surname = surnameTxt.Text;
            student.Adress = adressTxt.Text;
            student.ParentName=parentsNameTxt.Text;
            student.SchoolNumber = schoolTxt.Text;
            student.Id++;
            studentCombobox.Items.Add(student.Name);
            WpfApp8.FileHelper.FileHelper.WriteStudent(student);
            nameTxt.Text = "";
            surnameTxt.Text = "";
            adressTxt.Text = "";
            parentsNameTxt.Text = "";
            schoolTxt.Text = "";
        }
    }
}
