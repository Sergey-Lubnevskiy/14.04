
namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelGasolineCost = new System.Windows.Forms.Label();
            this.labelPaymentUnit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFuelPrice = new System.Windows.Forms.TextBox();
            this.fuelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonAmount = new System.Windows.Forms.RadioButton();
            this.radioButtonLiters = new System.Windows.Forms.RadioButton();
            this.sumRadioButton = new System.Windows.Forms.TextBox();
            this.fuelPriceLabel = new System.Windows.Forms.TextBox();
            this.cafeGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelCafeCost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.cafeGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelFuelPrice);
            this.groupBox1.Controls.Add(this.fuelTypeComboBox);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заправка";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.labelGasolineCost);
            this.groupBox4.Controls.Add(this.labelPaymentUnit);
            this.groupBox4.Location = new System.Drawing.Point(6, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "К оплате";
            // 
            // labelGasolineCost
            // 
            this.labelGasolineCost.AutoSize = true;
            this.labelGasolineCost.Location = new System.Drawing.Point(139, 75);
            this.labelGasolineCost.Name = "labelGasolineCost";
            this.labelGasolineCost.Size = new System.Drawing.Size(25, 13);
            this.labelGasolineCost.TabIndex = 11;
            this.labelGasolineCost.Text = "про";
            // 
            // labelPaymentUnit
            // 
            this.labelPaymentUnit.AutoSize = true;
            this.labelPaymentUnit.Location = new System.Drawing.Point(195, 75);
            this.labelPaymentUnit.Name = "labelPaymentUnit";
            this.labelPaymentUnit.Size = new System.Drawing.Size(27, 13);
            this.labelPaymentUnit.TabIndex = 11;
            this.labelPaymentUnit.Text = "грн.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бензин";
            // 
            // labelFuelPrice
            // 
            this.labelFuelPrice.Location = new System.Drawing.Point(102, 56);
            this.labelFuelPrice.Name = "labelFuelPrice";
            this.labelFuelPrice.Size = new System.Drawing.Size(121, 20);
            this.labelFuelPrice.TabIndex = 0;
            // 
            // fuelTypeComboBox
            // 
            this.fuelTypeComboBox.FormattingEnabled = true;
            this.fuelTypeComboBox.Location = new System.Drawing.Point(102, 19);
            this.fuelTypeComboBox.Name = "fuelTypeComboBox";
            this.fuelTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.fuelTypeComboBox.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox6.Controls.Add(this.radioButtonAmount);
            this.groupBox6.Controls.Add(this.radioButtonLiters);
            this.groupBox6.Controls.Add(this.sumRadioButton);
            this.groupBox6.Controls.Add(this.fuelPriceLabel);
            this.groupBox6.Location = new System.Drawing.Point(6, 127);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(234, 68);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // radioButtonAmount
            // 
            this.radioButtonAmount.AutoSize = true;
            this.radioButtonAmount.Location = new System.Drawing.Point(6, 38);
            this.radioButtonAmount.Name = "radioButtonAmount";
            this.radioButtonAmount.Size = new System.Drawing.Size(51, 17);
            this.radioButtonAmount.TabIndex = 11;
            this.radioButtonAmount.TabStop = true;
            this.radioButtonAmount.Text = "Цена";
            this.radioButtonAmount.UseVisualStyleBackColor = true;
            // 
            // radioButtonLiters
            // 
            this.radioButtonLiters.AutoSize = true;
            this.radioButtonLiters.Location = new System.Drawing.Point(5, 15);
            this.radioButtonLiters.Name = "radioButtonLiters";
            this.radioButtonLiters.Size = new System.Drawing.Size(59, 17);
            this.radioButtonLiters.TabIndex = 11;
            this.radioButtonLiters.TabStop = true;
            this.radioButtonLiters.Text = "Кол-во";
            this.radioButtonLiters.UseVisualStyleBackColor = true;
            // 
            // sumRadioButton
            // 
            this.sumRadioButton.Location = new System.Drawing.Point(96, 41);
            this.sumRadioButton.Name = "sumRadioButton";
            this.sumRadioButton.Size = new System.Drawing.Size(121, 20);
            this.sumRadioButton.TabIndex = 3;
            // 
            // fuelPriceLabel
            // 
            this.fuelPriceLabel.Location = new System.Drawing.Point(96, 15);
            this.fuelPriceLabel.Name = "fuelPriceLabel";
            this.fuelPriceLabel.Size = new System.Drawing.Size(121, 20);
            this.fuelPriceLabel.TabIndex = 2;
            // 
            // cafeGroupBox
            // 
            this.cafeGroupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cafeGroupBox.Controls.Add(this.textBox11);
            this.cafeGroupBox.Controls.Add(this.textBox9);
            this.cafeGroupBox.Controls.Add(this.textBox7);
            this.cafeGroupBox.Controls.Add(this.textBox5);
            this.cafeGroupBox.Controls.Add(this.textBox10);
            this.cafeGroupBox.Controls.Add(this.textBox8);
            this.cafeGroupBox.Controls.Add(this.textBox6);
            this.cafeGroupBox.Controls.Add(this.textBox4);
            this.cafeGroupBox.Controls.Add(this.checkBox4);
            this.cafeGroupBox.Controls.Add(this.checkBox3);
            this.cafeGroupBox.Controls.Add(this.checkBox2);
            this.cafeGroupBox.Controls.Add(this.checkBox1);
            this.cafeGroupBox.Controls.Add(this.label5);
            this.cafeGroupBox.Controls.Add(this.label6);
            this.cafeGroupBox.Controls.Add(this.groupBox5);
            this.cafeGroupBox.Location = new System.Drawing.Point(282, 12);
            this.cafeGroupBox.Name = "cafeGroupBox";
            this.cafeGroupBox.Size = new System.Drawing.Size(246, 336);
            this.cafeGroupBox.TabIndex = 1;
            this.cafeGroupBox.TabStop = false;
            this.cafeGroupBox.Text = "Кафе";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(175, 130);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(65, 20);
            this.textBox11.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(175, 104);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(65, 20);
            this.textBox9.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(175, 78);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(65, 20);
            this.textBox7.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(175, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(65, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(104, 130);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(65, 20);
            this.textBox10.TabIndex = 4;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(104, 104);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(65, 20);
            this.textBox8.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(104, 78);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 20);
            this.textBox6.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(65, 20);
            this.textBox4.TabIndex = 4;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 133);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(50, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "кола";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 107);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "картошка";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "бургер";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Ход-дог";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кол-во";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.labelCafeCost);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(6, 230);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "К оплате";
            // 
            // labelCafeCost
            // 
            this.labelCafeCost.AutoSize = true;
            this.labelCafeCost.Location = new System.Drawing.Point(143, 75);
            this.labelCafeCost.Name = "labelCafeCost";
            this.labelCafeCost.Size = new System.Drawing.Size(25, 13);
            this.labelCafeCost.TabIndex = 11;
            this.labelCafeCost.Text = "про";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "грн.";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.labelTotalCost);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 109);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Разчитать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "грн.";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(419, 80);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(25, 13);
            this.labelTotalCost.TabIndex = 11;
            this.labelTotalCost.Text = "про";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cafeGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.cafeGroupBox.ResumeLayout(false);
            this.cafeGroupBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox cafeGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelFuelPrice;
        private System.Windows.Forms.ComboBox fuelTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelGasolineCost;
        private System.Windows.Forms.Label labelPaymentUnit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox sumRadioButton;
        private System.Windows.Forms.TextBox fuelPriceLabel;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCafeCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonAmount;
        private System.Windows.Forms.RadioButton radioButtonLiters;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

