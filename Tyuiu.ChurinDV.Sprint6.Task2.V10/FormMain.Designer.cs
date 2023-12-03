
namespace Tyuiu.ChurinDV.Sprint6.Task2.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_CDV = new System.Windows.Forms.GroupBox();
            this.groupBoxInputData_CDV = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData_CDV = new System.Windows.Forms.GroupBox();
            this.buttonDone_CDV = new System.Windows.Forms.Button();
            this.buttonHelp_CDV = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStartStep_CDV = new System.Windows.Forms.Label();
            this.textBoxVarStartStep_CDV = new System.Windows.Forms.TextBox();
            this.textBoxVarStopStep_CDV = new System.Windows.Forms.TextBox();
            this.labelStopStep_CDV = new System.Windows.Forms.Label();
            this.labelResult_CDV = new System.Windows.Forms.Label();
            this.dataGridViewFunction_CDV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_CDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUslovie_CDV.SuspendLayout();
            this.groupBoxInputData_CDV.SuspendLayout();
            this.groupBoxOutputData_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_CDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_CDV
            // 
            this.groupBoxUslovie_CDV.Controls.Add(this.pictureBox1);
            this.groupBoxUslovie_CDV.Controls.Add(this.textBox1);
            this.groupBoxUslovie_CDV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_CDV.Name = "groupBoxUslovie_CDV";
            this.groupBoxUslovie_CDV.Size = new System.Drawing.Size(483, 326);
            this.groupBoxUslovie_CDV.TabIndex = 0;
            this.groupBoxUslovie_CDV.TabStop = false;
            this.groupBoxUslovie_CDV.Text = "Условие";
            // 
            // groupBoxInputData_CDV
            // 
            this.groupBoxInputData_CDV.Controls.Add(this.textBoxVarStopStep_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.textBoxVarStartStep_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.labelStopStep_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.labelStartStep_CDV);
            this.groupBoxInputData_CDV.Location = new System.Drawing.Point(12, 344);
            this.groupBoxInputData_CDV.Name = "groupBoxInputData_CDV";
            this.groupBoxInputData_CDV.Size = new System.Drawing.Size(272, 66);
            this.groupBoxInputData_CDV.TabIndex = 1;
            this.groupBoxInputData_CDV.TabStop = false;
            this.groupBoxInputData_CDV.Text = "Ввод данных";
            // 
            // groupBoxOutputData_CDV
            // 
            this.groupBoxOutputData_CDV.Controls.Add(this.chartFunction_CDV);
            this.groupBoxOutputData_CDV.Controls.Add(this.dataGridViewFunction_CDV);
            this.groupBoxOutputData_CDV.Controls.Add(this.labelResult_CDV);
            this.groupBoxOutputData_CDV.Location = new System.Drawing.Point(501, 12);
            this.groupBoxOutputData_CDV.Name = "groupBoxOutputData_CDV";
            this.groupBoxOutputData_CDV.Size = new System.Drawing.Size(598, 398);
            this.groupBoxOutputData_CDV.TabIndex = 2;
            this.groupBoxOutputData_CDV.TabStop = false;
            this.groupBoxOutputData_CDV.Text = "Вывод данных";
            // 
            // buttonDone_CDV
            // 
            this.buttonDone_CDV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_CDV.Location = new System.Drawing.Point(359, 344);
            this.buttonDone_CDV.Name = "buttonDone_CDV";
            this.buttonDone_CDV.Size = new System.Drawing.Size(136, 66);
            this.buttonDone_CDV.TabIndex = 3;
            this.buttonDone_CDV.Text = "Выполнить";
            this.buttonDone_CDV.UseVisualStyleBackColor = false;
            this.buttonDone_CDV.Click += new System.EventHandler(this.buttonDone_CDV_Click);
            this.buttonDone_CDV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_CDV_MouseDown);
            this.buttonDone_CDV.MouseEnter += new System.EventHandler(this.buttonDone_CDV_MouseEnter);
            this.buttonDone_CDV.MouseLeave += new System.EventHandler(this.buttonDone_CDV_MouseLeave);
            // 
            // buttonHelp_CDV
            // 
            this.buttonHelp_CDV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_CDV.Location = new System.Drawing.Point(291, 345);
            this.buttonHelp_CDV.Name = "buttonHelp_CDV";
            this.buttonHelp_CDV.Size = new System.Drawing.Size(62, 65);
            this.buttonHelp_CDV.TabIndex = 4;
            this.buttonHelp_CDV.Text = "Справка";
            this.buttonHelp_CDV.UseVisualStyleBackColor = false;
            this.buttonHelp_CDV.Click += new System.EventHandler(this.buttonHelp_CDV_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(470, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию F(x)  на заданном диапазоне. Результат вывести в DataGrid" +
    "View и построить график функции.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelStartStep_CDV
            // 
            this.labelStartStep_CDV.AutoSize = true;
            this.labelStartStep_CDV.Location = new System.Drawing.Point(7, 20);
            this.labelStartStep_CDV.Name = "labelStartStep_CDV";
            this.labelStartStep_CDV.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_CDV.TabIndex = 0;
            this.labelStartStep_CDV.Text = "Старт шага:";
            // 
            // textBoxVarStartStep_CDV
            // 
            this.textBoxVarStartStep_CDV.Location = new System.Drawing.Point(10, 37);
            this.textBoxVarStartStep_CDV.Name = "textBoxVarStartStep_CDV";
            this.textBoxVarStartStep_CDV.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStartStep_CDV.TabIndex = 1;
            // 
            // textBoxVarStopStep_CDV
            // 
            this.textBoxVarStopStep_CDV.Location = new System.Drawing.Point(135, 37);
            this.textBoxVarStopStep_CDV.Name = "textBoxVarStopStep_CDV";
            this.textBoxVarStopStep_CDV.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStopStep_CDV.TabIndex = 1;
            // 
            // labelStopStep_CDV
            // 
            this.labelStopStep_CDV.AutoSize = true;
            this.labelStopStep_CDV.Location = new System.Drawing.Point(132, 20);
            this.labelStopStep_CDV.Name = "labelStopStep_CDV";
            this.labelStopStep_CDV.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_CDV.TabIndex = 0;
            this.labelStopStep_CDV.Text = "Конец шага:";
            // 
            // labelResult_CDV
            // 
            this.labelResult_CDV.AutoSize = true;
            this.labelResult_CDV.Location = new System.Drawing.Point(7, 19);
            this.labelResult_CDV.Name = "labelResult_CDV";
            this.labelResult_CDV.Size = new System.Drawing.Size(62, 13);
            this.labelResult_CDV.TabIndex = 1;
            this.labelResult_CDV.Text = "Результат:";
            // 
            // dataGridViewFunction_CDV
            // 
            this.dataGridViewFunction_CDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_CDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction_CDV.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewFunction_CDV.Name = "dataGridViewFunction_CDV";
            this.dataGridViewFunction_CDV.RowHeadersVisible = false;
            this.dataGridViewFunction_CDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFunction_CDV.Size = new System.Drawing.Size(120, 354);
            this.dataGridViewFunction_CDV.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "F(x)";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // chartFunction_CDV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_CDV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_CDV.Legends.Add(legend1);
            this.chartFunction_CDV.Location = new System.Drawing.Point(132, 35);
            this.chartFunction_CDV.Name = "chartFunction_CDV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_CDV.Series.Add(series1);
            this.chartFunction_CDV.Size = new System.Drawing.Size(460, 354);
            this.chartFunction_CDV.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 422);
            this.Controls.Add(this.buttonHelp_CDV);
            this.Controls.Add(this.buttonDone_CDV);
            this.Controls.Add(this.groupBoxOutputData_CDV);
            this.Controls.Add(this.groupBoxInputData_CDV);
            this.Controls.Add(this.groupBoxUslovie_CDV);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 10 | Чурин Д. В.";
            this.groupBoxUslovie_CDV.ResumeLayout(false);
            this.groupBoxUslovie_CDV.PerformLayout();
            this.groupBoxInputData_CDV.ResumeLayout(false);
            this.groupBoxInputData_CDV.PerformLayout();
            this.groupBoxOutputData_CDV.ResumeLayout(false);
            this.groupBoxOutputData_CDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_CDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_CDV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInputData_CDV;
        private System.Windows.Forms.TextBox textBoxVarStopStep_CDV;
        private System.Windows.Forms.TextBox textBoxVarStartStep_CDV;
        private System.Windows.Forms.Label labelStopStep_CDV;
        private System.Windows.Forms.Label labelStartStep_CDV;
        private System.Windows.Forms.GroupBox groupBoxOutputData_CDV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CDV;
        private System.Windows.Forms.DataGridView dataGridViewFunction_CDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label labelResult_CDV;
        private System.Windows.Forms.Button buttonDone_CDV;
        private System.Windows.Forms.Button buttonHelp_CDV;
    }
}

