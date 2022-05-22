namespace PokeCalc.Domain.DamageCalculator
{
    public sealed class Offence
    {
        readonly int value;

        public int Value => value;

        public Offence(int value)
        {
            if (value <= 0) throw new System.ArgumentOutOfRangeException(value.ToString());
            this.value = value;
        }
    }
}
