namespace Obs_AdoNet.Personel
{
    partial class Personel_Student_Process_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Student_Process_Update));
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgStudentList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPasive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rtxtAdress = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.LblStudentNo = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPersonelSurname = new System.Windows.Forms.Label();
            this.lblPersonelName = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.BtnStudentGet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1027, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(945, 143);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 53);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 27);
            this.label3.TabIndex = 54;
            this.label3.Text = "Öğrenci Listesi";
            // 
            // dtgStudentList
            // 
            this.dtgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentList.Location = new System.Drawing.Point(47, 628);
            this.dtgStudentList.Name = "dtgStudentList";
            this.dtgStudentList.RowHeadersWidth = 51;
            this.dtgStudentList.RowTemplate.Height = 24;
            this.dtgStudentList.Size = new System.Drawing.Size(1037, 229);
            this.dtgStudentList.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(332, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 52;
            this.label2.Text = "Durum";
            // 
            // rbPasive
            // 
            this.rbPasive.AutoSize = true;
            this.rbPasive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPasive.Location = new System.Drawing.Point(471, 510);
            this.rbPasive.Name = "rbPasive";
            this.rbPasive.Size = new System.Drawing.Size(70, 28);
            this.rbPasive.TabIndex = 51;
            this.rbPasive.TabStop = true;
            this.rbPasive.Text = "Pasif";
            this.rbPasive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbActive.Location = new System.Drawing.Point(332, 510);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(69, 28);
            this.rbActive.TabIndex = 50;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Aktif";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // rtxtAdress
            // 
            this.rtxtAdress.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtAdress.Location = new System.Drawing.Point(606, 376);
            this.rtxtAdress.Name = "rtxtAdress";
            this.rtxtAdress.Size = new System.Drawing.Size(358, 165);
            this.rtxtAdress.TabIndex = 49;
            this.rtxtAdress.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(601, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 48;
            this.label4.Text = "Adres:";
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentPhone.Location = new System.Drawing.Point(335, 385);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Size = new System.Drawing.Size(229, 34);
            this.txtStudentPhone.TabIndex = 47;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(332, 344);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(181, 27);
            this.lblPhone.TabIndex = 46;
            this.lblPhone.Text = "Cep Telefonu:";
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentEmail.Location = new System.Drawing.Point(46, 385);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(229, 34);
            this.txtStudentEmail.TabIndex = 45;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentSurname.Location = new System.Drawing.Point(315, 277);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(233, 34);
            this.txtStudentSurname.TabIndex = 44;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentName.Location = new System.Drawing.Point(46, 277);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(229, 34);
            this.txtStudentName.TabIndex = 43;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(39, 344);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 27);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "E-Posta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(311, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Soyad:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(39, 232);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(51, 27);
            this.LblName.TabIndex = 40;
            this.LblName.Text = "Ad:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(44, 459);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(231, 66);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentNo.Location = new System.Drawing.Point(49, 162);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(229, 34);
            this.txtStudentNo.TabIndex = 38;
            // 
            // LblStudentNo
            // 
            this.LblStudentNo.AutoSize = true;
            this.LblStudentNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentNo.Location = new System.Drawing.Point(41, 104);
            this.LblStudentNo.Name = "LblStudentNo";
            this.LblStudentNo.Size = new System.Drawing.Size(155, 27);
            this.LblStudentNo.TabIndex = 37;
            this.LblStudentNo.Text = "Öğrenci No:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHours.Location = new System.Drawing.Point(940, 48);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(116, 27);
            this.lblHours.TabIndex = 36;
            this.lblHours.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(570, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(337, 27);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "1 Ağustos 2022 Cumaertesi";
            // 
            // lblPersonelSurname
            // 
            this.lblPersonelSurname.AutoSize = true;
            this.lblPersonelSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSurname.Location = new System.Drawing.Point(372, 48);
            this.lblPersonelSurname.Name = "lblPersonelSurname";
            this.lblPersonelSurname.Size = new System.Drawing.Size(77, 27);
            this.lblPersonelSurname.TabIndex = 34;
            this.lblPersonelSurname.Text = "Soyad";
            // 
            // lblPersonelName
            // 
            this.lblPersonelName.AutoSize = true;
            this.lblPersonelName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelName.Location = new System.Drawing.Point(252, 48);
            this.lblPersonelName.Name = "lblPersonelName";
            this.lblPersonelName.Size = new System.Drawing.Size(38, 27);
            this.lblPersonelName.TabIndex = 33;
            this.lblPersonelName.Text = "Ad";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNo.Location = new System.Drawing.Point(44, 48);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(116, 27);
            this.lblPersonelNo.TabIndex = 32;
            this.lblPersonelNo.Text = "20223000";
            // 
            // BtnStudentGet
            // 
            this.BtnStudentGet.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStudentGet.Location = new System.Drawing.Point(332, 162);
            this.BtnStudentGet.Name = "BtnStudentGet";
            this.BtnStudentGet.Size = new System.Drawing.Size(216, 34);
            this.BtnStudentGet.TabIndex = 57;
            this.BtnStudentGet.Text = "Getir";
            this.BtnStudentGet.UseVisualStyleBackColor = true;
            this.BtnStudentGet.Click += new System.EventHandler(this.BtnStudentGet_Click);
            // 
            // Personel_Student_Process_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 900);
            this.Controls.Add(this.BtnStudentGet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgStudentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPasive);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.rtxtAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.LblStudentNo);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPersonelSurname);
            this.Controls.Add(this.lblPersonelName);
            this.Controls.Add(this.lblPersonelNo);
            this.Name = "Personel_Student_Process_Update";
            this.Text = "Öğrenci Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.Personel_Student_Process_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgStudentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPasive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RichTextBox rtxtAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label LblStudentNo;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPersonelSurname;
        private System.Windows.Forms.Label lblPersonelName;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.Button BtnStudentGet;
    }
}