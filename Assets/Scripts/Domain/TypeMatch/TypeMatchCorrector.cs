using PokeCalc.Domain.Types;
using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.TypeMatch
{
    /// <summary>
    /// タイプ一致補正
    /// 使用するわざのタイプと
    /// 使用するポケモンのタイプが一致する場合、
    /// ダメージ1.5倍になる
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
