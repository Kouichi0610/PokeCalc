using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// ��������
    /// </summary>
    internal class Hasty : IStatsBuilder
    {
        ICalculator IStatsBuilder.HP => new HP();
        ICalculator IStatsBuilder.Attack => new Flat();
        ICalculator IStatsBuilder.Defence => new Lower();
        ICalculator IStatsBuilder.SpAttack => new Flat();
        ICalculator IStatsBuilder.SpDefence => new Flat();
        ICalculator IStatsBuilder.Speed => new Upper();
    }
}
