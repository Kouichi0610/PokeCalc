namespace PokeCalc.Domain.DamageCalculator
{
    public sealed  class Level
    {
        readonly int value;

        public int Value => value;

        public Level(int value)
        {
            if (value <= 0) throw new System.ArgumentOutOfRangeException(value.ToString());
            this.value = value;
        }
    }
}
