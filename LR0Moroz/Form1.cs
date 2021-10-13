using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Drawing;

namespace LR0Moroz
{
    public partial class MainTable : Form
    {
        public MainTable()
        {
            InitializeComponent();
        }
        public MainTable(string[] s)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(s);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddOrderForm child = new AddOrderForm(this);
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
                EditForm child = new EditForm(this);
                child.EditOrder.Text = dataGridView1.SelectedCells[0].Value.ToString();
                child.Show();
            }
            else MessageBox.Show("Выбранная ячейка пуста!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            DateTime today = DateTime.Today.Date;
            foreach (DataGridViewRow row in dataGridView1.Rows) 
            {
                DateTime dt = DateTime.Parse(row.Cells["Date2"].Value.ToString());
                if (dt > today)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
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
            int maxTr = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MSurname"]?.Value?.ToString() == "Трофимов")
                {
                    Trophimov1++;
                    if (Int32.TryParse(row.Cells["Cost"]?.Value?.ToString(), out int Cost))
                    {
                        if (Convert.ToInt32(row.Cells["Cost"]?.Value) > maxTr) 
                            maxTr = Convert.ToInt32(row.Cells["Cost"]?.Value);
                        var avg = Cost;
                        TrophimovCost += avg;
                    }
                }
            }
            if (Trophimov1 !=0 && TrophimovCost !=0)
            {
                TrophimovTextBox.Text = "Количество заказов: " + Trophimov1 + "\n" + "Средняя Стоимость заказов: " + TrophimovCost / Trophimov1 + "\n" + "Самый дорогой заказ: " + maxTr;
                MessageBox.Show(TrophimovTextBox.Text, "Трофимов В.М.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("У этого мастера нет заказов!");

        }
        private void Kislyakov_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kislyakov11();
        }
        public string Kislyakov11() 
        {
            int Kislyakov1 = 0;
            int KislyakovCost = 0;
            int maxKis = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MSurname"]?.Value?.ToString() == "Кисляков")
                {
                    Kislyakov1++;
                    if (Int32.TryParse(row.Cells["Cost"]?.Value?.ToString(), out int Cost))
                    {
                        if (Convert.ToInt32(row.Cells["Cost"]?.Value) > maxKis)
                            maxKis = Convert.ToInt32(row.Cells["Cost"]?.Value);
                        var avg = Cost;
                        KislyakovCost += avg;
                    }
                }
            }
            if (Kislyakov1 != 0 && KislyakovCost != 0)
            {
                KislyakovTextBox.Text = "Количество заказов: " + Kislyakov1 + "\n" + "Средняя стоимость заказов мастера: " + KislyakovCost / Kislyakov1 + "\n" + "Самый дорогой заказ: " + maxKis;
                MessageBox.Show(KislyakovTextBox.Text, "Кисляков С.В.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else MessageBox.Show("У этого мастера нет заказов!");
            return KislyakovTextBox.Text;

        }
        private void Markov_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int Markov1 = 0;
            int MarkovCost = 0;
            int maxMark = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MSurname"]?.Value?.ToString() == "Марков")
                {
                    Markov1++;
                    if (Int32.TryParse(row.Cells["Cost"]?.Value?.ToString(), out int Cost))
                    {
                        if (Convert.ToInt32(row.Cells["Cost"]?.Value) > maxMark)
                            maxMark = Convert.ToInt32(row.Cells["Cost"]?.Value);
                        var avg = Cost;
                        MarkovCost += avg;
                    }
                }
            }
            if (Markov1 !=0 && MarkovCost !=0) 
            {
                MarkovTextBox.Text = "Количество заказов: " + Markov1 + "\n" + "Средняя стоимость заказов мастера: " + MarkovCost / Markov1 + "\n" + "Самый дорогой заказ: " + maxMark;
                MessageBox.Show(MarkovTextBox.Text, "Марков В.Н.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("У этого мастера нет заказов!");
        }

      
    }
   
}
