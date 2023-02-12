
namespace Lab1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.labelHiddenWeight = new System.Windows.Forms.Label();
            this.textBoxHiddenWeight = new System.Windows.Forms.TextBox();
            this.labelHiddenTime = new System.Windows.Forms.Label();
            this.textBoxHiddenTime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDiag = new System.Windows.Forms.Label();
            this.labelResultKkal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес(кг)";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Биполярный транзистор",
            "Мужской",
            "Женский"});
            this.comboBoxSex.Location = new System.Drawing.Point(123, 36);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(184, 24);
            this.comboBoxSex.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(123, 89);
            this.textBoxWeight.MaxLength = 3;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(82, 22);
            this.textBoxWeight.TabIndex = 5;
            this.textBoxWeight.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxWeight_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Рост(см)";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(123, 135);
            this.textBoxHeight.MaxLength = 3;
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(82, 22);
            this.textBoxHeight.TabIndex = 7;
            this.textBoxHeight.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(28, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Возраст";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(123, 180);
            this.textBoxAge.MaxLength = 2;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(82, 22);
            this.textBoxAge.TabIndex = 9;
            this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAge_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(28, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цель";
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Items.AddRange(new object[] {
            "Поддержание веса и размеров",
            "Снижение веса",
            "Увеличение веса"});
            this.comboBoxTarget.Location = new System.Drawing.Point(123, 229);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(252, 24);
            this.comboBoxTarget.TabIndex = 11;
            this.comboBoxTarget.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTarget_SelectionChangeCommitted);
            // 
            // labelHiddenWeight
            // 
            this.labelHiddenWeight.AutoSize = true;
            this.labelHiddenWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHiddenWeight.Location = new System.Drawing.Point(29, 282);
            this.labelHiddenWeight.Name = "labelHiddenWeight";
            this.labelHiddenWeight.Size = new System.Drawing.Size(185, 25);
            this.labelHiddenWeight.TabIndex = 12;
            this.labelHiddenWeight.Text = "Желаемый вес(кг)";
            this.labelHiddenWeight.Visible = false;
            // 
            // textBoxHiddenWeight
            // 
            this.textBoxHiddenWeight.Location = new System.Drawing.Point(224, 285);
            this.textBoxHiddenWeight.MaxLength = 3;
            this.textBoxHiddenWeight.Name = "textBoxHiddenWeight";
            this.textBoxHiddenWeight.Size = new System.Drawing.Size(82, 22);
            this.textBoxHiddenWeight.TabIndex = 13;
            this.textBoxHiddenWeight.Visible = false;
            this.textBoxHiddenWeight.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHiddenWeight_Validating);
            // 
            // labelHiddenTime
            // 
            this.labelHiddenTime.AutoSize = true;
            this.labelHiddenTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHiddenTime.Location = new System.Drawing.Point(73, 323);
            this.labelHiddenTime.Name = "labelHiddenTime";
            this.labelHiddenTime.Size = new System.Drawing.Size(132, 25);
            this.labelHiddenTime.TabIndex = 14;
            this.labelHiddenTime.Text = "Срок(месяц)";
            this.labelHiddenTime.Visible = false;
            // 
            // textBoxHiddenTime
            // 
            this.textBoxHiddenTime.Location = new System.Drawing.Point(224, 326);
            this.textBoxHiddenTime.MaxLength = 3;
            this.textBoxHiddenTime.Name = "textBoxHiddenTime";
            this.textBoxHiddenTime.Size = new System.Drawing.Size(82, 22);
            this.textBoxHiddenTime.TabIndex = 15;
            this.textBoxHiddenTime.Visible = false;
            this.textBoxHiddenTime.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHiddenTime_Validating);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(356, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "Подсчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(739, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ваш диагноз";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(642, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "ИМТ(Индекс массы тела)";
            // 
            // labelDiag
            // 
            this.labelDiag.AutoSize = true;
            this.labelDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDiag.Location = new System.Drawing.Point(642, 85);
            this.labelDiag.Name = "labelDiag";
            this.labelDiag.Size = new System.Drawing.Size(0, 25);
            this.labelDiag.TabIndex = 21;
            // 
            // labelResultKkal
            // 
            this.labelResultKkal.AutoSize = true;
            this.labelResultKkal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelResultKkal.Location = new System.Drawing.Point(706, 205);
            this.labelResultKkal.Name = "labelResultKkal";
            this.labelResultKkal.Size = new System.Drawing.Size(0, 25);
            this.labelResultKkal.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(642, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Суточная норма(ккал)";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Viner Hand ITC", 14F);
            this.labelResult.Location = new System.Drawing.Point(739, 298);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 39);
            this.labelResult.TabIndex = 24;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(911, 483);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelResultKkal);
            this.Controls.Add(this.labelDiag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxHiddenTime);
            this.Controls.Add(this.labelHiddenTime);
            this.Controls.Add(this.textBoxHiddenWeight);
            this.Controls.Add(this.labelHiddenWeight);
            this.Controls.Add(this.comboBoxTarget);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(929, 530);
            this.MinimumSize = new System.Drawing.Size(929, 530);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.Label labelHiddenWeight;
        private System.Windows.Forms.TextBox textBoxHiddenWeight;
        private System.Windows.Forms.Label labelHiddenTime;
        private System.Windows.Forms.TextBox textBoxHiddenTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDiag;
        private System.Windows.Forms.Label labelResultKkal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelResult;
    }
}

