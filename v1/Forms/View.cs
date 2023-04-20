using Airport_kurs.Attr;
using Airport_kurs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Airport_kurs
{
    public partial class View : Form
    {
        private readonly Type[] tabsClass;
        private readonly DataGridView[] tabs;

        private readonly int accessLvl;
        private readonly Form logReg;
        private readonly AirportContext db;

        #region Constructor
        /*
         * Уровень доступа будет хранится в типе int.
         * admin = 2
         * oper = 1
         * user = 0
         */

        public View(int accessLvl, Form logReg, AirportContext db)
        {
            //По заданию доступ имеет только admin
            //Если не админ, то закрываем окно
            if (accessLvl != 2)
            {
                UserError();
                return;
            }

            this.accessLvl = accessLvl;
            //Сохраняем ссылку на окно входа/регистрации и на БД
            this.logReg = logReg;
            this.db = db;

            InitializeComponent();
            
            //ОБЯЗАТЕЛЬНО должны быть в одинаковом порядке
            tabsClass = new Type[] { typeof(Airplane), typeof(Flight), typeof(Ticket) };
            tabs = new DataGridView[] { airplanesDataView, flightsDataView, ticketsDataView };
            

            ConstructTables();

        }

        //Метод добавляющий столбцы в тублицы просмотра ДБ
        private void ConstructTables()
        {
            /*
             * Для получения столбцов используется рефлексию
             * получаем тип, смотрим какие у него поля
             * Заносим поля, как название столбцов
             */

            for (int i = 0; i < tabs.Length; i++)
            {
                foreach (var field in TypeExtensions.GetFilteredProperties(tabsClass[i]))
                {
                    tabs[i].Columns.Add(field.Name, field.Name);
                }
            }
            UpdateTabs();

            //Таблица поиска
            searchDataView.Columns.Add("InCountry", "InCountry");
            searchDataView.Columns.Add("ToCountry", "ToCountry");
            searchDataView.Columns.Add("DepartureTime", "DepartureTime");
            searchDataView.Columns.Add("Availability of tickets", "Availability of tickets");
        }

        private void UserError()
        {
            MessageBox.Show("Ошибка, просмотр информации доступен только для администратора");
            //logReg.Show();
        }
        #endregion

        private void UpdateTabs()
        {
            tabs[0].Rows.Clear();
            tabs[1].Rows.Clear();
            tabs[2].Rows.Clear();
            //Airplanes
            foreach (var i in db.Airplanes.ToList())
            {
                tabs[0].Rows.Add(i.Id, i.AirlineId, i.Type);
            }
            //Flight
            foreach (var i in db.Flights.ToList())
            {
                tabs[1].Rows.Add(i.Id, i.InCountryId, i.ToCountryId,
                    i.DepartureTime, i.ArrivalTimeSchedule, i.ArrivalTime, i.MaxPeople, i.People);
            }
            //Ticket
            foreach (var i in db.Tickets.ToList())
            {
                tabs[2].Rows.Add(i.Id, i.FlightId, i.AirplaneId, i.AirlineId, i.Class, i.Cost);
            }
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            //Получаем все полеты
            List<Flight> data = db.Flights.ToList();
            List<Flight> remove = new List<Flight>();

            //Если вписана страна, убираем все что не соответствует
            if (searchTb.Text != "")
            {
                //Получаем id страны (Используем LINQ)
                int countryId = db.Countries.Where(t => t.Name == searchTb.Text).First().Id;
                foreach (var i in data)
                {
                    if (i.ToCountryId != countryId)
                    {
                        //Добавляем в список удаления
                        remove.Add(i);
                    }
                }
            }

            //Если активна дата, то убираем все что не соответстувет
            if (searchDataTime.Enabled)
            {
                //Получаем дату
                DateTime date = searchDataTime.Value.Date;
                foreach (var i in data)
                {
                    Console.WriteLine(date + " " + i.DepartureTime.Date);
                    if (i.DepartureTime.Date != date)
                    {
                        //Добавляем в список удаления
                        remove.Add(i);
                    }
                }
            }

            //Удаляем повторения
            remove = remove.Distinct().ToList();

            //Удаляем из списка все ненужное
            foreach(var i in remove)
            {
                data.Remove(i);
            }

            //Чистим таблицу
            searchDataView.Rows.Clear();

            //Выводим таблицу
            foreach (var i in data)
            {
                string inCountry = db.Countries.Where(t => t.Id == i.InCountryId).First().Name;
                string toCountry = db.Countries.Where(t => t.Id == i.ToCountryId).First().Name;
                bool places = i.People < i.MaxPeople;

                searchDataView.Rows.Add(inCountry, toCountry, i.DepartureTime, places);
            }
        }

        private void searchCB_CheckedChanged(object sender, EventArgs e)
        {
            searchDataTime.Enabled = searchCB.Checked;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Подтверждение закрития приложения
            switch (MessageBox.Show(this, "Вы хотите выйти", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Application.Exit();
                    break;
            }
        }
    }
}
