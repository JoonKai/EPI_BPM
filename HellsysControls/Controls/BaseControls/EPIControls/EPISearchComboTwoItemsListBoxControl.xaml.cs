using HellsysLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HellsysControls.Controls.BaseControls.EPIControls
{
    /// <summary>
    /// EPISearchComboListBoxDualControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPISearchComboTwoItemsListBoxControl : UserControl
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string RootFolder { get => @AppDomain.CurrentDomain.BaseDirectory + "\\" + FolName + "\\"; }
        public string RootFile { get => @RootFolder + "\\" + FilName + ".Json"; }

        public string Title { get; set; }
        public string FolName { get; set; }
        public string FilName { get; set; }

        private TextBox mTxtBox = null;
        

        public EPISearchComboTwoItemsListBoxControl()
        {
            InitializeComponent();
            DataContext = this;
        }


        #region 이벤트
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //this.mTxtBox = cbItems.Template.FindName("PART_EditableTextBox", cbItems) as TextBox;


            DirectoryInfo di = new DirectoryInfo(RootFolder);
            if (!di.Exists) di.Create();
            FileInfo fi = new FileInfo(RootFile);

            if (fi.Exists)
            {
                List<string> jsonList = Helper.EPIJson.GetJsonFileList<string>(RootFile);
                lsbList.ItemsSource = jsonList;
                cbItems.ItemsSource = jsonList;
            }
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var jsonFileName = RootFile;
            List<string> items = GetListViewItems();
            var result = AddItem(items);

            lsbList.ItemsSource = result;
            lsbList.Items.Refresh();
            Helper.EPIJson.SaveToJsonFile(result, jsonFileName);

            txbText.Text = "";
            cbItems.ItemsSource = result;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            List<string> Items = GetListViewItems();
            if (lsbList.SelectedIndex >= 0)
            {
                Items.RemoveAt(lsbList.SelectedIndex);
                lsbList.ItemsSource = null;
                lsbList.Items.Clear();
                lsbList.ItemsSource = Items;
                cbItems.ItemsSource = Items;
                Helper.EPIJson.SaveToJsonFile(Items, RootFile);
            }
        }
        #endregion

        private List<string> AddItem(List<string> _items)
        {
            if (txbText.Text != "" && !_items.Contains(txbText.Text))
            {
                _items.Add(txbText.Text.ToUpper().Trim().ToString());
            }
            return _items;
        }
        private List<string> GetListViewItems()
        {
            var IDummy = new List<string>();
            if (lsbList.Items.Count == 0)
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

        //private void cbItems_KeyUp(object sender, KeyEventArgs e)
        //{
        //    cbItems.Items.Filter -= this.FilterPredicate;

        //    if((e.Key ==Key.Enter)||(e.Key == Key.Tab)||(e.Key == Key.Return))
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        cbItems.IsDropDownOpen = true;
        //        cbItems.Items.Filter += this.FilterPredicate;
        //    }
        //}
        //private bool FilterPredicate(object obj)
        //{
        //    string sValue = string.Empty;

        //    if(obj is string)
        //        sValue= obj.ToString();
        //    else if(obj is ComboBoxItem)
        //    {
        //        sValue = (obj as ComboBoxItem).Content.ToString();
        //    }
        //    else
        //    {
        //        System.Reflection.PropertyInfo info = obj.GetType().GetProperty(cbItems.DisplayMemberPath);
        //        if(info != null )
        //        {
        //            object oValue = info.GetValue(obj, null);
        //            if(oValue != null)
        //            {
        //                sValue= oValue.ToString();
        //            }
        //        }
        //    }

        //    if (!string.IsNullOrEmpty(sValue) && sValue.Contains(this.mTxtBox.Text))
        //        return true;
        //    else
        //        return false;
        //}
    }
}
