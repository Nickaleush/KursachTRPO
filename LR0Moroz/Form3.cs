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
    public partial class Form3 : Form
    {
        public Form1 otherForm;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            otherForm = form1;
        }

      

        private void EditButton_Click(object sender, EventArgs e)
        {
            otherForm.dataGridView1.SelectedCells[0].Value = EditOrder.Text;
            this.Hide();
        }
    }
}
