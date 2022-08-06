namespace Obs_AdoNet.Personel
{
    partial class Personel_Screen
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
            this.btnStudentProcess = new System.Windows.Forms.Button();
            this.btnTeacherProcess = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentProcess
            // 
            this.btnStudentProcess.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentProcess.Location = new System.Drawing.Point(29, 181);
            this.btnStudentProcess.Name = "btnStudentProcess";
            this.btnStudentProcess.Size = new System.Drawing.Size(212, 69);
            this.btnStudentProcess.TabIndex = 0;
            this.btnStudentProcess.Text = "Öğrenci İşlemleri";
            this.btnStudentProcess.UseVisualStyleBackColor = true;
            // 
            // btnTeacherProcess
            // 
            this.btnTeacherProcess.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeacherProcess.Location = new System.Drawing.Point(304, 181);
            this.btnTeacherProcess.Name = "btnTeacherProcess";
            this.btnTeacherProcess.Size = new System.Drawing.Size(212, 69);
            this.btnTeacherProcess.TabIndex = 1;
            this.btnTeacherProcess.Text = "Öğretmen İşlemleri";
            this.btnTeacherProcess.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(576, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Personel İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Personel_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTeacherProcess);
            this.Controls.Add(this.btnStudentProcess);
            this.Name = "Personel_Screen";
            this.Text = "Personel_Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentProcess;
        private System.Windows.Forms.Button btnTeacherProcess;
        private System.Windows.Forms.Button button2;
    }
}