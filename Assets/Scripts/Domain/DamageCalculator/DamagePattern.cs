using System.Collections.Generic;
using System.Linq;

namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// �_���[�W�̃p�^�[���ꗗ�̌v�Z
    /// </summary>
    public class DamagePattern
    {
        readonly IReadOnlyList<Damage> damages;
        readonly IReadOnlyList<Damage> criticals = new List<Damage>();

        public DamagePattern(Damage baseDamage, ICriticalCorrector critical)
        {
            if (baseDamage.Value == 0)
            {
                this.damages = new List<Damage>() { baseDamage };
                this.criticals = new List<Damage>() { baseDamage };
                return;
            }
            List<Damage> damages = new List<Damage>();
            List<Damage> criticals = new List<Damage>();

            // TODO:Mul��float����ύX������
            for (var i = 0; i <16; i ++)
            {
                float n = (85 + i) / 100.0f;
                var d = baseDamage.Mul(n);
                var c = critical.Correct(d);

                damages.Add(d);
                criticals.Add(c);
            }

            this.damages = damages;
            this.criticals = criticals;
        }

        public Damage[] Damages => damages.ToArray();
        public Damage[] Criticals => criticals.ToArray();

        public override string ToString()
        {
            var res = new System.Text.StringBuilder();

            res.Append(damages);
            res.Append(criticals);

            return res.ToString();
        }

        // TODO:�v�Z��
        // �_���[�W���痐��(0.85 �` 1.00)�p�^�[���𐶐�
        // �}���␳1.5(�X�i�C�p�[�␳��2.25)
    }
}
