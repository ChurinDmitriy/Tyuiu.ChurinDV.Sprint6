
namespace Tyuiu.ChurinDV.Sprint6.Task7.V5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_CDV = new System.Windows.Forms.Panel();
            this.buttonHelp_CDV = new System.Windows.Forms.Button();
            this.buttonSaveFile_CDV = new System.Windows.Forms.Button();
            this.buttonDone_CDV = new System.Windows.Forms.Button();
            this.buttonOpenFile_CDV = new System.Windows.Forms.Button();
            this.panelTop2_CDV = new System.Windows.Forms.Panel();
            this.groupBoxTask_CDV = new System.Windows.Forms.GroupBox();
            this.labelTask_CDV = new System.Windows.Forms.Label();
            this.panelLeft_CDV = new System.Windows.Forms.Panel();
            this.groupBoxInputData_CDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInputMatrix_CDV = new System.Windows.Forms.DataGridView();
            this.panelFill_CDV = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_CDV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutputMatrix_CDV = new System.Windows.Forms.DataGridView();
            this.splitter_CDV = new System.Windows.Forms.Splitter();
            this.toolTipButton_CDV = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_CDV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_CDV = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_CDV.SuspendLayout();
            this.panelTop2_CDV.SuspendLayout();
            this.groupBoxTask_CDV.SuspendLayout();
            this.panelLeft_CDV.SuspendLayout();
            this.groupBoxInputData_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix_CDV)).BeginInit();
            this.panelFill_CDV.SuspendLayout();
            this.groupBoxOutputData_CDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputMatrix_CDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_CDV
            // 
            this.panelTop_CDV.Controls.Add(this.buttonHelp_CDV);
            this.panelTop_CDV.Controls.Add(this.buttonSaveFile_CDV);
            this.panelTop_CDV.Controls.Add(this.buttonDone_CDV);
            this.panelTop_CDV.Controls.Add(this.buttonOpenFile_CDV);
            this.panelTop_CDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CDV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CDV.Name = "panelTop_CDV";
            this.panelTop_CDV.Size = new System.Drawing.Size(984, 74);
            this.panelTop_CDV.TabIndex = 0;
            // 
            // buttonHelp_CDV
            // 
            this.buttonHelp_CDV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_CDV.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_CDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_CDV.Image")));
            this.buttonHelp_CDV.Location = new System.Drawing.Point(888, 0);
            this.buttonHelp_CDV.Name = "buttonHelp_CDV";
            this.buttonHelp_CDV.Size = new System.Drawing.Size(96, 74);
            this.buttonHelp_CDV.TabIndex = 3;
            this.toolTipButton_CDV.SetToolTip(this.buttonHelp_CDV, "Информация о разработчике");
            this.buttonHelp_CDV.UseVisualStyleBackColor = false;
            this.buttonHelp_CDV.Click += new System.EventHandler(this.buttonHelp_CDV_Click);
            // 
            // buttonSaveFile_CDV
            // 
            this.buttonSaveFile_CDV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSaveFile_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_CDV.Enabled = false;
            this.buttonSaveFile_CDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_CDV.Image")));
            this.buttonSaveFile_CDV.Location = new System.Drawing.Point(209, 4);
            this.buttonSaveFile_CDV.Name = "buttonSaveFile_CDV";
            this.buttonSaveFile_CDV.Size = new System.Drawing.Size(96, 65);
            this.buttonSaveFile_CDV.TabIndex = 2;
            this.toolTipButton_CDV.SetToolTip(this.buttonSaveFile_CDV, "Сохраняет получивушуюся матрицу в выбранную папку");
            this.buttonSaveFile_CDV.UseVisualStyleBackColor = false;
            this.buttonSaveFile_CDV.Click += new System.EventHandler(this.buttonSaveFile_CDV_Click);
            // 
            // buttonDone_CDV
            // 
            this.buttonDone_CDV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDone_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_CDV.Enabled = false;
            this.buttonDone_CDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_CDV.Image")));
            this.buttonDone_CDV.Location = new System.Drawing.Point(106, 4);
            this.buttonDone_CDV.Name = "buttonDone_CDV";
            this.buttonDone_CDV.Size = new System.Drawing.Size(96, 65);
            this.buttonDone_CDV.TabIndex = 1;
            this.toolTipButton_CDV.SetToolTip(this.buttonDone_CDV, "Изменяет значения меньше 2 на 2 в поледнем столбце");
            this.buttonDone_CDV.UseVisualStyleBackColor = false;
            this.buttonDone_CDV.Click += new System.EventHandler(this.buttonDone_CDV_Click);
            // 
            // buttonOpenFile_CDV
            // 
            this.buttonOpenFile_CDV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFile_CDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_CDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_CDV.Image")));
            this.buttonOpenFile_CDV.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_CDV.Name = "buttonOpenFile_CDV";
            this.buttonOpenFile_CDV.Size = new System.Drawing.Size(96, 65);
            this.buttonOpenFile_CDV.TabIndex = 0;
            this.toolTipButton_CDV.SetToolTip(this.buttonOpenFile_CDV, "Открывает диалоговое окно для выбора файла");
            this.buttonOpenFile_CDV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_CDV.Click += new System.EventHandler(this.buttonOpenFile_CDV_Click);
            // 
            // panelTop2_CDV
            // 
            this.panelTop2_CDV.Controls.Add(this.groupBoxTask_CDV);
            this.panelTop2_CDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop2_CDV.Location = new System.Drawing.Point(0, 74);
            this.panelTop2_CDV.Name = "panelTop2_CDV";
            this.panelTop2_CDV.Size = new System.Drawing.Size(984, 85);
            this.panelTop2_CDV.TabIndex = 1;
            // 
            // groupBoxTask_CDV
            // 
            this.groupBoxTask_CDV.Controls.Add(this.labelTask_CDV);
            this.groupBoxTask_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_CDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_CDV.Name = "groupBoxTask_CDV";
            this.groupBoxTask_CDV.Size = new System.Drawing.Size(984, 85);
            this.groupBoxTask_CDV.TabIndex = 0;
            this.groupBoxTask_CDV.TabStop = false;
            this.groupBoxTask_CDV.Text = "Условие:";
            // 
            // labelTask_CDV
            // 
            this.labelTask_CDV.AutoSize = true;
            this.labelTask_CDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_CDV.Location = new System.Drawing.Point(6, 16);
            this.labelTask_CDV.Name = "labelTask_CDV";
            this.labelTask_CDV.Size = new System.Drawing.Size(767, 48);
            this.labelTask_CDV.TabIndex = 0;
            this.labelTask_CDV.Text = resources.GetString("labelTask_CDV.Text");
            // 
            // panelLeft_CDV
            // 
            this.panelLeft_CDV.Controls.Add(this.groupBoxInputData_CDV);
            this.panelLeft_CDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CDV.Location = new System.Drawing.Point(0, 159);
            this.panelLeft_CDV.Name = "panelLeft_CDV";
            this.panelLeft_CDV.Size = new System.Drawing.Size(250, 402);
            this.panelLeft_CDV.TabIndex = 2;
            // 
            // groupBoxInputData_CDV
            // 
            this.groupBoxInputData_CDV.Controls.Add(this.dataGridViewInputMatrix_CDV);
            this.groupBoxInputData_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInputData_CDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInputData_CDV.Name = "groupBoxInputData_CDV";
            this.groupBoxInputData_CDV.Size = new System.Drawing.Size(250, 402);
            this.groupBoxInputData_CDV.TabIndex = 0;
            this.groupBoxInputData_CDV.TabStop = false;
            this.groupBoxInputData_CDV.Text = "Ввод:";
            // 
            // dataGridViewInputMatrix_CDV
            // 
            this.dataGridViewInputMatrix_CDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputMatrix_CDV.ColumnHeadersVisible = false;
            this.dataGridViewInputMatrix_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInputMatrix_CDV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInputMatrix_CDV.Name = "dataGridViewInputMatrix_CDV";
            this.dataGridViewInputMatrix_CDV.ReadOnly = true;
            this.dataGridViewInputMatrix_CDV.RowHeadersVisible = false;
            this.dataGridViewInputMatrix_CDV.Size = new System.Drawing.Size(244, 383);
            this.dataGridViewInputMatrix_CDV.TabIndex = 0;
            // 
            // panelFill_CDV
            // 
            this.panelFill_CDV.Controls.Add(this.groupBoxOutputData_CDV);
            this.panelFill_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_CDV.Location = new System.Drawing.Point(250, 159);
            this.panelFill_CDV.Name = "panelFill_CDV";
            this.panelFill_CDV.Size = new System.Drawing.Size(734, 402);
            this.panelFill_CDV.TabIndex = 3;
            // 
            // groupBoxOutputData_CDV
            // 
            this.groupBoxOutputData_CDV.Controls.Add(this.dataGridViewOutputMatrix_CDV);
            this.groupBoxOutputData_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_CDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_CDV.Name = "groupBoxOutputData_CDV";
            this.groupBoxOutputData_CDV.Size = new System.Drawing.Size(734, 402);
            this.groupBoxOutputData_CDV.TabIndex = 0;
            this.groupBoxOutputData_CDV.TabStop = false;
            this.groupBoxOutputData_CDV.Text = "Вывод:";
            // 
            // dataGridViewOutputMatrix_CDV
            // 
            this.dataGridViewOutputMatrix_CDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputMatrix_CDV.ColumnHeadersVisible = false;
            this.dataGridViewOutputMatrix_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutputMatrix_CDV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutputMatrix_CDV.Name = "dataGridViewOutputMatrix_CDV";
            this.dataGridViewOutputMatrix_CDV.ReadOnly = true;
            this.dataGridViewOutputMatrix_CDV.RowHeadersVisible = false;
            this.dataGridViewOutputMatrix_CDV.Size = new System.Drawing.Size(728, 383);
            this.dataGridViewOutputMatrix_CDV.TabIndex = 0;
            // 
            // splitter_CDV
            // 
            this.splitter_CDV.Location = new System.Drawing.Point(250, 159);
            this.splitter_CDV.Name = "splitter_CDV";
            this.splitter_CDV.Size = new System.Drawing.Size(3, 402);
            this.splitter_CDV.TabIndex = 4;
            this.splitter_CDV.TabStop = false;
            // 
            // toolTipButton_CDV
            // 
            this.toolTipButton_CDV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_CDV.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask_CDV
            // 
            this.openFileDialogTask_CDV.FileName = "InPutFileTask7V5.csv";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitter_CDV);
            this.Controls.Add(this.panelFill_CDV);
            this.Controls.Add(this.panelLeft_CDV);
            this.Controls.Add(this.panelTop2_CDV);
            this.Controls.Add(this.panelTop_CDV);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 25 | Чурин Д. В.";
            this.panelTop_CDV.ResumeLayout(false);
            this.panelTop2_CDV.ResumeLayout(false);
            this.groupBoxTask_CDV.ResumeLayout(false);
            this.groupBoxTask_CDV.PerformLayout();
            this.panelLeft_CDV.ResumeLayout(false);
            this.groupBoxInputData_CDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix_CDV)).EndInit();
            this.panelFill_CDV.ResumeLayout(false);
            this.groupBoxOutputData_CDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputMatrix_CDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CDV;
        private System.Windows.Forms.Button buttonHelp_CDV;
        private System.Windows.Forms.Button buttonSaveFile_CDV;
        private System.Windows.Forms.Button buttonDone_CDV;
        private System.Windows.Forms.Button buttonOpenFile_CDV;
        private System.Windows.Forms.Panel panelTop2_CDV;
        private System.Windows.Forms.GroupBox groupBoxTask_CDV;
        private System.Windows.Forms.Label labelTask_CDV;
        private System.Windows.Forms.Panel panelLeft_CDV;
        private System.Windows.Forms.GroupBox groupBoxInputData_CDV;
        private System.Windows.Forms.DataGridView dataGridViewInputMatrix_CDV;
        private System.Windows.Forms.Panel panelFill_CDV;
        private System.Windows.Forms.GroupBox groupBoxOutputData_CDV;
        private System.Windows.Forms.DataGridView dataGridViewOutputMatrix_CDV;
        private System.Windows.Forms.Splitter splitter_CDV;
        private System.Windows.Forms.ToolTip toolTipButton_CDV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_CDV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_CDV;
    }
}

