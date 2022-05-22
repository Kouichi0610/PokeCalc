using System;
using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Effective : ITypeCorrector
    {
        public static readonly Effective Flat = new Effective(1.0f);    // (���{)
        public static readonly Effective Super = new Effective(2.0f);   // �������͂΂���
        public static readonly Effective NotVery = new Effective(0.5f); // �������͂��܂ЂƂ�
        public static readonly Effective NoEffective = new Effective(0.0f); // �������͂Ȃ��悤���c�c

        float correct;

        /// <summary>
        /// TODO:�R���X�g���N�^��private�ɂ���
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
                if (correct == 0) return "�������͂Ȃ��悤��";
                if (correct <= NotVery.correct) return "�������͂��܂ЂƂ̂悤��";
                if (correct > Flat.correct) return "�������͂΂���";
                return "�ӂ�";
            }
        }


        public override string ToString()
        {
            return string.Format("Effective:{0}", correct);
        }
    }
}
