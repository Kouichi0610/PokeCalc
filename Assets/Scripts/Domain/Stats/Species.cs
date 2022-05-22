using System;

namespace PokeCalc.Domain.Stats
{
    /// <summary>
    /// Ží‘°’l
    /// </summary>
    public class Species
    {
        readonly static int Min = 1;
        readonly static int Max = 999;
        readonly int value;

        public int Value => value;

        public Species(int value)
        {
            if (value < Min || value > Max) throw new ArgumentOutOfRangeException(value.ToString());
            this.value = value;
        }
    }
}
