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

namespace Homework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product>products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                Price = 60,
                Kartinka = "food",
                ProductType = ProductTypes.Food
            });products.Add(new Product()
            {
                ProductName = "Фен",
                Price = 5000,
                Kartinka = "appliance",
                ProductType = ProductTypes.Appliance
            });products.Add(new Product()
            {
                ProductName = "Посудомоечная машина",
                Price = 60000,
                Kartinka = "appliance",
                ProductType = ProductTypes.Appliance
            });products.Add(new Product()
            {
                ProductName = "Яблоки",
                Price = 200,
                Kartinka = "food",
                ProductType = ProductTypes.Food
            });
            lstBox.ItemsSource = products;
        }
    }
}
