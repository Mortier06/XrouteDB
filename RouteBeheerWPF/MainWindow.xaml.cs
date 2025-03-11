using RouteBeheerBL.interfaces;
using RouteBeheerBL.managers;
using RouteBeheerDB.Repository;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RouteBeheerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NetworkManager networkManager;
        string connectionString = "Data Source=PF4RK5Y6\\SQLEXPRESS;Initial Catalog=XrouteTest;Integrated Security=True;Trust Server Certificate=True";

        public MainWindow()
        {
            InitializeComponent();
            networkManager = new NetworkManager(new NetwerkRepository(connectionString));
        }

        private void ButtonSaveLocation(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("knop gedrukt maar doet niks")
        }
    }
}