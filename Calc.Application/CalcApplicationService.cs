using Calc.Domain.States.Models;
using Calc.Domain.Symbols.Models;
using System;

namespace Calc.Application
{
    public static class CalcApplicationService
    {
        private static StateBase state_ = new LeftEntry();

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

    public enum InputType
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Night,
        Plus,
        Minus,
        Multi,
        Divide,
        Equal,
        Clear,
        AllClear,
    }
}