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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLessonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentProcess
            // 
            this.btnStudentProcess.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentProcess.Location = new System.Drawing.Point(40, 37);
            this.btnStudentProcess.Name = "btnStudentProcess";
            this.btnStudentProcess.Size = new System.Drawing.Size(212, 69);
            this.btnStudentProcess.TabIndex = 1;
            this.btnStudentProcess.Text = "Öğrenci İşlemleri";
            this.btnStudentProcess.UseVisualStyleBackColor = true;
            this.btnStudentProcess.Click += new System.EventHandler(this.btnStudentProcess_Click);
            // 
            // btnTeacherProcess
            // 
            this.btnTeacherProcess.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeacherProcess.Location = new System.Drawing.Point(311, 37);
            this.btnTeacherProcess.Name = "btnTeacherProcess";
            this.btnTeacherProcess.Size = new System.Drawing.Size(212, 69);
            this.btnTeacherProcess.TabIndex = 2;
            this.btnTeacherProcess.Text = "Öğretmen İşlemleri";
            this.btnTeacherProcess.UseVisualStyleBackColor = true;
            this.btnTeacherProcess.Click += new System.EventHandler(this.btnTeacherProcess_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(311, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "Personel İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(580, 89);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 79);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLessonAdd
            // 
            this.btnLessonAdd.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLessonAdd.Location = new System.Drawing.Point(40, 150);
            this.btnLessonAdd.Name = "btnLessonAdd";
            this.btnLessonAdd.Size = new System.Drawing.Size(212, 69);
            this.btnLessonAdd.TabIndex = 4;
            this.btnLessonAdd.Text = "Ders İşlemleri";
            this.btnLessonAdd.UseVisualStyleBackColor = true;
            this.btnLessonAdd.Click += new System.EventHandler(this.btnLessonAdd_Click);
            // 
            // Personel_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 271);
            this.Controls.Add(this.btnLessonAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTeacherProcess);
            this.Controls.Add(this.btnStudentProcess);
            this.Name = "Personel_Screen";
            this.Text = "Personel Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentProcess;
        private System.Windows.Forms.Button btnTeacherProcess;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLessonAdd;
    }
}