using Calc.Application.States;
using Calc.Application.Symbols;

namespace Calc.ViewModels
{
    public class MainWindowViewModel : NotifycationObject
    {
        #region bind property

        private string? mainDisplay_;
        private string? subDisplay_;
        private string? operatorDisplay_;

        public string? MainDisplay
        {
            get => mainDisplay_;
            set => SetProperty(ref mainDisplay_, value);
        }

        public string? SubDisplay
        {
            get => subDisplay_;
            set => SetProperty(ref subDisplay_, value);
        }

        public string? OperatorDisplay
        {
            get => operatorDisplay_;
            set => SetProperty(ref operatorDisplay_, value);
        }

        #endregion bind property

        #region bind command

        private DelegateCommand? pushZeroCmd_;
        private DelegateCommand? pushOneCmd_;
        private DelegateCommand? pushTwoCmd_;
        private DelegateCommand? pushThreeCmd_;
        private DelegateCommand? pushFourCmd_;
        private DelegateCommand? pushFiveCmd_;
        private DelegateCommand? pushSixCmd_;
        private DelegateCommand? pushSevenCmd_;
        private DelegateCommand? pushEightCmd_;
        private DelegateCommand? pushNineCmd_;
        private DelegateCommand? pushPlusCmd_;
        private DelegateCommand? pushMinusCmd_;
        private DelegateCommand? pushEqualCmd_;
        private DelegateCommand? pushClearCmd_;
        private DelegateCommand? pushAllClearCmd_;

        public DelegateCommand PushZeroCmd => pushZeroCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Zero));
        public DelegateCommand PushOneCmd => pushOneCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.One));
        public DelegateCommand PushTwoCmd => pushTwoCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Two));
        public DelegateCommand PushThreeCmd => pushThreeCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Three));
        public DelegateCommand PushFourCmd => pushFourCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Four));
        public DelegateCommand PushFiveCmd => pushFiveCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Five));
        public DelegateCommand PushSixCmd => pushSixCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Six));
        public DelegateCommand PushSevenCmd => pushSevenCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Seven));
        public DelegateCommand PushEightCmd => pushEightCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Eight));
        public DelegateCommand PushNineCmd => pushNineCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Nine));
        public DelegateCommand PushPlusCmd => pushPlusCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Plus));
        public DelegateCommand PushMinusCmd => pushMinusCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Minus));
        public DelegateCommand PushEqualCmd => pushEqualCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Equal));
        public DelegateCommand PushClearCmd => pushClearCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.Clear));
        public DelegateCommand PushAllClearCmd => pushAllClearCmd_ ??= new DelegateCommand(() => StateApplicationService.Input(SymbolType.AllClear));

        #endregion bind command

        public MainWindowViewModel() =>
            StateApplicationService.NotifyStateChanged += (_, e) =>
            {
                MainDisplay = e.State.Main;
                SubDisplay = e.State.Sub;
                OperatorDisplay = e.State.Operator;
            };
    }
}