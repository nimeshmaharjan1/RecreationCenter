
namespace RecreationCenterTest
{
    partial class AddCustomerEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.entryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.inTimePicker = new System.Windows.Forms.DateTimePicker();
            this.outTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(35, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "In Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(35, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Out Time";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price.Location = new System.Drawing.Point(35, 314);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(53, 20);
            this.price.TabIndex = 4;
            this.price.Text = "Price";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(184, 54);
            this.nameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(207, 24);
            this.nameComboBox.TabIndex = 13;
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.Location = new System.Drawing.Point(184, 106);
            this.entryDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(207, 22);
            this.entryDatePicker.TabIndex = 13;
            // 
            // inTimePicker
            // 
            this.inTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.inTimePicker.Location = new System.Drawing.Point(184, 160);
            this.inTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inTimePicker.Name = "inTimePicker";
            this.inTimePicker.ShowUpDown = true;
            this.inTimePicker.Size = new System.Drawing.Size(113, 22);
            this.inTimePicker.TabIndex = 13;
            this.inTimePicker.Value = new System.DateTime(2021, 12, 27, 10, 0, 0, 0);
            this.inTimePicker.ValueChanged += new System.EventHandler(this.inTimePicker_ValueChanged);
            // 
            // outTimePicker
            // 
            this.outTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.outTimePicker.Location = new System.Drawing.Point(184, 215);
            this.outTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outTimePicker.Name = "outTimePicker";
            this.outTimePicker.ShowUpDown = true;
            this.outTimePicker.Size = new System.Drawing.Size(113, 22);
            this.outTimePicker.TabIndex = 13;
            this.outTimePicker.Value = new System.DateTime(2021, 12, 27, 18, 0, 0, 0);
            this.outTimePicker.ValueChanged += new System.EventHandler(this.outTimePicker_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(227, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(87, 374);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(184, 313);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(207, 22);
            this.priceTextBox.TabIndex = 15;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // customerTypeComboBox
            // 
            this.customerTypeComboBox.FormattingEnabled = true;
            this.customerTypeComboBox.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group of 5"});
            this.customerTypeComboBox.Location = new System.Drawing.Point(184, 260);
            this.customerTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(207, 24);
            this.customerTypeComboBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(35, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Customer Type";
            // 
            // AddCustomerEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(436, 449);
            this.Controls.Add(this.customerTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outTimePicker);
            this.Controls.Add(this.inTimePicker);
            this.Controls.Add(this.entryDatePicker);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCustomerEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomerEntryForm";
            this.Load += new System.EventHandler(this.AddCustomerEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private System.Windows.Forms.DateTimePicker inTimePicker;
        private System.Windows.Forms.DateTimePicker outTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
        private System.Windows.Forms.Label label5;
    }
}