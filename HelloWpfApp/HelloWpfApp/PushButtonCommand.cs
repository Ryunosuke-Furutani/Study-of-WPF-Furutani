using System;
using System.Windows.Input;

namespace HelloWpfApp
{
    class PushButtonCommand : ICommand
    {
        private readonly ViewModel.GreetingWindowViewModel _viewModel;
        private readonly string _greetingText = TextResource._greetingText;

        public PushButtonCommand(ViewModel.GreetingWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.Text = _greetingText;
        }
    }
}
