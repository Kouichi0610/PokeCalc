using System;

namespace PokeCalc.Domain.Stats
{
    /// <summary>
    /// 個体値
    /// 
    /// ・すべてMax
    /// ・最遅(すばやさのみMin)
    /// ・最弱(こうげきのみMin)
    /// ・最遅最弱(攻撃&素早さMin)
    /// </summary>
    public class Individuals
    {
        readonly int value;

        public static Individuals Max => new Individuals(31);
        public static Individuals Min => new Individuals(0);

        public int Value => value;

        private Individuals(int value)
        {
            if (value < 0 || value > 31)
            {
                throw new ArgumentOutOfRangeException(value.ToString());
            }
            this.value = value;
        }
    }
}
