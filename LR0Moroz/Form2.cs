using System;
using System.Windows.Forms;

namespace LR0Moroz
{
    public partial class AddOrderForm : Form
    {
        public MainTable otherForm;
        public AddOrderForm(MainTable form1)
        {
            InitializeComponent();
            otherForm = form1;
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainTable f1 = new MainTable();
            f1.ShowDialog();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((Custsurname.Text.Equals("")) || (ProductName.Text.Equals("")) || (MSurname.Text.Equals("")) || (Cost.Text.Equals("")))
            {
                MessageBox.Show("Вы не ввели все необходимые данные!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                otherForm.dataGridView1.Rows.Add(Custsurname.Text, ONumber.Text, ProductName.Text, Date1.Text, Date2.Text, MSurname.Text, Cost.Text);
                otherForm.MarkovTextBox.Clear();               
                Hide();
            }          
        }
        private void Custsurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && (l <  'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
                MessageBox.Show("Введите только буквы!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            

        } 
        private void ProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
                MessageBox.Show("Введите только буквы!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
           

        }      
        private void MSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
                MessageBox.Show("Введите только буквы!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
         
        }
        private void Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b' && l != '.')
            {
                e.Handled = true;
                MessageBox.Show("Введите только цифры!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }    
        }

       
    }
}
