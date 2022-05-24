namespace PokeCalc.Domain.DamageCalculator
{
    public interface IStats
    {
        IStatsValue HP { get; }
        IStatsValue Attack { get; }
        IStatsValue Defence { get; }
        IStatsValue SpAttack { get; }
        IStatsValue SpDefence { get; }
        IStatsValue Speed { get; }
    }
}
