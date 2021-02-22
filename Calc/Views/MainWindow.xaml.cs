using Calc.ViewModels;
using System.Windows;

namespace Calc.Views
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel viewModel_ = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = viewModel_;
        }
    }
}