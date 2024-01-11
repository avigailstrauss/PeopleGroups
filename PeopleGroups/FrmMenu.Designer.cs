
namespace PeopleGroups
{
    partial class FrmMenu
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
            this.Button1 = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.GrdGroups = new System.Windows.Forms.DataGridView();
            this.BtnViewEdit = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnViewPeople = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdGroups)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(26, 104);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(211, 48);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "+ Add New Group";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(26, 237);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(211, 48);
            this.btnDeleteGroup.TabIndex = 2;
            this.btnDeleteGroup.Text = "Delete Selected Group";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.BtnDeleteGroup_Click);
            // 
            // GrdGroups
            // 
            this.GrdGroups.AllowUserToAddRows = false;
            this.GrdGroups.AllowUserToDeleteRows = false;
            this.GrdGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdGroups.ColumnHeadersVisible = false;
            this.GrdGroups.Location = new System.Drawing.Point(140, 137);
            this.GrdGroups.MultiSelect = false;
            this.GrdGroups.Name = "GrdGroups";
            this.GrdGroups.ReadOnly = true;
            this.GrdGroups.RowHeadersVisible = false;
            this.GrdGroups.RowHeadersWidth = 51;
            this.GrdGroups.RowTemplate.Height = 24;
            this.GrdGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdGroups.Size = new System.Drawing.Size(303, 382);
            this.GrdGroups.TabIndex = 3;
            this.GrdGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdGroups_CellClick);
            this.GrdGroups.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Form1_DataBindingComplete);
            // 
            // BtnViewEdit
            // 
            this.BtnViewEdit.Location = new System.Drawing.Point(26, 173);
            this.BtnViewEdit.Name = "BtnViewEdit";
            this.BtnViewEdit.Size = new System.Drawing.Size(211, 48);
            this.BtnViewEdit.TabIndex = 4;
            this.BtnViewEdit.Text = "View/Edit Group";
            this.BtnViewEdit.UseVisualStyleBackColor = true;
            this.BtnViewEdit.Click += new System.EventHandler(this.BtnViewEdit_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(26, 40);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(211, 48);
            this.BtnImport.TabIndex = 5;
            this.BtnImport.Text = "+ Import New People";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.BtnViewPeople);
            this.groupBox1.Controls.Add(this.BtnViewEdit);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.BtnImport);
            this.groupBox1.Controls.Add(this.btnDeleteGroup);
            this.groupBox1.Location = new System.Drawing.Point(501, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 388);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // BtnViewPeople
            // 
            this.BtnViewPeople.Location = new System.Drawing.Point(26, 302);
            this.BtnViewPeople.Name = "BtnViewPeople";
            this.BtnViewPeople.Size = new System.Drawing.Size(211, 48);
            this.BtnViewPeople.TabIndex = 6;
            this.BtnViewPeople.Text = "View All People";
            this.BtnViewPeople.UseVisualStyleBackColor = true;
            this.BtnViewPeople.Click += new System.EventHandler(this.BtnViewPeople_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(135, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Groups";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrdGroups);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.GrdGroups)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.DataGridView GrdGroups;
        private System.Windows.Forms.Button BtnViewEdit;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnViewPeople;
    }
}

