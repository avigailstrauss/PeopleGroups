
namespace PeopleGroups
{
    partial class FrmViewAllPeople
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
            this.GrdAllPeople = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAllPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdAllPeople
            // 
            this.GrdAllPeople.AllowUserToAddRows = false;
            this.GrdAllPeople.AllowUserToDeleteRows = false;
            this.GrdAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAllPeople.Location = new System.Drawing.Point(52, 47);
            this.GrdAllPeople.MultiSelect = false;
            this.GrdAllPeople.Name = "GrdAllPeople";
            this.GrdAllPeople.ReadOnly = true;
            this.GrdAllPeople.RowHeadersVisible = false;
            this.GrdAllPeople.RowHeadersWidth = 51;
            this.GrdAllPeople.RowTemplate.Height = 24;
            this.GrdAllPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdAllPeople.Size = new System.Drawing.Size(1014, 495);
            this.GrdAllPeople.TabIndex = 1;
            // 
            // FrmViewAllPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 588);
            this.Controls.Add(this.GrdAllPeople);
            this.Name = "FrmViewAllPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All People";
            ((System.ComponentModel.ISupportInitialize)(this.GrdAllPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdAllPeople;
    }
}