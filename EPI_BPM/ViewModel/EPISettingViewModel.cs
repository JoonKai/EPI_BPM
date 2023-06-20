using EPI_BPM.Commands;
using EPI_BPM.Model;
using System.Windows;
using System.Windows.Input;

namespace EPI_BPM.ViewModel
{
    public class EPISettingViewModel : ViewModelBase
    {
        DatabaseSettingItem dbsetting = new DatabaseSettingItem();
        public string DBPath
        {
            get => dbsetting.DBPath;
            set
            {
                dbsetting.DBPath = value;
                OnPropertyChanged(nameof(DBPath));
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

    //public class SubViewModel : ViewModelBase, IParameterReceiver
    //{
    //    public SubData SubData { get; set; } = default;
    //    public void ReceiveParameter(object parameter)
    //    {

    //        if (parameter is SubData subData)
    //        {
    //            SubData = subData;
    //        }
    //    }
    //}
}
