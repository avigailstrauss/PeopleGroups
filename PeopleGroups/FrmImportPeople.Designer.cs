
namespace PeopleGroups
{
    partial class FrmImportPeople
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
            this.TxtFilepath = new System.Windows.Forms.TextBox();
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TxtFilepath
            // 
            this.TxtFilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtFilepath.Location = new System.Drawing.Point(60, 88);
            this.TxtFilepath.Name = "TxtFilepath";
            this.TxtFilepath.Size = new System.Drawing.Size(456, 26);
            this.TxtFilepath.TabIndex = 2;
            // 
            // BtnImport
            // 
            this.BtnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnImport.Location = new System.Drawing.Point(330, 170);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(137, 38);
            this.BtnImport.TabIndex = 3;
            this.BtnImport.Text = "Import File";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnBrowse.Location = new System.Drawing.Point(549, 82);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(138, 38);
            this.BtnBrowse.TabIndex = 4;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmImportPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 259);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.TxtFilepath);
            this.Name = "FrmImportPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtFilepath;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}