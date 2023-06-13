using EPI_BPM.Model;
using EPI_BPM.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace EPI_BPM.View.LaoutControl
{
    /// <summary>
    /// VendorControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class VendorControl : UserControl
    {
        public VendorControl()
        {
            InitializeComponent();
            Loaded += VendorControl_Loaded;
        }

        private void VendorControl_Loaded(object sender, RoutedEventArgs e)
        {
            VendorControlViewModel vendorControlViewModel = new VendorControlViewModel();
            this.DataContext = vendorControlViewModel;
        }

        private void vendorAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vendorDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vendorSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vendorRefresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            string filter = textBox.Text;

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.vendorDG.ItemsSource);

            if (string.IsNullOrWhiteSpace(filter))
            {
                collectionView.Filter = null;
            }
            else
            {
                collectionView.Filter = item =>
                {
                    Vendor vendor = item as Vendor;

                    switch (textBox.Name)
                    {
                        case "VendorCode_txt":
                            return (vendor.VendorCode.ToUpper().Contains(filter.ToUpper()));
                        case "VendorName_txt":
                            return (vendor.VendorName.ToUpper().Contains(filter.ToUpper()));
                        case "VendorPerson_txt":
                            return (vendor.VendorPerson.ToUpper().Contains(filter.ToUpper()));
                        case "VendorPersonCellPhone_txt":
                            return (vendor.VendorPersonCellPhone.ToUpper().Contains(filter.ToUpper()));
                        case "VendorProduct_txt":
                            return (vendor.VendorProduct.ToUpper().Contains(filter.ToUpper()));
                        case "VendorNote_txt":
                            return (vendor.VendorNote.ToUpper().Contains(filter.ToUpper()));
                    }
                    return (vendor.VendorCode.ToUpper().Contains(filter.ToUpper()));
                };
            }
        }
    }
}
