using GFTTest.infra.data.Interfaces;

namespace GFTTest.infra.data.Entity
{
    public class Trade : ITrade
    {
        private static int tradeID = 1;

        private readonly string name;

        public double Value { get; set; }
        public string ClientSector { get; set; }

        public Trade() => name = $"Trade{tradeID++}";

        public bool CalculateRisk(IRisk risk)
        {
            return risk.CalculateRisk(this);
        }

        public override string ToString()
        {
            return name;
        }
    }
}