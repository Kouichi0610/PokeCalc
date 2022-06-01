using System.Collections.Generic;

namespace PokeCalc.Domain.Stats
{
    public enum Nature
    {
        Bashful,
        Lonely,
        Adamant,
        Naughty,
        Brave,
        Bold,
        Impish,
        Lax,
        Relaxed,
        Modest,
        Mild,
        Rash,
        Quiet,
        Calm,
        Gentle,
        Careful,
        Sassy,
        Timid,
        Hasty,
        Jolly,
        Naive,
    }

    public static class NatureExtensions
    {
        static readonly Dictionary<Nature, string> dict = new Dictionary<Nature, string>()
        {
            { Nature.Bashful, "てれや" },
            { Nature.Lonely, "さみしがり" },
            { Nature.Adamant, "いじっぱり" },
            { Nature.Naughty, "やんちゃ" },
            { Nature.Brave, "ゆうかん" },
            { Nature.Bold, "ずぶとい" },
            { Nature.Impish, "わんぱく" },
            { Nature.Lax, "のうてんき" },
            { Nature.Relaxed, "のんき" },
            { Nature.Modest, "ひかえめ" },
            { Nature.Mild, "おっとり" },
            { Nature.Rash, "うっかりや" },
            { Nature.Quiet, "れいせい" },
            { Nature.Calm, "おだやか" },
            { Nature.Gentle, "おとなしい" },
            { Nature.Careful, "しんちょう" },
            { Nature.Sassy, "なまいき" },
            { Nature.Timid, "おくびょう" },
            { Nature.Hasty, "せっかち" },
            { Nature.Jolly, "ようき" },
            { Nature.Naive, "むじゃき" },
        };

        public static string Name(this Nature nature)
        {
            return "";
        }
    }
}
