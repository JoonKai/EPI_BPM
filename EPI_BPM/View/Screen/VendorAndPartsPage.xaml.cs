using EPI_BPM.DB;
using HellsysLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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

namespace EPI_BPM.View.Screen
{
    /// <summary>
    /// VendorPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class VendorAndPartsPage : UserControl
    {
        #region 데이터베이스멤버
        private static string SECTION1 = "DATABASE";
        private static string DbName = "MyDB,db";
        private static string MyDBPath = System.IO.Path.Combine(Helper.EPIIni.Read(SECTION1, "DBPath"), DbName);
        private static string conString = "Data Source=" + MyDBPath;
        //private static BindingSource bindingSrc;
        private static SQLiteConnection connection = new SQLiteConnection(conString);
        private static SQLiteCommand command = new SQLiteCommand("", connection);
        private static string sql;
        private static string dbCommand;
        DBManager _dbm = new DBManager();
        #endregion
        SQLiteConnection sqlCon;
        SQLiteCommand sqlCmd;
        SQLiteDataReader sqlReader;
        public VendorAndPartsPage()
        {
            InitializeComponent();
            InitPage();
        }

        private void InitPage()
        {
            _dbm.Create_DB();
            //UpdateDatabinding();
        }
    }
}
