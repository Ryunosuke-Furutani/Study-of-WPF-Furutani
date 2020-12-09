using System.ComponentModel;
using System.Windows.Input;

namespace HelloWpfApp.ViewModel
{
    public class GreetingWindowViewModel : INotifyPropertyChanged
    {
        private string _text = TextResource.INITIAL_TEXT;
        private ICommand _pushButtonCommand;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Text"));
                }
            }
        }

        public ICommand PushButtonCommand
        {
            get
            {
                return _pushButtonCommand = _pushButtonCommand ?? new PushButtonCommand(this);
            }
        }
    }
}
