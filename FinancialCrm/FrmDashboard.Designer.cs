﻿namespace FinancialCrm
{
	partial class FrmDashboard
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblBillAmount = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblBillTitle = new System.Windows.Forms.Label();
			this.lblTotalBalance = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btnBillForm = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLastBankProcessAmount
			// 
			this.lblLastBankProcessAmount.AutoSize = true;
			this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.White;
			this.lblLastBankProcessAmount.Location = new System.Drawing.Point(45, 36);
			this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
			this.lblLastBankProcessAmount.Size = new System.Drawing.Size(121, 45);
			this.lblLastBankProcessAmount.TabIndex = 4;
			this.lblLastBankProcessAmount.Text = "0.00TL";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 19);
			this.label7.TabIndex = 3;
			this.label7.Text = "Gelen Son Havale";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel5.Controls.Add(this.lblLastBankProcessAmount);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Location = new System.Drawing.Point(587, 38);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(184, 95);
			this.panel5.TabIndex = 11;
			// 
			// lblBillAmount
			// 
			this.lblBillAmount.AutoSize = true;
			this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillAmount.ForeColor = System.Drawing.Color.White;
			this.lblBillAmount.Location = new System.Drawing.Point(45, 36);
			this.lblBillAmount.Name = "lblBillAmount";
			this.lblBillAmount.Size = new System.Drawing.Size(121, 45);
			this.lblBillAmount.TabIndex = 4;
			this.lblBillAmount.Text = "0.00TL";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Toplam Bakiye";
			// 
			// lblBillTitle
			// 
			this.lblBillTitle.AutoSize = true;
			this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillTitle.ForeColor = System.Drawing.Color.White;
			this.lblBillTitle.Location = new System.Drawing.Point(3, 0);
			this.lblBillTitle.Name = "lblBillTitle";
			this.lblBillTitle.Size = new System.Drawing.Size(100, 19);
			this.lblBillTitle.TabIndex = 3;
			this.lblBillTitle.Text = "Fatura Başlığı";
			// 
			// lblTotalBalance
			// 
			this.lblTotalBalance.AutoSize = true;
			this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
			this.lblTotalBalance.Location = new System.Drawing.Point(45, 36);
			this.lblTotalBalance.Name = "lblTotalBalance";
			this.lblTotalBalance.Size = new System.Drawing.Size(121, 45);
			this.lblTotalBalance.TabIndex = 4;
			this.lblTotalBalance.Text = "0.00TL";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel3.Controls.Add(this.lblTotalBalance);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(183, 38);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(184, 95);
			this.panel3.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(17, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dashboard";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Blue;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(-9, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(806, 30);
			this.panel2.TabIndex = 8;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Transparent;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button8.ForeColor = System.Drawing.Color.Transparent;
			this.button8.Location = new System.Drawing.Point(14, 337);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(147, 39);
			this.button8.TabIndex = 7;
			this.button8.Text = "Çıkış Yap";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.ForeColor = System.Drawing.Color.Transparent;
			this.button6.Location = new System.Drawing.Point(14, 292);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(147, 39);
			this.button6.TabIndex = 6;
			this.button6.Text = "Ayarlar";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Transparent;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button7.ForeColor = System.Drawing.Color.Transparent;
			this.button7.Location = new System.Drawing.Point(14, 247);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(147, 39);
			this.button7.TabIndex = 5;
			this.button7.Text = "Dashboard";
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Transparent;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button5.ForeColor = System.Drawing.Color.Transparent;
			this.button5.Location = new System.Drawing.Point(14, 202);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(147, 39);
			this.button5.TabIndex = 4;
			this.button5.Text = "Banka Hareketleri";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// btnBillForm
			// 
			this.btnBillForm.BackColor = System.Drawing.Color.Transparent;
			this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillForm.ForeColor = System.Drawing.Color.Transparent;
			this.btnBillForm.Location = new System.Drawing.Point(14, 157);
			this.btnBillForm.Name = "btnBillForm";
			this.btnBillForm.Size = new System.Drawing.Size(147, 39);
			this.btnBillForm.TabIndex = 3;
			this.btnBillForm.Text = "Giderler";
			this.btnBillForm.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.ForeColor = System.Drawing.Color.Transparent;
			this.button3.Location = new System.Drawing.Point(14, 112);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(147, 39);
			this.button3.TabIndex = 2;
			this.button3.Text = "Faturalar";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.ForeColor = System.Drawing.Color.Transparent;
			this.button2.Location = new System.Drawing.Point(14, 67);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(147, 39);
			this.button2.TabIndex = 1;
			this.button2.Text = "Bankalar";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(14, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Kategoriler";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel4.Controls.Add(this.lblBillAmount);
			this.panel4.Controls.Add(this.lblBillTitle);
			this.panel4.Location = new System.Drawing.Point(385, 38);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(184, 95);
			this.panel4.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Navy;
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.btnBillForm);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(-12, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(179, 404);
			this.panel1.TabIndex = 7;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(183, 211);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(289, 188);
			this.chart1.TabIndex = 12;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(478, 211);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series2.Legend = "Legend1";
			series2.Name = "Faturalar";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(293, 188);
			this.chart2.TabIndex = 13;
			this.chart2.Text = "chart2";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel6.Controls.Add(this.label3);
			this.panel6.Location = new System.Drawing.Point(183, 150);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(289, 55);
			this.panel6.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(-1, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(281, 30);
			this.label3.TabIndex = 5;
			this.label3.Text = "Bankalar ve banka hesaplarındaki para miktarlarına\r\naşağıdakigrafikten ulaşabilir" +
    "siniz";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel7.Controls.Add(this.label5);
			this.panel7.Location = new System.Drawing.Point(478, 150);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(293, 55);
			this.panel7.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(3, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(242, 30);
			this.label5.TabIndex = 6;
			this.label5.Text = "Ödenen ve ödenmesi gereken fatura\r\ntutarlarına aşağıdaki grafikten ulaşabilirsini" +
    "z";
			// 
			// FrmDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 411);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Name = "FrmDashboard";
			this.Text = "FrmDashboard";
			this.Load += new System.EventHandler(this.FrmDashboard_Load);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblLastBankProcessAmount;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lblBillAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblBillTitle;
		private System.Windows.Forms.Label lblTotalBalance;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnBillForm;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label5;
	}
}