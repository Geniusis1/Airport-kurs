using System;
using System.Linq;
using System.Windows.Forms;
using Airport_kurs.Models;
using Microsoft.EntityFrameworkCore;

namespace Airport_kurs
{
    public partial class LogReg : Form
    {
        private AirportContext db;

        public LogReg()
        {
            InitializeComponent();
            ClearTb();
            lgErrorsLb.Text = "";
            regErrorsLb.Text = "";

            db = AirportContext.GetAirportContext();
        }

        private void regRegBt_Click(object sender, EventArgs e)
        {
			string username = regLoginTb.Text.Trim();
            string password = regPassTb.Text;

			/*
             * Уровень доступа будет хранится в типе int.
             * admin = 2
             * oper = 1
             * user = 0
             */

            int access = regUserRb.Checked ? 0 : regOperRb.Checked ? 1 : regAdminRb.Checked ? 2 : 0;

            //--Проверка на заполенине всех полей
            if (username == "" || password == "")
            {
                regErrorsLb.Text = "Ошибка регистрации!";
                return;
            }

            //--Проверка свободности логина
            var users = db.Users.FirstOrDefault(u => u.Username == username);

            if (users != null)
            {
                regErrorsLb.Text = "Логин занят.";
                ClearTb();
                return;
            }

			//--Занесение информации в БД
			try
            {
                User newUser = new User(username, password, access);

                //Добавляем пользователя в бд
                db.Users.Add(newUser);

                try
                {
                    //Записываем изменения в бд
                    db.SaveChanges();
                }
                catch (DbUpdateException)
                {
					//Ошибка, возникающая когда в бд нет нужной таблицы
					regErrorsLb.Text = "Ошибка БД. Смените БД на валидную!!!";
                    return;
                }

                ClearTb();

                //Вывод сообщения об успешной регистрации
                MessageBox.Show("Регистрация прошла успешно.");
            }
            catch (Exception)
            {
                //Любая другая ошибка
                regErrorsLb.Text = "Ошибка регистрации!";
            }
        }

        private void lgChangeBdBt_Click(object sender, EventArgs e)
        {
            //Смена файла бд
            db = AirportContext.ChangeDatabase();
        }

        private void lgLoginBt_Click(object sender, EventArgs e)
        {
            string username = lgLoginTb.Text;
            string password = User.PassToHashString(lgPassTb.Text);

            //--Проверка на заполенине всех полей
            if (username == "" || password == "")
            {
                lgErrorsLb.Text = "Такого пользователя не существует.";
                ClearTb();
                return;
            }

            //--Поиск пользователя по логину
            var users = db.Users.First(u => u.Username == username);

            if (users == null)
            {
                lgErrorsLb.Text = "Такого пользователя не существует.";
                ClearTb();
                return;
            }

            //--Сравнение пароля
            if (!users.ComparisonHash(password))
            {
                lgErrorsLb.Text = "Такого пользователя не существует.";
                ClearTb();
                return;
            }

            var view = new View(users.AccessLvl, this, db);
            this.Hide();
            view.ShowDialog();
        }

        private void ClearTb()
        {
            //Отчистка полей
            lgLoginTb.Text = "";
            lgPassTb.Text = "";
            regLoginTb.Text = "";
            regPassTb.Text = "";
        }
    }
}
