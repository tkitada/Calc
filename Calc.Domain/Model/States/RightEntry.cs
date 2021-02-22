using Calc.Domain.Model.Symbols;
using Calc.Domain.Model.Symbols.Numbers;
using Calc.Domain.Model.Symbols.Operators;
using System;

namespace Calc.Domain.Model.States
{
    /// <summary>
    /// 右辺値入力状態
    /// </summary>
    public class RightEntry : State
    {
        public RightEntry(long left, Operator @operator, long right)
        {
            Left = left;
            Operator = @operator;
            Right = right;
        }

        public override string? Main => Right.ToString();

        public override string? Sub => Left.ToString();

        public override State Input(Symbol symbol)
        {
            if (Operator is null) throw new InvalidOperationException($"{nameof(Operator)} is null");

            return symbol switch
            {
                Number number => new RightEntry(Left, Operator, Right * 10 + number.Value),
                Operator @operator => new OperatorEntry(Operator.Calc(Left, Right), @operator),
                Equal => new Result(Operator.Calc(Left, Right)),
                Clear => new RightEntry(Left, Operator, 0),
                AllClear => new LeftEntry(),
                _ => throw new ArgumentException(null, nameof(symbol))
            };
        }
    }
}