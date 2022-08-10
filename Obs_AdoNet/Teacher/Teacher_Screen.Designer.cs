namespace Obs_AdoNet.Teacher
{
    partial class Teacher_Screen
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
            this.lblTeacherNo = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblTeacherSurname = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.dtgTeacherLessonProgram = new System.Windows.Forms.DataGridView();
            this.lblLessonProgram = new System.Windows.Forms.Label();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.dtgStudentList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExamInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeacherLessonProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacherNo
            // 
            this.lblTeacherNo.AutoSize = true;
            this.lblTeacherNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherNo.Location = new System.Drawing.Point(37, 34);
            this.lblTeacherNo.Name = "lblTeacherNo";
            this.lblTeacherNo.Size = new System.Drawing.Size(155, 27);
            this.lblTeacherNo.TabIndex = 0;
            this.lblTeacherNo.Text = "Teacher No:";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherName.Location = new System.Drawing.Point(237, 34);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(77, 27);
            this.lblTeacherName.TabIndex = 1;
            this.lblTeacherName.Text = "Name:";
            // 
            // lblTeacherSurname
            // 
            this.lblTeacherSurname.AutoSize = true;
            this.lblTeacherSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherSurname.Location = new System.Drawing.Point(329, 34);
            this.lblTeacherSurname.Name = "lblTeacherSurname";
            this.lblTeacherSurname.Size = new System.Drawing.Size(220, 27);
            this.lblTeacherSurname.TabIndex = 2;
            this.lblTeacherSurname.Text = "Teacher Surname:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(576, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(285, 27);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "1 Ağustos 2022 Cuma :";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHours.Location = new System.Drawing.Point(897, 34);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(77, 27);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Saat:";
            // 
            // dtgTeacherLessonProgram
            // 
            this.dtgTeacherLessonProgram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTeacherLessonProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeacherLessonProgram.Location = new System.Drawing.Point(42, 216);
            this.dtgTeacherLessonProgram.Name = "dtgTeacherLessonProgram";
            this.dtgTeacherLessonProgram.RowHeadersWidth = 51;
            this.dtgTeacherLessonProgram.RowTemplate.Height = 24;
            this.dtgTeacherLessonProgram.Size = new System.Drawing.Size(582, 160);
            this.dtgTeacherLessonProgram.TabIndex = 5;
            // 
            // lblLessonProgram
            // 
            this.lblLessonProgram.AutoSize = true;
            this.lblLessonProgram.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLessonProgram.Location = new System.Drawing.Point(55, 159);
            this.lblLessonProgram.Name = "lblLessonProgram";
            this.lblLessonProgram.Size = new System.Drawing.Size(207, 27);
            this.lblLessonProgram.TabIndex = 6;
            this.lblLessonProgram.Text = "Ders Programı: ";
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentList.Location = new System.Drawing.Point(692, 159);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(233, 27);
            this.lblStudentList.TabIndex = 7;
            this.lblStudentList.Text = "Öğrenci Listesi: ";
            // 
            // dtgStudentList
            // 
            this.dtgStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentList.Location = new System.Drawing.Point(697, 216);
            this.dtgStudentList.Name = "dtgStudentList";
            this.dtgStudentList.RowHeadersWidth = 51;
            this.dtgStudentList.RowTemplate.Height = 24;
            this.dtgStudentList.Size = new System.Drawing.Size(613, 160);
            this.dtgStudentList.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(1165, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 50);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExamInput
            // 
            this.btnExamInput.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExamInput.Location = new System.Drawing.Point(1165, 111);
            this.btnExamInput.Name = "btnExamInput";
            this.btnExamInput.Size = new System.Drawing.Size(145, 50);
            this.btnExamInput.TabIndex = 11;
            this.btnExamInput.Text = "Not Giriş";
            this.btnExamInput.UseVisualStyleBackColor = true;
            this.btnExamInput.Click += new System.EventHandler(this.btnExamInput_Click);
            // 
            // Teacher_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 414);
            this.Controls.Add(this.btnExamInput);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgStudentList);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.lblLessonProgram);
            this.Controls.Add(this.dtgTeacherLessonProgram);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTeacherSurname);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblTeacherNo);
            this.Name = "Teacher_Screen";
            this.Text = "Öğretmen Ekranı";
            this.Load += new System.EventHandler(this.Teacher_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeacherLessonProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacherNo;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblTeacherSurname;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.DataGridView dtgTeacherLessonProgram;
        private System.Windows.Forms.Label lblLessonProgram;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.DataGridView dtgStudentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExamInput;
    }
}