
namespace Tyuiu.ChurinDV.Sprint6.Task6.V28
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
            this.openFileDialogTask_CDV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_CDV = new System.Windows.Forms.Panel();
            this.panelTask_CDV = new System.Windows.Forms.Panel();
            this.panelLeft_CDV = new System.Windows.Forms.Panel();
            this.panelRight_CDV = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_CDV = new System.Windows.Forms.GroupBox();
            this.labelTask_CDV = new System.Windows.Forms.Label();
            this.buttonOpenFile_CDV = new System.Windows.Forms.Button();
            this.buttonDone_CDV = new System.Windows.Forms.Button();
            this.buttonHelp_CDV = new System.Windows.Forms.Button();
            this.groupBoxOutputData_CDV = new System.Windows.Forms.GroupBox();
            this.textBoxInput_CDV = new System.Windows.Forms.TextBox();
            this.groupBoxResult_CDV = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_CDV = new System.Windows.Forms.TextBox();
            this.panelTop_CDV.SuspendLayout();
            this.panelTask_CDV.SuspendLayout();
            this.panelLeft_CDV.SuspendLayout();
            this.panelRight_CDV.SuspendLayout();
            this.groupBoxTask_CDV.SuspendLayout();
            this.groupBoxOutputData_CDV.SuspendLayout();
            this.groupBoxResult_CDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogTask_CDV
            // 
            this.openFileDialogTask_CDV.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // panelTop_CDV
            // 
            this.panelTop_CDV.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop_CDV.Controls.Add(this.buttonHelp_CDV);
            this.panelTop_CDV.Controls.Add(this.buttonDone_CDV);
            this.panelTop_CDV.Controls.Add(this.buttonOpenFile_CDV);
            this.panelTop_CDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CDV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CDV.Name = "panelTop_CDV";
            this.panelTop_CDV.Size = new System.Drawing.Size(884, 79);
            this.panelTop_CDV.TabIndex = 0;
            // 
            // panelTask_CDV
            // 
            this.panelTask_CDV.Controls.Add(this.groupBoxTask_CDV);
            this.panelTask_CDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_CDV.Location = new System.Drawing.Point(0, 79);
            this.panelTask_CDV.Name = "panelTask_CDV";
            this.panelTask_CDV.Size = new System.Drawing.Size(884, 86);
            this.panelTask_CDV.TabIndex = 1;
            // 
            // panelLeft_CDV
            // 
            this.panelLeft_CDV.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft_CDV.Controls.Add(this.groupBoxOutputData_CDV);
            this.panelLeft_CDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CDV.Location = new System.Drawing.Point(0, 165);
            this.panelLeft_CDV.Name = "panelLeft_CDV";
            this.panelLeft_CDV.Size = new System.Drawing.Size(424, 396);
            this.panelLeft_CDV.TabIndex = 2;
            // 
            // panelRight_CDV
            // 
            this.panelRight_CDV.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight_CDV.Controls.Add(this.groupBoxResult_CDV);
            this.panelRight_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_CDV.Location = new System.Drawing.Point(424, 165);
            this.panelRight_CDV.Name = "panelRight_CDV";
            this.panelRight_CDV.Size = new System.Drawing.Size(460, 396);
            this.panelRight_CDV.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(424, 165);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 396);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // groupBoxTask_CDV
            // 
            this.groupBoxTask_CDV.Controls.Add(this.labelTask_CDV);
            this.groupBoxTask_CDV.Location = new System.Drawing.Point(4, 7);
            this.groupBoxTask_CDV.Name = "groupBoxTask_CDV";
            this.groupBoxTask_CDV.Size = new System.Drawing.Size(877, 73);
            this.groupBoxTask_CDV.TabIndex = 0;
            this.groupBoxTask_CDV.TabStop = false;
            this.groupBoxTask_CDV.Text = "Условие:";
            // 
            // labelTask_CDV
            // 
            this.labelTask_CDV.AutoSize = true;
            this.labelTask_CDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_CDV.Location = new System.Drawing.Point(9, 20);
            this.labelTask_CDV.Name = "labelTask_CDV";
            this.labelTask_CDV.Size = new System.Drawing.Size(854, 32);
            this.labelTask_CDV.TabIndex = 0;
            this.labelTask_CDV.Text = resources.GetString("labelTask_CDV.Text");
            // 
            // buttonOpenFile_CDV
            // 
            this.buttonOpenFile_CDV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFile_CDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_CDV.Image")));
            this.buttonOpenFile_CDV.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_CDV.Name = "buttonOpenFile_CDV";
            this.buttonOpenFile_CDV.Size = new System.Drawing.Size(86, 69);
            this.buttonOpenFile_CDV.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonOpenFile_CDV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_CDV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_CDV.Click += new System.EventHandler(this.buttonOpenFile_CDV_Click);
            // 
            // buttonDone_CDV
            // 
            this.buttonDone_CDV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDone_CDV.Enabled = false;
            this.buttonDone_CDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_CDV.Image")));
            this.buttonDone_CDV.Location = new System.Drawing.Point(96, 4);
            this.buttonDone_CDV.Name = "buttonDone_CDV";
            this.buttonDone_CDV.Size = new System.Drawing.Size(86, 69);
            this.buttonDone_CDV.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonDone_CDV, "Производит новую строку состоящую из \r\nпредпоследних слов в каждой строке \r\nисход" +
        "ного текста\r\n");
            this.buttonDone_CDV.UseVisualStyleBackColor = false;
            this.buttonDone_CDV.Click += new System.EventHandler(this.buttonDone_CDV_Click);
            // 
            // buttonHelp_CDV
            // 
            this.buttonHelp_CDV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHelp_CDV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_CDV.Image")));
            this.buttonHelp_CDV.Location = new System.Drawing.Point(793, 4);
            this.buttonHelp_CDV.Name = "buttonHelp_CDV";
            this.buttonHelp_CDV.Size = new System.Drawing.Size(86, 69);
            this.buttonHelp_CDV.TabIndex = 2;
            this.buttonHelp_CDV.UseVisualStyleBackColor = false;
            this.buttonHelp_CDV.Click += new System.EventHandler(this.buttonHelp_CDV_Click);
            // 
            // groupBoxOutputData_CDV
            // 
            this.groupBoxOutputData_CDV.Controls.Add(this.textBoxInput_CDV);
            this.groupBoxOutputData_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_CDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_CDV.Name = "groupBoxOutputData_CDV";
            this.groupBoxOutputData_CDV.Size = new System.Drawing.Size(424, 396);
            this.groupBoxOutputData_CDV.TabIndex = 0;
            this.groupBoxOutputData_CDV.TabStop = false;
            this.groupBoxOutputData_CDV.Text = "Ввод:";
            // 
            // textBoxInput_CDV
            // 
            this.textBoxInput_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_CDV.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput_CDV.Multiline = true;
            this.textBoxInput_CDV.Name = "textBoxInput_CDV";
            this.textBoxInput_CDV.ReadOnly = true;
            this.textBoxInput_CDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_CDV.Size = new System.Drawing.Size(418, 377);
            this.textBoxInput_CDV.TabIndex = 0;
            // 
            // groupBoxResult_CDV
            // 
            this.groupBoxResult_CDV.Controls.Add(this.textBoxOutput_CDV);
            this.groupBoxResult_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_CDV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_CDV.Name = "groupBoxResult_CDV";
            this.groupBoxResult_CDV.Size = new System.Drawing.Size(460, 396);
            this.groupBoxResult_CDV.TabIndex = 0;
            this.groupBoxResult_CDV.TabStop = false;
            this.groupBoxResult_CDV.Text = "Вывод:";
            // 
            // textBoxOutput_CDV
            // 
            this.textBoxOutput_CDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput_CDV.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput_CDV.Multiline = true;
            this.textBoxOutput_CDV.Name = "textBoxOutput_CDV";
            this.textBoxOutput_CDV.ReadOnly = true;
            this.textBoxOutput_CDV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_CDV.Size = new System.Drawing.Size(454, 377);
            this.textBoxOutput_CDV.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelRight_CDV);
            this.Controls.Add(this.panelLeft_CDV);
            this.Controls.Add(this.panelTask_CDV);
            this.Controls.Add(this.panelTop_CDV);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 28 | Чурин Д. В.";
            this.panelTop_CDV.ResumeLayout(false);
            this.panelTask_CDV.ResumeLayout(false);
            this.panelLeft_CDV.ResumeLayout(false);
            this.panelRight_CDV.ResumeLayout(false);
            this.groupBoxTask_CDV.ResumeLayout(false);
            this.groupBoxTask_CDV.PerformLayout();
            this.groupBoxOutputData_CDV.ResumeLayout(false);
            this.groupBoxOutputData_CDV.PerformLayout();
            this.groupBoxResult_CDV.ResumeLayout(false);
            this.groupBoxResult_CDV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogTask_CDV;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelTop_CDV;
        private System.Windows.Forms.Panel panelTask_CDV;
        private System.Windows.Forms.Panel panelLeft_CDV;
        private System.Windows.Forms.Panel panelRight_CDV;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_CDV;
        private System.Windows.Forms.Button buttonDone_CDV;
        private System.Windows.Forms.Button buttonOpenFile_CDV;
        private System.Windows.Forms.GroupBox groupBoxTask_CDV;
        private System.Windows.Forms.Label labelTask_CDV;
        private System.Windows.Forms.GroupBox groupBoxOutputData_CDV;
        private System.Windows.Forms.TextBox textBoxInput_CDV;
        private System.Windows.Forms.GroupBox groupBoxResult_CDV;
        private System.Windows.Forms.TextBox textBoxOutput_CDV;
    }
}

