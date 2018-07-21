namespace SettlementExchangeRateCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.settlementTypeComboBox = new System.Windows.Forms.ComboBox();
            this.settlementAmountTextBox = new System.Windows.Forms.TextBox();
            this.creationExchangeRateTextBox = new System.Windows.Forms.TextBox();
            this.clearingSettlemntTextBox = new System.Windows.Forms.TextBox();
            this.foreignCreationAmountTextBox = new System.Windows.Forms.TextBox();
            this.foreignClearingAmuntTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.exchangeRateAmountTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exchangeRateTypeTextBox = new System.Windows.Forms.TextBox();
            this.accountingSchemaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.settlementTypeExplanationTextBox = new System.Windows.Forms.TextBox();
            this.exchangeRateTypeExplanationTextBox = new System.Windows.Forms.TextBox();
            this.splitter = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rodzaj rozrachunku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kwota rozrachunku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kurs utworzenia rozrachunku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kurs spłaty rozrachunku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rodzaj różnicy  kursowej";
            // 
            // settlementTypeComboBox
            // 
            this.settlementTypeComboBox.FormattingEnabled = true;
            this.settlementTypeComboBox.Items.AddRange(new object[] {
            "Zobowiązanie",
            "Należność"});
            this.settlementTypeComboBox.Location = new System.Drawing.Point(304, 27);
            this.settlementTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.settlementTypeComboBox.Name = "settlementTypeComboBox";
            this.settlementTypeComboBox.Size = new System.Drawing.Size(110, 21);
            this.settlementTypeComboBox.TabIndex = 5;
            this.settlementTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.settlementTypeComboBox_SelectedIndexChanged);
            // 
            // settlementAmountTextBox
            // 
            this.settlementAmountTextBox.Location = new System.Drawing.Point(304, 57);
            this.settlementAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.settlementAmountTextBox.Name = "settlementAmountTextBox";
            this.settlementAmountTextBox.Size = new System.Drawing.Size(110, 20);
            this.settlementAmountTextBox.TabIndex = 6;
            // 
            // creationExchangeRateTextBox
            // 
            this.creationExchangeRateTextBox.Location = new System.Drawing.Point(203, 92);
            this.creationExchangeRateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.creationExchangeRateTextBox.Name = "creationExchangeRateTextBox";
            this.creationExchangeRateTextBox.Size = new System.Drawing.Size(92, 20);
            this.creationExchangeRateTextBox.TabIndex = 7;
            // 
            // clearingSettlemntTextBox
            // 
            this.clearingSettlemntTextBox.Location = new System.Drawing.Point(203, 121);
            this.clearingSettlemntTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.clearingSettlemntTextBox.Name = "clearingSettlemntTextBox";
            this.clearingSettlemntTextBox.Size = new System.Drawing.Size(92, 20);
            this.clearingSettlemntTextBox.TabIndex = 8;
            // 
            // foreignCreationAmountTextBox
            // 
            this.foreignCreationAmountTextBox.Location = new System.Drawing.Point(304, 92);
            this.foreignCreationAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.foreignCreationAmountTextBox.Name = "foreignCreationAmountTextBox";
            this.foreignCreationAmountTextBox.Size = new System.Drawing.Size(110, 20);
            this.foreignCreationAmountTextBox.TabIndex = 9;
            // 
            // foreignClearingAmuntTextBox
            // 
            this.foreignClearingAmuntTextBox.Location = new System.Drawing.Point(304, 121);
            this.foreignClearingAmuntTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.foreignClearingAmuntTextBox.Name = "foreignClearingAmuntTextBox";
            this.foreignClearingAmuntTextBox.Size = new System.Drawing.Size(110, 20);
            this.foreignClearingAmuntTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kwota różnicy (wartość bezwzględna)";
            // 
            // exchangeRateAmountTextBox
            // 
            this.exchangeRateAmountTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.exchangeRateAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateAmountTextBox.Location = new System.Drawing.Point(304, 166);
            this.exchangeRateAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.exchangeRateAmountTextBox.Name = "exchangeRateAmountTextBox";
            this.exchangeRateAmountTextBox.Size = new System.Drawing.Size(110, 26);
            this.exchangeRateAmountTextBox.TabIndex = 12;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(26, 244);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(118, 33);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Przelicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exchangeRateTypeTextBox
            // 
            this.exchangeRateTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateTypeTextBox.ForeColor = System.Drawing.Color.Red;
            this.exchangeRateTypeTextBox.Location = new System.Drawing.Point(304, 195);
            this.exchangeRateTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.exchangeRateTypeTextBox.Name = "exchangeRateTypeTextBox";
            this.exchangeRateTypeTextBox.Size = new System.Drawing.Size(110, 20);
            this.exchangeRateTypeTextBox.TabIndex = 15;
            // 
            // accountingSchemaTextBox
            // 
            this.accountingSchemaTextBox.Location = new System.Drawing.Point(304, 218);
            this.accountingSchemaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountingSchemaTextBox.Name = "accountingSchemaTextBox";
            this.accountingSchemaTextBox.Size = new System.Drawing.Size(110, 20);
            this.accountingSchemaTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Schemat księgowy";
            // 
            // settlementTypeExplanationTextBox
            // 
            this.settlementTypeExplanationTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlementTypeExplanationTextBox.Location = new System.Drawing.Point(440, 5);
            this.settlementTypeExplanationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.settlementTypeExplanationTextBox.Multiline = true;
            this.settlementTypeExplanationTextBox.Name = "settlementTypeExplanationTextBox";
            this.settlementTypeExplanationTextBox.Size = new System.Drawing.Size(259, 80);
            this.settlementTypeExplanationTextBox.TabIndex = 18;
            // 
            // exchangeRateTypeExplanationTextBox
            // 
            this.exchangeRateTypeExplanationTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateTypeExplanationTextBox.Location = new System.Drawing.Point(440, 153);
            this.exchangeRateTypeExplanationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.exchangeRateTypeExplanationTextBox.Multiline = true;
            this.exchangeRateTypeExplanationTextBox.Name = "exchangeRateTypeExplanationTextBox";
            this.exchangeRateTypeExplanationTextBox.Size = new System.Drawing.Size(259, 104);
            this.exchangeRateTypeExplanationTextBox.TabIndex = 19;
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.DimGray;
            this.splitter.Location = new System.Drawing.Point(203, 153);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(211, 2);
            this.splitter.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 294);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.exchangeRateTypeExplanationTextBox);
            this.Controls.Add(this.settlementTypeExplanationTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.accountingSchemaTextBox);
            this.Controls.Add(this.exchangeRateTypeTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exchangeRateAmountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.foreignClearingAmuntTextBox);
            this.Controls.Add(this.foreignCreationAmountTextBox);
            this.Controls.Add(this.clearingSettlemntTextBox);
            this.Controls.Add(this.creationExchangeRateTextBox);
            this.Controls.Add(this.settlementAmountTextBox);
            this.Controls.Add(this.settlementTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kalkulator różnic kursowych";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox settlementTypeComboBox;
        private System.Windows.Forms.TextBox settlementAmountTextBox;
        private System.Windows.Forms.TextBox creationExchangeRateTextBox;
        private System.Windows.Forms.TextBox clearingSettlemntTextBox;
        private System.Windows.Forms.TextBox foreignCreationAmountTextBox;
        private System.Windows.Forms.TextBox foreignClearingAmuntTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox exchangeRateAmountTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox exchangeRateTypeTextBox;
        private System.Windows.Forms.TextBox accountingSchemaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox settlementTypeExplanationTextBox;
        private System.Windows.Forms.TextBox exchangeRateTypeExplanationTextBox;
        private System.Windows.Forms.Panel splitter;
    }
}

