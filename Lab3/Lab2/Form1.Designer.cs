
namespace Lab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.authors = new System.Windows.Forms.Button();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPDF = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.radioButtonFB2 = new System.Windows.Forms.RadioButton();
            this.radioButtonEPUB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNumberOfPages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUDK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датеЗагрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельИнструментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSortByYearr = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearchByName = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearBase = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // authors
            // 
            this.authors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.authors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.authors.FlatAppearance.BorderSize = 0;
            this.authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authors.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authors.Location = new System.Drawing.Point(649, 307);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(140, 63);
            this.authors.TabIndex = 1;
            this.authors.Text = "Авторы";
            this.authors.UseVisualStyleBackColor = false;
            this.authors.Click += new System.EventHandler(this.authors_Click);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.HorizontalScrollbar = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(461, 68);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.ScrollAlwaysVisible = true;
            this.listBoxInfo.Size = new System.Drawing.Size(502, 196);
            this.listBoxInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Format";
            // 
            // radioButtonPDF
            // 
            this.radioButtonPDF.AutoSize = true;
            this.radioButtonPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonPDF.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPDF.Location = new System.Drawing.Point(29, 103);
            this.radioButtonPDF.Name = "radioButtonPDF";
            this.radioButtonPDF.Size = new System.Drawing.Size(77, 32);
            this.radioButtonPDF.TabIndex = 4;
            this.radioButtonPDF.TabStop = true;
            this.radioButtonPDF.Text = "PDF";
            this.radioButtonPDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonTXT.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTXT.Location = new System.Drawing.Point(29, 142);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(70, 32);
            this.radioButtonTXT.TabIndex = 5;
            this.radioButtonTXT.TabStop = true;
            this.radioButtonTXT.Text = "TXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // radioButtonFB2
            // 
            this.radioButtonFB2.AutoSize = true;
            this.radioButtonFB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFB2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFB2.Location = new System.Drawing.Point(29, 183);
            this.radioButtonFB2.Name = "radioButtonFB2";
            this.radioButtonFB2.Size = new System.Drawing.Size(72, 32);
            this.radioButtonFB2.TabIndex = 6;
            this.radioButtonFB2.TabStop = true;
            this.radioButtonFB2.Text = "FB2";
            this.radioButtonFB2.UseVisualStyleBackColor = true;
            // 
            // radioButtonEPUB
            // 
            this.radioButtonEPUB.AutoSize = true;
            this.radioButtonEPUB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonEPUB.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEPUB.Location = new System.Drawing.Point(29, 223);
            this.radioButtonEPUB.Name = "radioButtonEPUB";
            this.radioButtonEPUB.Size = new System.Drawing.Size(93, 32);
            this.radioButtonEPUB.TabIndex = 7;
            this.radioButtonEPUB.TabStop = true;
            this.radioButtonEPUB.Text = "EPUB";
            this.radioButtonEPUB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(23, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Размер книги(мб)";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSize.Location = new System.Drawing.Point(29, 311);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 26);
            this.textBoxSize.TabIndex = 9;
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSize_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(29, 391);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 26);
            this.textBoxName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(23, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название книги";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(300, 68);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(145, 52);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(300, 140);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 52);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(300, 210);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 52);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNumberOfPages
            // 
            this.textBoxNumberOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberOfPages.Location = new System.Drawing.Point(29, 554);
            this.textBoxNumberOfPages.Name = "textBoxNumberOfPages";
            this.textBoxNumberOfPages.Size = new System.Drawing.Size(175, 26);
            this.textBoxNumberOfPages.TabIndex = 18;
            this.textBoxNumberOfPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberOfPages_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(23, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "Кол-во страниц";
            // 
            // textBoxUDK
            // 
            this.textBoxUDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUDK.Location = new System.Drawing.Point(29, 474);
            this.textBoxUDK.Name = "textBoxUDK";
            this.textBoxUDK.Size = new System.Drawing.Size(100, 26);
            this.textBoxUDK.TabIndex = 16;
            this.textBoxUDK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUDK_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(23, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "УДК файла";
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerYear.Location = new System.Drawing.Point(228, 387);
            this.dateTimePickerYear.MaxDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.dateTimePickerYear.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.ShowUpDown = true;
            this.dateTimePickerYear.Size = new System.Drawing.Size(73, 34);
            this.dateTimePickerYear.TabIndex = 19;
            this.dateTimePickerYear.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.панельИнструментовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 30);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНазваниюToolStripMenuItem,
            this.датеЗагрузкиToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поНазваниюToolStripMenuItem.Text = "По названию";
            this.поНазваниюToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // датеЗагрузкиToolStripMenuItem
            // 
            this.датеЗагрузкиToolStripMenuItem.Name = "датеЗагрузкиToolStripMenuItem";
            this.датеЗагрузкиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.датеЗагрузкиToolStripMenuItem.Text = "Дате загрузки";
            this.датеЗагрузкиToolStripMenuItem.Click += new System.EventHandler(this.датеЗагрузкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // панельИнструментовToolStripMenuItem
            // 
            this.панельИнструментовToolStripMenuItem.Name = "панельИнструментовToolStripMenuItem";
            this.панельИнструментовToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.панельИнструментовToolStripMenuItem.Text = "Панель инструментов";
            this.панельИнструментовToolStripMenuItem.Click += new System.EventHandler(this.панельИнструментовToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSortByYearr,
            this.toolStripButtonSearchByName,
            this.toolStripButtonClearBase});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(987, 31);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "toolStripSearch\r\n";
            this.toolStripButton1.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // toolStripSortByYearr
            // 
            this.toolStripSortByYearr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSortByYearr.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSortByYearr.Image")));
            this.toolStripSortByYearr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSortByYearr.Name = "toolStripSortByYearr";
            this.toolStripSortByYearr.Size = new System.Drawing.Size(29, 28);
            this.toolStripSortByYearr.Text = "toolStripButton2";
            this.toolStripSortByYearr.Click += new System.EventHandler(this.датеЗагрузкиToolStripMenuItem_Click);
            // 
            // toolStripButtonSearchByName
            // 
            this.toolStripButtonSearchByName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearchByName.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearchByName.Image")));
            this.toolStripButtonSearchByName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchByName.Name = "toolStripButtonSearchByName";
            this.toolStripButtonSearchByName.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonSearchByName.Text = "toolStripButton3";
            this.toolStripButtonSearchByName.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // toolStripButtonClearBase
            // 
            this.toolStripButtonClearBase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearBase.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearBase.Image")));
            this.toolStripButtonClearBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearBase.Name = "toolStripButtonClearBase";
            this.toolStripButtonClearBase.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonClearBase.Text = "toolStripButton2";
            this.toolStripButtonClearBase.Click += new System.EventHandler(this.toolStripButtonClearBase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 599);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.textBoxNumberOfPages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUDK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonEPUB);
            this.Controls.Add(this.radioButtonFB2);
            this.Controls.Add(this.radioButtonTXT);
            this.Controls.Add(this.radioButtonPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.authors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Electronic Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button authors;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPDF;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.RadioButton radioButtonFB2;
        private System.Windows.Forms.RadioButton radioButtonEPUB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNumberOfPages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUDK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датеЗагрузкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельИнструментовToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripSortByYearr;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearchByName;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearBase;
    }
}

