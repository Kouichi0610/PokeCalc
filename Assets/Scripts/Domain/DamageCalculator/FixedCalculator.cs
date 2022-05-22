namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// ちきゅうなげ、りゅうのいかりなど
    /// 固定ダメージ
    /// タイプ相性でこうかがない相手には0
    /// </summary>
    public sealed class FixedCalculator : IDamageCalculator
    {
        readonly Damage damage;

        public FixedCalculator(int damage, ITypeCorrector corrector)
        {
            this.damage = new Damage(damage);
            var corrected = corrector.Correct(this.damage);
            if (corrected.Value == 0) this.damage = new Damage(0);
        }
        Damage IDamageCalculator.Calculate()
        {
            return damage;
        }
    }
}
