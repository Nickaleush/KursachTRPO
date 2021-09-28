using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR0Moroz
{
    public partial class Form4 : Form
    {
        public Form1 otherForm;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            otherForm = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
            if (Convert.ToDateTime(otherForm.dataGridView1[3, 0].Value) > DatePick.Value) 
            {
                otherForm.dataGridView1.Rows.Clear();
                otherForm.ShowDialog();
            }
        }
    }
}
