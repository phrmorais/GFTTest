namespace GFTTest.infra.data.Interfaces
{
    public interface IRisk
    {
        string Type { get; }

        bool CalculateRisk(ITrade trade);
    }
}