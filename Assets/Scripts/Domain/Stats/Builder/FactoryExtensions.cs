using System.Collections.Generic;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// Nature -> IStatsBuilder変換ファクトリ
    /// </summary>
    public static class FactoryExtensions
    {
        static readonly Dictionary<Nature, IStatsBuilder> dict = new Dictionary<Nature, IStatsBuilder>()
        {
            { Nature.Bashful, new Bashful() },
            { Nature.Lonely, new Lonely() },
            { Nature.Adamant, new Adamant() },
            { Nature.Naughty, new Naughty() },
            { Nature.Brave, new Brave() },
            { Nature.Bold, new Bold() },
            { Nature.Impish, new Impish() },
            { Nature.Lax, new Lax() },
            { Nature.Relaxed, new Relaxed() },
            { Nature.Modest, new Modest() },
            { Nature.Mild, new Mild() },
            { Nature.Rash, new Rash() },
            { Nature.Quiet, new Quiet() },
            { Nature.Calm, new Calm() },
            { Nature.Gentle, new Gentle() },
            { Nature.Careful, new Careful() },
            { Nature.Sassy, new Sassy() },
            { Nature.Timid, new Timid() },
            { Nature.Hasty, new Hasty() },
            { Nature.Jolly, new Jolly() },
            { Nature.Naive, new Naive() },
        };

        public static IStatsBuilder ToStatsBuilder(this Nature nature)
        {
            return dict[nature];
        }
    }
}
