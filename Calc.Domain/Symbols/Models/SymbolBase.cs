using Calc.Domain.States.Models;

namespace Calc.Domain.Symbols.Models
{
    public abstract class SymbolBase
    {
    }

    /// <summary>
    /// 0-9
    /// </summary>
    public abstract class AllNumber : SymbolBase
    {
        public abstract uint Value { get; }
    }

    /// <summary>
    /// 1-9
    /// </summary>
    public abstract class Number : AllNumber
    {
    }

    /// <summary>
    /// 0
    /// </summary>
    public class Zero : AllNumber
    {
        public override uint Value => 0;
    }

    /// <summary>
    /// 1
    /// </summary>
    public class One : Number
    {
        public override uint Value => 1;
    }

    /// <summary>
    /// 2
    /// </summary>
    public class Two : Number
    {
        public override uint Value => 2;
    }

    /// <summary>
    /// 3
    /// </summary>
    public class Three : Number
    {
        public override uint Value => 3;
    }

    /// <summary>
    /// 4
    /// </summary>
    public class Four : Number
    {
        public override uint Value => 4;
    }

    /// <summary>
    /// 5
    /// </summary>
    public class Five : Number
    {
        public override uint Value => 5;
    }

    /// <summary>
    /// 6
    /// </summary>
    public class Six : Number
    {
        public override uint Value => 6;
    }

    /// <summary>
    /// 7
    /// </summary>
    public class Seven : Number
    {
        public override uint Value => 7;
    }

    /// <summary>
    /// 8
    /// </summary>
    public class Eight : Number
    {
        public override uint Value => 8;
    }

    /// <summary>
    /// 9
    /// </summary>
    public class Night : Number
    {
        public override uint Value => 9;
    }

    /// <summary>
    /// 演算子
    /// </summary>
    public abstract class Operator : SymbolBase
    {
    }

    /// <summary>
    /// +
    /// </summary>
    public class Plus : Operator
    {
    }

    /// <summary>
    /// -
    /// </summary>
    public class Minus : Operator
    {
    }

    /// <summary>
    /// =
    /// </summary>
    public class Equal : SymbolBase
    {
    }

    /// <summary>
    /// 表示されている数値の消去
    /// </summary>
    public class Clear : SymbolBase
    {
    }

    /// <summary>
    /// 状態のリセット
    /// </summary>
    public class AllClear : SymbolBase
    {
    }
}