namespace c_sharp_test_from_marchenko_oleksandr
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDeserialize = new System.Windows.Forms.RadioButton();
            this.radioButtonSerialize = new System.Windows.Forms.RadioButton();
            this.buttonRun = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDeserialize);
            this.groupBox1.Controls.Add(this.radioButtonSerialize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select action:";
            // 
            // radioButtonDeserialize
            // 
            this.radioButtonDeserialize.AutoSize = true;
            this.radioButtonDeserialize.Location = new System.Drawing.Point(7, 57);
            this.radioButtonDeserialize.Name = "radioButtonDeserialize";
            this.radioButtonDeserialize.Size = new System.Drawing.Size(224, 24);
            this.radioButtonDeserialize.TabIndex = 1;
            this.radioButtonDeserialize.Text = "deserialize files and folders";
            this.radioButtonDeserialize.UseVisualStyleBackColor = true;
            // 
            // radioButtonSerialize
            // 
            this.radioButtonSerialize.AutoSize = true;
            this.radioButtonSerialize.Checked = true;
            this.radioButtonSerialize.Location = new System.Drawing.Point(7, 26);
            this.radioButtonSerialize.Name = "radioButtonSerialize";
            this.radioButtonSerialize.Size = new System.Drawing.Size(206, 24);
            this.radioButtonSerialize.TabIndex = 0;
            this.radioButtonSerialize.TabStop = true;
            this.radioButtonSerialize.Text = "serialize files and folders";
            this.radioButtonSerialize.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(255, 13);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(130, 96);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRun_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Binary files(*.bin)|*.bin|All files(*.*)|*.*";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.Green;
            this.labelResult.Location = new System.Drawing.Point(16, 122);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(14, 20);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 158);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDeserialize;
        private System.Windows.Forms.RadioButton radioButtonSerialize;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelResult;
    }
}

