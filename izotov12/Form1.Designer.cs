namespace izotov12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbOvercastFreq = new System.Windows.Forms.Label();
            this.lbCloudyFreq = new System.Windows.Forms.Label();
            this.lbClearFreq = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbOvercastDur = new System.Windows.Forms.Label();
            this.lbCloudyDur = new System.Windows.Forms.Label();
            this.lbClearDur = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCurIter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btPause = new System.Windows.Forms.Button();
            this.lbWeather = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumOfIterations = new System.Windows.Forms.NumericUpDown();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbOvercastFreq);
            this.panel1.Controls.Add(this.lbCloudyFreq);
            this.panel1.Controls.Add(this.lbClearFreq);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lbOvercastDur);
            this.panel1.Controls.Add(this.lbCloudyDur);
            this.panel1.Controls.Add(this.lbClearDur);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbCurIter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btPause);
            this.panel1.Controls.Add(this.lbWeather);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NumOfIterations);
            this.panel1.Controls.Add(this.lbHour);
            this.panel1.Controls.Add(this.lbDay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 452);
            this.panel1.TabIndex = 0;
            // 
            // lbOvercastFreq
            // 
            this.lbOvercastFreq.AutoSize = true;
            this.lbOvercastFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOvercastFreq.Location = new System.Drawing.Point(480, 393);
            this.lbOvercastFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOvercastFreq.Name = "lbOvercastFreq";
            this.lbOvercastFreq.Size = new System.Drawing.Size(26, 29);
            this.lbOvercastFreq.TabIndex = 24;
            this.lbOvercastFreq.Text = "0";
            // 
            // lbCloudyFreq
            // 
            this.lbCloudyFreq.AutoSize = true;
            this.lbCloudyFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCloudyFreq.Location = new System.Drawing.Point(360, 393);
            this.lbCloudyFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCloudyFreq.Name = "lbCloudyFreq";
            this.lbCloudyFreq.Size = new System.Drawing.Size(26, 29);
            this.lbCloudyFreq.TabIndex = 23;
            this.lbCloudyFreq.Text = "0";
            // 
            // lbClearFreq
            // 
            this.lbClearFreq.AutoSize = true;
            this.lbClearFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClearFreq.Location = new System.Drawing.Point(259, 393);
            this.lbClearFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClearFreq.Name = "lbClearFreq";
            this.lbClearFreq.Size = new System.Drawing.Size(26, 29);
            this.lbClearFreq.TabIndex = 22;
            this.lbClearFreq.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(480, 364);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 29);
            this.label15.TabIndex = 21;
            this.label15.Text = "Overcast";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(360, 364);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 29);
            this.label16.TabIndex = 20;
            this.label16.Text = "Cloudy";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(259, 364);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 29);
            this.label17.TabIndex = 19;
            this.label17.Text = "Clear";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(147, 364);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 29);
            this.label18.TabIndex = 18;
            this.label18.Text = "Freq";
            // 
            // lbOvercastDur
            // 
            this.lbOvercastDur.AutoSize = true;
            this.lbOvercastDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOvercastDur.Location = new System.Drawing.Point(480, 309);
            this.lbOvercastDur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOvercastDur.Name = "lbOvercastDur";
            this.lbOvercastDur.Size = new System.Drawing.Size(26, 29);
            this.lbOvercastDur.TabIndex = 17;
            this.lbOvercastDur.Text = "0";
            // 
            // lbCloudyDur
            // 
            this.lbCloudyDur.AutoSize = true;
            this.lbCloudyDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCloudyDur.Location = new System.Drawing.Point(360, 309);
            this.lbCloudyDur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCloudyDur.Name = "lbCloudyDur";
            this.lbCloudyDur.Size = new System.Drawing.Size(26, 29);
            this.lbCloudyDur.TabIndex = 16;
            this.lbCloudyDur.Text = "0";
            // 
            // lbClearDur
            // 
            this.lbClearDur.AutoSize = true;
            this.lbClearDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClearDur.Location = new System.Drawing.Point(259, 309);
            this.lbClearDur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClearDur.Name = "lbClearDur";
            this.lbClearDur.Size = new System.Drawing.Size(26, 29);
            this.lbClearDur.TabIndex = 15;
            this.lbClearDur.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(480, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Overcast";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(360, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cloudy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(259, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Clear";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(145, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Days";
            // 
            // lbCurIter
            // 
            this.lbCurIter.AutoSize = true;
            this.lbCurIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurIter.Location = new System.Drawing.Point(487, 142);
            this.lbCurIter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurIter.Name = "lbCurIter";
            this.lbCurIter.Size = new System.Drawing.Size(26, 29);
            this.lbCurIter.TabIndex = 10;
            this.lbCurIter.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(353, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Iterations";
            // 
            // btPause
            // 
            this.btPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPause.Location = new System.Drawing.Point(408, 29);
            this.btPause.Margin = new System.Windows.Forms.Padding(4);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(260, 50);
            this.btPause.TabIndex = 8;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // lbWeather
            // 
            this.lbWeather.AutoSize = true;
            this.lbWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeather.Location = new System.Drawing.Point(73, 142);
            this.lbWeather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWeather.Name = "lbWeather";
            this.lbWeather.Size = new System.Drawing.Size(71, 29);
            this.lbWeather.TabIndex = 7;
            this.lbWeather.Text = "Clear";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(73, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weather";
            // 
            // NumOfIterations
            // 
            this.NumOfIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfIterations.Location = new System.Drawing.Point(358, 140);
            this.NumOfIterations.Margin = new System.Windows.Forms.Padding(4);
            this.NumOfIterations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumOfIterations.Name = "NumOfIterations";
            this.NumOfIterations.Size = new System.Drawing.Size(103, 34);
            this.NumOfIterations.TabIndex = 5;
            this.NumOfIterations.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHour.Location = new System.Drawing.Point(270, 142);
            this.lbHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(26, 29);
            this.lbHour.TabIndex = 4;
            this.lbHour.Text = "0";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDay.Location = new System.Drawing.Point(198, 142);
            this.lbDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(26, 29);
            this.lbDay.TabIndex = 3;
            this.lbDay.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(270, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(98, 29);
            this.btStart.Margin = new System.Windows.Forms.Padding(4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(260, 50);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(487, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Current iteration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(217, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 32);
            this.label10.TabIndex = 26;
            this.label10.Text = "Stationary distribution";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 452);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfIterations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown NumOfIterations;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbWeather;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Label lbCurIter;
        private System.Windows.Forms.Label lbOvercastFreq;
        private System.Windows.Forms.Label lbCloudyFreq;
        private System.Windows.Forms.Label lbClearFreq;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbOvercastDur;
        private System.Windows.Forms.Label lbCloudyDur;
        private System.Windows.Forms.Label lbClearDur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

