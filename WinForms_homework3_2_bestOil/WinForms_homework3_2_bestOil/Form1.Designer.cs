namespace WinForms_homework3_2_bestOil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelHrnOrLiter = new System.Windows.Forms.Label();
            this.labelSumForOil = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxLiters = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOilPrice = new System.Windows.Forms.TextBox();
            this.comboBoxOilType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelHrnFood = new System.Windows.Forms.Label();
            this.labelSumForFood = new System.Windows.Forms.Label();
            this.textBoxNumberCola = new System.Windows.Forms.TextBox();
            this.textBoxNumberFri = new System.Windows.Forms.TextBox();
            this.textBoxNumberHamburger = new System.Windows.Forms.TextBox();
            this.textBoxPriceCola = new System.Windows.Forms.TextBox();
            this.textBoxPriceFri = new System.Windows.Forms.TextBox();
            this.textBoxPriceHamburger = new System.Windows.Forms.TextBox();
            this.textBoxPriceHotDog = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxCola = new System.Windows.Forms.CheckBox();
            this.checkBoxFri = new System.Windows.Forms.CheckBox();
            this.checkBoxHamburger = new System.Windows.Forms.CheckBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxNumberHotDog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSum);
            this.groupBox1.Controls.Add(this.textBoxLiters);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxOilPrice);
            this.groupBox1.Controls.Add(this.comboBoxOilType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelHrnOrLiter);
            this.groupBox3.Controls.Add(this.labelSumForOil);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(11, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 105);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "До оплати:";
            // 
            // labelHrnOrLiter
            // 
            this.labelHrnOrLiter.AutoSize = true;
            this.labelHrnOrLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHrnOrLiter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHrnOrLiter.Location = new System.Drawing.Point(320, 54);
            this.labelHrnOrLiter.Name = "labelHrnOrLiter";
            this.labelHrnOrLiter.Size = new System.Drawing.Size(47, 25);
            this.labelHrnOrLiter.TabIndex = 9;
            this.labelHrnOrLiter.Text = "грн.";
            // 
            // labelSumForOil
            // 
            this.labelSumForOil.AutoSize = true;
            this.labelSumForOil.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSumForOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumForOil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSumForOil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSumForOil.Location = new System.Drawing.Point(3, 22);
            this.labelSumForOil.Name = "labelSumForOil";
            this.labelSumForOil.Size = new System.Drawing.Size(141, 64);
            this.labelSumForOil.TabIndex = 0;
            this.labelSumForOil.Text = "0,00";
            this.labelSumForOil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(243, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "л.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(243, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "грн.";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(137, 182);
            this.textBoxSum.MaxLength = 8;
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(100, 26);
            this.textBoxSum.TabIndex = 4;
            this.textBoxSum.TextChanged += new System.EventHandler(this.TextBoxSum_TextChanged);
            // 
            // textBoxLiters
            // 
            this.textBoxLiters.Location = new System.Drawing.Point(137, 142);
            this.textBoxLiters.MaxLength = 4;
            this.textBoxLiters.Name = "textBoxLiters";
            this.textBoxLiters.Size = new System.Drawing.Size(100, 26);
            this.textBoxLiters.TabIndex = 2;
            this.textBoxLiters.TextChanged += new System.EventHandler(this.TextBoxLiters_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(11, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 106);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(6, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Сума";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RadioButton2_MouseClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Кількість";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RadioButton1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(243, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "грн.";
            // 
            // textBoxOilPrice
            // 
            this.textBoxOilPrice.Location = new System.Drawing.Point(88, 73);
            this.textBoxOilPrice.Name = "textBoxOilPrice";
            this.textBoxOilPrice.ReadOnly = true;
            this.textBoxOilPrice.Size = new System.Drawing.Size(149, 26);
            this.textBoxOilPrice.TabIndex = 3;
            this.textBoxOilPrice.TabStop = false;
            // 
            // comboBoxOilType
            // 
            this.comboBoxOilType.FormattingEnabled = true;
            this.comboBoxOilType.Location = new System.Drawing.Point(88, 31);
            this.comboBoxOilType.Name = "comboBoxOilType";
            this.comboBoxOilType.Size = new System.Drawing.Size(149, 28);
            this.comboBoxOilType.TabIndex = 0;
            this.comboBoxOilType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOilType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ціна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бензин";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.textBoxNumberCola);
            this.groupBox4.Controls.Add(this.textBoxNumberFri);
            this.groupBox4.Controls.Add(this.textBoxNumberHamburger);
            this.groupBox4.Controls.Add(this.textBoxNumberHotDog);
            this.groupBox4.Controls.Add(this.textBoxPriceCola);
            this.groupBox4.Controls.Add(this.textBoxPriceFri);
            this.groupBox4.Controls.Add(this.textBoxPriceHamburger);
            this.groupBox4.Controls.Add(this.textBoxPriceHotDog);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.checkBoxCola);
            this.groupBox4.Controls.Add(this.checkBoxFri);
            this.groupBox4.Controls.Add(this.checkBoxHamburger);
            this.groupBox4.Controls.Add(this.checkBoxHotDog);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(423, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 362);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Міні-Кафе";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelHrnFood);
            this.groupBox5.Controls.Add(this.labelSumForFood);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(15, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 105);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "До оплати:";
            // 
            // labelHrnFood
            // 
            this.labelHrnFood.AutoSize = true;
            this.labelHrnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHrnFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHrnFood.Location = new System.Drawing.Point(311, 54);
            this.labelHrnFood.Name = "labelHrnFood";
            this.labelHrnFood.Size = new System.Drawing.Size(47, 25);
            this.labelHrnFood.TabIndex = 10;
            this.labelHrnFood.Text = "грн.";
            // 
            // labelSumForFood
            // 
            this.labelSumForFood.AutoSize = true;
            this.labelSumForFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSumForFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumForFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSumForFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSumForFood.Location = new System.Drawing.Point(3, 22);
            this.labelSumForFood.Name = "labelSumForFood";
            this.labelSumForFood.Size = new System.Drawing.Size(141, 64);
            this.labelSumForFood.TabIndex = 0;
            this.labelSumForFood.Text = "0,00";
            this.labelSumForFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNumberCola
            // 
            this.textBoxNumberCola.Location = new System.Drawing.Point(277, 198);
            this.textBoxNumberCola.MaxLength = 3;
            this.textBoxNumberCola.Name = "textBoxNumberCola";
            this.textBoxNumberCola.ReadOnly = true;
            this.textBoxNumberCola.Size = new System.Drawing.Size(80, 26);
            this.textBoxNumberCola.TabIndex = 12;
            this.textBoxNumberCola.Text = "0";
            this.textBoxNumberCola.TextChanged += new System.EventHandler(this.TextBoxNumberCola_TextChanged);
            // 
            // textBoxNumberFri
            // 
            this.textBoxNumberFri.Location = new System.Drawing.Point(277, 158);
            this.textBoxNumberFri.MaxLength = 3;
            this.textBoxNumberFri.Name = "textBoxNumberFri";
            this.textBoxNumberFri.ReadOnly = true;
            this.textBoxNumberFri.Size = new System.Drawing.Size(80, 26);
            this.textBoxNumberFri.TabIndex = 10;
            this.textBoxNumberFri.Text = "0";
            this.textBoxNumberFri.TextChanged += new System.EventHandler(this.TextBoxNumberFri_TextChanged);
            // 
            // textBoxNumberHamburger
            // 
            this.textBoxNumberHamburger.Location = new System.Drawing.Point(277, 118);
            this.textBoxNumberHamburger.MaxLength = 3;
            this.textBoxNumberHamburger.Name = "textBoxNumberHamburger";
            this.textBoxNumberHamburger.ReadOnly = true;
            this.textBoxNumberHamburger.Size = new System.Drawing.Size(80, 26);
            this.textBoxNumberHamburger.TabIndex = 8;
            this.textBoxNumberHamburger.Text = "0";
            this.textBoxNumberHamburger.TextChanged += new System.EventHandler(this.TextBoxNumberHamburger_TextChanged);
            // 
            // textBoxPriceCola
            // 
            this.textBoxPriceCola.Location = new System.Drawing.Point(162, 198);
            this.textBoxPriceCola.Name = "textBoxPriceCola";
            this.textBoxPriceCola.ReadOnly = true;
            this.textBoxPriceCola.Size = new System.Drawing.Size(100, 26);
            this.textBoxPriceCola.TabIndex = 13;
            this.textBoxPriceCola.TabStop = false;
            this.textBoxPriceCola.Text = "4,40";
            // 
            // textBoxPriceFri
            // 
            this.textBoxPriceFri.Location = new System.Drawing.Point(162, 158);
            this.textBoxPriceFri.Name = "textBoxPriceFri";
            this.textBoxPriceFri.ReadOnly = true;
            this.textBoxPriceFri.Size = new System.Drawing.Size(100, 26);
            this.textBoxPriceFri.TabIndex = 12;
            this.textBoxPriceFri.TabStop = false;
            this.textBoxPriceFri.Text = "7,20";
            // 
            // textBoxPriceHamburger
            // 
            this.textBoxPriceHamburger.Location = new System.Drawing.Point(162, 118);
            this.textBoxPriceHamburger.Name = "textBoxPriceHamburger";
            this.textBoxPriceHamburger.ReadOnly = true;
            this.textBoxPriceHamburger.Size = new System.Drawing.Size(100, 26);
            this.textBoxPriceHamburger.TabIndex = 10;
            this.textBoxPriceHamburger.TabStop = false;
            this.textBoxPriceHamburger.Text = "5,40";
            // 
            // textBoxPriceHotDog
            // 
            this.textBoxPriceHotDog.Location = new System.Drawing.Point(162, 78);
            this.textBoxPriceHotDog.Name = "textBoxPriceHotDog";
            this.textBoxPriceHotDog.ReadOnly = true;
            this.textBoxPriceHotDog.Size = new System.Drawing.Size(100, 26);
            this.textBoxPriceHotDog.TabIndex = 8;
            this.textBoxPriceHotDog.TabStop = false;
            this.textBoxPriceHotDog.Text = "4,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(273, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Кількість";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(158, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ціна";
            // 
            // checkBoxCola
            // 
            this.checkBoxCola.AutoSize = true;
            this.checkBoxCola.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxCola.Location = new System.Drawing.Point(15, 200);
            this.checkBoxCola.Name = "checkBoxCola";
            this.checkBoxCola.Size = new System.Drawing.Size(112, 24);
            this.checkBoxCola.TabIndex = 11;
            this.checkBoxCola.Text = "Кока-кола";
            this.checkBoxCola.UseVisualStyleBackColor = true;
            this.checkBoxCola.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckBoxCola_MouseClick);
            // 
            // checkBoxFri
            // 
            this.checkBoxFri.AutoSize = true;
            this.checkBoxFri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxFri.Location = new System.Drawing.Point(15, 160);
            this.checkBoxFri.Name = "checkBoxFri";
            this.checkBoxFri.Size = new System.Drawing.Size(141, 24);
            this.checkBoxFri.TabIndex = 9;
            this.checkBoxFri.Text = "Картопля-фрі";
            this.checkBoxFri.UseVisualStyleBackColor = true;
            this.checkBoxFri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckBoxFri_MouseClick);
            // 
            // checkBoxHamburger
            // 
            this.checkBoxHamburger.AutoSize = true;
            this.checkBoxHamburger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxHamburger.Location = new System.Drawing.Point(15, 120);
            this.checkBoxHamburger.Name = "checkBoxHamburger";
            this.checkBoxHamburger.Size = new System.Drawing.Size(114, 24);
            this.checkBoxHamburger.TabIndex = 7;
            this.checkBoxHamburger.Text = "Гамбургер";
            this.checkBoxHamburger.UseVisualStyleBackColor = true;
            this.checkBoxHamburger.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckBoxHamburger_MouseClick);
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxHotDog.Location = new System.Drawing.Point(15, 80);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(96, 24);
            this.checkBoxHotDog.TabIndex = 5;
            this.checkBoxHotDog.Text = "Хот-дог";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckBoxHotDog_MouseClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.buttonCalculate);
            this.groupBox6.Controls.Add(this.labelTotalSum);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox6.Location = new System.Drawing.Point(13, 381);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(800, 105);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ВСЬОГО до оплати:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(736, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "грн.";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCalculate.Location = new System.Drawing.Point(11, 25);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(379, 61);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Прорахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonCalculate_MouseClick);
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotalSum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalSum.Location = new System.Drawing.Point(428, 22);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(141, 64);
            this.labelTotalSum.TabIndex = 0;
            this.labelTotalSum.Text = "0,00";
            this.labelTotalSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxNumberHotDog
            // 
            this.textBoxNumberHotDog.Location = new System.Drawing.Point(277, 77);
            this.textBoxNumberHotDog.MaxLength = 3;
            this.textBoxNumberHotDog.Name = "textBoxNumberHotDog";
            this.textBoxNumberHotDog.ReadOnly = true;
            this.textBoxNumberHotDog.Size = new System.Drawing.Size(80, 26);
            this.textBoxNumberHotDog.TabIndex = 6;
            this.textBoxNumberHotDog.Text = "0";
            this.textBoxNumberHotDog.TextChanged += new System.EventHandler(this.TextBoxNumberHotDog_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 501);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelSumForOil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxLiters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOilPrice;
        private System.Windows.Forms.ComboBox comboBoxOilType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxCola;
        private System.Windows.Forms.CheckBox checkBoxFri;
        private System.Windows.Forms.CheckBox checkBoxHamburger;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.TextBox textBoxPriceCola;
        private System.Windows.Forms.TextBox textBoxPriceFri;
        private System.Windows.Forms.TextBox textBoxPriceHamburger;
        private System.Windows.Forms.TextBox textBoxPriceHotDog;
        private System.Windows.Forms.TextBox textBoxNumberCola;
        private System.Windows.Forms.TextBox textBoxNumberFri;
        private System.Windows.Forms.TextBox textBoxNumberHamburger;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelSumForFood;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTotalSum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelHrnOrLiter;
        private System.Windows.Forms.Label labelHrnFood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumberHotDog;
    }
}

