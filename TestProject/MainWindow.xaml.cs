using SourceGrid2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestProject
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grd.BorderStyle = BorderStyle.FixedSingle;
            grd.ColumnsCount = 3;
            grd.FixedRows = 1;
            grd.Rows.Insert(0);
            
            grd[0, 0] = new SourceGrid2.Cells.Real.ColumnHeader("String");
            grd[0, 1] = new SourceGrid2.Cells.Real.ColumnHeader("DateTime");
            grd[0, 2] = new SourceGrid2.Cells.Real.ColumnHeader("CheckBox");
            for (int r = 1; r < 10; r++)
            {
                grd.Rows.Insert(r);
                grd[r, 0] = new SourceGrid2.Cells.Real.Cell("Hello "
                  + r.ToString(), typeof(string));
                grd[r, 1] = new SourceGrid2.Cells.Real.Cell(
                  DateTime.Today, typeof(DateTime));
                grd[r, 2] = new SourceGrid2.Cells.Real.CheckBox(true);
            }
            grd.AutoSizeAll();
        }
    }
}
