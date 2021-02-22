using Calc.Application.Symbols;
using Calc.Domain.Model.States;
using Calc.Domain.Model.Symbols;
using Calc.Domain.Model.Symbols.Numbers;
using Calc.Domain.Model.Symbols.Operators;
using System;

namespace Calc.Application.States
{
    public static class StateApplicationService
    {
        public static event EventHandler<NotifyStateChangedEventArgs>? NotifyStateChanged;

        private static State state_ = new LeftEntry();

        public static void Input(SymbolType type)
        {
            state_ = state_.Input(type switch
            {
                SymbolType.Zero => new Zero(),
                SymbolType.One => new One(),
                SymbolType.Two => new Two(),
                SymbolType.Three => new Three(),
                SymbolType.Four => new Four(),
                SymbolType.Five => new Five(),
                SymbolType.Six => new Six(),
                SymbolType.Seven => new Seven(),
                SymbolType.Eight => new Eight(),
                SymbolType.Nine => new Night(),
                SymbolType.Plus => new Plus(),
                SymbolType.Minus => new Minus(),
                SymbolType.Equal => new Equal(),
                SymbolType.Clear => new Clear(),
                SymbolType.AllClear => new AllClear(),
                _ => throw new ArgumentException(null, nameof(type))
            });
            NotifyStateChanged?.Invoke(null, new NotifyStateChangedEventArgs(new StateData(state_)));
        }
    }
}