using System;

namespace PokeCalc.Domain.Stats
{
    /// <summary>
    /// Šî‘bƒ|ƒCƒ“ƒg(“w—Í’l)
    /// 0 ` 252
    /// </summary>
    public class BasePoints
    {
        static readonly int Min = 0;
        static readonly int Max = 252;
        readonly int value;

        public int Value => value;

        public BasePoints(int value)
        {
            if (value < Min || value > Max) throw new ArgumentOutOfRangeException(value.ToString());
            this.value = value;
        }
    }
}
/*
 * UŒ‚‘¤Aç”õ‘¤
 * ˆĞ—Í
 */