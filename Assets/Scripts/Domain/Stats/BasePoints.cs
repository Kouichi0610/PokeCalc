using System;

namespace PokeCalc.Domain.Stats
{
    /// <summary>
    /// ��b�|�C���g(�w�͒l)
    /// 0 �` 252
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
 * �U�����A�����
 * �З�
 */