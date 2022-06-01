using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// �悤��
    /// </summary>
    internal class Jolly : IStatsBuilder
    {
        ICalculator IStatsBuilder.HP => new HP();
        ICalculator IStatsBuilder.Attack => new Flat();
        ICalculator IStatsBuilder.Defence => new Flat();
        ICalculator IStatsBuilder.SpAttack => new Lower();
        ICalculator IStatsBuilder.SpDefence => new Flat();
        ICalculator IStatsBuilder.Speed => new Upper();
    }
}
