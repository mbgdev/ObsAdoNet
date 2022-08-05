namespace Obs_AdoNet.Teacher
{
    partial class Teacher_Exam_Input
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTeacherNo = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblTeacherSurname = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.dtgStudentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(1120, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 46);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTeacherNo
            // 
            this.lblTeacherNo.AutoSize = true;
            this.lblTeacherNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherNo.Location = new System.Drawing.Point(29, 29);
            this.lblTeacherNo.Name = "lblTeacherNo";
            this.lblTeacherNo.Size = new System.Drawing.Size(155, 27);
            this.lblTeacherNo.TabIndex = 1;
            this.lblTeacherNo.Text = "Teacher No:";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherName.Location = new System.Drawing.Point(220, 29);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(77, 27);
            this.lblTeacherName.TabIndex = 2;
            this.lblTeacherName.Text = "Name:";
            // 
            // lblTeacherSurname
            // 
            this.lblTeacherSurname.AutoSize = true;
            this.lblTeacherSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherSurname.Location = new System.Drawing.Point(303, 29);
            this.lblTeacherSurname.Name = "lblTeacherSurname";
            this.lblTeacherSurname.Size = new System.Drawing.Size(116, 27);
            this.lblTeacherSurname.TabIndex = 3;
            this.lblTeacherSurname.Text = "Surname:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(445, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(285, 27);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "1 Ağustos 2022 Cuma :";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHours.Location = new System.Drawing.Point(736, 29);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(77, 27);
            this.lblHours.TabIndex = 5;
            this.lblHours.Text = "Saat:";
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentList.Location = new System.Drawing.Point(29, 114);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(220, 27);
            this.lblStudentList.TabIndex = 6;
            this.lblStudentList.Text = "Öğrenci Listesi:";
            // 
            // dtgStudentList
            // 
            this.dtgStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentList.Location = new System.Drawing.Point(34, 151);
            this.dtgStudentList.Name = "dtgStudentList";
            this.dtgStudentList.RowHeadersWidth = 51;
            this.dtgStudentList.RowTemplate.Height = 24;
            this.dtgStudentList.Size = new System.Drawing.Size(779, 160);
            this.dtgStudentList.TabIndex = 9;
            // 
            // Teacher_Exam_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 450);
            this.Controls.Add(this.dtgStudentList);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTeacherSurname);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblTeacherNo);
            this.Controls.Add(this.btnBack);
            this.Name = "Teacher_Exam_Input";
            this.Text = "TeacherExamInput";
            this.Load += new System.EventHandler(this.Teacher_Exam_Input_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTeacherNo;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblTeacherSurname;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.DataGridView dtgStudentList;
    }
}