using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.ForcePicker
{
    /// <summary>
    /// シェルアームズ
    /// ぶつりかとくしゅダメージの大きいほうを採用
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
            return (float)force.Offence.Attack.Value / force.Defence.Defence.Value;
        }
        float SpecialRate()
        {
            return (float)force.Offence.SpAttack.Value / force.Defence.SpDefence.Value;
        }
    }
}
