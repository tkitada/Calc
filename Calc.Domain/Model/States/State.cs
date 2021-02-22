using Calc.Domain.Model.Symbols;
using Calc.Domain.Model.Symbols.Operators;

namespace Calc.Domain.Model.States
{
    public abstract class State
    {
        /// <summary>
        /// 演算子
        /// </summary>
        public Operator Operator { get; protected set; } = new Plus();

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
        public abstract State Input(Symbol symbol);
    }
}