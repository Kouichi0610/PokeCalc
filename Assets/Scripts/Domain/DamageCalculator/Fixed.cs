namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// �����イ�Ȃ��A��イ�̂�����Ȃ�
    /// �Œ�_���[�W
    /// �^�C�v�����ł��������Ȃ�����ɂ�0
    /// </summary>
    public sealed class Fixed : IFomula
    {
        readonly Damage damage;

        public Fixed(int damage, ITypeCorrector corrector)
        {
            this.damage = new Damage(damage);
            var corrected = corrector.Correct(this.damage);
            if (corrected.Value == 0) this.damage = new Damage(0);
        }
        Damage IFomula.Calculate()
        {
            return damage;
        }
    }
}
