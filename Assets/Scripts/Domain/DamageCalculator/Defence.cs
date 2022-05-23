namespace PokeCalc.Domain.DamageCalculator
{
    public sealed class Defence
    {
        readonly int value;

        public int Value => value;

        public Defence(int value)
        {
            if (value <= 0) throw new System.ArgumentOutOfRangeException(value.ToString());
            this.value = value;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Defence)) return false;
            var other = obj as Defence;
            return value == other.value;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
