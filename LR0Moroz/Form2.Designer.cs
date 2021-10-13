
namespace LR0Moroz
{
    partial class AddOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Custsurname = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Date1 = new System.Windows.Forms.DateTimePicker();
            this.Date2 = new System.Windows.Forms.DateTimePicker();
            this.ONumber = new System.Windows.Forms.TextBox();
            this.MSurname = new System.Windows.Forms.ComboBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(263, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить заказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ваш номер заказа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Наименование изделия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата приема заказа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата выполнения заказа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Фамилия мастера";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 360);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Стоимость";
            // 
            // Custsurname
            // 
            this.Custsurname.Location = new System.Drawing.Point(268, 139);
            this.Custsurname.Margin = new System.Windows.Forms.Padding(4);
            this.Custsurname.Name = "Custsurname";
            this.Custsurname.Size = new System.Drawing.Size(168, 25);
            this.Custsurname.TabIndex = 8;
            this.Custsurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Custsurname_KeyPress);
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(268, 356);
            this.Cost.Margin = new System.Windows.Forms.Padding(4);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(168, 25);
            this.Cost.TabIndex = 14;
            this.Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cost_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 417);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 417);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Date1
            // 
            this.Date1.Location = new System.Drawing.Point(268, 228);
            this.Date1.Margin = new System.Windows.Forms.Padding(4);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(168, 25);
            this.Date1.TabIndex = 17;
            // 
            // Date2
            // 
            this.Date2.Location = new System.Drawing.Point(268, 271);
            this.Date2.Margin = new System.Windows.Forms.Padding(4);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(168, 25);
            this.Date2.TabIndex = 18;
            // 
            // ONumber
            // 
            this.ONumber.Location = new System.Drawing.Point(556, 420);
            this.ONumber.Margin = new System.Windows.Forms.Padding(4);
            this.ONumber.Name = "ONumber";
            this.ONumber.ReadOnly = true;
            this.ONumber.Size = new System.Drawing.Size(101, 25);
            this.ONumber.TabIndex = 19;
            // 
            // MSurname
            // 
            this.MSurname.BackColor = System.Drawing.SystemColors.Menu;
            this.MSurname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MSurname.Items.AddRange(new object[] {
            "Марков",
            "Кисляков",
            "Трофимов"});
            this.MSurname.Location = new System.Drawing.Point(268, 313);
            this.MSurname.Margin = new System.Windows.Forms.Padding(4);
            this.MSurname.Name = "MSurname";
            this.MSurname.Size = new System.Drawing.Size(168, 25);
            this.MSurname.TabIndex = 20;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(268, 183);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(168, 25);
            this.ProductName.TabIndex = 10;
            this.ProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductName_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(444, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(728, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MSurname);
            this.Controls.Add(this.ONumber);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.Date1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.Custsurname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOrderForm";
            this.Text = "Добавление заказа";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox Custsurname;
        public System.Windows.Forms.TextBox Cost;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.DateTimePicker Date2;
        public System.Windows.Forms.DateTimePicker Date1;
        public System.Windows.Forms.TextBox ONumber;
        private System.Windows.Forms.ComboBox MSurname;
        public new System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}