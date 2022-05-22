using System;

namespace PokeCalc.Domain.Stats
{
    /// <summary>
    /// �̒l
    /// 
    /// �E���ׂ�Max
    /// �E�Œx(���΂₳�̂�Min)
    /// �E�Ŏ�(���������̂�Min)
    /// �E�Œx�Ŏ�(�U��&�f����Min)
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
