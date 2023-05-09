using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new();
            customer.CustomerId = 100;
            MessageBox.Show($"Customer {customer.CustomerId} added!");
        }
    }

    public class Customer
    {
        public int CustomerId { get; set; } 

    }
}
