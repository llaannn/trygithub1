
namespace WinsForm0718
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radyear = new System.Windows.Forms.RadioButton();
            this.radpart = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbxCar = new System.Windows.Forms.ComboBox();
            this.cbxgasbic = new System.Windows.Forms.ComboBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lble = new System.Windows.Forms.Label();
            this.Alldays = new System.Windows.Forms.Label();
            this.cbxtruck = new System.Windows.Forms.ComboBox();
            this.cbxbus = new System.Windows.Forms.ComboBox();
            this.cbxcari = new System.Windows.Forms.ComboBox();
            this.cbxcarb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AllResult = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(111, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用牌照稅應納稅額試算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "時間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "車種";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(30, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "汽缸總排氣量(立方公分cc) ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(30, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "試算結果";
            // 
            // radyear
            // 
            this.radyear.AutoSize = true;
            this.radyear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radyear.Location = new System.Drawing.Point(104, 66);
            this.radyear.Name = "radyear";
            this.radyear.Size = new System.Drawing.Size(59, 24);
            this.radyear.TabIndex = 5;
            this.radyear.TabStop = true;
            this.radyear.Text = "年度";
            this.radyear.UseVisualStyleBackColor = true;
            this.radyear.CheckedChanged += new System.EventHandler(this.radyear_CheckedChanged);
            // 
            // radpart
            // 
            this.radpart.AutoSize = true;
            this.radpart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radpart.Location = new System.Drawing.Point(189, 66);
            this.radpart.Name = "radpart";
            this.radpart.Size = new System.Drawing.Size(59, 24);
            this.radpart.TabIndex = 6;
            this.radpart.TabStop = true;
            this.radpart.Text = "區間";
            this.radpart.UseVisualStyleBackColor = true;
            this.radpart.CheckedChanged += new System.EventHandler(this.radpart_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker2.Location = new System.Drawing.Point(517, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // cbxCar
            // 
            this.cbxCar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCar.FormattingEnabled = true;
            this.cbxCar.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxCar.Location = new System.Drawing.Point(346, 150);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(121, 28);
            this.cbxCar.TabIndex = 9;
            this.cbxCar.SelectedIndexChanged += new System.EventHandler(this.cbxCar_SelectedIndexChanged);
            // 
            // cbxgasbic
            // 
            this.cbxgasbic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxgasbic.FormattingEnabled = true;
            this.cbxgasbic.Items.AddRange(new object[] {
            "150 ( 含 150 以 下 ) \t",
            "151-250 \t",
            "251-500 \t",
            "501-600 \t",
            "601-1200 \t",
            "1201-1800 \t",
            "1801以上 "});
            this.cbxgasbic.Location = new System.Drawing.Point(270, 218);
            this.cbxgasbic.Name = "cbxgasbic";
            this.cbxgasbic.Size = new System.Drawing.Size(197, 28);
            this.cbxgasbic.TabIndex = 10;
            this.cbxgasbic.SelectedIndexChanged += new System.EventHandler(this.cbxgasbic_SelectedIndexChanged);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(564, 335);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(103, 48);
            this.btnCalculator.TabIndex = 11;
            this.btnCalculator.Text = "開始計算";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(685, 335);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 48);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "重新填寫";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.Location = new System.Drawing.Point(664, 103);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(53, 12);
            this.lble.TabIndex = 14;
            this.lble.Text = "結束日期";
            // 
            // Alldays
            // 
            this.Alldays.AutoSize = true;
            this.Alldays.Location = new System.Drawing.Point(664, 125);
            this.Alldays.Name = "Alldays";
            this.Alldays.Size = new System.Drawing.Size(53, 12);
            this.Alldays.TabIndex = 15;
            this.Alldays.Text = "總共天數";
            this.Alldays.Visible = false;
            // 
            // cbxtruck
            // 
            this.cbxtruck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxtruck.FormattingEnabled = true;
            this.cbxtruck.Items.AddRange(new object[] {
            "500 以 下 \t",
            "501-600 \t",
            "601-1200 \t",
            "1201-1800 \t",
            "1801-2400 \t",
            "2401-3000 \t",
            "3001-3600 \t",
            "3601-4200 \t",
            "4201-4800 \t",
            "4801-5400 \t",
            "5401-6000 \t",
            "6001-6600 \t",
            "6601-7200 \t",
            "7201-7800 \t",
            "7801-8400 \t",
            "8401-9000 \t",
            "9001-9600 \t",
            "9601-10200 \t",
            "10201 以上"});
            this.cbxtruck.Location = new System.Drawing.Point(270, 218);
            this.cbxtruck.Name = "cbxtruck";
            this.cbxtruck.Size = new System.Drawing.Size(197, 28);
            this.cbxtruck.TabIndex = 19;
            this.cbxtruck.Visible = false;
            // 
            // cbxbus
            // 
            this.cbxbus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxbus.FormattingEnabled = true;
            this.cbxbus.Items.AddRange(new object[] {
            "500 以 下 \t",
            "501-600 \t",
            "601-1200 \t",
            "1201-1800 \t",
            "1801-2400 \t",
            "2401-3000 \t",
            "3001-3600 \t",
            "3601-4200 \t",
            "4201-4800 \t",
            "4801-5400 \t",
            "5401-6000 \t",
            "6001-6600 \t",
            "6601-7200 \t",
            "7201-7800 \t",
            "7801-8400 \t",
            "8401-9000 \t",
            "9001-9600 \t",
            "9601-10200 \t",
            "10201 以上"});
            this.cbxbus.Location = new System.Drawing.Point(270, 218);
            this.cbxbus.Name = "cbxbus";
            this.cbxbus.Size = new System.Drawing.Size(197, 28);
            this.cbxbus.TabIndex = 20;
            this.cbxbus.Visible = false;
            // 
            // cbxcari
            // 
            this.cbxcari.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxcari.FormattingEnabled = true;
            this.cbxcari.Items.AddRange(new object[] {
            "500 以下 \t",
            "501-600 \t",
            "601-1200 \t",
            "1201-1800 \t",
            "1801-2400 \t",
            "2401-3000 \t",
            "3001-4200 \t",
            "4201-5400 \t",
            "5401-6600 \t",
            "6601-7800",
            "7801 以上"});
            this.cbxcari.Location = new System.Drawing.Point(270, 218);
            this.cbxcari.Name = "cbxcari";
            this.cbxcari.Size = new System.Drawing.Size(197, 28);
            this.cbxcari.TabIndex = 21;
            this.cbxcari.Visible = false;
            // 
            // cbxcarb
            // 
            this.cbxcarb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxcarb.FormattingEnabled = true;
            this.cbxcarb.Items.AddRange(new object[] {
            "500 以下 \t",
            "501-600 \t",
            "601-1200 \t",
            "1201-1800 \t",
            "1801-2400 \t",
            "2401-3000 \t",
            "3001-4200 \t",
            "4201-5400 \t",
            "5401-6600 \t",
            "6601-7800",
            "7801 以上"});
            this.cbxcarb.Location = new System.Drawing.Point(270, 218);
            this.cbxcarb.Name = "cbxcarb";
            this.cbxcarb.Size = new System.Drawing.Size(197, 28);
            this.cbxcarb.TabIndex = 22;
            this.cbxcarb.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(45, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(633, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
            // 
            // AllResult
            // 
            this.AllResult.AutoSize = true;
            this.AllResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AllResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AllResult.Location = new System.Drawing.Point(106, 277);
            this.AllResult.Name = "AllResult";
            this.AllResult.Size = new System.Drawing.Size(57, 20);
            this.AllResult.TabIndex = 27;
            this.AllResult.Text = "含細項";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Location = new System.Drawing.Point(414, 103);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(53, 12);
            this.lbls.TabIndex = 13;
            this.lbls.Text = "開始日期";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(777, 448);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(11, 12);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "0";
            this.lblResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.AllResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxcarb);
            this.Controls.Add(this.cbxcari);
            this.Controls.Add(this.cbxbus);
            this.Controls.Add(this.cbxtruck);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Alldays);
            this.Controls.Add(this.lble);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.cbxgasbic);
            this.Controls.Add(this.cbxCar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radpart);
            this.Controls.Add(this.radyear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radyear;
        private System.Windows.Forms.RadioButton radpart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbxCar;
        private System.Windows.Forms.ComboBox cbxgasbic;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.ComboBox cbxtruck;
        private System.Windows.Forms.ComboBox cbxbus;
        private System.Windows.Forms.ComboBox cbxcari;
        private System.Windows.Forms.ComboBox cbxcarb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AllResult;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label Alldays;
        private System.Windows.Forms.Label lblResult;
    }
}

