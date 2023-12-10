
namespace Tyuiu.ChurinDV.Sprint6.Task7.V5
{
    partial class FormAbout_CDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_CDV));
            this.pictureBoxAvatar_CDV = new System.Windows.Forms.PictureBox();
            this.labelInfo_CDV = new System.Windows.Forms.Label();
            this.buttonOk_CDV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_CDV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_CDV
            // 
            this.pictureBoxAvatar_CDV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_CDV.Image")));
            this.pictureBoxAvatar_CDV.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_CDV.Name = "pictureBoxAvatar_CDV";
            this.pictureBoxAvatar_CDV.Size = new System.Drawing.Size(170, 198);
            this.pictureBoxAvatar_CDV.TabIndex = 0;
            this.pictureBoxAvatar_CDV.TabStop = false;
            // 
            // labelInfo_CDV
            // 
            this.labelInfo_CDV.AutoSize = true;
            this.labelInfo_CDV.Location = new System.Drawing.Point(188, 9);
            this.labelInfo_CDV.Name = "labelInfo_CDV";
            this.labelInfo_CDV.Size = new System.Drawing.Size(284, 156);
            this.labelInfo_CDV.TabIndex = 1;
            this.labelInfo_CDV.Text = resources.GetString("labelInfo_CDV.Text");
            // 
            // buttonOk_CDV
            // 
            this.buttonOk_CDV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOk_CDV.Location = new System.Drawing.Point(380, 172);
            this.buttonOk_CDV.Name = "buttonOk_CDV";
            this.buttonOk_CDV.Size = new System.Drawing.Size(102, 38);
            this.buttonOk_CDV.TabIndex = 2;
            this.buttonOk_CDV.Text = "Ок";
            this.buttonOk_CDV.UseVisualStyleBackColor = false;
            this.buttonOk_CDV.Click += new System.EventHandler(this.buttonOk_CDV_Click);
            // 
            // FormAbout_CDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 222);
            this.Controls.Add(this.buttonOk_CDV);
            this.Controls.Add(this.labelInfo_CDV);
            this.Controls.Add(this.pictureBoxAvatar_CDV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_CDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_CDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_CDV;
        private System.Windows.Forms.Label labelInfo_CDV;
        private System.Windows.Forms.Button buttonOk_CDV;
    }
}