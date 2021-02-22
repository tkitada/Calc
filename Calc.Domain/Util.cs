using System;

namespace Calc.Domain
{
    public static class Util
    {
        /// <summary>
        /// 桁数を求める ただし0は0桁<br/>
        /// Mathf.Log10(0)はNegativeInfinityを返すため、別途処理する。
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int GetDigit(ulong num) => num == 0 ? 0 : (int)MathF.Log10(num) + 1;
    }
}