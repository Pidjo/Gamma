using MySql.Data.MySqlClient;
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
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 32);
        }

        private void clouseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); 
        } 

        Point LastPoint;
        
        private void LoginForm1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void LoginForm1_MouseDown(object sender, MouseEventArgs e)
        {   
            LastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String LoginUser = loginField.Text;
            String passUser = passField.Text;
            
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `password`= @uP", db.getConnection());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP",MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {   
                this.Hide();
                MainForm1 mainForm1 = new MainForm1();
                mainForm1.Show();
            }
            else 
                MessageBox.Show("No");
            }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
