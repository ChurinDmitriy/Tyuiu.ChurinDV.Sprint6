
namespace Tyuiu.ChurinDV.Sprint6.Task0.V23
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
            this.pictureBoxFormula_CDV = new System.Windows.Forms.PictureBox();
            this.textBoxTask_CDV = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_CDV = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_CDV = new System.Windows.Forms.TextBox();
            this.labelInputData_CDV = new System.Windows.Forms.Label();
            this.groupBoxOutput_CDV = new System.Windows.Forms.GroupBox();
            this.labelResult_CDV = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxResult_CDV = new System.Windows.Forms.TextBox();
            this.buttonDone_CDV = new System.Windows.Forms.Button();
            this.buttonVopros_CDV = new System.Windows.Forms.Button();
            this.groupBoxUslovie_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_CDV)).BeginInit();
            this.groupBoxInputData_CDV.SuspendLayout();
            this.groupBoxOutput_CDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_CDV
            // 
            this.groupBoxUslovie_CDV.Controls.Add(this.pictureBoxFormula_CDV);
            this.groupBoxUslovie_CDV.Controls.Add(this.textBoxTask_CDV);
            this.groupBoxUslovie_CDV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_CDV.Name = "groupBoxUslovie_CDV";
            this.groupBoxUslovie_CDV.Size = new System.Drawing.Size(582, 235);
            this.groupBoxUslovie_CDV.TabIndex = 0;
            this.groupBoxUslovie_CDV.TabStop = false;
            this.groupBoxUslovie_CDV.Text = "Условие";
            // 
            // pictureBoxFormula_CDV
            // 
            this.pictureBoxFormula_CDV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_CDV.Image")));
            this.pictureBoxFormula_CDV.Location = new System.Drawing.Point(426, 19);
            this.pictureBoxFormula_CDV.Name = "pictureBoxFormula_CDV";
            this.pictureBoxFormula_CDV.Size = new System.Drawing.Size(127, 57);
            this.pictureBoxFormula_CDV.TabIndex = 1;
            this.pictureBoxFormula_CDV.TabStop = false;
            // 
            // textBoxTask_CDV
            // 
            this.textBoxTask_CDV.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_CDV.Multiline = true;
            this.textBoxTask_CDV.Name = "textBoxTask_CDV";
            this.textBoxTask_CDV.ReadOnly = true;
            this.textBoxTask_CDV.Size = new System.Drawing.Size(392, 210);
            this.textBoxTask_CDV.TabIndex = 0;
            this.textBoxTask_CDV.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой. Графический интерфейс оформить по шаблону и" +
    "з лекции.";
            // 
            // groupBoxInputData_CDV
            // 
            this.groupBoxInputData_CDV.Controls.Add(this.textBoxVarX_CDV);
            this.groupBoxInputData_CDV.Controls.Add(this.labelInputData_CDV);
            this.groupBoxInputData_CDV.Location = new System.Drawing.Point(12, 311);
            this.groupBoxInputData_CDV.Name = "groupBoxInputData_CDV";
            this.groupBoxInputData_CDV.Size = new System.Drawing.Size(392, 92);
            this.groupBoxInputData_CDV.TabIndex = 1;
            this.groupBoxInputData_CDV.TabStop = false;
            this.groupBoxInputData_CDV.Text = "Ввод данных";
            // 
            // textBoxVarX_CDV
            // 
            this.textBoxVarX_CDV.Location = new System.Drawing.Point(6, 59);
            this.textBoxVarX_CDV.Name = "textBoxVarX_CDV";
            this.textBoxVarX_CDV.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_CDV.TabIndex = 1;
            // 
            // labelInputData_CDV
            // 
            this.labelInputData_CDV.AutoSize = true;
            this.labelInputData_CDV.Location = new System.Drawing.Point(6, 43);
            this.labelInputData_CDV.Name = "labelInputData_CDV";
            this.labelInputData_CDV.Size = new System.Drawing.Size(84, 13);
            this.labelInputData_CDV.TabIndex = 0;
            this.labelInputData_CDV.Text = "Переменная X:";
            // 
            // groupBoxOutput_CDV
            // 
            this.groupBoxOutput_CDV.Controls.Add(this.textBoxResult_CDV);
            this.groupBoxOutput_CDV.Controls.Add(this.labelResult_CDV);
            this.groupBoxOutput_CDV.Location = new System.Drawing.Point(410, 311);
            this.groupBoxOutput_CDV.Name = "groupBoxOutput_CDV";
            this.groupBoxOutput_CDV.Size = new System.Drawing.Size(184, 92);
            this.groupBoxOutput_CDV.TabIndex = 2;
            this.groupBoxOutput_CDV.TabStop = false;
            this.groupBoxOutput_CDV.Text = "Вывод данных";
            // 
            // labelResult_CDV
            // 
            this.labelResult_CDV.Location = new System.Drawing.Point(6, 40);
            this.labelResult_CDV.Name = "labelResult_CDV";
            this.labelResult_CDV.Size = new System.Drawing.Size(100, 16);
            this.labelResult_CDV.TabIndex = 2;
            this.labelResult_CDV.Text = "Результат:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxResult_CDV
            // 
            this.textBoxResult_CDV.Location = new System.Drawing.Point(9, 59);
            this.textBoxResult_CDV.Name = "textBoxResult_CDV";
            this.textBoxResult_CDV.ReadOnly = true;
            this.textBoxResult_CDV.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_CDV.TabIndex = 3;
            // 
            // buttonDone_CDV
            // 
            this.buttonDone_CDV.Location = new System.Drawing.Point(467, 409);
            this.buttonDone_CDV.Name = "buttonDone_CDV";
            this.buttonDone_CDV.Size = new System.Drawing.Size(127, 33);
            this.buttonDone_CDV.TabIndex = 3;
            this.buttonDone_CDV.Text = "Выполнить";
            this.buttonDone_CDV.UseVisualStyleBackColor = true;
            this.buttonDone_CDV.Click += new System.EventHandler(this.buttonDone_CDV_Click);
            // 
            // buttonVopros_CDV
            // 
            this.buttonVopros_CDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVopros_CDV.Location = new System.Drawing.Point(410, 410);
            this.buttonVopros_CDV.Name = "buttonVopros_CDV";
            this.buttonVopros_CDV.Size = new System.Drawing.Size(51, 32);
            this.buttonVopros_CDV.TabIndex = 4;
            this.buttonVopros_CDV.Text = "?";
            this.buttonVopros_CDV.UseVisualStyleBackColor = true;
            this.buttonVopros_CDV.Click += new System.EventHandler(this.buttonVopros_CDV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 454);
            this.Controls.Add(this.buttonVopros_CDV);
            this.Controls.Add(this.buttonDone_CDV);
            this.Controls.Add(this.groupBoxOutput_CDV);
            this.Controls.Add(this.groupBoxInputData_CDV);
            this.Controls.Add(this.groupBoxUslovie_CDV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 23 | Чурин Д. В.";
            this.groupBoxUslovie_CDV.ResumeLayout(false);
            this.groupBoxUslovie_CDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_CDV)).EndInit();
            this.groupBoxInputData_CDV.ResumeLayout(false);
            this.groupBoxInputData_CDV.PerformLayout();
            this.groupBoxOutput_CDV.ResumeLayout(false);
            this.groupBoxOutput_CDV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_CDV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_CDV;
        private System.Windows.Forms.TextBox textBoxTask_CDV;
        private System.Windows.Forms.GroupBox groupBoxInputData_CDV;
        private System.Windows.Forms.GroupBox groupBoxOutput_CDV;
        private System.Windows.Forms.TextBox textBoxVarX_CDV;
        private System.Windows.Forms.Label labelInputData_CDV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelResult_CDV;
        private System.Windows.Forms.TextBox textBoxResult_CDV;
        private System.Windows.Forms.Button buttonDone_CDV;
        private System.Windows.Forms.Button buttonVopros_CDV;
    }
}

