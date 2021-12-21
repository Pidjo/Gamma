using Gamma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyWinner1
{
    public partial class FormOtchet : Form
    {
        public FormOtchet()
        {
            InitializeComponent();
        }
        ClassOtchet o = new ClassOtchet();
        private void FormOtchet_Load(object sender, EventArgs e)
        {
            dataGridViewO.DataSource = o.Otchet();
        }
    }
}
