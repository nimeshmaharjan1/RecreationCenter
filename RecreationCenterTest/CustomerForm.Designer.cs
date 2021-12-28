
namespace RecreationCenterTest
{
    partial class CustomerForm
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
            this.customerListGridView = new System.Windows.Forms.DataGridView();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.saveCustomer = new System.Windows.Forms.Button();
            this.retrieveCustomer = new System.Windows.Forms.Button();
            this.importCustomer = new System.Windows.Forms.Button();
            this.exportCustomer = new System.Windows.Forms.Button();
            this.goHomeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerListGridView
            // 
            this.customerListGridView.AllowUserToOrderColumns = true;
            this.customerListGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.customerListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerListGridView.Location = new System.Drawing.Point(170, 27);
            this.customerListGridView.Name = "customerListGridView";
            this.customerListGridView.Size = new System.Drawing.Size(516, 388);
            this.customerListGridView.TabIndex = 0;
            this.customerListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerListGridView_CellContentClick);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerBtn.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCustomerBtn.Location = new System.Drawing.Point(21, 40);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(124, 41);
            this.addCustomerBtn.TabIndex = 1;
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = false;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // saveCustomer
            // 
            this.saveCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.saveCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveCustomer.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveCustomer.Location = new System.Drawing.Point(21, 103);
            this.saveCustomer.Name = "saveCustomer";
            this.saveCustomer.Size = new System.Drawing.Size(124, 41);
            this.saveCustomer.TabIndex = 2;
            this.saveCustomer.Text = "Save";
            this.saveCustomer.UseVisualStyleBackColor = false;
            this.saveCustomer.Click += new System.EventHandler(this.saveCustomer_Click);
            // 
            // retrieveCustomer
            // 
            this.retrieveCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.retrieveCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrieveCustomer.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retrieveCustomer.Location = new System.Drawing.Point(21, 166);
            this.retrieveCustomer.Name = "retrieveCustomer";
            this.retrieveCustomer.Size = new System.Drawing.Size(124, 41);
            this.retrieveCustomer.TabIndex = 3;
            this.retrieveCustomer.Text = "Retrieve";
            this.retrieveCustomer.UseVisualStyleBackColor = false;
            this.retrieveCustomer.Click += new System.EventHandler(this.retrieveCustomer_Click);
            // 
            // importCustomer
            // 
            this.importCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.importCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importCustomer.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.importCustomer.Location = new System.Drawing.Point(21, 233);
            this.importCustomer.Name = "importCustomer";
            this.importCustomer.Size = new System.Drawing.Size(124, 41);
            this.importCustomer.TabIndex = 4;
            this.importCustomer.Text = "Import";
            this.importCustomer.UseVisualStyleBackColor = false;
            this.importCustomer.Click += new System.EventHandler(this.importCustomer_Click);
            // 
            // exportCustomer
            // 
            this.exportCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.exportCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportCustomer.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportCustomer.Location = new System.Drawing.Point(21, 296);
            this.exportCustomer.Name = "exportCustomer";
            this.exportCustomer.Size = new System.Drawing.Size(124, 41);
            this.exportCustomer.TabIndex = 5;
            this.exportCustomer.Text = "Export";
            this.exportCustomer.UseVisualStyleBackColor = false;
            this.exportCustomer.Click += new System.EventHandler(this.exportCustomer_Click);
            // 
            // goHomeBtn
            // 
            this.goHomeBtn.BackColor = System.Drawing.Color.Crimson;
            this.goHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goHomeBtn.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goHomeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goHomeBtn.Location = new System.Drawing.Point(21, 362);
            this.goHomeBtn.Name = "goHomeBtn";
            this.goHomeBtn.Size = new System.Drawing.Size(124, 41);
            this.goHomeBtn.TabIndex = 6;
            this.goHomeBtn.Text = "Home";
            this.goHomeBtn.UseVisualStyleBackColor = false;
            this.goHomeBtn.Click += new System.EventHandler(this.goHomeBtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(719, 437);
            this.Controls.Add(this.goHomeBtn);
            this.Controls.Add(this.exportCustomer);
            this.Controls.Add(this.importCustomer);
            this.Controls.Add(this.retrieveCustomer);
            this.Controls.Add(this.saveCustomer);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.customerListGridView);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerListGridView;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button saveCustomer;
        private System.Windows.Forms.Button retrieveCustomer;
        private System.Windows.Forms.Button importCustomer;
        private System.Windows.Forms.Button exportCustomer;
        private System.Windows.Forms.Button goHomeBtn;
    }
}