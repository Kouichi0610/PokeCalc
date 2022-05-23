namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// ダメージ補正インターフェイス
    /// </summary>
    public interface ITypeCorrector
    {
        Damage Correct(Damage damage);
    }
}
