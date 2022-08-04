namespace Obs_AdoNet.Ogrenci
{
    partial class Ogrenci_Ekrani
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
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblStudentScreenDateTime = new System.Windows.Forms.Label();
            this.dtgStudentLessonProgram = new System.Windows.Forms.DataGridView();
            this.lblStudentLessonProgram = new System.Windows.Forms.Label();
            this.lblExamResult = new System.Windows.Forms.Label();
            this.dtgExamResult = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentLessonProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExamResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNo.Location = new System.Drawing.Point(27, 39);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(110, 22);
            this.lblStudentNo.TabIndex = 0;
            this.lblStudentNo.Text = "Öğrenci NO";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.Location = new System.Drawing.Point(205, 39);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(110, 22);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Öğrenci Ad";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.Location = new System.Drawing.Point(397, 39);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(150, 22);
            this.lblStudentSurname.TabIndex = 2;
            this.lblStudentSurname.Text = "Öğrenci  Soyad";
            // 
            // lblStudentScreenDateTime
            // 
            this.lblStudentScreenDateTime.AutoSize = true;
            this.lblStudentScreenDateTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentScreenDateTime.Location = new System.Drawing.Point(629, 39);
            this.lblStudentScreenDateTime.Name = "lblStudentScreenDateTime";
            this.lblStudentScreenDateTime.Size = new System.Drawing.Size(210, 22);
            this.lblStudentScreenDateTime.TabIndex = 3;
            this.lblStudentScreenDateTime.Text = "Öğrenci  ekran Tarih";
            // 
            // dtgStudentLessonProgram
            // 
            this.dtgStudentLessonProgram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStudentLessonProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentLessonProgram.Location = new System.Drawing.Point(31, 136);
            this.dtgStudentLessonProgram.Name = "dtgStudentLessonProgram";
            this.dtgStudentLessonProgram.Size = new System.Drawing.Size(932, 136);
            this.dtgStudentLessonProgram.TabIndex = 4;
            // 
            // lblStudentLessonProgram
            // 
            this.lblStudentLessonProgram.AutoSize = true;
            this.lblStudentLessonProgram.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentLessonProgram.Location = new System.Drawing.Point(27, 91);
            this.lblStudentLessonProgram.Name = "lblStudentLessonProgram";
            this.lblStudentLessonProgram.Size = new System.Drawing.Size(220, 22);
            this.lblStudentLessonProgram.TabIndex = 5;
            this.lblStudentLessonProgram.Text = "Öğrenci Ders Programı";
            // 
            // lblExamResult
            // 
            this.lblExamResult.AutoSize = true;
            this.lblExamResult.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExamResult.Location = new System.Drawing.Point(27, 303);
            this.lblExamResult.Name = "lblExamResult";
            this.lblExamResult.Size = new System.Drawing.Size(250, 22);
            this.lblExamResult.TabIndex = 6;
            this.lblExamResult.Text = "Öğrenci  Sınav Sonuçları";
            // 
            // dtgExamResult
            // 
            this.dtgExamResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgExamResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExamResult.Location = new System.Drawing.Point(31, 346);
            this.dtgExamResult.Name = "dtgExamResult";
            this.dtgExamResult.Size = new System.Drawing.Size(932, 136);
            this.dtgExamResult.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(1043, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Ogrenci_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 549);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtgExamResult);
            this.Controls.Add(this.lblExamResult);
            this.Controls.Add(this.lblStudentLessonProgram);
            this.Controls.Add(this.dtgStudentLessonProgram);
            this.Controls.Add(this.lblStudentScreenDateTime);
            this.Controls.Add(this.lblStudentSurname);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentNo);
            this.Name = "Ogrenci_Ekrani";
            this.Text = "Obs Öğrenci Ekranı";
            this.Load += new System.EventHandler(this.Ogrenci_Ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentLessonProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExamResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblStudentScreenDateTime;
        private System.Windows.Forms.DataGridView dtgStudentLessonProgram;
        private System.Windows.Forms.Label lblStudentLessonProgram;
        private System.Windows.Forms.Label lblExamResult;
        private System.Windows.Forms.DataGridView dtgExamResult;
        private System.Windows.Forms.Button btnBack;
    }
}