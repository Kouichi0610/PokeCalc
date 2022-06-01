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
            { Nature.Bashful, "‚Ä‚ê‚â" },
            { Nature.Lonely, "‚³‚Ý‚µ‚ª‚è" },
            { Nature.Adamant, "‚¢‚¶‚Á‚Ï‚è" },
            { Nature.Naughty, "‚â‚ñ‚¿‚á" },
            { Nature.Brave, "‚ä‚¤‚©‚ñ" },
            { Nature.Bold, "‚¸‚Ô‚Æ‚¢" },
            { Nature.Impish, "‚í‚ñ‚Ï‚­" },
            { Nature.Lax, "‚Ì‚¤‚Ä‚ñ‚«" },
            { Nature.Relaxed, "‚Ì‚ñ‚«" },
            { Nature.Modest, "‚Ð‚©‚¦‚ß" },
            { Nature.Mild, "‚¨‚Á‚Æ‚è" },
            { Nature.Rash, "‚¤‚Á‚©‚è‚â" },
            { Nature.Quiet, "‚ê‚¢‚¹‚¢" },
            { Nature.Calm, "‚¨‚¾‚â‚©" },
            { Nature.Gentle, "‚¨‚Æ‚È‚µ‚¢" },
            { Nature.Careful, "‚µ‚ñ‚¿‚å‚¤" },
            { Nature.Sassy, "‚È‚Ü‚¢‚«" },
            { Nature.Timid, "‚¨‚­‚Ñ‚å‚¤" },
            { Nature.Hasty, "‚¹‚Á‚©‚¿" },
            { Nature.Jolly, "‚æ‚¤‚«" },
            { Nature.Naive, "‚Þ‚¶‚á‚«" },
        };

        public static string Name(this Nature nature)
        {
            return "";
        }
    }
}
