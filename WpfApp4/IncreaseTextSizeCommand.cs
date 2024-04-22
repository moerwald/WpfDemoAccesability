using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp4
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter) => true;

        public abstract void Execute(object? parameter);

        public EventHandler OnCanExecute;

        protected void OnCanExecuteChanged()
        {
            OnCanExecute?.Invoke(this, EventArgs.Empty);   
        }
    }



    public class IncreaseTextSizeCommand : CommandBase

    {
        private MainWindowViewModel _viewModel;

        public IncreaseTextSizeCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            _viewModel.IncreaseTextSize();
        }
    }
    public class DecreaseTextSizeCommand : CommandBase
    {
        private MainWindowViewModel _viewModel;

        public DecreaseTextSizeCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            _viewModel.DecreaseTextSize();
        }
    }
}
