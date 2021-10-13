
namespace LR0Moroz
{
    partial class MainTable
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTable));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customersurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ClearSelected = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ONumber = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Markov = new System.Windows.Forms.LinkLabel();
            this.Kislyakov = new System.Windows.Forms.LinkLabel();
            this.Trofimov = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.MarkovTextBox = new System.Windows.Forms.TextBox();
            this.KislyakovTextBox = new System.Windows.Forms.TextBox();
            this.TrophimovTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(41, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(104, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить Заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(1106, 446);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(86, 53);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Закрыть таблицу";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customersurname,
            this.OrderNumber,
            this.PrName,
            this.Date1,
            this.Date2,
            this.MSurname,
            this.Cost});
            this.dataGridView1.Location = new System.Drawing.Point(41, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 360);
            this.dataGridView1.TabIndex = 7;
          
            // 
            // Customersurname
            // 
            this.Customersurname.HeaderText = "Фамилия клиента";
            this.Customersurname.MinimumWidth = 6;
            this.Customersurname.Name = "Customersurname";
            this.Customersurname.ReadOnly = true;
            this.Customersurname.Width = 125;
            // 
            // OrderNumber
            // 
            this.OrderNumber.HeaderText = "Номер заказа";
            this.OrderNumber.MinimumWidth = 6;
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            this.OrderNumber.Width = 125;
            // 
            // PrName
            // 
            this.PrName.HeaderText = "Наименование изделия";
            this.PrName.MinimumWidth = 6;
            this.PrName.Name = "PrName";
            this.PrName.ReadOnly = true;
            this.PrName.Width = 125;
            // 
            // Date1
            // 
            this.Date1.HeaderText = "Дата приема заказа";
            this.Date1.MinimumWidth = 6;
            this.Date1.Name = "Date1";
            this.Date1.ReadOnly = true;
            this.Date1.Width = 125;
            // 
            // Date2
            // 
            this.Date2.HeaderText = "Дата выполнения заказа";
            this.Date2.MinimumWidth = 6;
            this.Date2.Name = "Date2";
            this.Date2.ReadOnly = true;
            this.Date2.Width = 125;
            // 
            // MSurname
            // 
            this.MSurname.HeaderText = "Фамилия мастера";
            this.MSurname.MinimumWidth = 6;
            this.MSurname.Name = "MSurname";
            this.MSurname.ReadOnly = true;
            this.MSurname.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 125;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(785, 446);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(186, 54);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Очистить таблицу";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ClearSelected
            // 
            this.ClearSelected.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearSelected.Location = new System.Drawing.Point(364, 446);
            this.ClearSelected.Margin = new System.Windows.Forms.Padding(4);
            this.ClearSelected.Name = "ClearSelected";
            this.ClearSelected.Size = new System.Drawing.Size(211, 54);
            this.ClearSelected.TabIndex = 9;
            this.ClearSelected.Text = "Удалить выделенный заказ";
            this.ClearSelected.UseVisualStyleBackColor = true;
            this.ClearSelected.Click += new System.EventHandler(this.ClearSelected_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(188, 446);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1027, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ONumber
            // 
            this.ONumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ONumber.Location = new System.Drawing.Point(619, 446);
            this.ONumber.Margin = new System.Windows.Forms.Padding(4);
            this.ONumber.Name = "ONumber";
            this.ONumber.Size = new System.Drawing.Size(135, 54);
            this.ONumber.TabIndex = 12;
            this.ONumber.Text = "Статус заказов";
            this.ONumber.UseVisualStyleBackColor = true;
            this.ONumber.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1436, 29);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Markov
            // 
            this.Markov.AutoSize = true;
            this.Markov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Markov.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Markov.LinkColor = System.Drawing.Color.Navy;
            this.Markov.Location = new System.Drawing.Point(1119, 332);
            this.Markov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Markov.Name = "Markov";
            this.Markov.Size = new System.Drawing.Size(90, 19);
            this.Markov.TabIndex = 14;
            this.Markov.TabStop = true;
            this.Markov.Text = "Марков В.Н.";
            this.Markov.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Markov_LinkClicked);
            // 
            // Kislyakov
            // 
            this.Kislyakov.ActiveLinkColor = System.Drawing.Color.Red;
            this.Kislyakov.AutoSize = true;
            this.Kislyakov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Kislyakov.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kislyakov.LinkColor = System.Drawing.Color.Navy;
            this.Kislyakov.Location = new System.Drawing.Point(1119, 289);
            this.Kislyakov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kislyakov.Name = "Kislyakov";
            this.Kislyakov.Size = new System.Drawing.Size(100, 19);
            this.Kislyakov.TabIndex = 15;
            this.Kislyakov.TabStop = true;
            this.Kislyakov.Text = "Кисляков С.В.";
            this.Kislyakov.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Kislyakov_LinkClicked);
            // 
            // Trofimov
            // 
            this.Trofimov.AutoSize = true;
            this.Trofimov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Trofimov.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Trofimov.LinkColor = System.Drawing.Color.Navy;
            this.Trofimov.Location = new System.Drawing.Point(1119, 375);
            this.Trofimov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Trofimov.Name = "Trofimov";
            this.Trofimov.Size = new System.Drawing.Size(107, 19);
            this.Trofimov.TabIndex = 16;
            this.Trofimov.TabStop = true;
            this.Trofimov.Text = "Трофимов В.М.";
            this.Trofimov.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Trofimov_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1102, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Наши мастера:";
            // 
            // MarkovTextBox
            // 
            this.MarkovTextBox.Location = new System.Drawing.Point(1580, 678);
            this.MarkovTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MarkovTextBox.Name = "MarkovTextBox";
            this.MarkovTextBox.Size = new System.Drawing.Size(160, 27);
            this.MarkovTextBox.TabIndex = 18;
            this.MarkovTextBox.Visible = false;
            // 
            // KislyakovTextBox
            // 
            this.KislyakovTextBox.Location = new System.Drawing.Point(1580, 678);
            this.KislyakovTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KislyakovTextBox.Name = "KislyakovTextBox";
            this.KislyakovTextBox.Size = new System.Drawing.Size(160, 27);
            this.KislyakovTextBox.TabIndex = 19;
            this.KislyakovTextBox.Visible = false;
            // 
            // TrophimovTextBox
            // 
            this.TrophimovTextBox.Location = new System.Drawing.Point(1580, 678);
            this.TrophimovTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TrophimovTextBox.Name = "TrophimovTextBox";
            this.TrophimovTextBox.Size = new System.Drawing.Size(160, 27);
            this.TrophimovTextBox.TabIndex = 20;
            this.TrophimovTextBox.Visible = false;
            // 
            // MainTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1436, 611);
            this.Controls.Add(this.TrophimovTextBox);
            this.Controls.Add(this.KislyakovTextBox);
            this.Controls.Add(this.MarkovTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trofimov);
            this.Controls.Add(this.Kislyakov);
            this.Controls.Add(this.Markov);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ONumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ClearSelected);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainTable";
            this.Text = "Ателье-мастерская \"ШейДаПари\"";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ClearSelected;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ONumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.LinkLabel Markov;
        private System.Windows.Forms.LinkLabel Kislyakov;
        private System.Windows.Forms.LinkLabel Trofimov;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox MarkovTextBox;
        private System.Windows.Forms.TextBox KislyakovTextBox;
        private System.Windows.Forms.TextBox TrophimovTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customersurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}

