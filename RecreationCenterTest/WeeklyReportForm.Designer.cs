
namespace RecreationCenter
{
    partial class WeeklyReportForm
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
            this.weeklyGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortByBtn = new System.Windows.Forms.Button();
            this.sortByTotalRevenueBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklyGridView
            // 
            this.weeklyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.weeklyGridView.Location = new System.Drawing.Point(60, 98);
            this.weeklyGridView.Margin = new System.Windows.Forms.Padding(4);
            this.weeklyGridView.Name = "weeklyGridView";
            this.weeklyGridView.RowHeadersWidth = 51;
            this.weeklyGridView.Size = new System.Drawing.Size(636, 294);
            this.weeklyGridView.TabIndex = 2;
            this.weeklyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weeklyGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Day";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "No. of Customers";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Revenue";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer Duration";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // sortByBtn
            // 
            this.sortByBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sortByBtn.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortByBtn.Location = new System.Drawing.Point(123, 427);
            this.sortByBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sortByBtn.Name = "sortByBtn";
            this.sortByBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.sortByBtn.Size = new System.Drawing.Size(221, 53);
            this.sortByBtn.TabIndex = 3;
            this.sortByBtn.Text = "Sort By Total Visitors";
            this.sortByBtn.UseVisualStyleBackColor = false;
            this.sortByBtn.Click += new System.EventHandler(this.sortByBtn_Click);
            // 
            // sortByTotalRevenueBtn
            // 
            this.sortByTotalRevenueBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sortByTotalRevenueBtn.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByTotalRevenueBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortByTotalRevenueBtn.Location = new System.Drawing.Point(413, 427);
            this.sortByTotalRevenueBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sortByTotalRevenueBtn.Name = "sortByTotalRevenueBtn";
            this.sortByTotalRevenueBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.sortByTotalRevenueBtn.Size = new System.Drawing.Size(223, 53);
            this.sortByTotalRevenueBtn.TabIndex = 4;
            this.sortByTotalRevenueBtn.Text = "Sort By Total Revenue";
            this.sortByTotalRevenueBtn.UseVisualStyleBackColor = false;
            this.sortByTotalRevenueBtn.Click += new System.EventHandler(this.sortByTotalRevenueBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(285, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Weekly Report";
            // 
            // WeeklyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(755, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortByTotalRevenueBtn);
            this.Controls.Add(this.weeklyGridView);
            this.Controls.Add(this.sortByBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WeeklyReportForm";
            this.Text = "WeeklyReportForm";
            this.Load += new System.EventHandler(this.WeeklyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView weeklyGridView;
        private System.Windows.Forms.Button sortByBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button sortByTotalRevenueBtn;
        private System.Windows.Forms.Label label1;
    }
}