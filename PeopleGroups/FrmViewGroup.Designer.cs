
namespace PeopleGroups
{
    partial class FrmViewGroup
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
            this.GrdMembers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdMembers
            // 
            this.GrdMembers.AllowUserToAddRows = false;
            this.GrdMembers.AllowUserToDeleteRows = false;
            this.GrdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMembers.Location = new System.Drawing.Point(66, 90);
            this.GrdMembers.Name = "GrdMembers";
            this.GrdMembers.ReadOnly = true;
            this.GrdMembers.RowHeadersVisible = false;
            this.GrdMembers.RowHeadersWidth = 51;
            this.GrdMembers.RowTemplate.Height = 24;
            this.GrdMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdMembers.Size = new System.Drawing.Size(838, 294);
            this.GrdMembers.TabIndex = 0;
            this.GrdMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMembers_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group Members";
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRemove.Location = new System.Drawing.Point(718, 47);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(186, 37);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Remove from Group";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAddNew.Location = new System.Drawing.Point(538, 47);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(174, 37);
            this.BtnAddNew.TabIndex = 5;
            this.BtnAddNew.Text = "+ Add New Members";
            this.BtnAddNew.UseVisualStyleBackColor = false;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // FrmViewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 455);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdMembers);
            this.Name = "FrmViewGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Remove Members";
            ((System.ComponentModel.ISupportInitialize)(this.GrdMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAddNew;
    }
}