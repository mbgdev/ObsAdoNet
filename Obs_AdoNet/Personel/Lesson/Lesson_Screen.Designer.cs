namespace Obs_AdoNet.Personel.Lesson
{
    partial class Lesson_Screen
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
            this.txtSearchLessonName = new System.Windows.Forms.TextBox();
            this.lblSerachLessonName = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPersonelSurname = new System.Windows.Forms.Label();
            this.lblPersonelName = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.dtgLessonList = new System.Windows.Forms.DataGridView();
            this.lblList = new System.Windows.Forms.Label();
            this.btnLessonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAssigment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLessonList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(1124, 37);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 53);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearchLessonName
            // 
            this.txtSearchLessonName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchLessonName.Location = new System.Drawing.Point(1022, 274);
            this.txtSearchLessonName.Name = "txtSearchLessonName";
            this.txtSearchLessonName.Size = new System.Drawing.Size(237, 34);
            this.txtSearchLessonName.TabIndex = 41;
            this.txtSearchLessonName.TextChanged += new System.EventHandler(this.txtSearchPersonelNo_TextChanged);
            // 
            // lblSerachLessonName
            // 
            this.lblSerachLessonName.AutoSize = true;
            this.lblSerachLessonName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSerachLessonName.Location = new System.Drawing.Point(1018, 233);
            this.lblSerachLessonName.Name = "lblSerachLessonName";
            this.lblSerachLessonName.Size = new System.Drawing.Size(197, 23);
            this.lblSerachLessonName.TabIndex = 40;
            this.lblSerachLessonName.Text = "Ders Adı Giriniz:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHours.Location = new System.Drawing.Point(736, 37);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(116, 27);
            this.lblHours.TabIndex = 39;
            this.lblHours.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(356, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(337, 27);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "1 Ağustos 2022 Cumaertesi";
            // 
            // lblPersonelSurname
            // 
            this.lblPersonelSurname.AutoSize = true;
            this.lblPersonelSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSurname.Location = new System.Drawing.Point(248, 37);
            this.lblPersonelSurname.Name = "lblPersonelSurname";
            this.lblPersonelSurname.Size = new System.Drawing.Size(77, 27);
            this.lblPersonelSurname.TabIndex = 37;
            this.lblPersonelSurname.Text = "Soyad";
            // 
            // lblPersonelName
            // 
            this.lblPersonelName.AutoSize = true;
            this.lblPersonelName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelName.Location = new System.Drawing.Point(153, 37);
            this.lblPersonelName.Name = "lblPersonelName";
            this.lblPersonelName.Size = new System.Drawing.Size(38, 27);
            this.lblPersonelName.TabIndex = 36;
            this.lblPersonelName.Text = "Ad";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNo.Location = new System.Drawing.Point(19, 37);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(116, 27);
            this.lblPersonelNo.TabIndex = 35;
            this.lblPersonelNo.Text = "20223000";
            // 
            // dtgLessonList
            // 
            this.dtgLessonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLessonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLessonList.Location = new System.Drawing.Point(12, 213);
            this.dtgLessonList.Name = "dtgLessonList";
            this.dtgLessonList.RowHeadersWidth = 51;
            this.dtgLessonList.RowTemplate.Height = 24;
            this.dtgLessonList.Size = new System.Drawing.Size(975, 233);
            this.dtgLessonList.TabIndex = 34;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblList.Location = new System.Drawing.Point(19, 151);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(220, 27);
            this.lblList.TabIndex = 33;
            this.lblList.Text = "Öğretmen Listesi";
            // 
            // btnLessonAdd
            // 
            this.btnLessonAdd.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLessonAdd.Location = new System.Drawing.Point(228, 493);
            this.btnLessonAdd.Name = "btnLessonAdd";
            this.btnLessonAdd.Size = new System.Drawing.Size(179, 53);
            this.btnLessonAdd.TabIndex = 44;
            this.btnLessonAdd.Text = "Ekleme";
            this.btnLessonAdd.UseVisualStyleBackColor = true;
            this.btnLessonAdd.Click += new System.EventHandler(this.btnLessonAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 53);
            this.button1.TabIndex = 45;
            this.button1.Text = "Listeleme";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(432, 493);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(216, 53);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Düzenleme";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAssigment
            // 
            this.btnAssigment.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAssigment.Location = new System.Drawing.Point(684, 493);
            this.btnAssigment.Name = "btnAssigment";
            this.btnAssigment.Size = new System.Drawing.Size(303, 53);
            this.btnAssigment.TabIndex = 48;
            this.btnAssigment.Text = "Ders Atama";
            this.btnAssigment.UseVisualStyleBackColor = true;
            this.btnAssigment.Click += new System.EventHandler(this.btnAssigment_Click);
            // 
            // Lesson_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 589);
            this.Controls.Add(this.btnAssigment);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLessonAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearchLessonName);
            this.Controls.Add(this.lblSerachLessonName);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPersonelSurname);
            this.Controls.Add(this.lblPersonelName);
            this.Controls.Add(this.lblPersonelNo);
            this.Controls.Add(this.dtgLessonList);
            this.Controls.Add(this.lblList);
            this.Name = "Lesson_Screen";
            this.Text = "Ders İşlemleri Ekranı";
            this.Load += new System.EventHandler(this.Lesson_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLessonList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearchLessonName;
        private System.Windows.Forms.Label lblSerachLessonName;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPersonelSurname;
        private System.Windows.Forms.Label lblPersonelName;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.DataGridView dtgLessonList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnLessonAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAssigment;
    }
}