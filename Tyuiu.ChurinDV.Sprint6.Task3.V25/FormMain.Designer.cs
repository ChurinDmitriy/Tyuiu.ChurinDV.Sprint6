
namespace Tyuiu.ChurinDV.Sprint6.Task3.V25
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
            this.textBoxTask_CDV = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_CDV = new System.Windows.Forms.GroupBox();
            this.labelResult_CDV = new System.Windows.Forms.Label();
            this.textBoxResult_CDV = new System.Windows.Forms.TextBox();
            this.buttonDone_CDV = new System.Windows.Forms.Button();
            this.buttonHelp_CDV = new System.Windows.Forms.Button();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.groupBoxUslovie_CDV.SuspendLayout();
            this.groupBoxOutputData_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_CDV
            // 
            this.groupBoxUslovie_CDV.Controls.Add(this.dataGridViewMatrix);
            this.groupBoxUslovie_CDV.Controls.Add(this.textBoxTask_CDV);
            this.groupBoxUslovie_CDV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_CDV.Name = "groupBoxUslovie_CDV";
            this.groupBoxUslovie_CDV.Size = new System.Drawing.Size(597, 307);
            this.groupBoxUslovie_CDV.TabIndex = 0;
            this.groupBoxUslovie_CDV.TabStop = false;
            this.groupBoxUslovie_CDV.Text = "Условие";
            // 
            // textBoxTask_CDV
            // 
            this.textBoxTask_CDV.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_CDV.Multiline = true;
            this.textBoxTask_CDV.Name = "textBoxTask_CDV";
            this.textBoxTask_CDV.ReadOnly = true;
            this.textBoxTask_CDV.Size = new System.Drawing.Size(268, 132);
            this.textBoxTask_CDV.TabIndex = 0;
            this.textBoxTask_CDV.Text = resources.GetString("textBoxTask_CDV.Text");
            // 
            // groupBoxOutputData_CDV
            // 
            this.groupBoxOutputData_CDV.Controls.Add(this.textBoxResult_CDV);
            this.groupBoxOutputData_CDV.Controls.Add(this.labelResult_CDV);
            this.groupBoxOutputData_CDV.Location = new System.Drawing.Point(617, 13);
            this.groupBoxOutputData_CDV.Name = "groupBoxOutputData_CDV";
            this.groupBoxOutputData_CDV.Size = new System.Drawing.Size(140, 83);
            this.groupBoxOutputData_CDV.TabIndex = 1;
            this.groupBoxOutputData_CDV.TabStop = false;
            this.groupBoxOutputData_CDV.Text = "Вывод данных";
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
            this.textBoxResult_CDV.Location = new System.Drawing.Point(7, 33);
            this.textBoxResult_CDV.Name = "textBoxResult_CDV";
            this.textBoxResult_CDV.ReadOnly = true;
            this.textBoxResult_CDV.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_CDV.TabIndex = 1;
            // 
            // buttonDone_CDV
            // 
            this.buttonDone_CDV.Location = new System.Drawing.Point(666, 285);
            this.buttonDone_CDV.Name = "buttonDone_CDV";
            this.buttonDone_CDV.Size = new System.Drawing.Size(91, 35);
            this.buttonDone_CDV.TabIndex = 2;
            this.buttonDone_CDV.Text = "Выполнить";
            this.buttonDone_CDV.UseVisualStyleBackColor = true;
            this.buttonDone_CDV.Click += new System.EventHandler(this.buttonDone_CDV_Click);
            // 
            // buttonHelp_CDV
            // 
            this.buttonHelp_CDV.Location = new System.Drawing.Point(617, 285);
            this.buttonHelp_CDV.Name = "buttonHelp_CDV";
            this.buttonHelp_CDV.Size = new System.Drawing.Size(43, 35);
            this.buttonHelp_CDV.TabIndex = 3;
            this.buttonHelp_CDV.Text = "?";
            this.buttonHelp_CDV.UseVisualStyleBackColor = true;
            this.buttonHelp_CDV.Click += new System.EventHandler(this.buttonHelp_CDV_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(282, 20);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(309, 281);
            this.dataGridViewMatrix.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 332);
            this.Controls.Add(this.buttonHelp_CDV);
            this.Controls.Add(this.buttonDone_CDV);
            this.Controls.Add(this.groupBoxOutputData_CDV);
            this.Controls.Add(this.groupBoxUslovie_CDV);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 25 | Чурин Д. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_CDV.ResumeLayout(false);
            this.groupBoxUslovie_CDV.PerformLayout();
            this.groupBoxOutputData_CDV.ResumeLayout(false);
            this.groupBoxOutputData_CDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_CDV;
        private System.Windows.Forms.TextBox textBoxTask_CDV;
        private System.Windows.Forms.GroupBox groupBoxOutputData_CDV;
        private System.Windows.Forms.TextBox textBoxResult_CDV;
        private System.Windows.Forms.Label labelResult_CDV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button buttonDone_CDV;
        private System.Windows.Forms.Button buttonHelp_CDV;
    }
}

