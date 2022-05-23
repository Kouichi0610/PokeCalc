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

        public override bool Equals(object obj)
        {
            if (!(obj is Offence)) return false;
            var other = obj as Offence;
            return value == other.value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
