namespace PokeCalc.Domain.DamageCalculator
{
    public sealed class Power
    {
        readonly int value;

        public int Value => value;

        public Power(int value)
        {
            if (value <= 0) throw new System.ArgumentOutOfRangeException(value.ToString());
            this.value = value;
        }
    }
}
