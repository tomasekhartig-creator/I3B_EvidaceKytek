using I3B_EvidaceKytek.Interfaces;
using I3B_EvidaceKytek.models;
using System;
using System.Collections.Generic;
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

namespace I3B_EvidaceKytek.Windows
{
    /// <summary>
    /// Interakční logika pro AddNewFlowerWindows.xaml
    /// </summary>
    public partial class AddNewFlowerWindows : Window
    {
        IFlowerManager _manager;
        public AddNewFlowerWindows(IFlowerManager manager)
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Flower newFlower = getFlower();
                _manager.Add(newFlower);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private Flower getFlower()
        {
            string name = NameInput.Text;
            string genus = GenusInput.Text;
            string color = ColorInput.SelectedValue.ToString();
            if(name.Length > 2 || genus.Length > 2 || ColorInput.SelectedIndex  != -1)
            {
                return new Flower { Name = name,
                    Genus = genus,
                    Color = color
                };
            }
            throw new Exception("The input data are incorrect!");
            return new Flower { Name = name,
                Genus = genus,
                Color = color
            };
        }
    }
}
