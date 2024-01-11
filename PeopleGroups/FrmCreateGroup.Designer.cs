
namespace PeopleGroups
{
    partial class FrmCreateGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(71, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGroupName.Location = new System.Drawing.Point(209, 80);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(213, 26);
            this.txtGroupName.TabIndex = 1;
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(195, 153);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(144, 46);
            this.btnCreateGroup.TabIndex = 2;
            this.btnCreateGroup.Text = "Create Group";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.BtnCreateGroup_Click);
            // 
            // FrmCreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 253);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreateGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnCreateGroup;
    }
}