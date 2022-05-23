using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Moves
{
    /// <summary>
    /// �{�f�B�v���X
    /// �U�����̂ڂ�����
    /// �h�䑤�̂ڂ�����
    /// </summary>
    internal class BodyPress : IForcePicker
    {
        readonly IForce force;

        public BodyPress(IForce force)
        {
            this.force = force;
        }
        Offence IForcePicker.Offence => new Offence(force.Offence.Defence);
        Defence IForcePicker.Defence => new Defence(force.Defence.Defence);
    }
}
