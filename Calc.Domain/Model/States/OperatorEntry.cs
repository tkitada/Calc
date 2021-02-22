using Calc.Domain.Model.Symbols;
using Calc.Domain.Model.Symbols.Numbers;
using Calc.Domain.Model.Symbols.Operators;
using System;

namespace Calc.Domain.Model.States
{
    /// <summary>
    /// 演算子入力状態
    /// </summary>
    public class OperatorEntry : State
    {
        public OperatorEntry(long left, Operator @operator)
        {
            Left = left;
            Operator = @operator;
        }

        public override State Input(Symbol symbol) => symbol switch
        {
            Number number => new RightEntry(Left, Operator, number.Value),
            Operator @operator => new OperatorEntry(Left, @operator),
            Equal => new Result(Left),
            Clear => this,
            AllClear => new LeftEntry(),
            _ => throw new ArgumentException(null, nameof(symbol))
        };
    }
}