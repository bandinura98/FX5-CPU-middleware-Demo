namespace fx5_demo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTemperatureTitle = new System.Windows.Forms.Label();
            this.lblTemperatureValue = new System.Windows.Forms.Label();
            
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSpeedTitle = new System.Windows.Forms.Label();
            this.lblSpeedValue = new System.Windows.Forms.Label();
            this.pbSpeed = new System.Windows.Forms.ProgressBar();
            
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblProductionTitle = new System.Windows.Forms.Label();
            this.lblProductionValue = new System.Windows.Forms.Label();
            
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTargetTitle = new System.Windows.Forms.Label();
            this.txtTargetCount = new System.Windows.Forms.TextBox();
            this.btnSetTarget = new System.Windows.Forms.Button();

            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusTitle.Location = new System.Drawing.Point(20, 20);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(125, 21);
            this.lblStatusTitle.TabIndex = 0;
            this.lblStatusTitle.Text = "PLC Bağl. Durum:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(150, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 21);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Bağlı Değil";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTemperatureValue);
            this.groupBox1.Controls.Add(this.lblTemperatureTitle);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(24, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıcaklık (D100)";
            // 
            // lblTemperatureTitle
            // 
            this.lblTemperatureTitle.AutoSize = true;
            this.lblTemperatureTitle.Location = new System.Drawing.Point(20, 30);
            this.lblTemperatureTitle.Name = "lblTemperatureTitle";
            this.lblTemperatureTitle.Size = new System.Drawing.Size(55, 19);
            this.lblTemperatureTitle.TabIndex = 0;
            this.lblTemperatureTitle.Text = "Derece:";
            // 
            // lblTemperatureValue
            // 
            this.lblTemperatureValue.AutoSize = true;
            this.lblTemperatureValue.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemperatureValue.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTemperatureValue.Location = new System.Drawing.Point(20, 50);
            this.lblTemperatureValue.Name = "lblTemperatureValue";
            this.lblTemperatureValue.Size = new System.Drawing.Size(76, 45);
            this.lblTemperatureValue.TabIndex = 1;
            this.lblTemperatureValue.Text = "0 °C";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbSpeed);
            this.groupBox2.Controls.Add(this.lblSpeedValue);
            this.groupBox2.Controls.Add(this.lblSpeedTitle);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(240, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hız (D102)";
            // 
            // lblSpeedTitle
            // 
            this.lblSpeedTitle.AutoSize = true;
            this.lblSpeedTitle.Location = new System.Drawing.Point(20, 30);
            this.lblSpeedTitle.Name = "lblSpeedTitle";
            this.lblSpeedTitle.Size = new System.Drawing.Size(46, 19);
            this.lblSpeedTitle.TabIndex = 0;
            this.lblSpeedTitle.Text = "Değer:";
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.AutoSize = true;
            this.lblSpeedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSpeedValue.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblSpeedValue.Location = new System.Drawing.Point(160, 20);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(28, 32);
            this.lblSpeedValue.TabIndex = 1;
            this.lblSpeedValue.Text = "0";
            // 
            // pbSpeed
            // 
            this.pbSpeed.Location = new System.Drawing.Point(24, 65);
            this.pbSpeed.Name = "pbSpeed";
            this.pbSpeed.Size = new System.Drawing.Size(200, 30);
            this.pbSpeed.TabIndex = 2;
            this.pbSpeed.Maximum = 1000;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblProductionValue);
            this.groupBox3.Controls.Add(this.lblProductionTitle);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(510, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 120);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Üretim Miktarı (D101)";
            // 
            // lblProductionTitle
            // 
            this.lblProductionTitle.AutoSize = true;
            this.lblProductionTitle.Location = new System.Drawing.Point(20, 30);
            this.lblProductionTitle.Name = "lblProductionTitle";
            this.lblProductionTitle.Size = new System.Drawing.Size(40, 19);
            this.lblProductionTitle.TabIndex = 0;
            this.lblProductionTitle.Text = "Adet:";
            // 
            // lblProductionValue
            // 
            this.lblProductionValue.AutoSize = true;
            this.lblProductionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductionValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblProductionValue.Location = new System.Drawing.Point(20, 50);
            this.lblProductionValue.Name = "lblProductionValue";
            this.lblProductionValue.Size = new System.Drawing.Size(38, 45);
            this.lblProductionValue.TabIndex = 1;
            this.lblProductionValue.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSetTarget);
            this.groupBox4.Controls.Add(this.txtTargetCount);
            this.groupBox4.Controls.Add(this.lblTargetTitle);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(24, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(686, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Komut Gönder (D200)";
            // 
            // lblTargetTitle
            // 
            this.lblTargetTitle.AutoSize = true;
            this.lblTargetTitle.Location = new System.Drawing.Point(20, 42);
            this.lblTargetTitle.Name = "lblTargetTitle";
            this.lblTargetTitle.Size = new System.Drawing.Size(81, 19);
            this.lblTargetTitle.TabIndex = 0;
            this.lblTargetTitle.Text = "Hedef Adet:";
            // 
            // txtTargetCount
            // 
            this.txtTargetCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTargetCount.Location = new System.Drawing.Point(120, 36);
            this.txtTargetCount.Name = "txtTargetCount";
            this.txtTargetCount.Size = new System.Drawing.Size(120, 29);
            this.txtTargetCount.TabIndex = 1;
            // 
            // btnSetTarget
            // 
            this.btnSetTarget.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSetTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTarget.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetTarget.ForeColor = System.Drawing.Color.White;
            this.btnSetTarget.Location = new System.Drawing.Point(260, 34);
            this.btnSetTarget.Name = "btnSetTarget";
            this.btnSetTarget.Size = new System.Drawing.Size(120, 33);
            this.btnSetTarget.TabIndex = 2;
            this.btnSetTarget.Text = "Gönder";
            this.btnSetTarget.UseVisualStyleBackColor = false;
            this.btnSetTarget.Click += new System.EventHandler(this.btnSetTarget_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(734, 341);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusTitle);
            this.Name = "Form1";
            this.Text = "PLC Monitor Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTemperatureTitle;
        private System.Windows.Forms.Label lblTemperatureValue;
        
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSpeedTitle;
        private System.Windows.Forms.Label lblSpeedValue;
        private System.Windows.Forms.ProgressBar pbSpeed;
        
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblProductionTitle;
        private System.Windows.Forms.Label lblProductionValue;
        
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTargetTitle;
        private System.Windows.Forms.TextBox txtTargetCount;
        private System.Windows.Forms.Button btnSetTarget;
    }
}
