using Calc.Domain.Model.Symbols;
using Calc.Domain.Model.Symbols.Numbers;
using Calc.Domain.Model.Symbols.Operators;
using System;

namespace Calc.Domain.Model.States
{
    /// <summary>
    /// 左辺値入力状態
    /// </summary>
    public class LeftEntry : State
    {
        public LeftEntry()
        {
        }

        public LeftEntry(long left) => Left = left;

        public override string? Main => Left.ToString();

        public override string? Sub => null;

        public override State Input(Symbol symbol) => symbol switch
        {
            Number number => new LeftEntry(Left * 10 + number.Value),
            Operator @operator => new OperatorEntry(Left, @operator),
            Equal => this,
            Clear or AllClear => new LeftEntry(),
            _ => throw new ArgumentException(null, nameof(symbol))
        };
    }
}