namespace WaterCCP
{
    partial class 원자재등록
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
            this.Rad_500 = new System.Windows.Forms.RadioButton();
            this.Rad_1000 = new System.Windows.Forms.RadioButton();
            this.Rad_250 = new System.Windows.Forms.RadioButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Num_Regi = new System.Windows.Forms.NumericUpDown();
            this.PetCap = new System.Windows.Forms.Label();
            this.CodeNum = new System.Windows.Forms.Label();
            this.Regi_Date = new System.Windows.Forms.DateTimePicker();
            this.btnRegi = new System.Windows.Forms.Button();
            this.Regi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Regi)).BeginInit();
            this.SuspendLayout();
            // 
            // Rad_500
            // 
            this.Rad_500.AutoSize = true;
            this.Rad_500.Location = new System.Drawing.Point(313, 164);
            this.Rad_500.Name = "Rad_500";
            this.Rad_500.Size = new System.Drawing.Size(68, 20);
            this.Rad_500.TabIndex = 43;
            this.Rad_500.TabStop = true;
            this.Rad_500.Text = "500ml";
            this.Rad_500.UseVisualStyleBackColor = true;
            // 
            // Rad_1000
            // 
            this.Rad_1000.AutoSize = true;
            this.Rad_1000.Location = new System.Drawing.Point(399, 164);
            this.Rad_1000.Name = "Rad_1000";
            this.Rad_1000.Size = new System.Drawing.Size(76, 20);
            this.Rad_1000.TabIndex = 42;
            this.Rad_1000.TabStop = true;
            this.Rad_1000.Text = "1000ml";
            this.Rad_1000.UseVisualStyleBackColor = true;
            // 
            // Rad_250
            // 
            this.Rad_250.AutoSize = true;
            this.Rad_250.Location = new System.Drawing.Point(225, 164);
            this.Rad_250.Name = "Rad_250";
            this.Rad_250.Size = new System.Drawing.Size(68, 20);
            this.Rad_250.TabIndex = 41;
            this.Rad_250.TabStop = true;
            this.Rad_250.Text = "250ml";
            this.Rad_250.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(169, 274);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 26);
            this.txtCode.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(197, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "개";
            // 
            // Num_Regi
            // 
            this.Num_Regi.Location = new System.Drawing.Point(112, 215);
            this.Num_Regi.Name = "Num_Regi";
            this.Num_Regi.Size = new System.Drawing.Size(84, 26);
            this.Num_Regi.TabIndex = 38;
            // 
            // PetCap
            // 
            this.PetCap.AutoSize = true;
            this.PetCap.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PetCap.Location = new System.Drawing.Point(34, 157);
            this.PetCap.Name = "PetCap";
            this.PetCap.Size = new System.Drawing.Size(150, 27);
            this.PetCap.TabIndex = 37;
            this.PetCap.Text = "PET + CAP";
            // 
            // CodeNum
            // 
            this.CodeNum.AutoSize = true;
            this.CodeNum.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CodeNum.Location = new System.Drawing.Point(34, 269);
            this.CodeNum.Name = "CodeNum";
            this.CodeNum.Size = new System.Drawing.Size(129, 27);
            this.CodeNum.TabIndex = 36;
            this.CodeNum.Text = "분류번호:";
            // 
            // Regi_Date
            // 
            this.Regi_Date.Location = new System.Drawing.Point(112, 101);
            this.Regi_Date.Name = "Regi_Date";
            this.Regi_Date.Size = new System.Drawing.Size(300, 26);
            this.Regi_Date.TabIndex = 35;
            // 
            // btnRegi
            // 
            this.btnRegi.Location = new System.Drawing.Point(302, 269);
            this.btnRegi.Name = "btnRegi";
            this.btnRegi.Size = new System.Drawing.Size(173, 85);
            this.btnRegi.TabIndex = 34;
            this.btnRegi.Text = "등록";
            this.btnRegi.UseVisualStyleBackColor = true;
            this.btnRegi.Click += new System.EventHandler(this.btnRegi_Click);
            // 
            // Regi
            // 
            this.Regi.AutoSize = true;
            this.Regi.Font = new System.Drawing.Font("문체부 돋음체", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Regi.Location = new System.Drawing.Point(159, 34);
            this.Regi.Name = "Regi";
            this.Regi.Size = new System.Drawing.Size(213, 35);
            this.Regi.TabIndex = 33;
            this.Regi.Text = "원자재 등록";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(244, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "단가:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 26);
            this.textBox1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(447, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 46;
            this.label2.Text = "원";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(31, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 47;
            this.label3.Text = "수량:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(34, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 27);
            this.label4.TabIndex = 48;
            this.label4.Text = "ㅇㅇ코드:";
            // 
            // 원자재등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(523, 398);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rad_500);
            this.Controls.Add(this.Rad_1000);
            this.Controls.Add(this.Rad_250);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Num_Regi);
            this.Controls.Add(this.PetCap);
            this.Controls.Add(this.CodeNum);
            this.Controls.Add(this.Regi_Date);
            this.Controls.Add(this.btnRegi);
            this.Controls.Add(this.Regi);
            this.Name = "원자재등록";
            this.Text = "원자재등록";
            ((System.ComponentModel.ISupportInitialize)(this.Num_Regi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rad_500;
        private System.Windows.Forms.RadioButton Rad_1000;
        private System.Windows.Forms.RadioButton Rad_250;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Num_Regi;
        private System.Windows.Forms.Label PetCap;
        private System.Windows.Forms.Label CodeNum;
        private System.Windows.Forms.DateTimePicker Regi_Date;
        private System.Windows.Forms.Button btnRegi;
        private System.Windows.Forms.Label Regi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}