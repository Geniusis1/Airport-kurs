using Airport_kurs.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Airport_kurs.Forms
{
	public partial class AddDbForm : Form
	{
		private readonly int table;
		private readonly AirportContext db;

		public AddDbForm(int table , AirportContext db)
		{
			InitializeComponent();

			this.table = table;
			this.db = db;

			//Заполнение combobox
			foreach(var i in db.Airlines)
			{
				airplanesAirlineCb.Items.Add(i.Name);
				ticketAirlineCb.Items.Add(i.Name);
			}
			foreach(var i in db.Countries)
			{
				flightInCb.Items.Add(i.Name);
				flightToCb.Items.Add(i.Name);
			}

			int tabs = tabControl1.TabCount;
			int count = 0;

			//Убираем все вкладки
			for (int i = 0; i < tabs; i++)
			{
				if(i != table)
				{
					tabControl1.TabPages.RemoveAt(count);
				}
				else
				{
					count++;
				}
			}
		}

		private void saveBt_Click(object sender, System.EventArgs e)
		{
			//По выбранной таблице создается новый обьект и добавляется в БД
			switch (table)
			{
				case 0:
					var airline = new Airline();
					airline.Name = airlineNameTb.Text;
					db.Add(airline);
					break;
				case 1:
					var airplane = new Airplane();
					airplane.AirlineId = db.Airlines.First(t => t.Name == airplanesAirlineCb.Text).Id;
					airplane.Type = airplanesTypeTb.Text;
					db.Add(airplane);
					break;
				case 2:
					var countrie = new Countrie();
					countrie.Name = cityNameTb.Text;
					db.Add(countrie);
					break;
				case 3:
					var flight = new Flight();
					flight.InCountryId = db.Countries.First(t => t.Name == flightInCb.Text).Id;
					flight.ToCountryId = db.Countries.First(t => t.Name == flightToCb.Text).Id;
					flight.DepartureTime = flightTimeInDate.Value;
					flight.ArrivalTime = flightTimeToDate.Value;
					flight.ArrivalTimeSchedule = flightTimeToDate.Value;
					flight.People = 0;
					try
					{
						flight.MaxPeople = int.Parse(flightMaxPassTb.Text);
					}
					catch (Exception)
					{
						MessageBox.Show("Ошибка!");
						return;
					}
					db.Add(flight);
					break;
				case 4:
					var ticket = new Ticket();
					
					ticket.AirlineId = db.Airlines.First(t => t.Name == ticketAirlineCb.Text).Id;
					ticket.Class = ticketClassCb.Text;

					try
					{
						ticket.FlightId = int.Parse(ticketFlightIdTb.Text);
						ticket.AirplaneId = int.Parse(ticketAirplaneTb.Text);
						ticket.Cost = int.Parse(ticketPriceTb.Text);
					}
					catch (Exception)
					{
						MessageBox.Show("Ошибка!");
						return;
					}
					db.Add(ticket);
					break;
			}

			//Сохранение изменений
			db.SaveChanges();
			Close();
		}

		private void exitBt_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
