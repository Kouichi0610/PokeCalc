namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// �U�����Ɩh�䑤�̐��
    /// </summary>
    public interface IForce
    {
        IStats Offence { get; }
        IStats Defence { get; }
    }
}
