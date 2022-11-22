﻿using HellsysLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace HellsysControls.Controls.BaseControls
{
    /// <summary>
    /// EPIComboListboxSingleControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPIComboListboxSingleControl : UserControl
    {
        public string RootFolder { get => @AppDomain.CurrentDomain.BaseDirectory + "\\" + FolName + "\\"; }
        public string RootFile { get => @RootFolder + "\\" + FilName + ".Json"; }

        public string Title { get; set; }
        public string FolName { get; set; }
        public string FilName { get; set; }


        public EPIComboListboxSingleControl()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
            DirectoryInfo di = new DirectoryInfo(RootFolder);
            if (!di.Exists) di.Create();
            FileInfo fi = new FileInfo(RootFile);

            if (fi.Exists)
            {
                List<string> jsonList = Helper.EPIJson.GetJsonFileList<string>(RootFile);
                lsbList.ItemsSource = jsonList;
                cbItems.ItemsSource = jsonList;
                cbItems.SelectedIndex = 2;
            }
        }
        #region 이벤트
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
            if(lsbList.SelectedIndex >= 0)
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
    }
}
