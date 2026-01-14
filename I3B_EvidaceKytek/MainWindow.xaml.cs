using I3B_EvidaceKytek.Database;
using I3B_EvidaceKytek.Interfaces;
using I3B_EvidaceKytek.Managers;
using I3B_EvidaceKytek.models;
using I3B_EvidaceKytek.Repositories;
using I3B_EvidaceKytek.Windows;
using System.Collections.ObjectModel;
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

namespace I3B_EvidaceKytek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Flower> Data { get; set; }
        public IFlowerManager Manager { get; set; }
        public MainWindow()
        {
            IFlowerRepository repository = new FlowerRepository(new FlowerContext());
            Manager = new FlowerManager(repository);
            Data = new ObservableCollection<Flower>(Manager.GetAll());
            InitializeComponent();

            LV.ItemsSource = Data;
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            AddNewFlowerWindows AddWindow = new(Manager);
            AddWindow.Closing += (s, e) =>
            {
                Data.Clear();   
                 LV.ItemsSource = Data;
            };

            AddWindow.ShowDialog();
        }
    }
}