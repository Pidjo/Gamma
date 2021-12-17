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
    public partial class FormTicket : Form
    {
        public FormTicket()
        {
            InitializeComponent();
        }
        ClassTicket t = new ClassTicket();

        private bool flag;

        string[] Buyer = { "Парень", "Девушка" };
        string[] Ticket = { "1", "2", "3", "4", "5" };
        string[] Title = { "Месть чебурашки", "Убить Билли Бонса", "Пираты реки Великой", "Пипа", "Биба и Боба", "Волк из Комарово", "Любовь и вороны", "Карпараська" };
        string[] Hall = { "Зал 1", "Зал 2", "Зал 3" };
        string[] Data = { "ПН", "ВТ", "СР", "ЧТ", "ПТ", "СБ", "ВС" };
        string[] Time = { "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00" };
        string[] Pay = { "Оплата: онлайн", "Оплата: наличными" };

        Random rng = new Random();
        int count = 0;

        public void NewTicket()
        {
            while (flag)
            {
                string buyer = Buyer[rng.Next(0, Buyer.Length)];
                string ticket = Ticket[rng.Next(0, Ticket.Length)];
                string title = Title[rng.Next(0, Title.Length)];
                string hall = Hall[rng.Next(0, Hall.Length)];
                string data = Data[rng.Next(0, Data.Length)];
                string time = Time[rng.Next(0, Time.Length)];
                string pay = Pay[rng.Next(0, Pay.Length)];
                t.Add_to_Ticket(buyer, ticket, title, hall, data, time, pay);
                count++;
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }



        private void FormTicket_Load(object sender, EventArgs e)
        {
            dataGridViewT.DataSource = t.Ticket();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            flag = true;
            Task.Run(() => NewTicket());
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            flag = false;
        }

    }
}
