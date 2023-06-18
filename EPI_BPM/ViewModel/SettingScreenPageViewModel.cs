using EPI_BPM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace EPI_BPM.ViewModel
{
    public class SettingScreenPageViewModel : ViewModelBase
    {
        string dbPath = "석이";
        public string DBPath 
        {
            get
            {
                return dbPath;
            }
            set
            {
                dbPath = value;
                OnPropertyChanged(nameof(DBPath));
                MessageBox.Show("시작");
            }
        }
        public ICommand saveCommand => new RelayCommand<string>(SaveIni);
        public ICommand loadCommand => new RelayCommand<string>(LoadIni);

        private void LoadIni(string obj)
        {
            
        }

        private void SaveIni(string obj)
        {
            DBPath = "손준석";
            MessageBox.Show(DBPath);
        }
    }
}
