namespace PokeCalc.Domain.Moves
{
    public interface IStats
    {
        int HP { get; }
        int Attack { get; }
        int Defence { get; }
        int SpAttack { get; }
        int SpDefence { get; }
        int Speed { get; }
    }
}
