namespace Calc.Domain.Model.Symbols.Operators
{
    /// <summary>
    /// -
    /// </summary>
    public class Minus : Operator
    {
        public override long Calc(long left, long right) => left - right;

        public override string ToString() => "Minus";
    }
}