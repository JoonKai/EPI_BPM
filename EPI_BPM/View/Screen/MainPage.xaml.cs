using EPI_BPM.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace EPI_BPM.View.Screen
{
    /// <summary>
    /// MainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            AddDataGridColumns();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            //ExcelDataGrid.BackgroundColor = System.Drawing.Color.White;
            //ExcelDataGrid.ColumnHeadersHeight = 80;
            //ExcelDataGrid.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            //ExcelDataGrid.RowHeadersVisible = false;
            //ExcelDataGrid.AllowUserToAddRows = false;
            //ExcelDataGrid.AllowUserToDeleteRows = false;
            //ExcelDataGrid.AllowUserToResizeColumns = false;
            //ExcelDataGrid.AllowUserToResizeRows = false;
            //ExcelDataGrid.RowTemplate.Height = 70;
            //ExcelDataGrid.Font = new System.Drawing.Font("tahoma", 9);
            //ExcelDataGrid.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            //ExcelDataGrid.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            //ExcelDataGrid.EnableHeadersVisualStyles = false;
            //ExcelDataGrid.MultiSelect = true;
        }

        private void AddDataGridColumns()
        {
            //int num = Helper.DGVHelper.GetCostCategoryCount();
            //List<string> categoryList = new List<string>();
            //categoryList = Helper.DGVHelper.GetCostCotegoryList();

            //for (int i = 0; i < num; i++)
            //{
            //    dgBPM.Columns.Add(categoryList[i].ToString());
            //    dgBPM.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            //    try
            //    {
            //        switch (i)
            //        {
            //            case 0:
            //                dgBPM.Columns[i].Width = 40;
            //                break;
            //            case 1:
            //                dgBPM.Columns[i].Width = 90;
            //                break;
            //            case 2:
            //                dgBPM.Columns[i].Width = 90;
            //                break;
            //            case 28:
            //                dgBPM.Columns[i].Width = 300;
            //                break;
            //            default:
            //                dgBPM.Columns[i].Width = 100;
            //                break;
            //        }
            //    }
            //    catch (Exception) { }

            //}


        }

        private void ExcelDataGrid_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //int currentIndex = ExcelDataGrid.FirstDisplayedScrollingColumnIndex;
            //int ScrollLines = System.Windows.Forms.SystemInformation.MouseWheelScrollLines;
            //if(e.Delta > 0)
            //{
            //    ExcelDataGrid.FirstDisplayedScrollingColumnIndex =Math.Max(0,currentIndex - ScrollLines);
            //}
            //else if(e.Delta < 0)
            //{
            //    ExcelDataGrid.FirstDisplayedScrollingColumnIndex = currentIndex + ScrollLines;
            //}

        }

        private void OptionOpen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Option ow = new Option();
            ow.ShowDialog();
        }
    }
}
