using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamma
{
    public partial class FormSeans : Form
    {
        public FormSeans()
        {
            InitializeComponent();
        }
        ClassSeans s = new ClassSeans();

        private bool flag;

        string[] Title = { "Месть чебурашки", "Убить Билли Бонса", "Пираты реки Великой", "Пипа", "Биба и Боба", "Волк из Комарово", "Любовь и вороны", "Карпараська" };
        string[] Genre = { "боевик", "драмма", "комедия", "биография", "спорт", "ужасы", "триллер", "детектив" };
        string[] Data = { "ПН", "ВТ", "СР", "ЧТ", "ПТ", "СБ", "ВС" };
        string[] Hall = { "Зал 1", "Зал 2", "Зал 3" };
        string[] Time = { "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00" };

        Random rng = new Random();
        int count = 0;

        public void NewSeans()
        {
            while (flag)
            {
                string title = Title[rng.Next(0, Title.Length)];
                string genre = Genre[rng.Next(0, Genre.Length)];
                string data = Data[rng.Next(0, Data.Length)];
                string hall = Hall[rng.Next(0, Hall.Length)];
                string time = Time[rng.Next(0, Time.Length)];
                s.Add_to_Seans(title, genre, data, hall, time);
                count++;
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            Task.Run(() => NewSeans());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void FormSeans_Load(object sender, EventArgs e)
        {
            dataSeans.DataSource = s.Seans();
        }
     

    }
}
