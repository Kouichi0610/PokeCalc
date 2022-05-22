using System;
using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Effective : ITypeCorrector
    {
        public static readonly Effective Flat = new Effective(1.0f);    // (等倍)
        public static readonly Effective Super = new Effective(2.0f);   // こうかはばつぐんだ
        public static readonly Effective NotVery = new Effective(0.5f); // こうかはいまひとつ
        public static readonly Effective NoEffective = new Effective(0.0f); // こうかはないようだ……

        float correct;

        /// <summary>
        /// TODO:コンストラクタをprivateにする
        /// </summary>
        /// <param name="correct"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private Effective(float correct)
        {
            if (correct < 0) throw new ArgumentOutOfRangeException(string.Format("invalid correct value {0}, correct"));
            this.correct = correct;
        }

        public Effective Append(Effective other)
        {
            return new Effective(correct * other.correct);
        }

        Damage ITypeCorrector.Correct(Damage damage)
        {
            return damage.Mul(correct);
        }

        string ITypeCorrector.State
        {
            get
            {
                if (correct == 0) return "こうかはないようだ";
                if (correct <= NotVery.correct) return "こうかはいまひとつのようだ";
                if (correct > Flat.correct) return "こうかはばつぐんだ";
                return "ふつう";
            }
        }


        public override string ToString()
        {
            return string.Format("Effective:{0}", correct);
        }
    }
}
