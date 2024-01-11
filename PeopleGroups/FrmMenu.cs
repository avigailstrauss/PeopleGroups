using PeopleGroups.Models;
//using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleGroups
{
    public partial class FrmMenu : Form
    {
        private int selectedGroupId;

        public FrmMenu()
        {
            InitializeComponent();
            RefreshData();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCreateGroup frmCreateGroup = new FrmCreateGroup();
                frmCreateGroup.ShowDialog();
                RefreshData();
            }
            catch (Exception ex)
            {

            }
        }

        private void GrdGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedGroupId = Convert.ToInt32(GrdGroups.Rows[e.RowIndex].Cells["group_id"].Value.ToString());
                btnDeleteGroup.Enabled = true;
                BtnViewEdit.Enabled = true;
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            FrmImportPeople FormImportPeople = new FrmImportPeople();
            FormImportPeople.Show();
        }

        private void BtnViewEdit_Click(object sender, EventArgs e)
        {
            FrmViewGroup formViewGroup = new FrmViewGroup(selectedGroupId);
            formViewGroup.Show();
        }


        public void RefreshData()
        {
            try
            {
                DBConnector db = new DBConnector();
                DataSet oDs = db.GetDSfromSP("get_groups", new List<SqlParameter>());

                GrdGroups.Rows.Clear();
                GrdGroups.Columns.Clear();


                GrdGroups.Columns.Add("group_id", "Group Id");
                GrdGroups.Columns.Add("group_name", "Group Name");

                foreach (DataRow row in oDs.Tables[0].Rows)
                {
                    GrdGroups.Rows.Add(row[0], row[1]);
                }

                GrdGroups.Columns["group_id"].Visible = false;
              
                if (GrdGroups.Rows.Count > 0)
                {
                    selectedGroupId = Convert.ToInt32(GrdGroups.Rows[0].Cells["group_id"].Value.ToString());
                }
                else
                {
                    btnDeleteGroup.Enabled = false;
                    BtnViewEdit.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                
            }
            

        }

        private void Form1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GrdGroups.ClearSelection();
        }
        
        private void BtnViewPeople_Click(object sender, EventArgs e)
        {
            FrmViewAllPeople formViewAllPeople = new FrmViewAllPeople();
            formViewAllPeople.Show();
        }

        private void BtnDeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnector db = new DBConnector();
                List<SqlParameter> oParams = new List<SqlParameter>();
                oParams.Add(new SqlParameter("@group_id", selectedGroupId));
                db.ExecuteSP("delete_group", oParams);
                DataSet oDs = db.GetDSfromSP("get_groups", new List<SqlParameter>());
                RefreshData();
            }
            catch(Exception ex)
            {

            }
           
        }
    }
}