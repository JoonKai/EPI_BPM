using System;
using System.Windows.Input;

namespace NestedUserControl
{
    public class ClearCommand : ICommand
    {
        private MainViewModel mainViewModel;

        public ClearCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainViewModel.Text1 = "";
            mainViewModel.Text2 = "";
        }
    }
}