namespace Airport_kurs
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
            this.loginRegTab = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.lgErrorsLb = new System.Windows.Forms.Label();
            this.lgLoginBt = new System.Windows.Forms.Button();
            this.lgRegTb = new System.Windows.Forms.TextBox();
            this.lgPassLb = new System.Windows.Forms.Label();
            this.lgLogingLb = new System.Windows.Forms.Label();
            this.lgLoginTb = new System.Windows.Forms.TextBox();
            this.regPage = new System.Windows.Forms.TabPage();
            this.regUserRb = new System.Windows.Forms.RadioButton();
            this.regOperRb = new System.Windows.Forms.RadioButton();
            this.regAdminRb = new System.Windows.Forms.RadioButton();
            this.regErrorsLb = new System.Windows.Forms.Label();
            this.regRegBt = new System.Windows.Forms.Button();
            this.regPassTb = new System.Windows.Forms.TextBox();
            this.regPassLb = new System.Windows.Forms.Label();
            this.regLoginLb = new System.Windows.Forms.Label();
            this.regLoginTb = new System.Windows.Forms.TextBox();
            this.loginRegTab.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.regPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginRegTab
            // 
            this.loginRegTab.Controls.Add(this.loginPage);
            this.loginRegTab.Controls.Add(this.regPage);
            this.loginRegTab.Location = new System.Drawing.Point(12, 12);
            this.loginRegTab.Name = "loginRegTab";
            this.loginRegTab.SelectedIndex = 0;
            this.loginRegTab.Size = new System.Drawing.Size(776, 426);
            this.loginRegTab.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.lgErrorsLb);
            this.loginPage.Controls.Add(this.lgLoginBt);
            this.loginPage.Controls.Add(this.lgRegTb);
            this.loginPage.Controls.Add(this.lgPassLb);
            this.loginPage.Controls.Add(this.lgLogingLb);
            this.loginPage.Controls.Add(this.lgLoginTb);
            this.loginPage.Location = new System.Drawing.Point(4, 25);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(768, 397);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "Вход";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // lgErrorsLb
            // 
            this.lgErrorsLb.AutoSize = true;
            this.lgErrorsLb.Location = new System.Drawing.Point(16, 366);
            this.lgErrorsLb.Name = "lgErrorsLb";
            this.lgErrorsLb.Size = new System.Drawing.Size(61, 17);
            this.lgErrorsLb.TabIndex = 12;
            this.lgErrorsLb.Text = "Ошибки";
            // 
            // lgLoginBt
            // 
            this.lgLoginBt.Location = new System.Drawing.Point(110, 160);
            this.lgLoginBt.Name = "lgLoginBt";
            this.lgLoginBt.Size = new System.Drawing.Size(118, 23);
            this.lgLoginBt.TabIndex = 4;
            this.lgLoginBt.Text = "Войти";
            this.lgLoginBt.UseVisualStyleBackColor = true;
            // 
            // lgRegTb
            // 
            this.lgRegTb.Location = new System.Drawing.Point(51, 117);
            this.lgRegTb.Name = "lgRegTb";
            this.lgRegTb.Size = new System.Drawing.Size(178, 22);
            this.lgRegTb.TabIndex = 3;
            // 
            // lgPassLb
            // 
            this.lgPassLb.AutoSize = true;
            this.lgPassLb.Location = new System.Drawing.Point(54, 96);
            this.lgPassLb.Name = "lgPassLb";
            this.lgPassLb.Size = new System.Drawing.Size(57, 17);
            this.lgPassLb.TabIndex = 2;
            this.lgPassLb.Text = "Пароль";
            // 
            // lgLogingLb
            // 
            this.lgLogingLb.AutoSize = true;
            this.lgLogingLb.Location = new System.Drawing.Point(51, 44);
            this.lgLogingLb.Name = "lgLogingLb";
            this.lgLogingLb.Size = new System.Drawing.Size(47, 17);
            this.lgLogingLb.TabIndex = 1;
            this.lgLogingLb.Text = "Логин";
            // 
            // lgLoginTb
            // 
            this.lgLoginTb.Location = new System.Drawing.Point(51, 67);
            this.lgLoginTb.Name = "lgLoginTb";
            this.lgLoginTb.Size = new System.Drawing.Size(178, 22);
            this.lgLoginTb.TabIndex = 0;
            // 
            // regPage
            // 
            this.regPage.Controls.Add(this.regUserRb);
            this.regPage.Controls.Add(this.regOperRb);
            this.regPage.Controls.Add(this.regAdminRb);
            this.regPage.Controls.Add(this.regErrorsLb);
            this.regPage.Controls.Add(this.regRegBt);
            this.regPage.Controls.Add(this.regPassTb);
            this.regPage.Controls.Add(this.regPassLb);
            this.regPage.Controls.Add(this.regLoginLb);
            this.regPage.Controls.Add(this.regLoginTb);
            this.regPage.Location = new System.Drawing.Point(4, 25);
            this.regPage.Name = "regPage";
            this.regPage.Padding = new System.Windows.Forms.Padding(3);
            this.regPage.Size = new System.Drawing.Size(768, 397);
            this.regPage.TabIndex = 1;
            this.regPage.Text = "Регистрация";
            this.regPage.UseVisualStyleBackColor = true;
            // 
            // regUserRb
            // 
            this.regUserRb.AutoSize = true;
            this.regUserRb.Location = new System.Drawing.Point(283, 114);
            this.regUserRb.Name = "regUserRb";
            this.regUserRb.Size = new System.Drawing.Size(77, 21);
            this.regUserRb.TabIndex = 14;
            this.regUserRb.TabStop = true;
            this.regUserRb.Text = "Клиент";
            this.regUserRb.UseVisualStyleBackColor = true;
            // 
            // regOperRb
            // 
            this.regOperRb.AutoSize = true;
            this.regOperRb.Location = new System.Drawing.Point(283, 87);
            this.regOperRb.Name = "regOperRb";
            this.regOperRb.Size = new System.Drawing.Size(95, 21);
            this.regOperRb.TabIndex = 13;
            this.regOperRb.TabStop = true;
            this.regOperRb.Text = "Оператор";
            this.regOperRb.UseVisualStyleBackColor = true;
            // 
            // regAdminRb
            // 
            this.regAdminRb.AutoSize = true;
            this.regAdminRb.Location = new System.Drawing.Point(283, 60);
            this.regAdminRb.Name = "regAdminRb";
            this.regAdminRb.Size = new System.Drawing.Size(132, 21);
            this.regAdminRb.TabIndex = 12;
            this.regAdminRb.TabStop = true;
            this.regAdminRb.Text = "Администратор";
            this.regAdminRb.UseVisualStyleBackColor = true;
            // 
            // regErrorsLb
            // 
            this.regErrorsLb.AutoSize = true;
            this.regErrorsLb.Location = new System.Drawing.Point(19, 363);
            this.regErrorsLb.Name = "regErrorsLb";
            this.regErrorsLb.Size = new System.Drawing.Size(61, 17);
            this.regErrorsLb.TabIndex = 11;
            this.regErrorsLb.Text = "Ошибки";
            // 
            // regRegBt
            // 
            this.regRegBt.Location = new System.Drawing.Point(97, 153);
            this.regRegBt.Name = "regRegBt";
            this.regRegBt.Size = new System.Drawing.Size(118, 23);
            this.regRegBt.TabIndex = 9;
            this.regRegBt.Text = "Создать";
            this.regRegBt.UseVisualStyleBackColor = true;
            this.regRegBt.Click += new System.EventHandler(this.regRegBt_Click);
            // 
            // regPassTb
            // 
            this.regPassTb.Location = new System.Drawing.Point(38, 110);
            this.regPassTb.Name = "regPassTb";
            this.regPassTb.Size = new System.Drawing.Size(178, 22);
            this.regPassTb.TabIndex = 8;
            // 
            // regPassLb
            // 
            this.regPassLb.AutoSize = true;
            this.regPassLb.Location = new System.Drawing.Point(41, 89);
            this.regPassLb.Name = "regPassLb";
            this.regPassLb.Size = new System.Drawing.Size(57, 17);
            this.regPassLb.TabIndex = 7;
            this.regPassLb.Text = "Пароль";
            // 
            // regLoginLb
            // 
            this.regLoginLb.AutoSize = true;
            this.regLoginLb.Location = new System.Drawing.Point(38, 37);
            this.regLoginLb.Name = "regLoginLb";
            this.regLoginLb.Size = new System.Drawing.Size(47, 17);
            this.regLoginLb.TabIndex = 6;
            this.regLoginLb.Text = "Логин";
            // 
            // regLoginTb
            // 
            this.regLoginTb.Location = new System.Drawing.Point(38, 60);
            this.regLoginTb.Name = "regLoginTb";
            this.regLoginTb.Size = new System.Drawing.Size(178, 22);
            this.regLoginTb.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginRegTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loginRegTab.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.regPage.ResumeLayout(false);
            this.regPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl loginRegTab;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.TabPage regPage;
        private System.Windows.Forms.Label lgLogingLb;
        private System.Windows.Forms.TextBox lgLoginTb;
        private System.Windows.Forms.Button lgLoginBt;
        private System.Windows.Forms.TextBox lgRegTb;
        private System.Windows.Forms.Label lgPassLb;
        private System.Windows.Forms.Button regRegBt;
        private System.Windows.Forms.TextBox regPassTb;
        private System.Windows.Forms.Label regPassLb;
        private System.Windows.Forms.Label regLoginLb;
        private System.Windows.Forms.TextBox regLoginTb;
        private System.Windows.Forms.Label regErrorsLb;
        private System.Windows.Forms.Label lgErrorsLb;
        private System.Windows.Forms.RadioButton regUserRb;
        private System.Windows.Forms.RadioButton regOperRb;
        private System.Windows.Forms.RadioButton regAdminRb;
    }
}

