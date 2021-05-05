using CashRegister.Shared;
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

namespace CashRegister.UICore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

        }
        public ObservableCollection<Product> Products { get; } = new();
        public ObservableCollection<ReceiptLineViewModel> Basket { get; } = new();
        public decimal TotalSum => Basket.Sum(rl => rl.TotalPrice);
        private void OnAddProduct(object sender, RoutedEventArgs e)
        {

        }

        private async void OnCheckout(object sender, RoutedEventArgs e)
        {

        }
    }
}
