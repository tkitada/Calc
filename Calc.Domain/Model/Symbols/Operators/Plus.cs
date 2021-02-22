namespace Calc.Domain.Model.Symbols.Operators
{
    /// <summary>
    /// +
    /// </summary>
    public class Plus : Operator
    {
        public override long Calc(long left, long right) => left + right;

        public override string ToString() => "+";
    }
}