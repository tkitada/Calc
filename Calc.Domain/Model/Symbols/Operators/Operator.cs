namespace Calc.Domain.Model.Symbols.Operators
{
    /// <summary>
    /// 演算子
    /// </summary>
    public abstract class Operator : Symbol
    {
        public abstract long Calc(long left, long right);
    }
}