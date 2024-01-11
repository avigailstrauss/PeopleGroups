
namespace PeopleGroups
{
    partial class FrmAddNewPerson
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
            this.GrdNonMembers = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdNonMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdNonMembers
            // 
            this.GrdNonMembers.AllowUserToAddRows = false;
            this.GrdNonMembers.AllowUserToDeleteRows = false;
            this.GrdNonMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdNonMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdNonMembers.Location = new System.Drawing.Point(59, 59);
            this.GrdNonMembers.MultiSelect = false;
            this.GrdNonMembers.Name = "GrdNonMembers";
            this.GrdNonMembers.ReadOnly = true;
            this.GrdNonMembers.RowHeadersVisible = false;
            this.GrdNonMembers.RowHeadersWidth = 51;
            this.GrdNonMembers.RowTemplate.Height = 24;
            this.GrdNonMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdNonMembers.Size = new System.Drawing.Size(675, 268);
            this.GrdNonMembers.TabIndex = 4;
            this.GrdNonMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdNonMembers_CellClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddNew.Location = new System.Drawing.Point(275, 356);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(266, 41);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "+ Add Selected Person to Group";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // FrmAddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.GrdNonMembers);
            this.Name = "FrmAddNewPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Person to Group";
            ((System.ComponentModel.ISupportInitialize)(this.GrdNonMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GrdNonMembers;
        private System.Windows.Forms.Button btnAddNew;
    }
}