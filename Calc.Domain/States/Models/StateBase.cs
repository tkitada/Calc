using Calc.Domain.Symbols.Models;
using System;

namespace Calc.Domain.States.Models
{
    public abstract class StateBase
    {
        /// <summary>
        /// 演算子
        /// </summary>
        public Operator? Operator { get; protected set; }

        /// <summary>
        /// 左辺値
        /// </summary>
        public long Left { get; protected set; }

        /// <summary>
        /// 右辺値
        /// </summary>
        public long Right { get; protected set; }

        /// <summary>
        /// 状態を遷移させる入力
        /// </summary>
        /// <param name="symbol">入力シンボル</param>
        /// <returns>遷移後の状態</returns>
        public abstract StateBase Input(SymbolBase symbol);
    }

    /// <summary>
    /// 左辺値入力状態
    /// </summary>
    public class LeftEntry : StateBase
    {
        public override StateBase Input(SymbolBase symbol) => throw new NotImplementedException();
    }

    /// <summary>
    /// 演算子入力状態
    /// </summary>
    public class OperatorEntry : StateBase
    {
        public override StateBase Input(SymbolBase symbol) => throw new NotImplementedException();
    }

    /// <summary>
    /// 右辺値入力状態
    /// </summary>
    public class RightEntry : StateBase
    {
        public override StateBase Input(SymbolBase symbol) => throw new NotImplementedException();
    }

    /// <summary>
    /// 結果表示状態
    /// </summary>
    public class Result : StateBase
    {
        public override StateBase Input(SymbolBase symbol) => throw new NotImplementedException();
    }
}