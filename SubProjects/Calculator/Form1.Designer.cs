namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxComboCalc = new System.Windows.Forms.GroupBox();
            this.buttonComboBoxCalculate = new System.Windows.Forms.Button();
            this.comboboxComboCalc_operator = new System.Windows.Forms.ComboBox();
            this.textBoxComboCalc_Result = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_oper2 = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_oper1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRadioCalc = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonPower = new System.Windows.Forms.RadioButton();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.radioButtonMul = new System.Windows.Forms.RadioButton();
            this.radioButtonSub = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.buttonRadioCalculate = new System.Windows.Forms.Button();
            this.textBoxRadioCalc_Result = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_oper2 = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_oper1 = new System.Windows.Forms.TextBox();
            this.groupBoxComboCalc.SuspendLayout();
            this.groupBoxRadioCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComboCalc
            // 
            this.groupBoxComboCalc.Controls.Add(this.buttonComboBoxCalculate);
            this.groupBoxComboCalc.Controls.Add(this.comboboxComboCalc_operator);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Result);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_oper2);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_oper1);
            this.groupBoxComboCalc.Controls.Add(this.label4);
            this.groupBoxComboCalc.Controls.Add(this.label3);
            this.groupBoxComboCalc.Controls.Add(this.label2);
            this.groupBoxComboCalc.Controls.Add(this.label1);
            this.groupBoxComboCalc.Location = new System.Drawing.Point(19, 21);
            this.groupBoxComboCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxComboCalc.Name = "groupBoxComboCalc";
            this.groupBoxComboCalc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxComboCalc.Size = new System.Drawing.Size(584, 107);
            this.groupBoxComboCalc.TabIndex = 0;
            this.groupBoxComboCalc.TabStop = false;
            this.groupBoxComboCalc.Text = "Combobox Calculator";
            // 
            // buttonComboBoxCalculate
            // 
            this.buttonComboBoxCalculate.Location = new System.Drawing.Point(376, 44);
            this.buttonComboBoxCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonComboBoxCalculate.Name = "buttonComboBoxCalculate";
            this.buttonComboBoxCalculate.Size = new System.Drawing.Size(66, 18);
            this.buttonComboBoxCalculate.TabIndex = 8;
            this.buttonComboBoxCalculate.Text = "Calculate";
            this.buttonComboBoxCalculate.UseVisualStyleBackColor = true;
            this.buttonComboBoxCalculate.Click += new System.EventHandler(this.buttonComboBoxCalculate_Click);
            // 
            // comboboxComboCalc_operator
            // 
            this.comboboxComboCalc_operator.FormattingEnabled = true;
            this.comboboxComboCalc_operator.Location = new System.Drawing.Point(130, 44);
            this.comboboxComboCalc_operator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboboxComboCalc_operator.Name = "comboboxComboCalc_operator";
            this.comboboxComboCalc_operator.Size = new System.Drawing.Size(106, 20);
            this.comboboxComboCalc_operator.TabIndex = 7;
            // 
            // textBoxComboCalc_Result
            // 
            this.textBoxComboCalc_Result.Location = new System.Drawing.Point(467, 42);
            this.textBoxComboCalc_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxComboCalc_Result.Name = "textBoxComboCalc_Result";
            this.textBoxComboCalc_Result.Size = new System.Drawing.Size(88, 21);
            this.textBoxComboCalc_Result.TabIndex = 6;
            // 
            // textBoxComboCalc_oper2
            // 
            this.textBoxComboCalc_oper2.Location = new System.Drawing.Point(260, 42);
            this.textBoxComboCalc_oper2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxComboCalc_oper2.Name = "textBoxComboCalc_oper2";
            this.textBoxComboCalc_oper2.Size = new System.Drawing.Size(88, 21);
            this.textBoxComboCalc_oper2.TabIndex = 5;
            // 
            // textBoxComboCalc_oper1
            // 
            this.textBoxComboCalc_oper1.Location = new System.Drawing.Point(17, 42);
            this.textBoxComboCalc_oper1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxComboCalc_oper1.Name = "textBoxComboCalc_oper1";
            this.textBoxComboCalc_oper1.Size = new System.Drawing.Size(88, 21);
            this.textBoxComboCalc_oper1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operand2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand1";
            // 
            // groupBoxRadioCalc
            // 
            this.groupBoxRadioCalc.Controls.Add(this.label8);
            this.groupBoxRadioCalc.Controls.Add(this.label7);
            this.groupBoxRadioCalc.Controls.Add(this.label6);
            this.groupBoxRadioCalc.Controls.Add(this.label5);
            this.groupBoxRadioCalc.Controls.Add(this.radioButtonPower);
            this.groupBoxRadioCalc.Controls.Add(this.radioButtonDiv);
            this.groupBoxRadioCalc.Controls.Add(this.radioButtonMul);
            this.groupBoxRadioCalc.Controls.Add(this.radioButtonSub);
            this.groupBoxRadioCalc.Controls.Add(this.radioButtonAdd);
            this.groupBoxRadioCalc.Controls.Add(this.buttonRadioCalculate);
            this.groupBoxRadioCalc.Controls.Add(this.textBoxRadioCalc_Result);
            this.groupBoxRadioCalc.Controls.Add(this.textBoxRadioCalc_oper2);
            this.groupBoxRadioCalc.Controls.Add(this.textBoxRadioCalc_oper1);
            this.groupBoxRadioCalc.Location = new System.Drawing.Point(19, 149);
            this.groupBoxRadioCalc.Name = "groupBoxRadioCalc";
            this.groupBoxRadioCalc.Size = new System.Drawing.Size(584, 100);
            this.groupBoxRadioCalc.TabIndex = 1;
            this.groupBoxRadioCalc.TabStop = false;
            this.groupBoxRadioCalc.Text = "Radio button Calculator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "Result";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Operator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Operand2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operand1";
            // 
            // radioButtonPower
            // 
            this.radioButtonPower.AutoSize = true;
            this.radioButtonPower.Location = new System.Drawing.Point(204, 59);
            this.radioButtonPower.Name = "radioButtonPower";
            this.radioButtonPower.Size = new System.Drawing.Size(29, 16);
            this.radioButtonPower.TabIndex = 14;
            this.radioButtonPower.TabStop = true;
            this.radioButtonPower.Text = "^";
            this.radioButtonPower.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Location = new System.Drawing.Point(169, 69);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(29, 16);
            this.radioButtonDiv.TabIndex = 13;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "/";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            // 
            // radioButtonMul
            // 
            this.radioButtonMul.AutoSize = true;
            this.radioButtonMul.Location = new System.Drawing.Point(169, 47);
            this.radioButtonMul.Name = "radioButtonMul";
            this.radioButtonMul.Size = new System.Drawing.Size(29, 16);
            this.radioButtonMul.TabIndex = 12;
            this.radioButtonMul.TabStop = true;
            this.radioButtonMul.Text = "*";
            this.radioButtonMul.UseVisualStyleBackColor = true;
            // 
            // radioButtonSub
            // 
            this.radioButtonSub.AutoSize = true;
            this.radioButtonSub.Location = new System.Drawing.Point(134, 69);
            this.radioButtonSub.Name = "radioButtonSub";
            this.radioButtonSub.Size = new System.Drawing.Size(29, 16);
            this.radioButtonSub.TabIndex = 11;
            this.radioButtonSub.TabStop = true;
            this.radioButtonSub.Text = "-";
            this.radioButtonSub.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(134, 47);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(29, 16);
            this.radioButtonAdd.TabIndex = 10;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "+";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRadioCalculate
            // 
            this.buttonRadioCalculate.Location = new System.Drawing.Point(376, 52);
            this.buttonRadioCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRadioCalculate.Name = "buttonRadioCalculate";
            this.buttonRadioCalculate.Size = new System.Drawing.Size(66, 18);
            this.buttonRadioCalculate.TabIndex = 9;
            this.buttonRadioCalculate.Text = "Calculate";
            this.buttonRadioCalculate.UseVisualStyleBackColor = true;
            this.buttonRadioCalculate.Click += new System.EventHandler(this.buttonRadioCalculate_Click);
            // 
            // textBoxRadioCalc_Result
            // 
            this.textBoxRadioCalc_Result.Location = new System.Drawing.Point(467, 52);
            this.textBoxRadioCalc_Result.Name = "textBoxRadioCalc_Result";
            this.textBoxRadioCalc_Result.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioCalc_Result.TabIndex = 2;
            // 
            // textBoxRadioCalc_oper2
            // 
            this.textBoxRadioCalc_oper2.Location = new System.Drawing.Point(248, 49);
            this.textBoxRadioCalc_oper2.Name = "textBoxRadioCalc_oper2";
            this.textBoxRadioCalc_oper2.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioCalc_oper2.TabIndex = 1;
            // 
            // textBoxRadioCalc_oper1
            // 
            this.textBoxRadioCalc_oper1.Location = new System.Drawing.Point(17, 49);
            this.textBoxRadioCalc_oper1.Name = "textBoxRadioCalc_oper1";
            this.textBoxRadioCalc_oper1.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioCalc_oper1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 274);
            this.Controls.Add(this.groupBoxRadioCalc);
            this.Controls.Add(this.groupBoxComboCalc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBoxComboCalc.ResumeLayout(false);
            this.groupBoxComboCalc.PerformLayout();
            this.groupBoxRadioCalc.ResumeLayout(false);
            this.groupBoxRadioCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComboCalc;
        private System.Windows.Forms.Button buttonComboBoxCalculate;
        private System.Windows.Forms.ComboBox comboboxComboCalc_operator;
        private System.Windows.Forms.TextBox textBoxComboCalc_Result;
        private System.Windows.Forms.TextBox textBoxComboCalc_oper2;
        private System.Windows.Forms.TextBox textBoxComboCalc_oper1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRadioCalc;
        private System.Windows.Forms.RadioButton radioButtonPower;
        private System.Windows.Forms.RadioButton radioButtonDiv;
        private System.Windows.Forms.RadioButton radioButtonMul;
        private System.Windows.Forms.RadioButton radioButtonSub;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Button buttonRadioCalculate;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Result;
        private System.Windows.Forms.TextBox textBoxRadioCalc_oper2;
        private System.Windows.Forms.TextBox textBoxRadioCalc_oper1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

