using DemoLibrary;
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

namespace WPFMiniProject
{
    /// <summary>
    /// Interaction logic for AddressWindow.xaml
    /// </summary>
    public partial class AddressWindow : Window
    {
        ISaveAddress _parent;
        public AddressWindow(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void submitAddressButton_Click(object sender, RoutedEventArgs e)
        {
            _parent.SaveAddress(new AddressModel
            {
                HouseNumber = houseNumberText.Text,
                District = districtText.Text,
                State = stateText.Text,
                ZipCode = zipCodeText.Text
            });

            this.Close();
        }
    }
}
