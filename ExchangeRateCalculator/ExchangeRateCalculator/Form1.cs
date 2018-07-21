using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using SettlementExchangeRateCalculator.Enums;

namespace SettlementExchangeRateCalculator
{
    public partial class Form1 : Form
    {
        private decimal _foreignCreationAmount;
        private decimal _foreignClearingAmount;
        private decimal _exchangeRateAmount;
        private ExchangeRateType? _exchangeRateType;
        private string _schema;
        private SettlementType? _settlementType;

        public Form1()
        {
            InitializeComponent();
            creationExchangeRateTextBox.Text = "0,228786";
            clearingSettlemntTextBox.Text = "0,232061";
            settlementAmountTextBox.Text = "26501,92";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var validationData = ValidateForm();

            if (!validationData.isValid)
            {
                MessageBox.Show(validationData.validationMessage);
                return;
            }

            CalculateExchangeRateAmounts();
            SetExchangeRateAmount();

            CalculateExchangeRateType();
            SetExchangeRateType();

            CalculateAccountingSchema();
            SetAccountingSchema();

            SetExchangeRateExplanation();
        }

        private (bool isValid, string validationMessage) ValidateForm()
        {
            var strigBuilder = new StringBuilder();
            var isValid = true;

            if (string.IsNullOrEmpty(settlementTypeComboBox.Text))
            {
                isValid = false;
                strigBuilder.Append("Uzupełnij rodzaj rozrachunku!" + Environment.NewLine);
            }

            if (string.IsNullOrEmpty(settlementAmountTextBox.Text))
            {
                isValid = false;
                strigBuilder.Append("Uzupełnij kwotę rozrachunku!" + Environment.NewLine);
            }

            if (string.IsNullOrEmpty(creationExchangeRateTextBox.Text))
            {
                isValid = false;
                strigBuilder.Append("Uzupełnij kurs tworzący rozrachunek (z faktury)!" + Environment.NewLine);
            }

            if (string.IsNullOrEmpty(clearingSettlemntTextBox.Text))
            {
                isValid = false;
                strigBuilder.Append("Uzupełnij kurs spłaty rozrachunku (kurs wyciągu bankowego z transakcją potwierdzającą spłatę!");
            }

            return (isValid, strigBuilder.ToString());
        }


        private void CalculateExchangeRateAmounts()
        {
            _foreignCreationAmount =
                decimal.Round(decimal.Parse(creationExchangeRateTextBox.Text) * decimal.Parse(settlementAmountTextBox.Text), 2);
            _foreignClearingAmount =
                decimal.Round(
                    decimal.Parse(clearingSettlemntTextBox.Text) * decimal.Parse(settlementAmountTextBox.Text), 2);
            _exchangeRateAmount = _foreignCreationAmount - _foreignClearingAmount;
        }

        private void SetExchangeRateAmount()
        {
            foreignCreationAmountTextBox.Text = _foreignCreationAmount.ToString(CultureInfo.InvariantCulture);
            foreignClearingAmuntTextBox.Text = _foreignClearingAmount.ToString(CultureInfo.InvariantCulture);
            exchangeRateAmountTextBox.Text = Math.Abs(_exchangeRateAmount).ToString(CultureInfo.InvariantCulture);
        }

        private void CalculateExchangeRateType()
        {
            if (!string.IsNullOrEmpty(exchangeRateTypeTextBox.Text))
                exchangeRateTypeTextBox.Text = "";
            
            var isPositiveExchangeRate = 
                _settlementType == SettlementType.Receivable ?
                _exchangeRateAmount < 0 :
                _exchangeRateAmount > 0;

            _exchangeRateType = isPositiveExchangeRate ? ExchangeRateType.Positive : ExchangeRateType.Negative;
        }

        private void SetExchangeRateType()
        {
            exchangeRateTypeTextBox.Text = _exchangeRateType.Value.GetStringValue();
            SetExchangeRateTypeColor();
        }

        private void SetExchangeRateTypeColor()
        {
            switch (_exchangeRateType)
            {
                case ExchangeRateType.Positive:
                    exchangeRateTypeTextBox.ForeColor = exchangeRateAmountTextBox.ForeColor = Color.Green;
                    break;
                case ExchangeRateType.Negative:
                    exchangeRateTypeTextBox.ForeColor = exchangeRateAmountTextBox.ForeColor = Color.Red;
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Nieobsugiwany type różnicy kursowej: {nameof(_exchangeRateType)}");
            }
        }

        private void CalculateAccountingSchema()
        {
            var exchangeRateType = exchangeRateTypeTextBox.Text.ToExchangeRateTypeEnum();
            var settlementType = settlementTypeComboBox.Text.ToSettlementTypeEnum();

            switch (settlementType)
            {
                case SettlementType.Receivable:
                    _schema = exchangeRateType == ExchangeRateType.Positive ? "RECEIVEFXD+" : "RECEIVEFXD-";
                    break;
                case SettlementType.Liability:
                    _schema = exchangeRateType == ExchangeRateType.Positive ? "PAYABLEFXD+" : "PAYABLEFXD-";
                    break;
            }
        }

        private void SetAccountingSchema()
        {
            accountingSchemaTextBox.Text = _schema;
        }

        private void settlementTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settlementType = GetSettlementType();
            
            var liabilityExplanation = "Kontrahent wykonał usługę na rzecz SKANSKA (potwierdzone fakturą otrzymaną przez SKANSKA), " +
                                       "ale SKANSKA jeszcze nie zapłaciła.";

            var receivableExplanation = "SKANSKA wykonała na rzecz kontrahenta usługę (potwierdzone fakturą wystawioną przez SKANSKA), " +
                                        "ale nie otrzymała jeszcze zapłaty";

            var explanation =
                settlementTypeComboBox.Text == SettlementType.Liability.GetStringValue()
                    ? liabilityExplanation
                    : receivableExplanation;

            settlementTypeExplanationTextBox.Text = explanation + Environment.NewLine;
        }

        private SettlementType GetSettlementType()
        {
            return settlementTypeComboBox.Text.ToSettlementTypeEnum();
        }

        private void SetExchangeRateExplanation()
        {
            var positiveLiabiityExplanation = $"Dodatnia różnica kursowa: {Environment.NewLine}" +
                                              $"Kurs spłaty zobowiązania przez SKANSKA jest wyższy niż kurs określony na fakturze, " +
                                              $"czyli SKANSKA zapłaciła więcej niż wynikało to z faktury." +
                                              $"{Environment.NewLine} " +
                                              $"{Environment.NewLine} " +
                                              $"Zobowiązanie + kurs na fakturze > kurs spłaty = Dodatnia różnica kursowa";

            var negativeLiabiltyExplanation = $"Ujemna różnica kursowa: {Environment.NewLine}" +
                                              $"Kurs spłaty zobowiązania przez SKANSKA jest wyższy niż kurs określony na fakturze, " +
                                              $"czyli SKANSKA zapłaciła więcej niż wynikało to z faktury." +
                                              $"{Environment.NewLine} " +
                                              $"{Environment.NewLine} " +
                                              $"Zobowiązanie + kurs na fakturze < kurs spłaty = Ujemna różnica kursowa";

            var positiveReceivableExplanation = $"Dodatnia różnica kursowa: {Environment.NewLine}" +
                                              $"SKANSKA otrzymała zapłatę należności po wyższym kursie niż kurs określony na fakturze," +
                                              $" czyli otrzymała więcej pieniędzy niż wynikało to z faktury." +
                                              $"{Environment.NewLine} " +
                                              $"{Environment.NewLine} " +
                                              $"Należność + kurs na fakturze < kurs potwierdzenia otrzymania płatności = Dodatnia różnica kursowa"; 

            var negativeReceivableExplanation = $"Ujemna różnica kursowa. {Environment.NewLine}" +
                                              $"SKANSKA otrzymała zapłatę należności po niższym kursie niż kurs określony na fakturze," +
                                              $" czyli otrzymała mniej pieniędzy niż wynikało to z faktury." +
                                              $"{Environment.NewLine} " +
                                              $"{Environment.NewLine} " +
                                              $"Należność + kurs na fakturze > kurs potwierdzenia otrzymania płatności = Ujemna różnica kursowa";                                             ;


            var settlementType = settlementTypeComboBox.Text.ToSettlementTypeEnum();
            var explanation = string.Empty;

            switch (settlementType)
            {
                case SettlementType.Liability:
                    explanation += _foreignCreationAmount > _foreignClearingAmount
                        ? positiveLiabiityExplanation
                        : negativeLiabiltyExplanation;
                    break;
                case SettlementType.Receivable:
                    explanation += _foreignCreationAmount < _foreignClearingAmount
                        ? positiveReceivableExplanation
                        : negativeReceivableExplanation;
                    break;
            }

            exchangeRateTypeExplanationTextBox.Text = explanation;
        }

        private void ClearAllFields()
        {
            ClearControl(settlementTypeComboBox);
            ClearControl(settlementAmountTextBox);
            ClearControl(creationExchangeRateTextBox);
            ClearControl(foreignCreationAmountTextBox);
            ClearControl(clearingSettlemntTextBox);
            ClearControl(foreignClearingAmuntTextBox);
            ClearControl(exchangeRateAmountTextBox);
            ClearControl(exchangeRateTypeTextBox);
            ClearControl(accountingSchemaTextBox);
            ClearControl(settlementTypeExplanationTextBox);
            ClearControl(exchangeRateTypeExplanationTextBox);
        }

        private void ClearControl(Control control)
        {
            control.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}

