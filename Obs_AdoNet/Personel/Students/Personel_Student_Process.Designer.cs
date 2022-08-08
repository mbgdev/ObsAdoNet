namespace Obs_AdoNet.Personel
{
    partial class Personel_Process
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
            this.lblList = new System.Windows.Forms.Label();
            this.dtgStudentList = new System.Windows.Forms.DataGridView();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.lblPersonelName = new System.Windows.Forms.Label();
            this.lblPersonelSurname = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblSerachStudentNo = new System.Windows.Forms.Label();
            this.txtSearchStudentNo = new System.Windows.Forms.TextBox();
            this.btnSearchStudentNo = new System.Windows.Forms.Button();
            this.btnStudentList = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.BtnStudentUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblList.Location = new System.Drawing.Point(63, 154);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(207, 27);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Öğrenci Listesi";
            // 
            // dtgStudentList
            // 
            this.dtgStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentList.Location = new System.Drawing.Point(56, 216);
            this.dtgStudentList.Name = "dtgStudentList";
            this.dtgStudentList.RowHeadersWidth = 51;
            this.dtgStudentList.RowTemplate.Height = 24;
            this.dtgStudentList.Size = new System.Drawing.Size(975, 233);
            this.dtgStudentList.TabIndex = 1;
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNo.Location = new System.Drawing.Point(63, 40);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(116, 27);
            this.lblPersonelNo.TabIndex = 2;
            this.lblPersonelNo.Text = "20223000";
            // 
            // lblPersonelName
            // 
            this.lblPersonelName.AutoSize = true;
            this.lblPersonelName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelName.Location = new System.Drawing.Point(197, 40);
            this.lblPersonelName.Name = "lblPersonelName";
            this.lblPersonelName.Size = new System.Drawing.Size(38, 27);
            this.lblPersonelName.TabIndex = 3;
            this.lblPersonelName.Text = "Ad";
            // 
            // lblPersonelSurname
            // 
            this.lblPersonelSurname.AutoSize = true;
            this.lblPersonelSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSurname.Location = new System.Drawing.Point(273, 40);
            this.lblPersonelSurname.Name = "lblPersonelSurname";
            this.lblPersonelSurname.Size = new System.Drawing.Size(77, 27);
            this.lblPersonelSurname.TabIndex = 4;
            this.lblPersonelSurname.Text = "Soyad";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(400, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(337, 27);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "1 Ağustos 2022 Cumaertesi";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHours.Location = new System.Drawing.Point(780, 40);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(116, 27);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "00:00:00";
            // 
            // lblSerachStudentNo
            // 
            this.lblSerachStudentNo.AutoSize = true;
            this.lblSerachStudentNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSerachStudentNo.Location = new System.Drawing.Point(1061, 240);
            this.lblSerachStudentNo.Name = "lblSerachStudentNo";
            this.lblSerachStudentNo.Size = new System.Drawing.Size(168, 27);
            this.lblSerachStudentNo.TabIndex = 7;
            this.lblSerachStudentNo.Text = "Öğrenci No: ";
            // 
            // txtSearchStudentNo
            // 
            this.txtSearchStudentNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchStudentNo.Location = new System.Drawing.Point(1066, 277);
            this.txtSearchStudentNo.Name = "txtSearchStudentNo";
            this.txtSearchStudentNo.Size = new System.Drawing.Size(208, 34);
            this.txtSearchStudentNo.TabIndex = 8;
            // 
            // btnSearchStudentNo
            // 
            this.btnSearchStudentNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchStudentNo.Location = new System.Drawing.Point(1066, 340);
            this.btnSearchStudentNo.Name = "btnSearchStudentNo";
            this.btnSearchStudentNo.Size = new System.Drawing.Size(200, 42);
            this.btnSearchStudentNo.TabIndex = 9;
            this.btnSearchStudentNo.Text = "Ara";
            this.btnSearchStudentNo.UseVisualStyleBackColor = true;
            this.btnSearchStudentNo.Click += new System.EventHandler(this.btnSearchStudentNo_Click);
            // 
            // btnStudentList
            // 
            this.btnStudentList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentList.Location = new System.Drawing.Point(56, 503);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(200, 42);
            this.btnStudentList.TabIndex = 10;
            this.btnStudentList.Text = "Listeleme";
            this.btnStudentList.UseVisualStyleBackColor = true;
            this.btnStudentList.Click += new System.EventHandler(this.btnStudentList_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentAdd.Location = new System.Drawing.Point(303, 503);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(200, 42);
            this.btnStudentAdd.TabIndex = 11;
            this.btnStudentAdd.Text = "Ekleme";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // BtnStudentUpdate
            // 
            this.BtnStudentUpdate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStudentUpdate.Location = new System.Drawing.Point(537, 503);
            this.BtnStudentUpdate.Name = "BtnStudentUpdate";
            this.BtnStudentUpdate.Size = new System.Drawing.Size(200, 42);
            this.BtnStudentUpdate.TabIndex = 12;
            this.BtnStudentUpdate.Text = "Düzenleme";
            this.BtnStudentUpdate.UseVisualStyleBackColor = true;
            this.BtnStudentUpdate.Click += new System.EventHandler(this.BtnStudentUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(1160, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 53);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Personel_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 591);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnStudentUpdate);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.btnStudentList);
            this.Controls.Add(this.btnSearchStudentNo);
            this.Controls.Add(this.txtSearchStudentNo);
            this.Controls.Add(this.lblSerachStudentNo);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPersonelSurname);
            this.Controls.Add(this.lblPersonelName);
            this.Controls.Add(this.lblPersonelNo);
            this.Controls.Add(this.dtgStudentList);
            this.Controls.Add(this.lblList);
            this.Name = "Personel_Process";
            this.Text = "Öğrenci işleri Ekranı";
            this.Load += new System.EventHandler(this.Personel_Student_Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.DataGridView dtgStudentList;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.Label lblPersonelName;
        private System.Windows.Forms.Label lblPersonelSurname;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblSerachStudentNo;
        private System.Windows.Forms.TextBox txtSearchStudentNo;
        private System.Windows.Forms.Button btnSearchStudentNo;
        private System.Windows.Forms.Button btnStudentList;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Button BtnStudentUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}