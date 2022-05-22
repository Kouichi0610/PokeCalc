namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Damage
    {
        readonly int value;

        public int Value => value;

        /// <summary>
        /// コンストラクタ
        /// Calculaterから使用可能
        /// 外部(Corrector)からは使用禁止
        /// </summary>
        /// <param name="value"></param>
        internal Damage(int value)
        {
            if (value <= 0) value = 0;
            this.value = value;
        }


        public Damage Mul(float n)
        {
            return new Damage((int)(value * n));
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public static bool operator ==(Damage a, Damage b)
        {
            return a.value == b.value;
        }
        public static bool operator !=(Damage a, Damage b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Damage)) return false;
            Damage other = (Damage)obj;
            return other.value == value;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}
