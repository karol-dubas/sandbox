using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_demo
{
    public class SampleViewModel : BaseViewModel
    {
        public SampleViewModel()
        {
            SaveCmd = new RelayCommand(pars => Save());
        }

        public ICommand SaveCmd { get; set; }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private void Save()
        {
            // Send to DB
        }
    }
}
