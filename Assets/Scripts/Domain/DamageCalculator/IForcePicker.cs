namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// �U�h�̐�͂��擾
    /// </summary>
    public interface IForcePicker
    {
        Offence Offence { get; }
        Defence Defence { get; }
        Power Power { get; }
    }
}
