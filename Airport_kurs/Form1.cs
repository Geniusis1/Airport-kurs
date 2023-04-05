using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            regErrorsLb.Text = "";
            lgErrorsLb.Text = "";

            //Подключение к БД
            //Тут должен быть код, но пока просто коменты (. )_(. ) 
        }

        private void regRegBt_Click(object sender, EventArgs e)
        {
            //Проверка на заполенине всех полей
            if (regLoginTb.Text == null || regPassTb.Text == null
                || (!regUserRb.Checked && !regOperRb.Checked && !regAdminRb.Checked))
            {
                regErrorsLb.Text = "Ошибка регистрации!";
                return;
            }

            //Занесение информации в БД

        }
    }
}
