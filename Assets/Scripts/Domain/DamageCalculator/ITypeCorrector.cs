namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// �_���[�W�␳�C���^�[�t�F�C�X
    /// </summary>
    public interface ITypeCorrector
    {
        Damage Correct(Damage damage);
    }
}
