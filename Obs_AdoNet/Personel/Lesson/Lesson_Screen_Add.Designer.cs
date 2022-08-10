namespace Obs_AdoNet.Personel.Lesson
{
    partial class Lesson_Screen_Add
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
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPersonelSurname = new System.Windows.Forms.Label();
            this.lblPersonelName = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.dtgLessonList = new System.Windows.Forms.DataGridView();
            this.lblList = new System.Windows.Forms.Label();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLessonDay = new System.Windows.Forms.TextBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtLEssonTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPasive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLessonList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(911, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 40);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHours.Location = new System.Drawing.Point(736, 29);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(116, 27);
            this.lblHours.TabIndex = 50;
            this.lblHours.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(356, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(337, 27);
            this.lblDate.TabIndex = 49;
            this.lblDate.Text = "1 Ağustos 2022 Cumaertesi";
            // 
            // lblPersonelSurname
            // 
            this.lblPersonelSurname.AutoSize = true;
            this.lblPersonelSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSurname.Location = new System.Drawing.Point(246, 29);
            this.lblPersonelSurname.Name = "lblPersonelSurname";
            this.lblPersonelSurname.Size = new System.Drawing.Size(77, 27);
            this.lblPersonelSurname.TabIndex = 48;
            this.lblPersonelSurname.Text = "Soyad";
            // 
            // lblPersonelName
            // 
            this.lblPersonelName.AutoSize = true;
            this.lblPersonelName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelName.Location = new System.Drawing.Point(153, 29);
            this.lblPersonelName.Name = "lblPersonelName";
            this.lblPersonelName.Size = new System.Drawing.Size(38, 27);
            this.lblPersonelName.TabIndex = 47;
            this.lblPersonelName.Text = "Ad";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNo.Location = new System.Drawing.Point(19, 29);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(116, 27);
            this.lblPersonelNo.TabIndex = 46;
            this.lblPersonelNo.Text = "20223000";
            // 
            // dtgLessonList
            // 
            this.dtgLessonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLessonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLessonList.Location = new System.Drawing.Point(24, 347);
            this.dtgLessonList.Name = "dtgLessonList";
            this.dtgLessonList.RowHeadersWidth = 51;
            this.dtgLessonList.RowTemplate.Height = 24;
            this.dtgLessonList.Size = new System.Drawing.Size(997, 233);
            this.dtgLessonList.TabIndex = 45;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblList.Location = new System.Drawing.Point(24, 293);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(168, 27);
            this.lblList.TabIndex = 44;
            this.lblList.Text = "Ders Listesi";
            // 
            // txtLessonName
            // 
            this.txtLessonName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLessonName.Location = new System.Drawing.Point(24, 156);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(208, 34);
            this.txtLessonName.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ders  Adı";
            // 
            // txtLessonDay
            // 
            this.txtLessonDay.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLessonDay.Location = new System.Drawing.Point(283, 156);
            this.txtLessonDay.Name = "txtLessonDay";
            this.txtLessonDay.Size = new System.Drawing.Size(208, 34);
            this.txtLessonDay.TabIndex = 57;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTime.Location = new System.Drawing.Point(521, 110);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(142, 27);
            this.LblTime.TabIndex = 58;
            this.LblTime.Text = "Ders Saati";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDay.Location = new System.Drawing.Point(278, 110);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(129, 27);
            this.lblDay.TabIndex = 59;
            this.lblDay.Text = "Ders Günü";
            // 
            // txtLEssonTime
            // 
            this.txtLEssonTime.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLEssonTime.Location = new System.Drawing.Point(526, 156);
            this.txtLEssonTime.Name = "txtLEssonTime";
            this.txtLEssonTime.Size = new System.Drawing.Size(208, 34);
            this.txtLEssonTime.TabIndex = 60;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(759, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 34);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 65;
            this.label2.Text = "Durum";
            // 
            // rbPasive
            // 
            this.rbPasive.AutoSize = true;
            this.rbPasive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPasive.Location = new System.Drawing.Point(253, 232);
            this.rbPasive.Name = "rbPasive";
            this.rbPasive.Size = new System.Drawing.Size(70, 28);
            this.rbPasive.TabIndex = 64;
            this.rbPasive.TabStop = true;
            this.rbPasive.Text = "Pasif";
            this.rbPasive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbActive.Location = new System.Drawing.Point(133, 233);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(69, 28);
            this.rbActive.TabIndex = 63;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Aktif";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // Lesson_Screen_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPasive);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLEssonTime);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.txtLessonDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLessonName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPersonelSurname);
            this.Controls.Add(this.lblPersonelName);
            this.Controls.Add(this.lblPersonelNo);
            this.Controls.Add(this.dtgLessonList);
            this.Controls.Add(this.lblList);
            this.Name = "Lesson_Screen_Add";
            this.Text = "Ders Ekleme ";
            this.Load += new System.EventHandler(this.Lesson_Screen_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLessonList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPersonelSurname;
        private System.Windows.Forms.Label lblPersonelName;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.DataGridView dtgLessonList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.TextBox txtLessonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLessonDay;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtLEssonTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPasive;
        private System.Windows.Forms.RadioButton rbActive;
    }
}