using Cipher_Шифер_.Core;
using System;

namespace Cipher_Шифер_.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand Base64ViewCommand { get; set; }
        public RelayCommand ROTViewCommand { get; set; }

        public Base64ViewModel Base64VM { get; set; }
        public ROTViewModel ROTVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            Base64VM = new Base64ViewModel();
            ROTVM = new ROTViewModel();
            CurrentView = Base64VM;

            Base64ViewCommand = new RelayCommand(o =>
            {
                CurrentView = Base64VM;
            });

            ROTViewCommand = new RelayCommand(o =>
            {
                CurrentView = ROTVM;
            });
        }
    }
}
