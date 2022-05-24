using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.ForcePicker
{
    /// <summary>
    /// �T�C�R�V���b�N
    /// �U�����̂Ƃ�����
    /// �h�䑤�̂ڂ�����
    /// </summary>
    internal class PsycoShock : IForcePicker
    {
        readonly IForce force;

        public PsycoShock(IForce force)
        {
            this.force = force;
        }

        Offence IForcePicker.Offence => new Offence(force.Offence.SpAttack);
        Defence IForcePicker.Defence => new Defence(force.Defence.Defence);
    }
}
