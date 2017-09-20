using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UltimRules.ViewModel
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public INavigation Navigation;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
