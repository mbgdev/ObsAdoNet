namespace Obs_AdoNet.Personel.Teachers
{
    partial class Personel_Teacher_Process
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
            this.BtnTeacherUpdate = new System.Windows.Forms.Button();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.btnTeacherList = new System.Windows.Forms.Button();
            this.btnSearchTeacherNo = new System.Windows.Forms.Button();
            this.txtSearchTeacherNo = new System.Windows.Forms.TextBox();
            this.lblSerachTeacherNo = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPersonelSurname = new System.Windows.Forms.Label();
            this.lblPersonelName = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.dtgTeachersList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeachersList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTeacherUpdate
            // 
            this.BtnTeacherUpdate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTeacherUpdate.Location = new System.Drawing.Point(509, 492);
            this.BtnTeacherUpdate.Name = "BtnTeacherUpdate";
            this.BtnTeacherUpdate.Size = new System.Drawing.Size(200, 42);
            this.BtnTeacherUpdate.TabIndex = 25;
            this.BtnTeacherUpdate.Text = "Düzenleme";
            this.BtnTeacherUpdate.UseVisualStyleBackColor = true;
            this.BtnTeacherUpdate.Click += new System.EventHandler(this.BtnTeacherUpdate_Click);
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeacherAdd.Location = new System.Drawing.Point(275, 492);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(200, 42);
            this.btnTeacherAdd.TabIndex = 24;
            this.btnTeacherAdd.Text = "Ekleme";
            this.btnTeacherAdd.UseVisualStyleBackColor = true;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // btnTeacherList
            // 
            this.btnTeacherList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeacherList.Location = new System.Drawing.Point(28, 492);
            this.btnTeacherList.Name = "btnTeacherList";
            this.btnTeacherList.Size = new System.Drawing.Size(200, 42);
            this.btnTeacherList.TabIndex = 23;
            this.btnTeacherList.Text = "Listeleme";
            this.btnTeacherList.UseVisualStyleBackColor = true;
            this.btnTeacherList.Click += new System.EventHandler(this.btnTeacherList_Click);
            // 
            // btnSearchTeacherNo
            // 
            this.btnSearchTeacherNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchTeacherNo.Location = new System.Drawing.Point(1038, 329);
            this.btnSearchTeacherNo.Name = "btnSearchTeacherNo";
            this.btnSearchTeacherNo.Size = new System.Drawing.Size(200, 42);
            this.btnSearchTeacherNo.TabIndex = 22;
            this.btnSearchTeacherNo.Text = "Ara";
            this.btnSearchTeacherNo.UseVisualStyleBackColor = true;
            this.btnSearchTeacherNo.Click += new System.EventHandler(this.btnSearchTeacherNo_Click);
            // 
            // txtSearchTeacherNo
            // 
            this.txtSearchTeacherNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchTeacherNo.Location = new System.Drawing.Point(1038, 266);
            this.txtSearchTeacherNo.Name = "txtSearchTeacherNo";
            this.txtSearchTeacherNo.Size = new System.Drawing.Size(208, 34);
            this.txtSearchTeacherNo.TabIndex = 21;
            // 
            // lblSerachTeacherNo
            // 
            this.lblSerachTeacherNo.AutoSize = true;
            this.lblSerachTeacherNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSerachTeacherNo.Location = new System.Drawing.Point(1033, 230);
            this.lblSerachTeacherNo.Name = "lblSerachTeacherNo";
            this.lblSerachTeacherNo.Size = new System.Drawing.Size(181, 27);
            this.lblSerachTeacherNo.TabIndex = 20;
            this.lblSerachTeacherNo.Text = "Öğretmen No: ";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHours.Location = new System.Drawing.Point(752, 29);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(116, 27);
            this.lblHours.TabIndex = 19;
            this.lblHours.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(372, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(337, 27);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "1 Ağustos 2022 Cumaertesi";
            // 
            // lblPersonelSurname
            // 
            this.lblPersonelSurname.AutoSize = true;
            this.lblPersonelSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSurname.Location = new System.Drawing.Point(245, 29);
            this.lblPersonelSurname.Name = "lblPersonelSurname";
            this.lblPersonelSurname.Size = new System.Drawing.Size(77, 27);
            this.lblPersonelSurname.TabIndex = 17;
            this.lblPersonelSurname.Text = "Soyad";
            // 
            // lblPersonelName
            // 
            this.lblPersonelName.AutoSize = true;
            this.lblPersonelName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelName.Location = new System.Drawing.Point(169, 29);
            this.lblPersonelName.Name = "lblPersonelName";
            this.lblPersonelName.Size = new System.Drawing.Size(38, 27);
            this.lblPersonelName.TabIndex = 16;
            this.lblPersonelName.Text = "Ad";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNo.Location = new System.Drawing.Point(35, 29);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(116, 27);
            this.lblPersonelNo.TabIndex = 15;
            this.lblPersonelNo.Text = "20223000";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblList.Location = new System.Drawing.Point(35, 143);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(220, 27);
            this.lblList.TabIndex = 13;
            this.lblList.Text = "Öğretmen Listesi";
            // 
            // dtgTeachersList
            // 
            this.dtgTeachersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeachersList.Location = new System.Drawing.Point(39, 191);
            this.dtgTeachersList.Name = "dtgTeachersList";
            this.dtgTeachersList.RowHeadersWidth = 51;
            this.dtgTeachersList.RowTemplate.Height = 24;
            this.dtgTeachersList.Size = new System.Drawing.Size(977, 267);
            this.dtgTeachersList.TabIndex = 26;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(1111, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 53);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Personel_Teacher_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 588);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtgTeachersList);
            this.Controls.Add(this.BtnTeacherUpdate);
            this.Controls.Add(this.btnTeacherAdd);
            this.Controls.Add(this.btnTeacherList);
            this.Controls.Add(this.btnSearchTeacherNo);
            this.Controls.Add(this.txtSearchTeacherNo);
            this.Controls.Add(this.lblSerachTeacherNo);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPersonelSurname);
            this.Controls.Add(this.lblPersonelName);
            this.Controls.Add(this.lblPersonelNo);
            this.Controls.Add(this.lblList);
            this.Name = "Personel_Teacher_Process";
            this.Text = "Öğretmen İşlemleri Ekranı";
            this.Load += new System.EventHandler(this.Personel_Teacher_Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeachersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTeacherUpdate;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.Button btnTeacherList;
        private System.Windows.Forms.Button btnSearchTeacherNo;
        private System.Windows.Forms.TextBox txtSearchTeacherNo;
        private System.Windows.Forms.Label lblSerachTeacherNo;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPersonelSurname;
        private System.Windows.Forms.Label lblPersonelName;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.DataGridView dtgTeachersList;
        private System.Windows.Forms.Button btnBack;
    }
}