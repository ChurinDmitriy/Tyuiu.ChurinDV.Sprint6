
namespace Tyuiu.ChurinDV.Sprint6.Task5.V3
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_CDV = new System.Windows.Forms.Panel();
            this.groupBoxTAsk_CDV = new System.Windows.Forms.GroupBox();
            this.buttonHelp_CDV = new System.Windows.Forms.Button();
            this.buttonOpenFile_CDV = new System.Windows.Forms.Button();
            this.buttonDone_CDV = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelLeft_CDV = new System.Windows.Forms.Panel();
            this.panelFull_CDV = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxOutputData_CDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_CDV = new System.Windows.Forms.DataGridView();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_CDV.SuspendLayout();
            this.groupBoxTAsk_CDV.SuspendLayout();
            this.panelLeft_CDV.SuspendLayout();
            this.panelFull_CDV.SuspendLayout();
            this.groupBoxOutputData_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_CDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_CDV
            // 
            this.panelTop_CDV.Controls.Add(this.buttonDone_CDV);
            this.panelTop_CDV.Controls.Add(this.buttonOpenFile_CDV);
            this.panelTop_CDV.Controls.Add(this.buttonHelp_CDV);
            this.panelTop_CDV.Controls.Add(this.groupBoxTAsk_CDV);
            this.panelTop_CDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CDV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CDV.Name = "panelTop_CDV";
            this.panelTop_CDV.Size = new System.Drawing.Size(800, 88);
            this.panelTop_CDV.TabIndex = 0;
            // 
            // groupBoxTAsk_CDV
            // 
            this.groupBoxTAsk_CDV.Controls.Add(this.textBox1);
            this.groupBoxTAsk_CDV.Location = new System.Drawing.Point(4, 3);
            this.groupBoxTAsk_CDV.Name = "groupBoxTAsk_CDV";
            this.groupBoxTAsk_CDV.Size = new System.Drawing.Size(508, 77);
            this.groupBoxTAsk_CDV.TabIndex = 0;
            this.groupBoxTAsk_CDV.TabStop = false;
            this.groupBoxTAsk_CDV.Text = "Условие:";
            // 
            // buttonHelp_CDV
            // 
            this.buttonHelp_CDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonHelp_CDV.Location = new System.Drawing.Point(707, 12);
            this.buttonHelp_CDV.Name = "buttonHelp_CDV";
            this.buttonHelp_CDV.Size = new System.Drawing.Size(81, 68);
            this.buttonHelp_CDV.TabIndex = 1;
            this.buttonHelp_CDV.Text = "Справка";
            this.buttonHelp_CDV.UseVisualStyleBackColor = false;
            this.buttonHelp_CDV.Click += new System.EventHandler(this.buttonHelp_CDV_Click);
            // 
            // buttonOpenFile_CDV
            // 
            this.buttonOpenFile_CDV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonOpenFile_CDV.Location = new System.Drawing.Point(616, 12);
            this.buttonOpenFile_CDV.Name = "buttonOpenFile_CDV";
            this.buttonOpenFile_CDV.Size = new System.Drawing.Size(85, 68);
            this.buttonOpenFile_CDV.TabIndex = 2;
            this.buttonOpenFile_CDV.Text = "Открыть файл";
            this.buttonOpenFile_CDV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_CDV.Click += new System.EventHandler(this.buttonOpenFile_CDV_Click);
            // 
            // buttonDone_CDV
            // 
            this.buttonDone_CDV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_CDV.Location = new System.Drawing.Point(527, 12);
            this.buttonDone_CDV.Name = "buttonDone_CDV";
            this.buttonDone_CDV.Size = new System.Drawing.Size(83, 68);
            this.buttonDone_CDV.TabIndex = 3;
            this.buttonDone_CDV.Text = "Выполнить";
            this.buttonDone_CDV.UseVisualStyleBackColor = false;
            this.buttonDone_CDV.Click += new System.EventHandler(this.buttonDone_CDV_Click);
            this.buttonDone_CDV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_CDV_MouseDown);
            this.buttonDone_CDV.MouseEnter += new System.EventHandler(this.buttonDone_CDV_MouseEnter);
            this.buttonDone_CDV.MouseLeave += new System.EventHandler(this.buttonDone_CDV_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(508, 58);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V3.txt. Вывести в dataGridView. Вывести в" +
    "се вещественные числа.  Построить диаграмму по этим значениям.";
            // 
            // panelLeft_CDV
            // 
            this.panelLeft_CDV.Controls.Add(this.groupBoxOutputData_CDV);
            this.panelLeft_CDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CDV.Location = new System.Drawing.Point(0, 88);
            this.panelLeft_CDV.Name = "panelLeft_CDV";
            this.panelLeft_CDV.Size = new System.Drawing.Size(127, 362);
            this.panelLeft_CDV.TabIndex = 1;
            // 
            // panelFull_CDV
            // 
            this.panelFull_CDV.Controls.Add(this.chartGraph);
            this.panelFull_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFull_CDV.Location = new System.Drawing.Point(127, 88);
            this.panelFull_CDV.Name = "panelFull_CDV";
            this.panelFull_CDV.Size = new System.Drawing.Size(673, 362);
            this.panelFull_CDV.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(127, 88);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 362);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // groupBoxOutputData_CDV
            // 
            this.groupBoxOutputData_CDV.Controls.Add(this.dataGridViewNums_CDV);
            this.groupBoxOutputData_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_CDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_CDV.Name = "groupBoxOutputData_CDV";
            this.groupBoxOutputData_CDV.Size = new System.Drawing.Size(127, 362);
            this.groupBoxOutputData_CDV.TabIndex = 0;
            this.groupBoxOutputData_CDV.TabStop = false;
            this.groupBoxOutputData_CDV.Text = "Вывод данных:";
            // 
            // dataGridViewNums_CDV
            // 
            this.dataGridViewNums_CDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_CDV.ColumnHeadersVisible = false;
            this.dataGridViewNums_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_CDV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums_CDV.Name = "dataGridViewNums_CDV";
            this.dataGridViewNums_CDV.RowHeadersVisible = false;
            this.dataGridViewNums_CDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums_CDV.Size = new System.Drawing.Size(121, 343);
            this.dataGridViewNums_CDV.TabIndex = 0;
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(6, 0);
            this.chartGraph.Name = "chartGraph";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Size = new System.Drawing.Size(664, 359);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelFull_CDV);
            this.Controls.Add(this.panelLeft_CDV);
            this.Controls.Add(this.panelTop_CDV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 3 | Чурин Д. В.";
            this.panelTop_CDV.ResumeLayout(false);
            this.groupBoxTAsk_CDV.ResumeLayout(false);
            this.groupBoxTAsk_CDV.PerformLayout();
            this.panelLeft_CDV.ResumeLayout(false);
            this.panelFull_CDV.ResumeLayout(false);
            this.groupBoxOutputData_CDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_CDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CDV;
        private System.Windows.Forms.Button buttonDone_CDV;
        private System.Windows.Forms.Button buttonOpenFile_CDV;
        private System.Windows.Forms.Button buttonHelp_CDV;
        private System.Windows.Forms.GroupBox groupBoxTAsk_CDV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLeft_CDV;
        private System.Windows.Forms.Panel panelFull_CDV;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxOutputData_CDV;
        private System.Windows.Forms.DataGridView dataGridViewNums_CDV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
    }
}

