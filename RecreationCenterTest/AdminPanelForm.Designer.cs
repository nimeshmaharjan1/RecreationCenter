
namespace RecreationCenter
{
    partial class AdminPanelForm
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
            this.goHomeBtn = new System.Windows.Forms.Button();
            this.exportTicketPrice = new System.Windows.Forms.Button();
            this.importTicketPrice = new System.Windows.Forms.Button();
            this.retrievePrice = new System.Windows.Forms.Button();
            this.savePrice = new System.Windows.Forms.Button();
            this.addTicketPriceBtn = new System.Windows.Forms.Button();
            this.ticketPriceListGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketPriceListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goHomeBtn
            // 
            this.goHomeBtn.BackColor = System.Drawing.Color.Crimson;
            this.goHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goHomeBtn.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goHomeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goHomeBtn.Location = new System.Drawing.Point(31, 506);
            this.goHomeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.goHomeBtn.Name = "goHomeBtn";
            this.goHomeBtn.Size = new System.Drawing.Size(165, 50);
            this.goHomeBtn.TabIndex = 13;
            this.goHomeBtn.Text = "Logout";
            this.goHomeBtn.UseVisualStyleBackColor = false;
            this.goHomeBtn.Click += new System.EventHandler(this.goHomeBtn_Click);
            // 
            // exportTicketPrice
            // 
            this.exportTicketPrice.BackColor = System.Drawing.Color.LightSeaGreen;
            this.exportTicketPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportTicketPrice.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportTicketPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportTicketPrice.Location = new System.Drawing.Point(31, 424);
            this.exportTicketPrice.Margin = new System.Windows.Forms.Padding(4);
            this.exportTicketPrice.Name = "exportTicketPrice";
            this.exportTicketPrice.Size = new System.Drawing.Size(165, 50);
            this.exportTicketPrice.TabIndex = 12;
            this.exportTicketPrice.Text = "Export";
            this.exportTicketPrice.UseVisualStyleBackColor = false;
            this.exportTicketPrice.Click += new System.EventHandler(this.exportTicketPrice_Click);
            // 
            // importTicketPrice
            // 
            this.importTicketPrice.BackColor = System.Drawing.Color.LightSeaGreen;
            this.importTicketPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importTicketPrice.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importTicketPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.importTicketPrice.Location = new System.Drawing.Point(31, 347);
            this.importTicketPrice.Margin = new System.Windows.Forms.Padding(4);
            this.importTicketPrice.Name = "importTicketPrice";
            this.importTicketPrice.Size = new System.Drawing.Size(165, 50);
            this.importTicketPrice.TabIndex = 11;
            this.importTicketPrice.Text = "Import";
            this.importTicketPrice.UseVisualStyleBackColor = false;
            this.importTicketPrice.Click += new System.EventHandler(this.ImportTicketPrice_Click);
            // 
            // retrievePrice
            // 
            this.retrievePrice.BackColor = System.Drawing.Color.LightSeaGreen;
            this.retrievePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrievePrice.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrievePrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retrievePrice.Location = new System.Drawing.Point(31, 264);
            this.retrievePrice.Margin = new System.Windows.Forms.Padding(4);
            this.retrievePrice.Name = "retrievePrice";
            this.retrievePrice.Size = new System.Drawing.Size(165, 50);
            this.retrievePrice.TabIndex = 10;
            this.retrievePrice.Text = "Retrieve";
            this.retrievePrice.UseVisualStyleBackColor = false;
            this.retrievePrice.Click += new System.EventHandler(this.RetrievePrice_Click);
            // 
            // savePrice
            // 
            this.savePrice.BackColor = System.Drawing.Color.LightSeaGreen;
            this.savePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePrice.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savePrice.Location = new System.Drawing.Point(31, 187);
            this.savePrice.Margin = new System.Windows.Forms.Padding(4);
            this.savePrice.Name = "savePrice";
            this.savePrice.Size = new System.Drawing.Size(165, 50);
            this.savePrice.TabIndex = 9;
            this.savePrice.Text = "Save";
            this.savePrice.UseVisualStyleBackColor = false;
            this.savePrice.Click += new System.EventHandler(this.SavePrice_Click);
            // 
            // addTicketPriceBtn
            // 
            this.addTicketPriceBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addTicketPriceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTicketPriceBtn.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTicketPriceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTicketPriceBtn.Location = new System.Drawing.Point(31, 109);
            this.addTicketPriceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addTicketPriceBtn.Name = "addTicketPriceBtn";
            this.addTicketPriceBtn.Size = new System.Drawing.Size(165, 50);
            this.addTicketPriceBtn.TabIndex = 8;
            this.addTicketPriceBtn.Text = "Add Ticket Price";
            this.addTicketPriceBtn.UseVisualStyleBackColor = false;
            this.addTicketPriceBtn.Click += new System.EventHandler(this.AddTicketPriceBtn_Click);
            // 
            // ticketPriceListGridView
            // 
            this.ticketPriceListGridView.AllowUserToOrderColumns = true;
            this.ticketPriceListGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.ticketPriceListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketPriceListGridView.Location = new System.Drawing.Point(230, 93);
            this.ticketPriceListGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ticketPriceListGridView.Name = "ticketPriceListGridView";
            this.ticketPriceListGridView.RowHeadersWidth = 51;
            this.ticketPriceListGridView.Size = new System.Drawing.Size(688, 478);
            this.ticketPriceListGridView.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 22);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(182, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Admin Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(953, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goHomeBtn);
            this.Controls.Add(this.exportTicketPrice);
            this.Controls.Add(this.importTicketPrice);
            this.Controls.Add(this.retrievePrice);
            this.Controls.Add(this.savePrice);
            this.Controls.Add(this.addTicketPriceBtn);
            this.Controls.Add(this.ticketPriceListGridView);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketPriceListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goHomeBtn;
        private System.Windows.Forms.Button exportTicketPrice;
        private System.Windows.Forms.Button importTicketPrice;
        private System.Windows.Forms.Button retrievePrice;
        private System.Windows.Forms.Button savePrice;
        private System.Windows.Forms.Button addTicketPriceBtn;
        private System.Windows.Forms.DataGridView ticketPriceListGridView;
        private System.Windows.Forms.Label label1;
    }
}