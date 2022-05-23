using PokeCalc.Domain.Types;
using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.TypeMatch
{
    /// <summary>
    /// �^�C�v��v�␳
    /// �g�p����킴�̃^�C�v��
    /// �g�p����|�P�����̃^�C�v����v����ꍇ�A
    /// �_���[�W1.5�{�ɂȂ�
    /// </summary>
    public sealed class TypeMatchCorrector : ITypeMatchCorrector
    {
        const float Match = 1.5f;
        const float NoMatch = 1.0f;
        readonly float value;

        public static ITypeMatchCorrector Create(PokeType[] offenceTypes, PokeType move)
        {
            foreach (var t in offenceTypes)
            {
                if (t == move) return new TypeMatchCorrector(Match);
            }
            return new TypeMatchCorrector(NoMatch);
        }

        private TypeMatchCorrector(float value)
        {
            this.value = value;
        }

        Damage ITypeMatchCorrector.Correct(Damage damage)
        {
            return damage.Mul(value);
        }
    }
}
