using System;

namespace SettlementExchangeRateCalculator.Enums
{
    public enum SettlementType
    {
        Receivable,
        Liability
    }

    public static class SettlemenTypesExtension
    {
        public static string GetStringValue(this SettlementType settlementType)
        {
            switch (settlementType)
            {
                case SettlementType.Receivable: return "Należność";
                case SettlementType.Liability: return "Zobowiązanie";
                default: throw new ArgumentOutOfRangeException($"Brak wartości {nameof(settlementType)} dla typu wyliczeniowego {nameof(SettlementType)}.");
            }
        }

        public static SettlementType ToSettlementTypeEnum(this string settlementTypeString)
        {
            switch (settlementTypeString)
            {
                case "Należność": return SettlementType.Receivable;
                case "Zobowiązanie": return SettlementType.Liability;
                    default: throw new ArgumentOutOfRangeException($"Brak wartości {settlementTypeString} dla typu wyliczeniowego {nameof(SettlementType)}.");
            }
        }
    }
}