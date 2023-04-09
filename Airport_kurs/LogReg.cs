using System;
using System.Windows.Forms;
using Airport_kurs.Models;

namespace Airport_kurs
{
    public partial class LogReg : Form
    {
        private AirportContext db;

        public LogReg()
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
                /*
                 * Уровень доступа будет хранится в типе int.
                 * admin = 2
                 * oper = 1
                 * user = 0
                 */
                int access = regUserRb.Checked ? 0 : regOperRb.Checked ? 1 : regAdminRb.Checked ? 2 : 0;

                User newUser = new User(username, password, access);

                //Добавляем пользователя в бд
                db.Users.Add(newUser);

                try
                {
                    //Записываем изменения в бд
                    db.SaveChanges();
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException)
                {
                    //Ошибка, возникающая когда в бд нет нужной таблицы
                    MessageBox.Show("Ошибка БД. Смените БД на валидную!!!");
                    return;
                }

                //Отчистка полей
                regLoginTb.Text = "";
                regPassTb.Text = "";

                //Вывод сообщения об успешной регистрации
                MessageBox.Show("Регистрация прошла успешно");
            }
            catch (Exception ex)
            {
                //Любая другая ошибка
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
