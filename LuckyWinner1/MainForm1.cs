using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamma
{
    public partial class MainForm1 : Form
    {
        private Form activeForm;
        public MainForm1()
        {
            InitializeComponent();
        }

        private void clouseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void OpenFormSeans(Form FormSeans, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            
            activeForm = FormSeans;
            FormSeans.TopLevel = false;
            FormSeans.FormBorderStyle = FormBorderStyle.None;
            FormSeans.Dock = DockStyle.Fill;
            this.panelSeans.Controls.Add(FormSeans);
            this.panelSeans.Tag = FormSeans;
            FormSeans.BringToFront();
            FormSeans.Show();
            labelTItle.Text = FormSeans.Text;


        }

        private void buttonSeans_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             FormSeans a = new FormSeans();
             a.Show();*/
            OpenFormSeans(new FormSeans(), sender);
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }
        private void OpenFormTicket(Form FormTicket, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = FormTicket;
            FormTicket.TopLevel = false;
            FormTicket.FormBorderStyle = FormBorderStyle.None;
            FormTicket.Dock = DockStyle.Fill;
            this.panelSeans.Controls.Add(FormTicket);
            this.panelSeans.Tag = FormTicket;
            FormTicket.BringToFront();
            FormTicket.Show();
            labelTItle.Text = FormTicket.Text;


        }
        private void buttonPokupka_Click(object sender, EventArgs e)
        {
            OpenFormTicket(new FormTicket(), sender);
        }
    }
}
