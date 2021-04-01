using GFTTest.Core.Factory;
using GFTTest.infra.data.Enum;
using GFTTest.infra.data.Interfaces;
using System.Collections.Generic;

namespace GFTTest.Core.Utils
{
    public class Category
    {
        private readonly List<ITrade> _portfolio;

        public Category(List<ITrade> portfolio)
        {
            _portfolio = portfolio;
        }

        public List<string> GetCategories()
        {
            IRisk risk = null;

            List<string> tradeCategories = new List<string>();

            List<IRisk> risks = new List<IRisk> {
                RiskFactory.Create(TypeRisk.LowRisk),
                RiskFactory.Create(TypeRisk.MediumRisk),
                RiskFactory.Create(TypeRisk.HighRisk)
            };

            foreach (var trade in _portfolio)
            {
                foreach (IRisk r in risks)
                {
                    risk = r;

                    if (r.CalculateRisk(trade))
                    {
                        break;
                    }
                }

                if (risk != null) tradeCategories.Add(risk.Type);
            }

            return tradeCategories;
        }
    }
}