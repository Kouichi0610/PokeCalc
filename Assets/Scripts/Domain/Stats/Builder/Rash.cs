using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// ‚¤‚Á‚©‚è‚â
    /// </summary>
    internal class Rash : IStatsBuilder
    {
        ICalculator IStatsBuilder.HP => new HP();
        ICalculator IStatsBuilder.Attack => new Flat();
        ICalculator IStatsBuilder.Defence => new Flat();
        ICalculator IStatsBuilder.SpAttack => new Upper();
        ICalculator IStatsBuilder.SpDefence => new Lower();
        ICalculator IStatsBuilder.Speed => new Flat();
    }
}
