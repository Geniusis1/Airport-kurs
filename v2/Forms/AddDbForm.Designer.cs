namespace Airport_kurs.Forms
{
	partial class AddDbForm
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
			this.saveBt = new System.Windows.Forms.Button();
			this.exitBt = new System.Windows.Forms.Button();
			this.ticketsTab = new System.Windows.Forms.TabPage();
			this.ticketAirplaneTb = new System.Windows.Forms.TextBox();
			this.ticketFlightIdTb = new System.Windows.Forms.TextBox();
			this.ticketPriceTb = new System.Windows.Forms.TextBox();
			this.ticketClassCb = new System.Windows.Forms.ComboBox();
			this.ticketAirlineCb = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.flightsTab = new System.Windows.Forms.TabPage();
			this.flightMaxPassTb = new System.Windows.Forms.TextBox();
			this.flightTimeToDate = new System.Windows.Forms.DateTimePicker();
			this.flightTimeInDate = new System.Windows.Forms.DateTimePicker();
			this.flightToCb = new System.Windows.Forms.ComboBox();
			this.flightInCb = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.countriesTab = new System.Windows.Forms.TabPage();
			this.cityNameTb = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.airplanesTab = new System.Windows.Forms.TabPage();
			this.airplanesTypeTb = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.airplanesAirlineCb = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.airlinesTab = new System.Windows.Forms.TabPage();
			this.airlineNameTb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ticketsTab.SuspendLayout();
			this.flightsTab.SuspendLayout();
			this.countriesTab.SuspendLayout();
			this.airplanesTab.SuspendLayout();
			this.airlinesTab.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveBt
			// 
			this.saveBt.Location = new System.Drawing.Point(224, 356);
			this.saveBt.Name = "saveBt";
			this.saveBt.Size = new System.Drawing.Size(111, 23);
			this.saveBt.TabIndex = 1;
			this.saveBt.Text = "Сохранить";
			this.saveBt.UseVisualStyleBackColor = true;
			this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
			// 
			// exitBt
			// 
			this.exitBt.Location = new System.Drawing.Point(224, 403);
			this.exitBt.Name = "exitBt";
			this.exitBt.Size = new System.Drawing.Size(111, 23);
			this.exitBt.TabIndex = 2;
			this.exitBt.Text = "Выйти";
			this.exitBt.UseVisualStyleBackColor = true;
			this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
			// 
			// ticketsTab
			// 
			this.ticketsTab.Controls.Add(this.ticketAirplaneTb);
			this.ticketsTab.Controls.Add(this.ticketFlightIdTb);
			this.ticketsTab.Controls.Add(this.ticketPriceTb);
			this.ticketsTab.Controls.Add(this.ticketClassCb);
			this.ticketsTab.Controls.Add(this.ticketAirlineCb);
			this.ticketsTab.Controls.Add(this.label10);
			this.ticketsTab.Controls.Add(this.label11);
			this.ticketsTab.Controls.Add(this.label12);
			this.ticketsTab.Controls.Add(this.label13);
			this.ticketsTab.Controls.Add(this.label14);
			this.ticketsTab.Location = new System.Drawing.Point(4, 25);
			this.ticketsTab.Name = "ticketsTab";
			this.ticketsTab.Size = new System.Drawing.Size(209, 399);
			this.ticketsTab.TabIndex = 4;
			this.ticketsTab.Text = "Билеты";
			this.ticketsTab.UseVisualStyleBackColor = true;
			// 
			// ticketAirplaneTb
			// 
			this.ticketAirplaneTb.Location = new System.Drawing.Point(10, 96);
			this.ticketAirplaneTb.Name = "ticketAirplaneTb";
			this.ticketAirplaneTb.Size = new System.Drawing.Size(179, 22);
			this.ticketAirplaneTb.TabIndex = 21;
			// 
			// ticketFlightIdTb
			// 
			this.ticketFlightIdTb.Location = new System.Drawing.Point(10, 35);
			this.ticketFlightIdTb.Name = "ticketFlightIdTb";
			this.ticketFlightIdTb.Size = new System.Drawing.Size(179, 22);
			this.ticketFlightIdTb.TabIndex = 20;
			// 
			// ticketPriceTb
			// 
			this.ticketPriceTb.Location = new System.Drawing.Point(10, 287);
			this.ticketPriceTb.Name = "ticketPriceTb";
			this.ticketPriceTb.Size = new System.Drawing.Size(179, 22);
			this.ticketPriceTb.TabIndex = 19;
			// 
			// ticketClassCb
			// 
			this.ticketClassCb.FormattingEnabled = true;
			this.ticketClassCb.Items.AddRange(new object[] {
            "Первый класс",
            "Бизнес",
            "Эконом"});
			this.ticketClassCb.Location = new System.Drawing.Point(10, 225);
			this.ticketClassCb.Name = "ticketClassCb";
			this.ticketClassCb.Size = new System.Drawing.Size(179, 24);
			this.ticketClassCb.TabIndex = 16;
			// 
			// ticketAirlineCb
			// 
			this.ticketAirlineCb.FormattingEnabled = true;
			this.ticketAirlineCb.Location = new System.Drawing.Point(10, 163);
			this.ticketAirlineCb.Name = "ticketAirlineCb";
			this.ticketAirlineCb.Size = new System.Drawing.Size(179, 24);
			this.ticketAirlineCb.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 267);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 17);
			this.label10.TabIndex = 14;
			this.label10.Text = "Цена";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 205);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 17);
			this.label11.TabIndex = 13;
			this.label11.Text = "Класс";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(7, 143);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 17);
			this.label12.TabIndex = 12;
			this.label12.Text = "Авиалиния";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(7, 76);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(86, 17);
			this.label13.TabIndex = 11;
			this.label13.Text = "Id самолета";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(7, 15);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(62, 17);
			this.label14.TabIndex = 10;
			this.label14.Text = "Id рейса";
			// 
			// flightsTab
			// 
			this.flightsTab.Controls.Add(this.flightMaxPassTb);
			this.flightsTab.Controls.Add(this.flightTimeToDate);
			this.flightsTab.Controls.Add(this.flightTimeInDate);
			this.flightsTab.Controls.Add(this.flightToCb);
			this.flightsTab.Controls.Add(this.flightInCb);
			this.flightsTab.Controls.Add(this.label9);
			this.flightsTab.Controls.Add(this.label8);
			this.flightsTab.Controls.Add(this.label7);
			this.flightsTab.Controls.Add(this.label6);
			this.flightsTab.Controls.Add(this.label5);
			this.flightsTab.Location = new System.Drawing.Point(4, 25);
			this.flightsTab.Name = "flightsTab";
			this.flightsTab.Size = new System.Drawing.Size(209, 399);
			this.flightsTab.TabIndex = 3;
			this.flightsTab.Text = "Рейсы";
			this.flightsTab.UseVisualStyleBackColor = true;
			// 
			// flightMaxPassTb
			// 
			this.flightMaxPassTb.Location = new System.Drawing.Point(11, 288);
			this.flightMaxPassTb.Name = "flightMaxPassTb";
			this.flightMaxPassTb.Size = new System.Drawing.Size(178, 22);
			this.flightMaxPassTb.TabIndex = 9;
			// 
			// flightTimeToDate
			// 
			this.flightTimeToDate.Location = new System.Drawing.Point(11, 226);
			this.flightTimeToDate.Name = "flightTimeToDate";
			this.flightTimeToDate.Size = new System.Drawing.Size(178, 22);
			this.flightTimeToDate.TabIndex = 8;
			// 
			// flightTimeInDate
			// 
			this.flightTimeInDate.Location = new System.Drawing.Point(11, 164);
			this.flightTimeInDate.Name = "flightTimeInDate";
			this.flightTimeInDate.Size = new System.Drawing.Size(178, 22);
			this.flightTimeInDate.TabIndex = 7;
			// 
			// flightToCb
			// 
			this.flightToCb.FormattingEnabled = true;
			this.flightToCb.Location = new System.Drawing.Point(11, 97);
			this.flightToCb.Name = "flightToCb";
			this.flightToCb.Size = new System.Drawing.Size(178, 24);
			this.flightToCb.TabIndex = 6;
			// 
			// flightInCb
			// 
			this.flightInCb.FormattingEnabled = true;
			this.flightInCb.Location = new System.Drawing.Point(11, 36);
			this.flightInCb.Name = "flightInCb";
			this.flightInCb.Size = new System.Drawing.Size(178, 24);
			this.flightInCb.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 268);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(174, 17);
			this.label9.TabIndex = 4;
			this.label9.Text = "Макс. кол-во пассажиров";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 206);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 17);
			this.label8.TabIndex = 3;
			this.label8.Text = "Время прилета";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 17);
			this.label7.TabIndex = 2;
			this.label7.Text = "Время вылета";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Страна прилета";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Страна вылета";
			// 
			// countriesTab
			// 
			this.countriesTab.Controls.Add(this.cityNameTb);
			this.countriesTab.Controls.Add(this.label4);
			this.countriesTab.Location = new System.Drawing.Point(4, 25);
			this.countriesTab.Name = "countriesTab";
			this.countriesTab.Size = new System.Drawing.Size(209, 399);
			this.countriesTab.TabIndex = 2;
			this.countriesTab.Text = "Города";
			this.countriesTab.UseVisualStyleBackColor = true;
			// 
			// cityNameTb
			// 
			this.cityNameTb.Location = new System.Drawing.Point(10, 34);
			this.cityNameTb.Name = "cityNameTb";
			this.cityNameTb.Size = new System.Drawing.Size(179, 22);
			this.cityNameTb.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Название";
			// 
			// airplanesTab
			// 
			this.airplanesTab.Controls.Add(this.airplanesTypeTb);
			this.airplanesTab.Controls.Add(this.label3);
			this.airplanesTab.Controls.Add(this.airplanesAirlineCb);
			this.airplanesTab.Controls.Add(this.label2);
			this.airplanesTab.Location = new System.Drawing.Point(4, 25);
			this.airplanesTab.Name = "airplanesTab";
			this.airplanesTab.Padding = new System.Windows.Forms.Padding(3);
			this.airplanesTab.Size = new System.Drawing.Size(209, 399);
			this.airplanesTab.TabIndex = 1;
			this.airplanesTab.Text = "Самолеты";
			this.airplanesTab.UseVisualStyleBackColor = true;
			// 
			// airplanesTypeTb
			// 
			this.airplanesTypeTb.Location = new System.Drawing.Point(8, 96);
			this.airplanesTypeTb.Name = "airplanesTypeTb";
			this.airplanesTypeTb.Size = new System.Drawing.Size(178, 22);
			this.airplanesTypeTb.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Тип самолета";
			// 
			// airplanesAirlineCb
			// 
			this.airplanesAirlineCb.FormattingEnabled = true;
			this.airplanesAirlineCb.Location = new System.Drawing.Point(8, 28);
			this.airplanesAirlineCb.Name = "airplanesAirlineCb";
			this.airplanesAirlineCb.Size = new System.Drawing.Size(178, 24);
			this.airplanesAirlineCb.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Авиалиния";
			// 
			// airlinesTab
			// 
			this.airlinesTab.Controls.Add(this.airlineNameTb);
			this.airlinesTab.Controls.Add(this.label1);
			this.airlinesTab.Location = new System.Drawing.Point(4, 25);
			this.airlinesTab.Name = "airlinesTab";
			this.airlinesTab.Padding = new System.Windows.Forms.Padding(3);
			this.airlinesTab.Size = new System.Drawing.Size(209, 399);
			this.airlinesTab.TabIndex = 0;
			this.airlinesTab.Text = "Авиалинии";
			this.airlinesTab.UseVisualStyleBackColor = true;
			// 
			// airlineNameTb
			// 
			this.airlineNameTb.Location = new System.Drawing.Point(11, 27);
			this.airlineNameTb.Name = "airlineNameTb";
			this.airlineNameTb.Size = new System.Drawing.Size(175, 22);
			this.airlineNameTb.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.airlinesTab);
			this.tabControl1.Controls.Add(this.airplanesTab);
			this.tabControl1.Controls.Add(this.countriesTab);
			this.tabControl1.Controls.Add(this.flightsTab);
			this.tabControl1.Controls.Add(this.ticketsTab);
			this.tabControl1.Location = new System.Drawing.Point(1, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(217, 428);
			this.tabControl1.TabIndex = 0;
			// 
			// AddDbForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 442);
			this.Controls.Add(this.exitBt);
			this.Controls.Add(this.saveBt);
			this.Controls.Add(this.tabControl1);
			this.Name = "AddDbForm";
			this.ticketsTab.ResumeLayout(false);
			this.ticketsTab.PerformLayout();
			this.flightsTab.ResumeLayout(false);
			this.flightsTab.PerformLayout();
			this.countriesTab.ResumeLayout(false);
			this.countriesTab.PerformLayout();
			this.airplanesTab.ResumeLayout(false);
			this.airplanesTab.PerformLayout();
			this.airlinesTab.ResumeLayout(false);
			this.airlinesTab.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button saveBt;
		private System.Windows.Forms.Button exitBt;
		private System.Windows.Forms.TabPage ticketsTab;
		private System.Windows.Forms.TextBox ticketAirplaneTb;
		private System.Windows.Forms.TextBox ticketFlightIdTb;
		private System.Windows.Forms.TextBox ticketPriceTb;
		private System.Windows.Forms.ComboBox ticketClassCb;
		private System.Windows.Forms.ComboBox ticketAirlineCb;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TabPage flightsTab;
		private System.Windows.Forms.TextBox flightMaxPassTb;
		private System.Windows.Forms.DateTimePicker flightTimeToDate;
		private System.Windows.Forms.DateTimePicker flightTimeInDate;
		private System.Windows.Forms.ComboBox flightToCb;
		private System.Windows.Forms.ComboBox flightInCb;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabPage countriesTab;
		private System.Windows.Forms.TextBox cityNameTb;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage airplanesTab;
		private System.Windows.Forms.TextBox airplanesTypeTb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox airplanesAirlineCb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage airlinesTab;
		private System.Windows.Forms.TextBox airlineNameTb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}