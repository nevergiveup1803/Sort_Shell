namespace Sort_Shell
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заполнениеМассиваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайныйМассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводВручнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеРезультатовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСтатистикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРезультатСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заполнениеМассиваToolStripMenuItem,
            this.сохранениеРезультатовToolStripMenuItem,
            this.диаграммаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1591, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заполнениеМассиваToolStripMenuItem
            // 
            this.заполнениеМассиваToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.заполнениеМассиваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.случайныйМассивToolStripMenuItem,
            this.изФайлаToolStripMenuItem,
            this.вводВручнуюToolStripMenuItem});
            this.заполнениеМассиваToolStripMenuItem.Name = "заполнениеМассиваToolStripMenuItem";
            this.заполнениеМассиваToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.заполнениеМассиваToolStripMenuItem.Text = "Заполнение массива";
            this.заполнениеМассиваToolStripMenuItem.Click += new System.EventHandler(this.заполнениеМассиваToolStripMenuItem_Click);
            // 
            // случайныйМассивToolStripMenuItem
            // 
            this.случайныйМассивToolStripMenuItem.Name = "случайныйМассивToolStripMenuItem";
            this.случайныйМассивToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.случайныйМассивToolStripMenuItem.Text = "Случайный  массив";
            this.случайныйМассивToolStripMenuItem.Click += new System.EventHandler(this.случайныйМассивToolStripMenuItem_Click);
            // 
            // изФайлаToolStripMenuItem
            // 
            this.изФайлаToolStripMenuItem.Name = "изФайлаToolStripMenuItem";
            this.изФайлаToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.изФайлаToolStripMenuItem.Text = "Из файла...";
            this.изФайлаToolStripMenuItem.Click += new System.EventHandler(this.изФайлаToolStripMenuItem_Click);
            // 
            // вводВручнуюToolStripMenuItem
            // 
            this.вводВручнуюToolStripMenuItem.Name = "вводВручнуюToolStripMenuItem";
            this.вводВручнуюToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.вводВручнуюToolStripMenuItem.Text = "Ввод вручную";
            this.вводВручнуюToolStripMenuItem.Click += new System.EventHandler(this.вводВручнуюToolStripMenuItem_Click);
            // 
            // сохранениеРезультатовToolStripMenuItem
            // 
            this.сохранениеРезультатовToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.сохранениеРезультатовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьСтатистикуToolStripMenuItem,
            this.сохранитьРезультатСортировкиToolStripMenuItem});
            this.сохранениеРезультатовToolStripMenuItem.Name = "сохранениеРезультатовToolStripMenuItem";
            this.сохранениеРезультатовToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.сохранениеРезультатовToolStripMenuItem.Text = "Сохранение результатов";
            this.сохранениеРезультатовToolStripMenuItem.Click += new System.EventHandler(this.сохранениеРезультатовToolStripMenuItem_Click);
            // 
            // сохранитьСтатистикуToolStripMenuItem
            // 
            this.сохранитьСтатистикуToolStripMenuItem.Name = "сохранитьСтатистикуToolStripMenuItem";
            this.сохранитьСтатистикуToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.сохранитьСтатистикуToolStripMenuItem.Text = "Сохранить статистику";
            this.сохранитьСтатистикуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСтатистикуToolStripMenuItem_Click);
            // 
            // сохранитьРезультатСортировкиToolStripMenuItem
            // 
            this.сохранитьРезультатСортировкиToolStripMenuItem.Name = "сохранитьРезультатСортировкиToolStripMenuItem";
            this.сохранитьРезультатСортировкиToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.сохранитьРезультатСортировкиToolStripMenuItem.Text = "Сохранить результат сортировки";
            this.сохранитьРезультатСортировкиToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРезультатСортировкиToolStripMenuItem_Click);
            // 
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.диаграммаToolStripMenuItem.Text = "Диаграмма";
            this.диаграммаToolStripMenuItem.Click += new System.EventHandler(this.диаграммаToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(32, 76);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 444);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(385, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(519, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат сортировки:";
            this.label2.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(263, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите в меню способ заполнения массива";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(20, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1259, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(385, 101);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Готово";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(880, 124);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(675, 388);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(353, 506);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(23, 43);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(88, 444);
            this.listBox2.TabIndex = 6;
            this.listBox2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(511, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(340, 506);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1591, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка Шелла";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заполнениеМассиваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem случайныйМассивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводВручнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранениеРезультатовToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСтатистикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРезультатСортировкиToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

