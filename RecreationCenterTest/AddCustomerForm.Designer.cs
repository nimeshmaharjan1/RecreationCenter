
namespace RecreationCenterTest
{
    partial class AddCustomerForm
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerAgeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerContactTextBox = new System.Windows.Forms.TextBox();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(129, 46);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(205, 20);
            this.customerNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // customerAgeTextBox
            // 
            this.customerAgeTextBox.Location = new System.Drawing.Point(129, 92);
            this.customerAgeTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.customerAgeTextBox.Name = "customerAgeTextBox";
            this.customerAgeTextBox.Size = new System.Drawing.Size(205, 20);
            this.customerAgeTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Location = new System.Drawing.Point(129, 138);
            this.customerAddressTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(205, 20);
            this.customerAddressTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(39, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact";
            // 
            // customerContactTextBox
            // 
            this.customerContactTextBox.Location = new System.Drawing.Point(129, 183);
            this.customerContactTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.customerContactTextBox.Name = "customerContactTextBox";
            this.customerContactTextBox.Size = new System.Drawing.Size(205, 20);
            this.customerContactTextBox.TabIndex = 6;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.BackColor = System.Drawing.Color.Crimson;
            this.addCustomerBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addCustomerBtn.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCustomerBtn.Location = new System.Drawing.Point(144, 238);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(112, 38);
            this.addCustomerBtn.TabIndex = 8;
            this.addCustomerBtn.Text = "OK";
            this.addCustomerBtn.UseVisualStyleBackColor = false;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(386, 303);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerContactTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerAgeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameTextBox);
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerAgeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerContactTextBox;
        private System.Windows.Forms.Button addCustomerBtn;
    }
}