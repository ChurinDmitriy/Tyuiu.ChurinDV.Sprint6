
namespace Tyuiu.ChurinDV.Sprint6.Task4.V6
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
            this.panelTop_CDV = new System.Windows.Forms.Panel();
            this.buttonHelp_CDV = new System.Windows.Forms.Button();
            this.buttonSave_CDV = new System.Windows.Forms.Button();
            this.buttonDone_CDV = new System.Windows.Forms.Button();
            this.groupBoxInputData_CDV = new System.Windows.Forms.GroupBox();
            this.textBoxVarStopStep_CDV = new System.Windows.Forms.TextBox();
            this.textBoxVarStartStep_CDV = new System.Windows.Forms.TextBox();
            this.labelStopStep_CDV = new System.Windows.Forms.Label();
            this.labelStartStep_CDV = new System.Windows.Forms.Label();
            this.groupBoxTask_CDV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CDV = new System.Windows.Forms.TextBox();
            this.panelOutput_CDV = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_CDV = new System.Windows.Forms.GroupBox();
            this.textBoxOutputData_CDV = new System.Windows.Forms.TextBox();
            this.panelGraph_CDV = new System.Windows.Forms.Panel();
            this.chartFunction_CDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterPanels_CDV = new System.Windows.Forms.Splitter();
            this.panelTop_CDV.SuspendLayout();
            this.groupBoxInputData_CDV.SuspendLayout();
            this.groupBoxTask_CDV.SuspendLayout();
            this.panelOutput_CDV.SuspendLayout();
            this.groupBoxOutputData_CDV.SuspendLayout();
            this.panelGraph_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_CDV
            // 
            this.panelTop_CDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTop_CDV.Controls.Add(this.buttonHelp_CDV);
            this.panelTop_CDV.Controls.Add(this.buttonSave_CDV);
            this.panelTop_CDV.Controls.Add(this.buttonDone_CDV);
            this.panelTop_CDV.Controls.Add(this.groupBoxInputData_CDV);
            this.panelTop_CDV.Controls.Add(this.groupBoxTask_CDV);
            this.panelTop_CDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CDV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CDV.Name = "panelTop_CDV";
            this.panelTop_CDV.Size = new System.Drawing.Size(784, 100);
            this.panelTop_CDV.TabIndex = 0;
            // 
            // buttonHelp_CDV
            // 
            this.buttonHelp_CDV.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonHelp_CDV.Location = new System.Drawing.Point(676, 15);
            this.buttonHelp_CDV.Name = "buttonHelp_CDV";
            this.buttonHelp_CDV.Size = new System.Drawing.Size(96, 72);
            this.buttonHelp_CDV.TabIndex = 4;
            this.buttonHelp_CDV.Text = "Справка";
            this.buttonHelp_CDV.UseVisualStyleBackColor = false;
            this.buttonHelp_CDV.Click += new System.EventHandler(this.buttonHelp_CDV_Click);
            // 
            // buttonSave_CDV
            // 
            this.buttonSave_CDV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_CDV.Location = new System.Drawing.Point(572, 15);
            this.buttonSave_CDV.Name = "buttonSave_CDV";
            this.buttonSave_CDV.Size = new System.Drawing.Size(98, 72);
            this.buttonSave_CDV.TabIndex = 3;
            this.buttonSave_CDV.Text = "Сохранить";
            this.buttonSave_CDV.UseVisualStyleBackColor = false;
            this.buttonSave_CDV.Click += new System.EventHandler(this.buttonSave_CDV_Click);
            // 
            // buttonDone_CDV
            // 
            this.buttonDone_CDV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_CDV.Location = new System.Drawing.Point(467, 15);
            this.buttonDone_CDV.Name = "buttonDone_CDV";
            this.buttonDone_CDV.Size = new System.Drawing.Size(99, 72);
            this.buttonDone_CDV.TabIndex = 2;
            this.buttonDone_CDV.Text = "Выполнить";
            this.buttonDone_CDV.UseVisualStyleBackColor = false;
            this.buttonDone_CDV.Click += new System.EventHandler(this.buttonDone_CDV_Click);
            this.buttonDone_CDV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_CDV_MouseDown);
            this.buttonDone_CDV.MouseEnter += new System.EventHandler(this.buttonDone_CDV_MouseEnter);
            this.buttonDone_CDV.MouseLeave += new System.EventHandler(this.buttonDone_CDV_MouseLeave);
            // 
            // groupBoxInputData_CDV
            // 
            this.groupBoxInputData_CDV.Controls.Add(this.textBoxVarStopStep_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.textBoxVarStartStep_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.labelStopStep_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.labelStartStep_CDV);
            this.groupBoxInputData_CDV.Location = new System.Drawing.Point(274, 3);
            this.groupBoxInputData_CDV.Name = "groupBoxInputData_CDV";
            this.groupBoxInputData_CDV.Size = new System.Drawing.Size(176, 90);
            this.groupBoxInputData_CDV.TabIndex = 1;
            this.groupBoxInputData_CDV.TabStop = false;
            this.groupBoxInputData_CDV.Text = "Ввод данных:";
            // 
            // textBoxVarStopStep_CDV
            // 
            this.textBoxVarStopStep_CDV.Location = new System.Drawing.Point(100, 47);
            this.textBoxVarStopStep_CDV.Name = "textBoxVarStopStep_CDV";
            this.textBoxVarStopStep_CDV.Size = new System.Drawing.Size(66, 20);
            this.textBoxVarStopStep_CDV.TabIndex = 3;
            // 
            // textBoxVarStartStep_CDV
            // 
            this.textBoxVarStartStep_CDV.Location = new System.Drawing.Point(10, 47);
            this.textBoxVarStartStep_CDV.Name = "textBoxVarStartStep_CDV";
            this.textBoxVarStartStep_CDV.Size = new System.Drawing.Size(64, 20);
            this.textBoxVarStartStep_CDV.TabIndex = 2;
            // 
            // labelStopStep_CDV
            // 
            this.labelStopStep_CDV.AutoSize = true;
            this.labelStopStep_CDV.Location = new System.Drawing.Point(97, 31);
            this.labelStopStep_CDV.Name = "labelStopStep_CDV";
            this.labelStopStep_CDV.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_CDV.TabIndex = 1;
            this.labelStopStep_CDV.Text = "Конец шага:";
            // 
            // labelStartStep_CDV
            // 
            this.labelStartStep_CDV.AutoSize = true;
            this.labelStartStep_CDV.Location = new System.Drawing.Point(6, 31);
            this.labelStartStep_CDV.Name = "labelStartStep_CDV";
            this.labelStartStep_CDV.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_CDV.TabIndex = 0;
            this.labelStartStep_CDV.Text = "Старт шага:";
            // 
            // groupBoxTask_CDV
            // 
            this.groupBoxTask_CDV.Controls.Add(this.textBoxTask_CDV);
            this.groupBoxTask_CDV.Location = new System.Drawing.Point(12, 3);
            this.groupBoxTask_CDV.Name = "groupBoxTask_CDV";
            this.groupBoxTask_CDV.Size = new System.Drawing.Size(256, 90);
            this.groupBoxTask_CDV.TabIndex = 0;
            this.groupBoxTask_CDV.TabStop = false;
            this.groupBoxTask_CDV.Text = "Условие:";
            // 
            // textBoxTask_CDV
            // 
            this.textBoxTask_CDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_CDV.Location = new System.Drawing.Point(6, 12);
            this.textBoxTask_CDV.Multiline = true;
            this.textBoxTask_CDV.Name = "textBoxTask_CDV";
            this.textBoxTask_CDV.ReadOnly = true;
            this.textBoxTask_CDV.Size = new System.Drawing.Size(244, 72);
            this.textBoxTask_CDV.TabIndex = 0;
            this.textBoxTask_CDV.Text = resources.GetString("textBoxTask_CDV.Text");
            // 
            // panelOutput_CDV
            // 
            this.panelOutput_CDV.BackColor = System.Drawing.Color.Gray;
            this.panelOutput_CDV.Controls.Add(this.groupBoxOutputData_CDV);
            this.panelOutput_CDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutput_CDV.Location = new System.Drawing.Point(0, 100);
            this.panelOutput_CDV.Name = "panelOutput_CDV";
            this.panelOutput_CDV.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutput_CDV.Size = new System.Drawing.Size(200, 311);
            this.panelOutput_CDV.TabIndex = 0;
            // 
            // groupBoxOutputData_CDV
            // 
            this.groupBoxOutputData_CDV.BackColor = System.Drawing.Color.Silver;
            this.groupBoxOutputData_CDV.Controls.Add(this.textBoxOutputData_CDV);
            this.groupBoxOutputData_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_CDV.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutputData_CDV.Name = "groupBoxOutputData_CDV";
            this.groupBoxOutputData_CDV.Size = new System.Drawing.Size(190, 301);
            this.groupBoxOutputData_CDV.TabIndex = 0;
            this.groupBoxOutputData_CDV.TabStop = false;
            this.groupBoxOutputData_CDV.Text = "Вывод:";
            // 
            // textBoxOutputData_CDV
            // 
            this.textBoxOutputData_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutputData_CDV.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutputData_CDV.Multiline = true;
            this.textBoxOutputData_CDV.Name = "textBoxOutputData_CDV";
            this.textBoxOutputData_CDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputData_CDV.Size = new System.Drawing.Size(184, 282);
            this.textBoxOutputData_CDV.TabIndex = 0;
            // 
            // panelGraph_CDV
            // 
            this.panelGraph_CDV.BackColor = System.Drawing.Color.White;
            this.panelGraph_CDV.Controls.Add(this.chartFunction_CDV);
            this.panelGraph_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph_CDV.Location = new System.Drawing.Point(200, 100);
            this.panelGraph_CDV.Name = "panelGraph_CDV";
            this.panelGraph_CDV.Size = new System.Drawing.Size(584, 311);
            this.panelGraph_CDV.TabIndex = 0;
            // 
            // chartFunction_CDV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_CDV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_CDV.Legends.Add(legend1);
            this.chartFunction_CDV.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_CDV.Name = "chartFunction_CDV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_CDV.Series.Add(series1);
            this.chartFunction_CDV.Size = new System.Drawing.Size(581, 311);
            this.chartFunction_CDV.TabIndex = 0;
            this.chartFunction_CDV.Text = "График функции 3cos(x) / 4x - 0,5 + sin(x) -5x - 2";
            // 
            // splitterPanels_CDV
            // 
            this.splitterPanels_CDV.Location = new System.Drawing.Point(200, 100);
            this.splitterPanels_CDV.Name = "splitterPanels_CDV";
            this.splitterPanels_CDV.Size = new System.Drawing.Size(3, 311);
            this.splitterPanels_CDV.TabIndex = 1;
            this.splitterPanels_CDV.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitterPanels_CDV);
            this.Controls.Add(this.panelGraph_CDV);
            this.Controls.Add(this.panelOutput_CDV);
            this.Controls.Add(this.panelTop_CDV);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 6 | Чурин Д. В.";
            this.panelTop_CDV.ResumeLayout(false);
            this.groupBoxInputData_CDV.ResumeLayout(false);
            this.groupBoxInputData_CDV.PerformLayout();
            this.groupBoxTask_CDV.ResumeLayout(false);
            this.groupBoxTask_CDV.PerformLayout();
            this.panelOutput_CDV.ResumeLayout(false);
            this.groupBoxOutputData_CDV.ResumeLayout(false);
            this.groupBoxOutputData_CDV.PerformLayout();
            this.panelGraph_CDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CDV;
        private System.Windows.Forms.Panel panelOutput_CDV;
        private System.Windows.Forms.Panel panelGraph_CDV;
        private System.Windows.Forms.Splitter splitterPanels_CDV;
        private System.Windows.Forms.GroupBox groupBoxOutputData_CDV;
        private System.Windows.Forms.TextBox textBoxOutputData_CDV;
        private System.Windows.Forms.GroupBox groupBoxTask_CDV;
        private System.Windows.Forms.GroupBox groupBoxInputData_CDV;
        private System.Windows.Forms.TextBox textBoxVarStopStep_CDV;
        private System.Windows.Forms.TextBox textBoxVarStartStep_CDV;
        private System.Windows.Forms.Label labelStopStep_CDV;
        private System.Windows.Forms.Label labelStartStep_CDV;
        private System.Windows.Forms.TextBox textBoxTask_CDV;
        private System.Windows.Forms.Button buttonDone_CDV;
        private System.Windows.Forms.Button buttonHelp_CDV;
        private System.Windows.Forms.Button buttonSave_CDV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CDV;
    }
}

