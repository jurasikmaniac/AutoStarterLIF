namespace ServerControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serverFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxCountUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.maxCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(12, 258);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.consoleBox.Size = new System.Drawing.Size(607, 90);
            this.consoleBox.TabIndex = 5;
            this.consoleBox.Text = "";
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Location = new System.Drawing.Point(15, 29);
            this.ipAddressBox.MaxLength = 11;
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(100, 20);
            this.ipAddressBox.TabIndex = 0;
            this.ipAddressBox.Text = "127.0.0.1";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(143, 29);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(61, 20);
            this.portBox.TabIndex = 1;
            this.portBox.Text = "28000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP адрес сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "порт";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serverFileName
            // 
            this.serverFileName.Location = new System.Drawing.Point(15, 82);
            this.serverFileName.Name = "serverFileName";
            this.serverFileName.ReadOnly = true;
            this.serverFileName.Size = new System.Drawing.Size(189, 20);
            this.serverFileName.TabIndex = 7;
            this.serverFileName.Text = "ddctd_cm_yo_server.exe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Файл сервера";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сетевые пробы(если больше положенно, то убиваем сервер):";
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(340, 354);
            this.countBox.Name = "countBox";
            this.countBox.ReadOnly = true;
            this.countBox.Size = new System.Drawing.Size(100, 20);
            this.countBox.TabIndex = 11;
            this.countBox.Text = "0";
            this.countBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Допустимое количество сетевых проб";
            // 
            // maxCountUpDown
            // 
            this.maxCountUpDown.Location = new System.Drawing.Point(18, 122);
            this.maxCountUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxCountUpDown.Name = "maxCountUpDown";
            this.maxCountUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxCountUpDown.TabIndex = 3;
            this.maxCountUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.maxCountUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 382);
            this.Controls.Add(this.maxCountUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipAddressBox);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ServerControl";
            ((System.ComponentModel.ISupportInitialize)(this.maxCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.TextBox ipAddressBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox serverFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown maxCountUpDown;
    }
}

