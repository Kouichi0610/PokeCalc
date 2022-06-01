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
            { Nature.Bashful, "�Ă��" },
            { Nature.Lonely, "���݂�����" },
            { Nature.Adamant, "�������ς�" },
            { Nature.Naughty, "��񂿂�" },
            { Nature.Brave, "�䂤����" },
            { Nature.Bold, "���ԂƂ�" },
            { Nature.Impish, "���ς�" },
            { Nature.Lax, "�̂��Ă�" },
            { Nature.Relaxed, "�̂�" },
            { Nature.Modest, "�Ђ�����" },
            { Nature.Mild, "�����Ƃ�" },
            { Nature.Rash, "���������" },
            { Nature.Quiet, "�ꂢ����" },
            { Nature.Calm, "�����₩" },
            { Nature.Gentle, "���ƂȂ���" },
            { Nature.Careful, "���񂿂傤" },
            { Nature.Sassy, "�Ȃ܂���" },
            { Nature.Timid, "�����т傤" },
            { Nature.Hasty, "��������" },
            { Nature.Jolly, "�悤��" },
            { Nature.Naive, "�ނ��Ⴋ" },
        };

        public static string Name(this Nature nature)
        {
            return "";
        }
    }
}
