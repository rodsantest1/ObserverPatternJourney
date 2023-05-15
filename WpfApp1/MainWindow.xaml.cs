using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Customer _customer = new Customer();
        public Customer Customer => _customer;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _customer;
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            _customer.CustomerId += 100;
            MessageBox.Show($"Customer {_customer.CustomerId} added!");
        }
    }

    public class Customer : INotifyPropertyChanged
    {
        private int _customerId;
        public int CustomerId
        {
            get => _customerId;
            set
            {
                _customerId = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
