using Airport_kurs.Forms;
using Airport_kurs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Airport_kurs
{
    public partial class View : Form
    {
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
            this.accessLvl = accessLvl;
            //Сохраняем ссылку на окно входа/регистрации и на БД
            this.logReg = logReg;
            this.db = db;

			InitializeComponent();
            ConstructTables();

			//Условия для ограничений доступа к БД

			//Удаление в базе даннх
			//groupBox1.Enabled = false;

			if (accessLvl < 1)
			{
				ViewTabs.TabPages.Remove(dbConfTab);
			}
			if (accessLvl < 2)
			{
				delForIdGb.Enabled = false;
				dbSwitch.Items.RemoveAt(5);
			}
		}

        //Метод добавляющий столбцы в таблицы просмотра БД
        private void ConstructTables()
        {
			AddInfInColums(airplanesDataView, 1);
			AddInfInColums(flightsDataView, 3);
			AddInfInColums(ticketsDataView, 4);

			//Таблица поиска рейсов
			searchDataView.Columns.Add("Город вылета", "Город вылета");
            searchDataView.Columns.Add("Город прилета", "Город прилета");
            searchDataView.Columns.Add("Дата и время вылета", "Дата и время вылета");
            searchDataView.Columns.Add("Наличие билетов", "Наличие билетов");

            //Таблица задержек
            delaysDataView.Columns.Add("Id рейса", "Id рейса");
            delaysDataView.Columns.Add("Город вылета", "Город вылета");
            delaysDataView.Columns.Add("Город прилета", "Город прилета");
            delaysDataView.Columns.Add("Время прилета", "Время прилета");
            delaysDataView.Columns.Add("Статус", "Статус");

			//Таблица поиска билетов
			searchTicketsGridView.Columns.Add("Тип самолета", "Тип самолета");
			searchTicketsGridView.Columns.Add("Класс", "Класс");
			searchTicketsGridView.Columns.Add("Стоймость", "Стоймость");
			searchTicketsGridView.Columns.Add("Время полета", "Время полета");

            UpdateTabs();
        }
		#endregion

		private void UpdateTabs()
        {
			AddInfTable(airplanesDataView, 1, db);
			AddInfTable(flightsDataView, 3, db);
			AddInfTable(ticketsDataView, 4, db);

			//Таблица задержек
			delaysDataView.Rows.Clear();

            foreach (var i in db.Flights.ToList())
            {
                DateTime cancelStr = DateTime.Parse("2000-01-01T00:00");
                //Ищем задержки и отмены
                if (i.ArrivalTimeSchedule.TimeOfDay != i.ArrivalTime.TimeOfDay)
                {
                    delaysDataView.Rows.Add(i.Id,
						db.Countries.First(t => i.InCountryId == t.Id).Name,
                        db.Countries.First(t => i.ToCountryId == t.Id).Name,
                        i.ArrivalTime,
                        //Тенарная операция(сокр if)
                        cancelStr == i.ArrivalTime ? "Отменен" : "Задерживается"
                        );
                }
            }

			searchTicketsCountryCb.Items.Clear();
			searchFlightCountryCb.Items.Clear();
			//Добавление городов в comboBox
			foreach (var i in db.Countries)
			{
				searchTicketsCountryCb.Items.Add(i.Name);
				searchFlightCountryCb.Items.Add(i.Name);
			}
		}

        private void searchBt_Click(object sender, EventArgs e)
        {
            //Получаем все полеты
            List<Flight> data = db.Flights.ToList();
            List<Flight> remove = new List<Flight>();

            //Если вписан город, убираем все что не соответствует
            if (searchFlightCountryCb.Text != "")
            {
                //Получаем id страны (Используем LINQ)
                int countryId = db.Countries.First(t => t.Name == searchFlightCountryCb.Text).Id;
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
                string inCountry = db.Countries.First(t => t.Id == i.InCountryId).Name;
                string toCountry = db.Countries.First(t => t.Id == i.ToCountryId).Name;
                int places = i.MaxPeople - i.People;

                searchDataView.Rows.Add(inCountry, toCountry, i.DepartureTime, places);
            }
        }

		//Checkbox - для поиска
        private void searchCB_CheckedChanged(object sender, EventArgs e)
        {
            searchDataTime.Enabled = searchCB.Checked;
        }

		//Действия при закрытии приложения
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

		//Добавление колонок в основные таблицы
		/// <summary>
		///  0-Airlines 1-Airplanes 2-Countries 3-Flights 4-Tickets 5-Users
		/// </summary>
		/// <param name="table">Таблица в которую добавляются колонки</param>
		/// <param name="tableInDb">Номер таблицы в БД</param>
		private void AddInfInColums(DataGridView table, int tableInDb)
		{
			List<string> columns = new List<string>();

			//По номеру таблицы заполняем список колонок
			columns.Add("Id");
			switch (tableInDb)
			{
				case 0:
					columns.Add("Название");
					break;
				case 1:
					columns.Add("Авиалиния");
					columns.Add("Тип самолета");
					break;
				case 2:
					columns.Add("Город");
					break;
				case 3:
					columns.Add("Город вылета");
					columns.Add("Город прилета");
					columns.Add("Дата и время вылета");
					columns.Add("Дата и время прилета по рассписанию");
					columns.Add("Дата и время прилета");
					columns.Add("Кол-во мест");
					columns.Add("Кол-во купленный билетов");
					break;
				case 4:
					columns.Add("Id рейса");
					columns.Add("Id самолета");
					columns.Add("Авиалиния");
					columns.Add("Класс");
					columns.Add("Стоймость");
					break;
				case 5:
					columns.Add("Логин");
					columns.Add("Пароль");
					columns.Add("Уровень доступа");
					groupBox2.Enabled = false;
					break;
			}

			//Отчиска таблицы от старых колонок
			table.Columns.Clear();

			//Заполнение таблицы колонками
			foreach (var i in columns)
			{
				table.Columns.Add(i, i);
			}
		}

		//Добавление информации в основные таблицы
		/// <summary>
		///  0-Airlines 1-Airplanes 2-Countries 3-Flights 4-Tickets 5-Users
		/// </summary>
		/// <param name="table">Таблица в которую добавляется информация</param>
		/// <param name="tableInDb">Номер таблицы в БД</param>
		private void AddInfTable(DataGridView table, int tableInDb, AirportContext db)
		{
			//Отчистка таблицы
			table.Rows.Clear();

			//По номеру таблицы заполняем информацией таблицу
			switch (tableInDb)
			{
				case 0:
					foreach(var i in db.Airlines.ToList())
					{
						table.Rows.Add(i.Id, i.Name);
					}
					break;
				case 1:
					foreach(var i in db.Airplanes.ToList())
					{
						table.Rows.Add(i.Id, db.Airlines.First(t => i.AirlineId == t.Id).Name, i.Type);
					}
					break;
				case 2:
					foreach(var i in db.Countries.ToList())
					{
						table.Rows.Add(i.Id, i.Name);
					}
					break;
				case 3:
					foreach (var i in db.Flights.ToList())
					{
						table.Rows.Add(i.Id,
							db.Countries.First(t => i.InCountryId == t.Id).Name,
							db.Countries.First(t => i.ToCountryId == t.Id).Name,
							i.DepartureTime.ToString(),
							i.ArrivalTimeSchedule.ToString(),
							i.ArrivalTime.ToString(),
							i.MaxPeople, i.People);
					}
					break;
				case 4:
					foreach(var i in db.Tickets.ToList())
					{
						table.Rows.Add(i.Id, i.FlightId, i.AirplaneId,
							db.Airlines.First(t => i.AirlineId == t.Id).Name,
							i.Class, i.Cost);
					}
					break;
				case 5:
					foreach(var i in db.Users.ToList())
					{
						table.Rows.Add(i.Id, i.Username, i.Password, i.AccessLvl);
					}
					break;
			}
		}

		#region EditDB

		//Заполнение таблицы для просмотра и изменения БД
		private void dbSwitch_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Добавление колонок
			AddInfInColums(editDbGridView, dbSwitch.SelectedIndex);
			
			//Добавление информации
			AddInfTable(editDbGridView, dbSwitch.SelectedIndex, db);
		}

		//Кнопка удаления по ID
		private void deleteDbBt_Click(object sender, EventArgs e)
		{
			int id;

			//Получаем id
			try
			{
				id = int.Parse(idDeleteDbTb.Text);
			}
			catch (Exception) { return; }

			try
			{
				//По id и выбранной таблице удаляется строка
				switch (dbSwitch.SelectedIndex)
				{
					case 0:
						db.Airlines.Remove(db.Airlines.First(t => t.Id == id));
						break;
					case 1:
						db.Airplanes.Remove(db.Airplanes.First(t => t.Id == id));
						break;
					case 2:
						db.Countries.Remove(db.Countries.First(t => t.Id == id));
						break;
					case 3:
						db.Flights.Remove(db.Flights.First(t => t.Id == id));
						break;
					case 4:
						db.Tickets.Remove(db.Tickets.First(t => t.Id == id));
						break;
					case 5:
						db.Users.Remove(db.Users.First(t => t.Id == id));
						break;
					default: return;
				}
			}
			catch (Exception) { }

			//Сохранение изменений в БД
			db.SaveChanges();
			//Обновление информации в окне
			AddInfTable(editDbGridView, dbSwitch.SelectedIndex, db);
		}

		#region SaveChangeInTable

		//Действие при изменении информации в окне
		private void editDbGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				//По строке получаем id элемента
				int row = e.RowIndex;
				int id = (int)editDbGridView[0, row].Value;
				
				//Заменяем в зависимости от выбранной таблицы
				switch (dbSwitch.SelectedIndex)
				{
					case 0:
						var airline = db.Airlines.First(t => t.Id == id);

						airline.Name = (string)editDbGridView[1, row].Value;

						db.Update(airline);
						break;
					case 1:
						var airplane = db.Airplanes.First(t => t.Id == id);

						airplane.AirlineId = db.Airlines.First(t => t.Name == (string)editDbGridView[1, row].Value).Id;
						airplane.Type = (string)editDbGridView[2, row].Value;

						db.Update(airplane);
						break;
					case 2:
						var countrie = db.Countries.First(t => t.Id == id);
						
						countrie.Name = (string)editDbGridView[1, row].Value;

						db.Update(countrie);
						break;
					case 3:
						var flight = db.Flights.First(t => t.Id == id);

						flight.InCountryId = db.Countries.First(t => t.Name == (string)editDbGridView[1, row].Value).Id;
						flight.ToCountryId = db.Countries.First(t => t.Name == (string)editDbGridView[2, row].Value).Id;
						flight.DepartureTime = DateTime.Parse((string)editDbGridView[3, row].Value);
						flight.ArrivalTimeSchedule = DateTime.Parse((string)editDbGridView[4, row].Value);
						flight.ArrivalTime = DateTime.Parse((string)editDbGridView[5, row].Value);
						flight.MaxPeople = (int)editDbGridView[6, row].Value;
						flight.MaxPeople = (int)editDbGridView[7, row].Value;

						db.Update(flight);
						break;
					case 4:
						var ticket = db.Tickets.First(t => t.Id == id);

						ticket.FlightId = (int)editDbGridView[1, row].Value;
						ticket.AirplaneId = (int)editDbGridView[2, row].Value;
						ticket.AirlineId = (int)editDbGridView[3, row].Value;
						ticket.Class = (string)editDbGridView[4, row].Value;
						ticket.Cost = (int)editDbGridView[5, row].Value;

						db.Update(ticket);
						break;
					case 5:
						var user = db.Users.First(t => t.Id == id);

						user.Username = (string)editDbGridView[1, row].Value;
						user.Password = (string)editDbGridView[2, row].Value;
						user.AccessLvl = (int)editDbGridView[3, row].Value;

						db.Update(user);
						break;
				}
			}
			catch (Exception)
			{
				//Вывод сообщения об ошибки, если не получилось сохранить данные
				MessageBox.Show("Не удалось сохранить. Проверте правильность данных!");
				AddInfTable(editDbGridView, dbSwitch.SelectedIndex, db);
				return;
			}

			//Сохранение изменений в БД и обновление всех таблиц
			db.SaveChanges();
			UpdateTabs();
		}
		
		//Создание нового элемента в таблице
		private void createNewRowBt_Click(object sender, EventArgs e)
		{
			var view = new AddDbForm(dbSwitch.SelectedIndex, db);
			view.ShowDialog();
			AddInfTable(editDbGridView, dbSwitch.SelectedIndex, db);
		}

		#endregion

		#endregion

		//Кнопка поиска рейсов
		private void searchTicketsBt_Click(object sender, EventArgs e)
		{
			searchTicketsGridView.Rows.Clear();

			foreach (var i in db.Tickets)
			{
				Flight flight = db.Flights.First(t => t.Id == i.FlightId);
				if (flight.ToCountry.Name == searchTicketsCountryCb.Text)
				{
					//Заполение таблицы
					var time = flight.ArrivalTimeSchedule.Subtract(flight.DepartureTime);
					searchTicketsGridView.Rows.Add(
						db.Airplanes.First(t => t.Id == i.AirplaneId).Type,
						i.Class,
						i.Cost,
						time);
				}
			}
		}

		private void delaysSearchBt_Click(object sender, EventArgs e)
		{
			delaysDataView.Rows.Clear();
			foreach (var i in db.Flights.ToList())
			{
				DateTime cancelStr = DateTime.Parse("2000-01-01T00:00");
				//Ищем задержки и отмены по фильтру
				if (i.ArrivalTimeSchedule != i.ArrivalTime &&
					i.ArrivalTimeSchedule.Date == delaysDate.Value.Date)
				{
					delaysDataView.Rows.Add(i.Id, db.Countries.First(t => i.InCountryId == t.Id).Name,
						db.Countries.First(t => i.ToCountryId == t.Id).Name,
						i.ArrivalTime,
						//Тенарная операция(сокр if)
						cancelStr == i.ArrivalTime ? "Отменен" : "Задерживается"
						);
				}
			}
		}

		private void reloadTablesBt_Click(object sender, EventArgs e)
		{
			UpdateTabs();
		}

		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			var sort = System.ComponentModel.ListSortDirection.Ascending;

			if (radioButton1.Checked)
			{
				searchTicketsGridView.Sort(searchTicketsGridView.Columns[2], sort);
			}
			else
			{
				searchTicketsGridView.Sort(searchTicketsGridView.Columns[3], sort);
			}
		}
		
	}
}