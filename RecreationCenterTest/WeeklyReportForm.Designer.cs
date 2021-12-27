
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
            this.sortByBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklyGridView
            // 
            this.weeklyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.weeklyGridView.Location = new System.Drawing.Point(0, -2);
            this.weeklyGridView.Name = "weeklyGridView";
            this.weeklyGridView.Size = new System.Drawing.Size(345, 234);
            this.weeklyGridView.TabIndex = 2;
            this.weeklyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weeklyGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Day";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "No. of Customers";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Minutes";
            this.Column3.Name = "Column3";
            // 
            // sortByBtn
            // 
            this.sortByBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.sortByBtn.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortByBtn.Location = new System.Drawing.Point(77, 255);
            this.sortByBtn.Name = "sortByBtn";
            this.sortByBtn.Size = new System.Drawing.Size(178, 36);
            this.sortByBtn.TabIndex = 3;
            this.sortByBtn.Text = "Sort By Total Visitors";
            this.sortByBtn.UseVisualStyleBackColor = false;
            this.sortByBtn.Click += new System.EventHandler(this.sortByBtn_Click);
            // 
            // WeeklyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 313);
            this.Controls.Add(this.weeklyGridView);
            this.Controls.Add(this.sortByBtn);
            this.Name = "WeeklyReportForm";
            this.Text = "WeeklyReportForm";
            this.Load += new System.EventHandler(this.WeeklyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView weeklyGridView;
        private System.Windows.Forms.Button sortByBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}