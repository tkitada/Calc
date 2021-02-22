using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Calc.ViewModels
{
    public abstract class NotifycationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void SetProperty<T>(ref T target, T value, [CallerMemberName] string caller = "")
        {
            target = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }

    public class DelegateCommand : ICommand
    {
        private readonly Action execute_;
        private readonly Func<bool>? canExecute_;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public DelegateCommand(Action execute, Func<bool>? canExecute = null)
        {
            execute_ = execute;
            canExecute_ = canExecute;
        }

        public void Execute(object? parameter) => execute_?.Invoke();

        public bool CanExecute(object? parameter) => canExecute_ is null || canExecute_();
    }

    public class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> execute_;
        private readonly Func<T, bool>? canExecute_;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public DelegateCommand(Action<T> execute, Func<T, bool>? canExecute = null)
        {
            execute_ = execute;
            canExecute_ = canExecute;
        }

        public void Execute(object? parameter)
        {
            if (parameter is T param) execute_?.Invoke(param);
        }

        public bool CanExecute(object? parameter) => canExecute_ is null || (parameter is T param ? canExecute_(param) : throw new ArgumentException(null, nameof(parameter)));
    }
}