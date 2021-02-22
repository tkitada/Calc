using Calc.Domain.Model.States;
using Calc.Domain.Model.Symbols;
using Calc.Domain.Model.Symbols.Numbers;
using Calc.Domain.Model.Symbols.Operators;
using System;

namespace Calc.Application
{
    public static class CalcApplicationService
    {
        private static State state_ = new LeftEntry();

        public static void Input(InputType type) => state_ = state_.Input(type switch
        {
            InputType.Zero => new Zero(),
            InputType.One => new One(),
            InputType.Two => new Two(),
            InputType.Three => new Three(),
            InputType.Four => new Four(),
            InputType.Five => new Five(),
            InputType.Six => new Six(),
            InputType.Seven => new Seven(),
            InputType.Eight => new Eight(),
            InputType.Night => new Night(),
            InputType.Plus => new Plus(),
            InputType.Minus => new Minus(),
            InputType.Equal => new Equal(),
            InputType.Clear => new Clear(),
            InputType.AllClear => new AllClear(),
            _ => throw new ArgumentException(null, nameof(type))
        });
    }
}