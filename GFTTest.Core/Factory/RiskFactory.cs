using GFTTest.infra.data.Entity;
using GFTTest.infra.data.Enum;
using GFTTest.infra.data.Interfaces;
using System;

namespace GFTTest.Core.Factory
{
    public static class RiskFactory
    {
        public static IRisk Create(TypeRisk risk)
        {
            return Create(risk.ToString());
        }

        public static IRisk Create(string risk)
        {
            switch (risk)
            {
                case "LowRisk":
                    return new LowRisk();

                case "MediumRisk":
                    return new MediumRisk();

                case "HighRisk":
                    return new HighRisk();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}