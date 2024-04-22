using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp4
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private int _fontSize = 14;

        public MainWindowViewModel()
        {
            IncreaseTextSizeCommand = new IncreaseTextSizeCommand(this);
            DecreaseTextSizeCommand = new DecreaseTextSizeCommand(this);
        }

        public int FontSize
        {
            get => _fontSize; set
            {
                _fontSize = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public void IncreaseTextSize() => FontSize += 2;
        public void DecreaseTextSize() => FontSize -= 2;

        public ICommand IncreaseTextSizeCommand { get;  }
        public ICommand DecreaseTextSizeCommand { get;  }


        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
