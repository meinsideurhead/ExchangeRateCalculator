using System;

namespace SettlementExchangeRateCalculator.Enums
{
   
    public enum ExchangeRateType
    {
        Positive,
        Negative
    }

    public static class ExchangeRateTypeExtension
    {
        private static string positiveExchangeRateText = "Dodatnia";
        private static string negativeExchangeRateText = "Ujemna";
        
        public static string GetStringValue(this ExchangeRateType exchangeRateType)
        {
            switch (exchangeRateType)
            {
                case ExchangeRateType.Positive: return positiveExchangeRateText;
                case ExchangeRateType.Negative: return negativeExchangeRateText;
                default: throw new ArgumentOutOfRangeException($"Brak wartości {nameof(exchangeRateType)} dla typu wyliczeniowego {nameof(ExchangeRateType)}.");
            }
        }

        public static ExchangeRateType ToExchangeRateTypeEnum(this string exchangeRateTypeString)
        {
            switch (exchangeRateTypeString)
            {
                case "Dodatnia": return ExchangeRateType.Positive;
                case "Ujemna": return ExchangeRateType.Negative;
                default: throw new ArgumentOutOfRangeException($"Brak wartości {exchangeRateTypeString} dla typu wyliczeniowego {nameof(ExchangeRateType)}.");
            }
        }
    }
}
