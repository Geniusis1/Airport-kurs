using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.IO;
using System.Windows.Forms;

namespace Airport_kurs.Models
{
    public class AirportContext : DbContext
    {
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Countrie> Countries { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        private string pathDb = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(pathDb);
        }

        private void SetPathDatabase(string path)
        {
            pathDb = "Data Source=" + path;
        }

        private static void CreateDialogWindowFileDB(AirportContext db, RegistryKey key)
        {
            //Создаем диалоговое окно для выбора файла базы данных
            var dialog = new OpenFileDialog();
            dialog.FileName = "Database";
            dialog.DefaultExt = ".db";
            dialog.Filter = "Database (.db)|*.db";

            //Октрываем диалоговое окно
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Если все хорошо, то устанавливаем путь к БД
                db.SetPathDatabase(dialog.FileName);
                //Записываем путь в реестр
                key.SetValue("dbPath", dialog.FileName);
                //Закрываем диалоговое окно (освобождаем ресурсы) 
                dialog.Dispose();
            }
            else
            {
                //!!! -- ПРИДУМАТЬ ЧТО ТО ИНОЕ -- !!!)
                //Если не удалось открыть, то закрываем приложение
                Application.Exit();
            }
        }

        public static AirportContext ChangeDatabase()
        {
            AirportContext db = new AirportContext();
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\OurSettings");
            CreateDialogWindowFileDB(db, key);
            
            //Закрываем реестр (освобождаем ресурсы)
            key.Close();

            return db;
        }

        public static AirportContext GetAirportContext()
        {
            //--Подключение к БД
            AirportContext db = new AirportContext();
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\OurSettings");

            //Путь к файлу бд будет храниться в реестре
            try
            {
                string path = key.GetValue("dbPath", null).ToString();

                //Если нет в реестре, то выбираем файл в проводнике
                if (path == null)
                {
                    CreateDialogWindowFileDB(db, key);
                }
                //Если есть, то проверяем файл и записываем путь
                else
                {
                    if (File.Exists(path))
                    {
                        db.SetPathDatabase(path);
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                //При первом запуске, еще не существует данного параметра в реестре
                CreateDialogWindowFileDB(db, key);
            }
            finally
            {
                //Закрываем реестр (освобождаем ресурсы)
                key.Close();
            }
            return db;
        }


		public static void Update<TEntity>(TEntity entity, DbContext context)
	where TEntity : class
		{
			context.Entry(entity).State = EntityState.Modified;
			context.SaveChanges();
		}
	}
}
