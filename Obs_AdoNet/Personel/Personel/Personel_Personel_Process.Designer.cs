namespace Obs_AdoNet.Personel.Personel
{
    partial class Personel_Personel_Process
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
            this.BtnPersonelUpdate = new System.Windows.Forms.Button();
            this.btnPersonelAdd = new System.Windows.Forms.Button();
            this.btnPersonelList = new System.Windows.Forms.Button();
            this.btnSearchPersonelNo = new System.Windows.Forms.Button();
            this.txtSearchPersonelNo = new System.Windows.Forms.TextBox();
            this.lblSerachStudentNo = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPersonelSurname = new System.Windows.Forms.Label();
            this.lblPersonelName = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.dtgPersonelList = new System.Windows.Forms.DataGridView();
            this.lblList = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonelList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPersonelUpdate
            // 
            this.BtnPersonelUpdate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonelUpdate.Location = new System.Drawing.Point(508, 501);
            this.BtnPersonelUpdate.Name = "BtnPersonelUpdate";
            this.BtnPersonelUpdate.Size = new System.Drawing.Size(200, 42);
            this.BtnPersonelUpdate.TabIndex = 25;
            this.BtnPersonelUpdate.Text = "Düzenleme";
            this.BtnPersonelUpdate.UseVisualStyleBackColor = true;
            this.BtnPersonelUpdate.Click += new System.EventHandler(this.BtnPersonelUpdate_Click);
            // 
            // btnPersonelAdd
            // 
            this.btnPersonelAdd.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelAdd.Location = new System.Drawing.Point(274, 501);
            this.btnPersonelAdd.Name = "btnPersonelAdd";
            this.btnPersonelAdd.Size = new System.Drawing.Size(200, 42);
            this.btnPersonelAdd.TabIndex = 24;
            this.btnPersonelAdd.Text = "Ekleme";
            this.btnPersonelAdd.UseVisualStyleBackColor = true;
            this.btnPersonelAdd.Click += new System.EventHandler(this.btnPersonelAdd_Click);
            // 
            // btnPersonelList
            // 
            this.btnPersonelList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelList.Location = new System.Drawing.Point(27, 501);
            this.btnPersonelList.Name = "btnPersonelList";
            this.btnPersonelList.Size = new System.Drawing.Size(200, 42);
            this.btnPersonelList.TabIndex = 23;
            this.btnPersonelList.Text = "Listeleme";
            this.btnPersonelList.UseVisualStyleBackColor = true;
            this.btnPersonelList.Click += new System.EventHandler(this.btnPersonelList_Click);
            // 
            // btnSearchPersonelNo
            // 
            this.btnSearchPersonelNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchPersonelNo.Location = new System.Drawing.Point(1037, 338);
            this.btnSearchPersonelNo.Name = "btnSearchPersonelNo";
            this.btnSearchPersonelNo.Size = new System.Drawing.Size(200, 42);
            this.btnSearchPersonelNo.TabIndex = 22;
            this.btnSearchPersonelNo.Text = "Ara";
            this.btnSearchPersonelNo.UseVisualStyleBackColor = true;
            this.btnSearchPersonelNo.Click += new System.EventHandler(this.btnSearchPersonelNo_Click);
            // 
            // txtSearchPersonelNo
            // 
            this.txtSearchPersonelNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchPersonelNo.Location = new System.Drawing.Point(1037, 275);
            this.txtSearchPersonelNo.Name = "txtSearchPersonelNo";
            this.txtSearchPersonelNo.Size = new System.Drawing.Size(208, 34);
            this.txtSearchPersonelNo.TabIndex = 21;
            // 
            // lblSerachStudentNo
            // 
            this.lblSerachStudentNo.AutoSize = true;
            this.lblSerachStudentNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSerachStudentNo.Location = new System.Drawing.Point(1032, 238);
            this.lblSerachStudentNo.Name = "lblSerachStudentNo";
            this.lblSerachStudentNo.Size = new System.Drawing.Size(181, 27);
            this.lblSerachStudentNo.TabIndex = 20;
            this.lblSerachStudentNo.Text = "Personel No: ";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHours.Location = new System.Drawing.Point(751, 38);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(116, 27);
            this.lblHours.TabIndex = 19;
            this.lblHours.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(371, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(337, 27);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "1 Ağustos 2022 Cumaertesi";
            // 
            // lblPersonelSurname
            // 
            this.lblPersonelSurname.AutoSize = true;
            this.lblPersonelSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSurname.Location = new System.Drawing.Point(244, 38);
            this.lblPersonelSurname.Name = "lblPersonelSurname";
            this.lblPersonelSurname.Size = new System.Drawing.Size(77, 27);
            this.lblPersonelSurname.TabIndex = 17;
            this.lblPersonelSurname.Text = "Soyad";
            // 
            // lblPersonelName
            // 
            this.lblPersonelName.AutoSize = true;
            this.lblPersonelName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelName.Location = new System.Drawing.Point(168, 38);
            this.lblPersonelName.Name = "lblPersonelName";
            this.lblPersonelName.Size = new System.Drawing.Size(38, 27);
            this.lblPersonelName.TabIndex = 16;
            this.lblPersonelName.Text = "Ad";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNo.Location = new System.Drawing.Point(34, 38);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(116, 27);
            this.lblPersonelNo.TabIndex = 15;
            this.lblPersonelNo.Text = "20223000";
            // 
            // dtgPersonelList
            // 
            this.dtgPersonelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonelList.Location = new System.Drawing.Point(27, 214);
            this.dtgPersonelList.Name = "dtgPersonelList";
            this.dtgPersonelList.RowHeadersWidth = 51;
            this.dtgPersonelList.RowTemplate.Height = 24;
            this.dtgPersonelList.Size = new System.Drawing.Size(975, 233);
            this.dtgPersonelList.TabIndex = 14;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblList.Location = new System.Drawing.Point(34, 152);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(220, 27);
            this.lblList.TabIndex = 13;
            this.lblList.Text = "Personel Listesi";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(1102, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 53);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Personel_Personel_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 580);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnPersonelUpdate);
            this.Controls.Add(this.btnPersonelAdd);
            this.Controls.Add(this.btnPersonelList);
            this.Controls.Add(this.btnSearchPersonelNo);
            this.Controls.Add(this.txtSearchPersonelNo);
            this.Controls.Add(this.lblSerachStudentNo);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPersonelSurname);
            this.Controls.Add(this.lblPersonelName);
            this.Controls.Add(this.lblPersonelNo);
            this.Controls.Add(this.dtgPersonelList);
            this.Controls.Add(this.lblList);
            this.Name = "Personel_Personel_Process";
            this.Text = "Personel İşlemleri Ekranı";
            this.Load += new System.EventHandler(this.Personel_Personel_Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonelList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPersonelUpdate;
        private System.Windows.Forms.Button btnPersonelAdd;
        private System.Windows.Forms.Button btnPersonelList;
        private System.Windows.Forms.Button btnSearchPersonelNo;
        private System.Windows.Forms.TextBox txtSearchPersonelNo;
        private System.Windows.Forms.Label lblSerachStudentNo;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPersonelSurname;
        private System.Windows.Forms.Label lblPersonelName;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.DataGridView dtgPersonelList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnBack;
    }
}