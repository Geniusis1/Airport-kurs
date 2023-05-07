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
            this.ViewTabs = new System.Windows.Forms.TabControl();
            this.airlineTab = new System.Windows.Forms.TabPage();
            this.airplanesDataView = new System.Windows.Forms.DataGridView();
            this.flightsTab = new System.Windows.Forms.TabPage();
            this.flightsDataView = new System.Windows.Forms.DataGridView();
            this.ticketsTab = new System.Windows.Forms.TabPage();
            this.ticketsDataView = new System.Windows.Forms.DataGridView();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchDataView = new System.Windows.Forms.DataGridView();
            this.searchBt = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchDateLb = new System.Windows.Forms.Label();
            this.searchDataTime = new System.Windows.Forms.DateTimePicker();
            this.searchLb = new System.Windows.Forms.Label();
            this.searchCB = new System.Windows.Forms.CheckBox();
            this.ViewTabs.SuspendLayout();
            this.airlineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesDataView)).BeginInit();
            this.flightsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataView)).BeginInit();
            this.ticketsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataView)).BeginInit();
            this.searchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewTabs
            // 
            this.ViewTabs.Controls.Add(this.airlineTab);
            this.ViewTabs.Controls.Add(this.flightsTab);
            this.ViewTabs.Controls.Add(this.ticketsTab);
            this.ViewTabs.Controls.Add(this.searchTab);
            this.ViewTabs.Location = new System.Drawing.Point(2, 2);
            this.ViewTabs.Name = "ViewTabs";
            this.ViewTabs.SelectedIndex = 0;
            this.ViewTabs.Size = new System.Drawing.Size(798, 449);
            this.ViewTabs.TabIndex = 0;
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
            this.airplanesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airplanesDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airplanesDataView.Location = new System.Drawing.Point(3, 3);
            this.airplanesDataView.Name = "airplanesDataView";
            this.airplanesDataView.RowTemplate.Height = 24;
            this.airplanesDataView.Size = new System.Drawing.Size(784, 414);
            this.airplanesDataView.TabIndex = 0;
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
            this.flightsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightsDataView.Location = new System.Drawing.Point(0, 0);
            this.flightsDataView.Name = "flightsDataView";
            this.flightsDataView.RowTemplate.Height = 24;
            this.flightsDataView.Size = new System.Drawing.Size(790, 420);
            this.flightsDataView.TabIndex = 0;
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
            this.ticketsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketsDataView.Location = new System.Drawing.Point(0, 0);
            this.ticketsDataView.Name = "ticketsDataView";
            this.ticketsDataView.RowTemplate.Height = 24;
            this.ticketsDataView.Size = new System.Drawing.Size(790, 420);
            this.ticketsDataView.TabIndex = 0;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchCB);
            this.searchTab.Controls.Add(this.searchDataView);
            this.searchTab.Controls.Add(this.searchBt);
            this.searchTab.Controls.Add(this.searchTb);
            this.searchTab.Controls.Add(this.searchDateLb);
            this.searchTab.Controls.Add(this.searchDataTime);
            this.searchTab.Controls.Add(this.searchLb);
            this.searchTab.Location = new System.Drawing.Point(4, 25);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(790, 420);
            this.searchTab.TabIndex = 5;
            this.searchTab.Text = "Поиск";
            this.searchTab.UseVisualStyleBackColor = true;
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
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(22, 36);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(200, 22);
            this.searchTb.TabIndex = 3;
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
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewTabs);
            this.Name = "View";
            this.Text = "Airport";
            this.ViewTabs.ResumeLayout(false);
            this.airlineTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.airplanesDataView)).EndInit();
            this.flightsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataView)).EndInit();
            this.ticketsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataView)).EndInit();
            this.searchTab.ResumeLayout(false);
            this.searchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ViewTabs;
        private System.Windows.Forms.TabPage airlineTab;
        private System.Windows.Forms.TabPage flightsTab;
        private System.Windows.Forms.TabPage ticketsTab;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.DataGridView airplanesDataView;
        private System.Windows.Forms.DataGridView flightsDataView;
        private System.Windows.Forms.DataGridView ticketsDataView;
        private System.Windows.Forms.DataGridView searchDataView;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label searchDateLb;
        private System.Windows.Forms.DateTimePicker searchDataTime;
        private System.Windows.Forms.Label searchLb;
        private System.Windows.Forms.CheckBox searchCB;
    }
}