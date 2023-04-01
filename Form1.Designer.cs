namespace grafikirafiki
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.linkLabel_next = new System.Windows.Forms.LinkLabel();
            this.linkLabel_before = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label_article1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_next
            // 
            this.linkLabel_next.AutoSize = true;
            this.linkLabel_next.Location = new System.Drawing.Point(626, 193);
            this.linkLabel_next.Name = "linkLabel_next";
            this.linkLabel_next.Size = new System.Drawing.Size(44, 13);
            this.linkLabel_next.TabIndex = 14;
            this.linkLabel_next.TabStop = true;
            this.linkLabel_next.Text = "Вперёд";
            this.linkLabel_next.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_next_LinkClicked);
            // 
            // linkLabel_before
            // 
            this.linkLabel_before.AutoSize = true;
            this.linkLabel_before.Location = new System.Drawing.Point(52, 193);
            this.linkLabel_before.Name = "linkLabel_before";
            this.linkLabel_before.Size = new System.Drawing.Size(39, 13);
            this.linkLabel_before.TabIndex = 13;
            this.linkLabel_before.TabStop = true;
            this.linkLabel_before.Text = "Назад";
            this.linkLabel_before.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_before_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(48, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 148);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.label_price);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(401, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(126, 34);
            this.panel4.TabIndex = 9;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(55, 11);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(31, 13);
            this.label_price.TabIndex = 3;
            this.label_price.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цена:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.label_title);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(209, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 34);
            this.panel3.TabIndex = 8;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(82, 11);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(35, 13);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label_article1);
            this.panel2.Location = new System.Drawing.Point(36, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 31);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Артикул:";
            // 
            // label_article1
            // 
            this.label_article1.AutoSize = true;
            this.label_article1.BackColor = System.Drawing.Color.Transparent;
            this.label_article1.Location = new System.Drawing.Point(66, 11);
            this.label_article1.Name = "label_article1";
            this.label_article1.Size = new System.Drawing.Size(36, 13);
            this.label_article1.TabIndex = 1;
            this.label_article1.Text = "Article";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Создать график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(783, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 208);
            this.dataGridView1.TabIndex = 17;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(48, 226);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "До 5.000р";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "От 5.000р до 10.000р";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "От 10.000р";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(632, 270);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 558);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel_next);
            this.Controls.Add(this.linkLabel_before);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_next;
        private System.Windows.Forms.LinkLabel linkLabel_before;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_article1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

