using GFTTest.infra.data.Enum;
using GFTTest.infra.data.Interfaces;

namespace GFTTest.infra.data.Entity
{
    public class LowRisk : IRisk
    {
        public string Type { get; private set; }

        public bool CalculateRisk(ITrade trade)
        {
            if (trade.Value < 1000000 && trade.ClientSector.Equals(SectorRisk.Public.ToString()))
            {
                Type = TypeRisk.LowRisk.ToString().ToUpper();

                return true;
            }

            Type = TypeRisk.NoneRisk.ToString();

            return false;
        }
    }
}