using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Moves
{
    /// <summary>
    /// �V�F���A�[���Y
    /// �Ԃ肩�Ƃ�����_���[�W�̑傫���ق����̗p
    /// </summary>
    internal class ShellArms : IForcePicker
    {
        readonly IForce force;
        public ShellArms(IForce force)
        {
            this.force = force;
        }

        Offence IForcePicker.Offence
        {
            get
            {
                if (PhysicalOver())
                {
                    return new Offence(force.Offence.Attack);
                }
                return new Offence(force.Offence.SpAttack);
            }
        }

        Defence IForcePicker.Defence
        {
            get
            {
                if (PhysicalOver())
                {
                    return new Defence(force.Defence.Defence);
                }
                return new Defence(force.Defence.SpDefence);
            }
        }

        bool PhysicalOver()
        {
            return PhysicalRate() > SpecialRate();
        }

        float PhysicalRate()
        {
            return (float)force.Offence.Attack / force.Defence.Defence;
        }
        float SpecialRate()
        {
            return (float)force.Offence.SpAttack / force.Defence.SpDefence;
        }
    }
}