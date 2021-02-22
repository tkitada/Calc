namespace Calc.Domain.Model.Symbols.Numbers
{
    /// <summary>
    /// 0-9
    /// </summary>
    public abstract class Number : Symbol
    {
        public abstract uint Value { get; }
    }
}