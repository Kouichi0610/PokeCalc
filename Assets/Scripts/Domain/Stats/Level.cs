using System;

namespace PokeCalc.Domain.Stats
{
    /// <summary>
    /// ƒŒƒxƒ‹
    /// </summary>
    public class Level
    {
        static readonly int Min = 1;
        static readonly int Max = 100;

        readonly int value;
        public int Value => value;

        public Level(int value)
        {
            if (value < Min || value > Max) throw new ArgumentOutOfRangeException(value.ToString());
            this.value = value;
        }
    }
}
