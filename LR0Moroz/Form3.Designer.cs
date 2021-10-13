
namespace LR0Moroz
{
    partial class EditForm
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
            this.EditOrder = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.EditDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // EditOrder
            // 
            this.EditOrder.Location = new System.Drawing.Point(138, 127);
            this.EditOrder.Name = "EditOrder";
            this.EditOrder.Size = new System.Drawing.Size(225, 25);
            this.EditOrder.TabIndex = 0;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(180, 174);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(125, 26);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditDate
            // 
            this.EditDate.Location = new System.Drawing.Point(138, 76);
            this.EditDate.Name = "EditDate";
            this.EditDate.Size = new System.Drawing.Size(225, 25);
            this.EditDate.TabIndex = 2;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 302);
            this.Controls.Add(this.EditDate);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.EditOrder);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "EditForm";
            this.Text = "Статус заказов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox EditOrder;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DateTimePicker EditDate;
    }
}