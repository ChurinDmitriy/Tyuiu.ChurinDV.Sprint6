
namespace Tyuiu.ChurinDV.Sprint6.Task1.V26
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
            this.groupBoxUslovie_CDV = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData_CDV = new System.Windows.Forms.GroupBox();
            this.groupBoxInputData_CDV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CDV = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_CDV = new System.Windows.Forms.PictureBox();
            this.textBoxVarStart_CDV = new System.Windows.Forms.TextBox();
            this.labelStart_CDV = new System.Windows.Forms.Label();
            this.labelStop_CDV = new System.Windows.Forms.Label();
            this.textBoxVarStop_CDV = new System.Windows.Forms.TextBox();
            this.buttonDone_CDV = new System.Windows.Forms.Button();
            this.buttonHelp_CDV = new System.Windows.Forms.Button();
            this.labelResult_CDV = new System.Windows.Forms.Label();
            this.textBoxResult_CDV = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_CDV.SuspendLayout();
            this.groupBoxOutputData_CDV.SuspendLayout();
            this.groupBoxInputData_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_CDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_CDV
            // 
            this.groupBoxUslovie_CDV.Controls.Add(this.pictureBoxFormula_CDV);
            this.groupBoxUslovie_CDV.Controls.Add(this.textBoxTask_CDV);
            this.groupBoxUslovie_CDV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_CDV.Name = "groupBoxUslovie_CDV";
            this.groupBoxUslovie_CDV.Size = new System.Drawing.Size(506, 345);
            this.groupBoxUslovie_CDV.TabIndex = 0;
            this.groupBoxUslovie_CDV.TabStop = false;
            this.groupBoxUslovie_CDV.Text = "Условие";
            // 
            // groupBoxOutputData_CDV
            // 
            this.groupBoxOutputData_CDV.Controls.Add(this.textBoxResult_CDV);
            this.groupBoxOutputData_CDV.Controls.Add(this.labelResult_CDV);
            this.groupBoxOutputData_CDV.Location = new System.Drawing.Point(524, 12);
            this.groupBoxOutputData_CDV.Name = "groupBoxOutputData_CDV";
            this.groupBoxOutputData_CDV.Size = new System.Drawing.Size(264, 426);
            this.groupBoxOutputData_CDV.TabIndex = 1;
            this.groupBoxOutputData_CDV.TabStop = false;
            this.groupBoxOutputData_CDV.Text = "Вывод данных";
            // 
            // groupBoxInputData_CDV
            // 
            this.groupBoxInputData_CDV.Controls.Add(this.labelStop_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.labelStart_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.textBoxVarStop_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.textBoxVarStart_CDV);
            this.groupBoxInputData_CDV.Location = new System.Drawing.Point(12, 363);
            this.groupBoxInputData_CDV.Name = "groupBoxInputData_CDV";
            this.groupBoxInputData_CDV.Size = new System.Drawing.Size(258, 75);
            this.groupBoxInputData_CDV.TabIndex = 2;
            this.groupBoxInputData_CDV.TabStop = false;
            this.groupBoxInputData_CDV.Text = "Ввод данных";
            // 
            // textBoxTask_CDV
            // 
            this.textBoxTask_CDV.Location = new System.Drawing.Point(0, 19);
            this.textBoxTask_CDV.Multiline = true;
            this.textBoxTask_CDV.Name = "textBoxTask_CDV";
            this.textBoxTask_CDV.ReadOnly = true;
            this.textBoxTask_CDV.Size = new System.Drawing.Size(290, 35);
            this.textBoxTask_CDV.TabIndex = 0;
            this.textBoxTask_CDV.Text = "Протабулировать функция F(x) на заданном диапазоне. Результат вывести в виде табл" +
    "ицы.";
            // 
            // pictureBoxFormula_CDV
            // 
            this.pictureBoxFormula_CDV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_CDV.Image")));
            this.pictureBoxFormula_CDV.Location = new System.Drawing.Point(0, 60);
            this.pictureBoxFormula_CDV.Name = "pictureBoxFormula_CDV";
            this.pictureBoxFormula_CDV.Size = new System.Drawing.Size(343, 44);
            this.pictureBoxFormula_CDV.TabIndex = 1;
            this.pictureBoxFormula_CDV.TabStop = false;
            // 
            // textBoxVarStart_CDV
            // 
            this.textBoxVarStart_CDV.Location = new System.Drawing.Point(6, 49);
            this.textBoxVarStart_CDV.Name = "textBoxVarStart_CDV";
            this.textBoxVarStart_CDV.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStart_CDV.TabIndex = 0;
            // 
            // labelStart_CDV
            // 
            this.labelStart_CDV.AutoSize = true;
            this.labelStart_CDV.Location = new System.Drawing.Point(6, 31);
            this.labelStart_CDV.Name = "labelStart_CDV";
            this.labelStart_CDV.Size = new System.Drawing.Size(67, 13);
            this.labelStart_CDV.TabIndex = 1;
            this.labelStart_CDV.Text = "Старт шага:";
            // 
            // labelStop_CDV
            // 
            this.labelStop_CDV.AutoSize = true;
            this.labelStop_CDV.Location = new System.Drawing.Point(149, 31);
            this.labelStop_CDV.Name = "labelStop_CDV";
            this.labelStop_CDV.Size = new System.Drawing.Size(69, 13);
            this.labelStop_CDV.TabIndex = 1;
            this.labelStop_CDV.Text = "Конец шага:";
            // 
            // textBoxVarStop_CDV
            // 
            this.textBoxVarStop_CDV.Location = new System.Drawing.Point(152, 49);
            this.textBoxVarStop_CDV.Name = "textBoxVarStop_CDV";
            this.textBoxVarStop_CDV.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStop_CDV.TabIndex = 0;
            // 
            // buttonDone_CDV
            // 
            this.buttonDone_CDV.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_CDV.Location = new System.Drawing.Point(363, 363);
            this.buttonDone_CDV.Name = "buttonDone_CDV";
            this.buttonDone_CDV.Size = new System.Drawing.Size(155, 75);
            this.buttonDone_CDV.TabIndex = 3;
            this.buttonDone_CDV.Text = "Выполнить";
            this.buttonDone_CDV.UseVisualStyleBackColor = false;
            this.buttonDone_CDV.Click += new System.EventHandler(this.buttonDone_CDV_Click);
            // 
            // buttonHelp_CDV
            // 
            this.buttonHelp_CDV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_CDV.Location = new System.Drawing.Point(276, 363);
            this.buttonHelp_CDV.Name = "buttonHelp_CDV";
            this.buttonHelp_CDV.Size = new System.Drawing.Size(81, 75);
            this.buttonHelp_CDV.TabIndex = 4;
            this.buttonHelp_CDV.Text = "Справка";
            this.buttonHelp_CDV.UseVisualStyleBackColor = false;
            this.buttonHelp_CDV.Click += new System.EventHandler(this.buttonHelp_CDV_Click);
            // 
            // labelResult_CDV
            // 
            this.labelResult_CDV.AutoSize = true;
            this.labelResult_CDV.Location = new System.Drawing.Point(6, 16);
            this.labelResult_CDV.Name = "labelResult_CDV";
            this.labelResult_CDV.Size = new System.Drawing.Size(62, 13);
            this.labelResult_CDV.TabIndex = 0;
            this.labelResult_CDV.Text = "Результат:";
            // 
            // textBoxResult_CDV
            // 
            this.textBoxResult_CDV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_CDV.Location = new System.Drawing.Point(6, 34);
            this.textBoxResult_CDV.Multiline = true;
            this.textBoxResult_CDV.Name = "textBoxResult_CDV";
            this.textBoxResult_CDV.ReadOnly = true;
            this.textBoxResult_CDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_CDV.Size = new System.Drawing.Size(252, 386);
            this.textBoxResult_CDV.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_CDV);
            this.Controls.Add(this.buttonDone_CDV);
            this.Controls.Add(this.groupBoxInputData_CDV);
            this.Controls.Add(this.groupBoxOutputData_CDV);
            this.Controls.Add(this.groupBoxUslovie_CDV);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск1 | Вариант 26 | Чурин Д. В.";
            this.groupBoxUslovie_CDV.ResumeLayout(false);
            this.groupBoxUslovie_CDV.PerformLayout();
            this.groupBoxOutputData_CDV.ResumeLayout(false);
            this.groupBoxOutputData_CDV.PerformLayout();
            this.groupBoxInputData_CDV.ResumeLayout(false);
            this.groupBoxInputData_CDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_CDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_CDV;
        private System.Windows.Forms.GroupBox groupBoxOutputData_CDV;
        private System.Windows.Forms.GroupBox groupBoxInputData_CDV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_CDV;
        private System.Windows.Forms.TextBox textBoxTask_CDV;
        private System.Windows.Forms.TextBox textBoxResult_CDV;
        private System.Windows.Forms.Label labelResult_CDV;
        private System.Windows.Forms.Label labelStop_CDV;
        private System.Windows.Forms.Label labelStart_CDV;
        private System.Windows.Forms.TextBox textBoxVarStop_CDV;
        private System.Windows.Forms.TextBox textBoxVarStart_CDV;
        private System.Windows.Forms.Button buttonDone_CDV;
        private System.Windows.Forms.Button buttonHelp_CDV;
    }
}

