using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// ‚È‚Ü‚¢‚«
    /// </summary>
    internal class Sassy : IStatsBuilder
    {
        ICalculator IStatsBuilder.HP => new HP();
        ICalculator IStatsBuilder.Attack => new Flat();
        ICalculator IStatsBuilder.Defence => new Flat();
        ICalculator IStatsBuilder.SpAttack => new Flat();
        ICalculator IStatsBuilder.SpDefence => new Upper();
        ICalculator IStatsBuilder.Speed => new Lower();
    }
}
