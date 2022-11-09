using HellsysLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace HellsysControls.Controls
{
    /// <summary>
    /// EPIComboListboxSingleControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPIComboListboxSingleControl : UserControl
    {
        public string RootFolder { get => @AppDomain.CurrentDomain.BaseDirectory + "\\" + "JRCP" + "\\"; }
        public string RootFile { get => @RootFolder + "\\" + "PL" + ".Json"; }

        public string FolName { get; set; }
        public string FilName { get; set; }

        public EPIComboListboxSingleControl()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            DirectoryInfo di = new DirectoryInfo(RootFolder);
            if (!di.Exists) di.Create();
            FileInfo fi = new FileInfo(RootFile);

            if (fi.Exists)
            {
                List<string> LoadJson = Helper.EPIJson.LoadedJsonFile<string>(RootFile);
                lsbList.ItemsSource = LoadJson;
                cbItems.ItemsSource = LoadJson;
                cbItems.SelectedIndex = 2;
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var jsonFIleName = RootFile;
            List<string> items = GetListViewItems();
            var result = AddItem(items);

            lsbList.ItemsSource = result;
            lsbList.Items.Refresh();
            List<string> list = Helper.EPIJson.GetnerateList(result);
            Helper.EPIJson.SaveToJsonFIle(list, jsonFIleName);

            txbText.Text = "";
            cbItems.ItemsSource = result;



        }


        private List<string> AddItem(List<string> _items)
        {
            if(txbText.Text != "" && !_items.Contains(txbText.Text))
            {
                _items.Add(txbText.Text.ToUpper().Trim().ToString());
            }
            return _items;
        }
        private List<string> GetListViewItems()
        {
            var IDummy = new List<string>();
            if(lsbList.Items.Count == 0)
            {
                return IDummy;
            }
            else
            {
                foreach (var item in lsbList.Items)
                {
                    IDummy.Add(item.ToString());
                }
            }
            return IDummy;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            List<string> Items = GetListViewItems();
            if(lsbList.SelectedIndex >= 0)
            {
                Items.RemoveAt(lsbList.SelectedIndex);
                lsbList.ItemsSource = null;
                lsbList.Items.Clear();
                lsbList.ItemsSource = Items;
                cbItems.ItemsSource = Items;
                List<string> list = Helper.EPIJson.GetnerateList(Items);
                Helper.EPIJson.SaveToJsonFIle(list, RootFile);
            }
        }
    }
}
