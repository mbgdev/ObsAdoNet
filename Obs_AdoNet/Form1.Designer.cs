namespace Obs_AdoNet
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.txtTeacherNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.LblPersonel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(43, 94);
            this.txtStudentNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(151, 22);
            this.txtStudentNo.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogIn.Location = new System.Drawing.Point(43, 142);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(149, 37);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Giriş Yap";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeacher.Location = new System.Drawing.Point(279, 142);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(149, 37);
            this.btnTeacher.TabIndex = 5;
            this.btnTeacher.Text = "Giriş Yap";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // txtTeacherNo
            // 
            this.txtTeacherNo.Location = new System.Drawing.Point(280, 94);
            this.txtTeacherNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTeacherNo.Name = "txtTeacherNo";
            this.txtTeacherNo.Size = new System.Drawing.Size(151, 22);
            this.txtTeacherNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(274, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen No:";
            // 
            // btnPersonel
            // 
            this.btnPersonel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.Location = new System.Drawing.Point(506, 142);
            this.btnPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(149, 37);
            this.btnPersonel.TabIndex = 8;
            this.btnPersonel.Text = "Giriş Yap";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(507, 94);
            this.txtPersonelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(151, 22);
            this.txtPersonelNo.TabIndex = 7;
            // 
            // LblPersonel
            // 
            this.LblPersonel.AutoSize = true;
            this.LblPersonel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPersonel.Location = new System.Drawing.Point(501, 46);
            this.LblPersonel.Name = "LblPersonel";
            this.LblPersonel.Size = new System.Drawing.Size(168, 27);
            this.LblPersonel.TabIndex = 6;
            this.LblPersonel.Text = "Personel No:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.txtPersonelNo);
            this.Controls.Add(this.LblPersonel);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.txtTeacherNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Obs Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.TextBox txtTeacherNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label LblPersonel;
    }
}

