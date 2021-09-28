using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace LR0Moroz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2(this);
            child.Show();
            child.ONumber.Text = ONumber_generation().ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int ONumber_generation() 
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }      
        private void ClearButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        private void ClearSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value != null)
            {
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);
            } else MessageBox.Show("Заказ отсутсвует!");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value != null)
            {
                Form3 child = new Form3(this);
                child.EditOrder.Text = dataGridView1.SelectedCells[0].Value.ToString();
                child.Show();
            }
            else MessageBox.Show("Выбранная ячейка пуста!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4(this);
            child.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        int num = str1.Count();
                        dataGridView1.RowCount = num;
                        for (int i = 0; i < num-1; i++)
                        {
                            str = str1[i].Split('^');
                                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {                                   
                                    string data = str[j].Replace("[etot_simvol]", "^");
                                    dataGridView1.Rows[i].Cells[j].Value = str[j]; 
                                }
                                catch { }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog()== DialogResult.OK) 
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null) 
                {
                    StreamWriter myWrite = new StreamWriter(myStream);
                    try 
                    {
                    for (int i =0; i<dataGridView1.RowCount -1; i++) 
                        {
                        for (int j = 0; j<dataGridView1.ColumnCount; j++) 
                            {
                                string data = dataGridView1.Rows[i].Cells[j].Value.ToString().Replace("^", "[etot_simvol]");
                                myWrite.Write(data + "^" );                          
                            }
                            myWrite.WriteLine(); 
                        }               
                    } catch(Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                    
                    }
                    finally 
                    {
                        myWrite.Close();
                    }
                    myStream.Close();               
                }            
            }
        }
        private void Trofimov_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int Trophimov1 = 0;
            int TrophimovCost = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MSurname"]?.Value?.ToString() == "Трофимов")
                {
                    Trophimov1++;
                    if (Int32.TryParse(row.Cells["Cost"]?.Value?.ToString(), out int Cost))
                    {                       
                        var avg = Cost;
                        TrophimovCost += avg;
                    }
                }
            }
            TrophimovTextBox.Text = "Количество заказов: " + Trophimov1 + "Средняя Стоимость заказов: " + TrophimovCost/ Trophimov1;
            MessageBox.Show(TrophimovTextBox.Text, "Трофимов В.М.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Kislyakov_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            int Kislyakov1 = 0;
            int KislyakovCost = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MSurname"]?.Value?.ToString() == "Кисляков")
                {
                    Kislyakov1++;
                    if (Int32.TryParse(row.Cells["Cost"]?.Value?.ToString(), out int Cost))
                    {
                        var avg = Cost;
                        KislyakovCost += avg;
                    }
                }
            }
            if (Kislyakov1 !=null && KislyakovCost != 0)
            {
                KislyakovTextBox.Text = "Количество заказов: " + Kislyakov1 + "\n" + "Средняя стоимость заказов мастера: " + KislyakovCost / Kislyakov1;
                MessageBox.Show(KislyakovTextBox.Text, "Кисляков С.В.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Markov_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int Markov1 = 0;
            int MarkovCost = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MSurname"]?.Value?.ToString() == "Марков")
                {
                    Markov1++;
                    if (Int32.TryParse(row.Cells["Cost"]?.Value?.ToString(), out int Cost))
                    {
                        var avg = Cost;
                        MarkovCost += avg;
                    }
                }
            }
            MarkovTextBox.Text = "Количество заказов: " + Markov1 + "\n" + "Средняя стоимость заказов мастера: " + MarkovCost/Markov1;
            MessageBox.Show(MarkovTextBox.Text, "Марков В.Н.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   
}
