using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleGroups
{
    public partial class FrmViewGroup : Form
    {
        private int groupId;
        private int selectedPersonId;
        public FrmViewGroup(int groupId)
        {          
            this.groupId = groupId;
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
            try
            {               

                DBConnector db = new DBConnector();
                List<SqlParameter> oParams = new List<SqlParameter>();
                oParams.Add(new SqlParameter("@group_id", groupId));
                DataSet oDs = db.GetDSfromSP("get_persons_in_group", oParams);

                GrdMembers.Rows.Clear();
                GrdMembers.Columns.Clear();

                GrdMembers.Columns.Add("person_id", "Person Id");
                GrdMembers.Columns.Add("first_name", "First Name");
                GrdMembers.Columns.Add("last_name", "Last Name");
                GrdMembers.Columns.Add("nickname", "NickName");
                GrdMembers.Columns.Add("email", "Email");
                GrdMembers.Columns.Add("add1", "Address");
                GrdMembers.Columns.Add("city", "City");
                GrdMembers.Columns.Add("state", "State");
                GrdMembers.Columns.Add("zip", "Zip");

                foreach (DataRow row in oDs.Tables[0].Rows)
                {
                    GrdMembers.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
                }

                GrdMembers.Columns["person_id"].Visible = false;

                if (GrdMembers.Rows.Count > 0)
                {
                    selectedPersonId = Convert.ToInt32(GrdMembers.Rows[0].Cells["person_id"].Value.ToString());
                    if (!BtnRemove.Enabled)
                        BtnRemove.Enabled = true;
                }
                else
                {
                    BtnRemove.Enabled = false;                   
                }
            }
            catch(Exception ex)
            {

            }            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnector db = new DBConnector();

                List<SqlParameter> oParams = new List<SqlParameter>();
                oParams.Add(new SqlParameter("@group_id", groupId));
                oParams.Add(new SqlParameter("@person_id", selectedPersonId));

                db.ExecuteSP("remove_person_from_group", oParams);

                DataSet oDs = db.GetDSfromSP("get_groups", new List<SqlParameter>());
                RefreshData();
            }
            catch (Exception ex)
            {

            }
        }

        private void GrdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedPersonId = Convert.ToInt32(GrdMembers.Rows[e.RowIndex].Cells["person_id"].Value.ToString());
                BtnRemove.Enabled = true;
            }
        }      

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddNewPerson formAddNewPerson = new FrmAddNewPerson(groupId);
            formAddNewPerson.ShowDialog();
            RefreshData();
        }      
    }
}
