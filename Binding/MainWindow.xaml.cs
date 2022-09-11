using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {





        public ObservableCollection<Car> Cars { get; set; }







        public MainWindow()
        {
            InitializeComponent();
            MyCar = new Car
            {
                Model = "AMG",
                Vendor = "Mercedes",
                Year = 2022
            };


            Cars = new ObservableCollection<Car>
            {
                new Car
            {
                    Id=1,
                Model = "AMG",
                Vendor = "Mercedes",
                Year = 2022
                },
                 new Car
            {
                     Id=2,
                Model = "Malibu",
                Vendor = "Chevrolet",
                Year = 2022
                },
                  new Car
            {
                      Id=3,
                Model = "V",
                Vendor = "Volvo",
                Year = 2022
                },
            };


            this.DataContext = this;
        }
        public Car MyCar { get; set; }





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["PrimaryColor"] = this.Resources["PrimaryColor2"];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MyCar.Model = "E-200";
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var car = listbox.SelectedItem as Car;
            MessageBox.Show(car.Model);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Cars.Add(new Car
            {
                Model = "F12 Berlinetta",
                Vendor = "Ferrari",
                Year = 2018
            });
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var stackpanel = btn.Parent as StackPanel;
            var txtBlock = stackpanel.Children[0] as TextBlock;
            var id = int.Parse(txtBlock.Text);
            var car = Cars.FirstOrDefault(c => c.Id == id);
            MessageBox.Show(car.Model);
        }
    }
}
