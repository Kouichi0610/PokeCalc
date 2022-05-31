
namespace PokeCalc.Domain.Stats.Processor
{
    public class Default : IBuilderProcessor
    {
        IStatsBuilder IBuilderProcessor.Process(IStatsBuilder source)
        {
            return source;
        }
    }
}
