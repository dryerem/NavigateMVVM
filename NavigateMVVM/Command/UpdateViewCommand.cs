using NavigateMVVM.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigateMVVM.Command
{
    internal class UpdateViewCommand : ICommand
    {
        private MainViewModel _viewModel;
        
        public UpdateViewCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Home")
            {
                _viewModel.CurrentViewModel = new HomeViewModel();
            }
            else if (parameter.ToString() == "Second")
            {
                _viewModel.CurrentViewModel = new SecondViewModel();
            }
        }
    }
}
