using System;
using System.Windows.Forms;
using Airport_kurs.Models;

namespace Airport_kurs
{
    public partial class Form1 : Form
    {
        private AirportContext db;

        public Form1()
        {
            InitializeComponent();
            regErrorsLb.Text = "";
            lgErrorsLb.Text = "";

            db = AirportContext.GetAirportContext();
        }

        private void regRegBt_Click(object sender, EventArgs e)
        {
            //--Проверка на заполенине всех полей
            if (regLoginTb.Text == null || regPassTb.Text == null
                || (!regUserRb.Checked && !regOperRb.Checked && !regAdminRb.Checked))
            {
                regErrorsLb.Text = "Ошибка регистрации!";
                return;
            }

            //--Занесение информации в БД
            try
            {
                string username = regLoginTb.Text;
                string password = regPassTb.Text;
                int access = regUserRb.Checked ? 0 : regOperRb.Checked ? 1 : regAdminRb.Checked ? 2 : 0;

                User newUser = new User(username, password, access);

                db.Users.Add(newUser);

                try
                {
                    db.SaveChanges();
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException)
                {
                    MessageBox.Show("Ошибка БД. Смените БД на валидную!!!");
                    return;
                }

                regLoginTb.Text = "";
                regPassTb.Text = "";
                MessageBox.Show("Регистрация прошла успешно");
            }
            catch (InvalidOperationException ex)
            {
#if DEBUG
                regLoginTb.Text = ex.ToString();
#else
                regErrorsLb.Text = "Ошибка регистрации!";
#endif
            }
        }

        private void lgChangeBdBt_Click(object sender, EventArgs e)
        {
            //Смена файла бд
            db = AirportContext.ChangeDatabase();
        }
    }
}
