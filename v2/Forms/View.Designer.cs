using System.Windows.Forms;

namespace Airport_kurs
{
    partial class View
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dbConfTab = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.createNewRowBt = new System.Windows.Forms.Button();
			this.delForIdGb = new System.Windows.Forms.GroupBox();
			this.deleteDbBt = new System.Windows.Forms.Button();
			this.idDeleteDbTb = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dbSwitch = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.editDbGridView = new System.Windows.Forms.DataGridView();
			this.delaysTab = new System.Windows.Forms.TabPage();
			this.reloadTablesBt = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.delaysDate = new System.Windows.Forms.DateTimePicker();
			this.delaysSearchBt = new System.Windows.Forms.Button();
			this.delaysDataView = new System.Windows.Forms.DataGridView();
			this.searchTab = new System.Windows.Forms.TabPage();
			this.searchFlightCountryCb = new System.Windows.Forms.ComboBox();
			this.searchCB = new System.Windows.Forms.CheckBox();
			this.searchDataView = new System.Windows.Forms.DataGridView();
			this.searchBt = new System.Windows.Forms.Button();
			this.searchDateLb = new System.Windows.Forms.Label();
			this.searchDataTime = new System.Windows.Forms.DateTimePicker();
			this.searchLb = new System.Windows.Forms.Label();
			this.ticketsTab = new System.Windows.Forms.TabPage();
			this.ticketsDataView = new System.Windows.Forms.DataGridView();
			this.flightsTab = new System.Windows.Forms.TabPage();
			this.flightsDataView = new System.Windows.Forms.DataGridView();
			this.airlineTab = new System.Windows.Forms.TabPage();
			this.airplanesDataView = new System.Windows.Forms.DataGridView();
			this.ViewTabs = new System.Windows.Forms.TabControl();
			this.searchTicketsTab = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.searchTicketsGB_2 = new System.Windows.Forms.GroupBox();
			this.searchTicketsCountryCb = new System.Windows.Forms.ComboBox();
			this.searchTicketsBt = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.searchTicketsGridView = new System.Windows.Forms.DataGridView();
			this.dbConfTab.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.delForIdGb.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.editDbGridView)).BeginInit();
			this.delaysTab.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.delaysDataView)).BeginInit();
			this.searchTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchDataView)).BeginInit();
			this.ticketsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ticketsDataView)).BeginInit();
			this.flightsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flightsDataView)).BeginInit();
			this.airlineTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.airplanesDataView)).BeginInit();
			this.ViewTabs.SuspendLayout();
			this.searchTicketsTab.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.searchTicketsGB_2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchTicketsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dbConfTab
			// 
			this.dbConfTab.Controls.Add(this.groupBox2);
			this.dbConfTab.Controls.Add(this.delForIdGb);
			this.dbConfTab.Controls.Add(this.dbSwitch);
			this.dbConfTab.Controls.Add(this.label1);
			this.dbConfTab.Controls.Add(this.editDbGridView);
			this.dbConfTab.Location = new System.Drawing.Point(4, 25);
			this.dbConfTab.Name = "dbConfTab";
			this.dbConfTab.Padding = new System.Windows.Forms.Padding(3);
			this.dbConfTab.Size = new System.Drawing.Size(790, 420);
			this.dbConfTab.TabIndex = 7;
			this.dbConfTab.Text = "Изменение БД";
			this.dbConfTab.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.createNewRowBt);
			this.groupBox2.Location = new System.Drawing.Point(459, 67);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(323, 72);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Добавление в БД";
			// 
			// createNewRowBt
			// 
			this.createNewRowBt.Location = new System.Drawing.Point(224, 33);
			this.createNewRowBt.Name = "createNewRowBt";
			this.createNewRowBt.Size = new System.Drawing.Size(93, 23);
			this.createNewRowBt.TabIndex = 0;
			this.createNewRowBt.Text = "Создать";
			this.createNewRowBt.UseVisualStyleBackColor = true;
			this.createNewRowBt.Click += new System.EventHandler(this.createNewRowBt_Click);
			// 
			// delForIdGb
			// 
			this.delForIdGb.Controls.Add(this.deleteDbBt);
			this.delForIdGb.Controls.Add(this.idDeleteDbTb);
			this.delForIdGb.Controls.Add(this.label2);
			this.delForIdGb.Location = new System.Drawing.Point(459, 145);
			this.delForIdGb.Name = "delForIdGb";
			this.delForIdGb.Size = new System.Drawing.Size(323, 65);
			this.delForIdGb.TabIndex = 3;
			this.delForIdGb.TabStop = false;
			this.delForIdGb.Text = "Удаление по id";
			// 
			// deleteDbBt
			// 
			this.deleteDbBt.Location = new System.Drawing.Point(224, 27);
			this.deleteDbBt.Name = "deleteDbBt";
			this.deleteDbBt.Size = new System.Drawing.Size(93, 23);
			this.deleteDbBt.TabIndex = 5;
			this.deleteDbBt.Text = "Удалить";
			this.deleteDbBt.UseVisualStyleBackColor = true;
			this.deleteDbBt.Click += new System.EventHandler(this.deleteDbBt_Click);
			// 
			// idDeleteDbTb
			// 
			this.idDeleteDbTb.Location = new System.Drawing.Point(39, 28);
			this.idDeleteDbTb.Name = "idDeleteDbTb";
			this.idDeleteDbTb.Size = new System.Drawing.Size(115, 22);
			this.idDeleteDbTb.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "id :";
			// 
			// dbSwitch
			// 
			this.dbSwitch.FormattingEnabled = true;
			this.dbSwitch.Items.AddRange(new object[] {
            "Авиалинии",
            "Самолеты",
            "Города",
            "Рейсы",
            "Билеты",
            "Пользователи"});
			this.dbSwitch.Location = new System.Drawing.Point(459, 28);
			this.dbSwitch.Name = "dbSwitch";
			this.dbSwitch.Size = new System.Drawing.Size(323, 24);
			this.dbSwitch.TabIndex = 2;
			this.dbSwitch.SelectedIndexChanged += new System.EventHandler(this.dbSwitch_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(456, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Активная таблица";
			// 
			// editDbGridView
			// 
			this.editDbGridView.AllowUserToDeleteRows = false;
			this.editDbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.editDbGridView.Location = new System.Drawing.Point(7, 6);
			this.editDbGridView.Name = "editDbGridView";
			this.editDbGridView.RowTemplate.Height = 24;
			this.editDbGridView.Size = new System.Drawing.Size(442, 408);
			this.editDbGridView.TabIndex = 0;
			this.editDbGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.editDbGridView_CellEndEdit);
			// 
			// delaysTab
			// 
			this.delaysTab.Controls.Add(this.reloadTablesBt);
			this.delaysTab.Controls.Add(this.groupBox3);
			this.delaysTab.Controls.Add(this.delaysDataView);
			this.delaysTab.Location = new System.Drawing.Point(4, 25);
			this.delaysTab.Name = "delaysTab";
			this.delaysTab.Size = new System.Drawing.Size(790, 420);
			this.delaysTab.TabIndex = 6;
			this.delaysTab.Text = "Задержки и отмены";
			this.delaysTab.UseVisualStyleBackColor = true;
			// 
			// reloadTablesBt
			// 
			this.reloadTablesBt.Location = new System.Drawing.Point(12, 388);
			this.reloadTablesBt.Name = "reloadTablesBt";
			this.reloadTablesBt.Size = new System.Drawing.Size(141, 23);
			this.reloadTablesBt.TabIndex = 2;
			this.reloadTablesBt.Text = "Показать всё";
			this.reloadTablesBt.UseVisualStyleBackColor = true;
			this.reloadTablesBt.Click += new System.EventHandler(this.reloadTablesBt_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.delaysDate);
			this.groupBox3.Controls.Add(this.delaysSearchBt);
			this.groupBox3.Location = new System.Drawing.Point(6, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(239, 118);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Поиск по дате";
			// 
			// delaysDate
			// 
			this.delaysDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.delaysDate.Location = new System.Drawing.Point(6, 30);
			this.delaysDate.Name = "delaysDate";
			this.delaysDate.Size = new System.Drawing.Size(215, 22);
			this.delaysDate.TabIndex = 1;
			// 
			// delaysSearchBt
			// 
			this.delaysSearchBt.Location = new System.Drawing.Point(158, 89);
			this.delaysSearchBt.Name = "delaysSearchBt";
			this.delaysSearchBt.Size = new System.Drawing.Size(75, 23);
			this.delaysSearchBt.TabIndex = 0;
			this.delaysSearchBt.Text = "Поиск";
			this.delaysSearchBt.UseVisualStyleBackColor = true;
			this.delaysSearchBt.Click += new System.EventHandler(this.delaysSearchBt_Click);
			// 
			// delaysDataView
			// 
			this.delaysDataView.AllowUserToAddRows = false;
			this.delaysDataView.AllowUserToDeleteRows = false;
			this.delaysDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.delaysDataView.Location = new System.Drawing.Point(251, 0);
			this.delaysDataView.Name = "delaysDataView";
			this.delaysDataView.ReadOnly = true;
			this.delaysDataView.RowTemplate.Height = 24;
			this.delaysDataView.Size = new System.Drawing.Size(539, 420);
			this.delaysDataView.TabIndex = 0;
			// 
			// searchTab
			// 
			this.searchTab.Controls.Add(this.searchFlightCountryCb);
			this.searchTab.Controls.Add(this.searchCB);
			this.searchTab.Controls.Add(this.searchDataView);
			this.searchTab.Controls.Add(this.searchBt);
			this.searchTab.Controls.Add(this.searchDateLb);
			this.searchTab.Controls.Add(this.searchDataTime);
			this.searchTab.Controls.Add(this.searchLb);
			this.searchTab.Location = new System.Drawing.Point(4, 25);
			this.searchTab.Name = "searchTab";
			this.searchTab.Size = new System.Drawing.Size(790, 420);
			this.searchTab.TabIndex = 5;
			this.searchTab.Text = "Поиск рейса";
			this.searchTab.UseVisualStyleBackColor = true;
			// 
			// searchFlightCountryCb
			// 
			this.searchFlightCountryCb.FormattingEnabled = true;
			this.searchFlightCountryCb.Location = new System.Drawing.Point(22, 37);
			this.searchFlightCountryCb.Name = "searchFlightCountryCb";
			this.searchFlightCountryCb.Size = new System.Drawing.Size(186, 24);
			this.searchFlightCountryCb.TabIndex = 7;
			// 
			// searchCB
			// 
			this.searchCB.AutoSize = true;
			this.searchCB.Checked = global::Airport_kurs.Properties.Settings.Default.yes;
			this.searchCB.CheckState = System.Windows.Forms.CheckState.Checked;
			this.searchCB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Airport_kurs.Properties.Settings.Default, "yes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.searchCB.Location = new System.Drawing.Point(22, 78);
			this.searchCB.Name = "searchCB";
			this.searchCB.Size = new System.Drawing.Size(64, 21);
			this.searchCB.TabIndex = 6;
			this.searchCB.Text = "Дата";
			this.searchCB.UseVisualStyleBackColor = true;
			this.searchCB.CheckedChanged += new System.EventHandler(this.searchCB_CheckedChanged);
			// 
			// searchDataView
			// 
			this.searchDataView.AllowUserToAddRows = false;
			this.searchDataView.AllowUserToDeleteRows = false;
			this.searchDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.searchDataView.Location = new System.Drawing.Point(255, 0);
			this.searchDataView.Name = "searchDataView";
			this.searchDataView.ReadOnly = true;
			this.searchDataView.RowTemplate.Height = 24;
			this.searchDataView.Size = new System.Drawing.Size(539, 424);
			this.searchDataView.TabIndex = 5;
			// 
			// searchBt
			// 
			this.searchBt.Location = new System.Drawing.Point(22, 189);
			this.searchBt.Name = "searchBt";
			this.searchBt.Size = new System.Drawing.Size(200, 23);
			this.searchBt.TabIndex = 4;
			this.searchBt.Text = "Поиск";
			this.searchBt.UseVisualStyleBackColor = true;
			this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
			// 
			// searchDateLb
			// 
			this.searchDateLb.AutoSize = true;
			this.searchDateLb.Location = new System.Drawing.Point(22, 124);
			this.searchDateLb.Name = "searchDateLb";
			this.searchDateLb.Size = new System.Drawing.Size(111, 17);
			this.searchDateLb.TabIndex = 2;
			this.searchDateLb.Text = "Дата прибытия";
			// 
			// searchDataTime
			// 
			this.searchDataTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.searchDataTime.Location = new System.Drawing.Point(22, 147);
			this.searchDataTime.Name = "searchDataTime";
			this.searchDataTime.Size = new System.Drawing.Size(200, 22);
			this.searchDataTime.TabIndex = 1;
			// 
			// searchLb
			// 
			this.searchLb.AutoSize = true;
			this.searchLb.Location = new System.Drawing.Point(19, 16);
			this.searchLb.Name = "searchLb";
			this.searchLb.Size = new System.Drawing.Size(117, 17);
			this.searchLb.TabIndex = 0;
			this.searchLb.Text = "Город прибытия";
			// 
			// ticketsTab
			// 
			this.ticketsTab.Controls.Add(this.ticketsDataView);
			this.ticketsTab.Location = new System.Drawing.Point(4, 25);
			this.ticketsTab.Name = "ticketsTab";
			this.ticketsTab.Size = new System.Drawing.Size(790, 420);
			this.ticketsTab.TabIndex = 4;
			this.ticketsTab.Text = "Билеты";
			this.ticketsTab.UseVisualStyleBackColor = true;
			// 
			// ticketsDataView
			// 
			this.ticketsDataView.AllowUserToAddRows = false;
			this.ticketsDataView.AllowUserToDeleteRows = false;
			this.ticketsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ticketsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ticketsDataView.Location = new System.Drawing.Point(0, 0);
			this.ticketsDataView.Name = "ticketsDataView";
			this.ticketsDataView.ReadOnly = true;
			this.ticketsDataView.RowTemplate.Height = 24;
			this.ticketsDataView.Size = new System.Drawing.Size(790, 420);
			this.ticketsDataView.TabIndex = 0;
			// 
			// flightsTab
			// 
			this.flightsTab.Controls.Add(this.flightsDataView);
			this.flightsTab.Location = new System.Drawing.Point(4, 25);
			this.flightsTab.Name = "flightsTab";
			this.flightsTab.Size = new System.Drawing.Size(790, 420);
			this.flightsTab.TabIndex = 3;
			this.flightsTab.Text = "Рейсы";
			this.flightsTab.UseVisualStyleBackColor = true;
			// 
			// flightsDataView
			// 
			this.flightsDataView.AllowUserToAddRows = false;
			this.flightsDataView.AllowUserToDeleteRows = false;
			this.flightsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.flightsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flightsDataView.Location = new System.Drawing.Point(0, 0);
			this.flightsDataView.Name = "flightsDataView";
			this.flightsDataView.ReadOnly = true;
			this.flightsDataView.RowTemplate.Height = 24;
			this.flightsDataView.Size = new System.Drawing.Size(790, 420);
			this.flightsDataView.TabIndex = 0;
			// 
			// airlineTab
			// 
			this.airlineTab.Controls.Add(this.airplanesDataView);
			this.airlineTab.Location = new System.Drawing.Point(4, 25);
			this.airlineTab.Name = "airlineTab";
			this.airlineTab.Padding = new System.Windows.Forms.Padding(3);
			this.airlineTab.Size = new System.Drawing.Size(790, 420);
			this.airlineTab.TabIndex = 2;
			this.airlineTab.Text = "Самолеты";
			this.airlineTab.UseVisualStyleBackColor = true;
			// 
			// airplanesDataView
			// 
			this.airplanesDataView.AllowUserToAddRows = false;
			this.airplanesDataView.AllowUserToDeleteRows = false;
			this.airplanesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.airplanesDataView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.airplanesDataView.Location = new System.Drawing.Point(3, 3);
			this.airplanesDataView.Name = "airplanesDataView";
			this.airplanesDataView.ReadOnly = true;
			this.airplanesDataView.RowTemplate.Height = 24;
			this.airplanesDataView.Size = new System.Drawing.Size(784, 414);
			this.airplanesDataView.TabIndex = 0;
			// 
			// ViewTabs
			// 
			this.ViewTabs.Controls.Add(this.airlineTab);
			this.ViewTabs.Controls.Add(this.flightsTab);
			this.ViewTabs.Controls.Add(this.ticketsTab);
			this.ViewTabs.Controls.Add(this.searchTab);
			this.ViewTabs.Controls.Add(this.delaysTab);
			this.ViewTabs.Controls.Add(this.dbConfTab);
			this.ViewTabs.Controls.Add(this.searchTicketsTab);
			this.ViewTabs.Location = new System.Drawing.Point(2, 2);
			this.ViewTabs.Name = "ViewTabs";
			this.ViewTabs.SelectedIndex = 0;
			this.ViewTabs.Size = new System.Drawing.Size(798, 449);
			this.ViewTabs.TabIndex = 0;
			// 
			// searchTicketsTab
			// 
			this.searchTicketsTab.Controls.Add(this.groupBox4);
			this.searchTicketsTab.Controls.Add(this.searchTicketsGB_2);
			this.searchTicketsTab.Controls.Add(this.searchTicketsGridView);
			this.searchTicketsTab.Location = new System.Drawing.Point(4, 25);
			this.searchTicketsTab.Name = "searchTicketsTab";
			this.searchTicketsTab.Size = new System.Drawing.Size(790, 420);
			this.searchTicketsTab.TabIndex = 8;
			this.searchTicketsTab.Text = "Поиск билета";
			this.searchTicketsTab.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.radioButton2);
			this.groupBox4.Controls.Add(this.radioButton1);
			this.groupBox4.Location = new System.Drawing.Point(15, 178);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(200, 126);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Фильтры";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(17, 79);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(107, 21);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "По времени";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(17, 40);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(120, 21);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "По стоимости";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// searchTicketsGB_2
			// 
			this.searchTicketsGB_2.Controls.Add(this.searchTicketsCountryCb);
			this.searchTicketsGB_2.Controls.Add(this.searchTicketsBt);
			this.searchTicketsGB_2.Controls.Add(this.label4);
			this.searchTicketsGB_2.Location = new System.Drawing.Point(15, 14);
			this.searchTicketsGB_2.Name = "searchTicketsGB_2";
			this.searchTicketsGB_2.Size = new System.Drawing.Size(200, 145);
			this.searchTicketsGB_2.TabIndex = 5;
			this.searchTicketsGB_2.TabStop = false;
			this.searchTicketsGB_2.Text = "Поиск по городу";
			// 
			// searchTicketsCountryCb
			// 
			this.searchTicketsCountryCb.FormattingEnabled = true;
			this.searchTicketsCountryCb.Location = new System.Drawing.Point(17, 56);
			this.searchTicketsCountryCb.Name = "searchTicketsCountryCb";
			this.searchTicketsCountryCb.Size = new System.Drawing.Size(151, 24);
			this.searchTicketsCountryCb.TabIndex = 4;
			// 
			// searchTicketsBt
			// 
			this.searchTicketsBt.Location = new System.Drawing.Point(94, 116);
			this.searchTicketsBt.Name = "searchTicketsBt";
			this.searchTicketsBt.Size = new System.Drawing.Size(100, 23);
			this.searchTicketsBt.TabIndex = 3;
			this.searchTicketsBt.Text = "Поиск";
			this.searchTicketsBt.UseVisualStyleBackColor = true;
			this.searchTicketsBt.Click += new System.EventHandler(this.radioButton_CheckedChanged);
			this.searchTicketsBt.Click += new System.EventHandler(this.searchTicketsBt_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Город прибытия: ";
			// 
			// searchTicketsGridView
			// 
			this.searchTicketsGridView.AllowUserToAddRows = false;
			this.searchTicketsGridView.AllowUserToDeleteRows = false;
			this.searchTicketsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.searchTicketsGridView.Location = new System.Drawing.Point(255, 3);
			this.searchTicketsGridView.Name = "searchTicketsGridView";
			this.searchTicketsGridView.ReadOnly = true;
			this.searchTicketsGridView.RowTemplate.Height = 24;
			this.searchTicketsGridView.Size = new System.Drawing.Size(535, 417);
			this.searchTicketsGridView.TabIndex = 0;
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ViewTabs);
			this.Name = "View";
			this.Text = "Airport";
			this.dbConfTab.ResumeLayout(false);
			this.dbConfTab.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.delForIdGb.ResumeLayout(false);
			this.delForIdGb.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.editDbGridView)).EndInit();
			this.delaysTab.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.delaysDataView)).EndInit();
			this.searchTab.ResumeLayout(false);
			this.searchTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchDataView)).EndInit();
			this.ticketsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ticketsDataView)).EndInit();
			this.flightsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flightsDataView)).EndInit();
			this.airlineTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.airplanesDataView)).EndInit();
			this.ViewTabs.ResumeLayout(false);
			this.searchTicketsTab.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.searchTicketsGB_2.ResumeLayout(false);
			this.searchTicketsGB_2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchTicketsGridView)).EndInit();
			this.ResumeLayout(false);

        }

		private void EditDbGridView_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			throw new System.NotImplementedException();
		}

		#endregion
		private System.Windows.Forms.TabPage dbConfTab;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button createNewRowBt;
		private System.Windows.Forms.GroupBox delForIdGb;
		private System.Windows.Forms.Button deleteDbBt;
		private System.Windows.Forms.TextBox idDeleteDbTb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox dbSwitch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView editDbGridView;
		private System.Windows.Forms.TabPage delaysTab;
		private System.Windows.Forms.Button reloadTablesBt;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DateTimePicker delaysDate;
		private System.Windows.Forms.Button delaysSearchBt;
		private System.Windows.Forms.DataGridView delaysDataView;
		private System.Windows.Forms.TabPage searchTab;
		private System.Windows.Forms.CheckBox searchCB;
		private System.Windows.Forms.DataGridView searchDataView;
		private System.Windows.Forms.Button searchBt;
		private System.Windows.Forms.Label searchDateLb;
		private System.Windows.Forms.DateTimePicker searchDataTime;
		private System.Windows.Forms.Label searchLb;
		private System.Windows.Forms.TabPage ticketsTab;
		private System.Windows.Forms.DataGridView ticketsDataView;
		private System.Windows.Forms.TabPage flightsTab;
		private System.Windows.Forms.DataGridView flightsDataView;
		private System.Windows.Forms.TabPage airlineTab;
		private System.Windows.Forms.DataGridView airplanesDataView;
		private System.Windows.Forms.TabControl ViewTabs;
		private System.Windows.Forms.TabPage searchTicketsTab;
		private System.Windows.Forms.Button searchTicketsBt;
		private System.Windows.Forms.DataGridView searchTicketsGridView;
		private System.Windows.Forms.GroupBox searchTicketsGB_2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox searchTicketsCountryCb;
		private System.Windows.Forms.ComboBox searchFlightCountryCb;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}