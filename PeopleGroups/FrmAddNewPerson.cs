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
    public partial class FrmAddNewPerson : Form
    {
        private int groupId;
        private int selectedPersonId;

        public FrmAddNewPerson(int groupId)
        {
            InitializeComponent();
            this.groupId = groupId;
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                DBConnector db = new DBConnector();
                List<SqlParameter> oParams = new List<SqlParameter>();
                oParams.Add(new SqlParameter("@group_id", groupId));
                DataSet oDs = db.GetDSfromSP("get_persons_not_in_group", oParams);
                GrdNonMembers.Rows.Clear();
                GrdNonMembers.Columns.Clear();

                GrdNonMembers.Columns.Add("person_id", "Person Id");
                GrdNonMembers.Columns.Add("first_name", "First Name");
                GrdNonMembers.Columns.Add("last_name", "Last Name");
                GrdNonMembers.Columns.Add("nickname", "NickName");
                GrdNonMembers.Columns.Add("email", "Email");
                GrdNonMembers.Columns.Add("add1", "Address");
                GrdNonMembers.Columns.Add("city", "City");
                GrdNonMembers.Columns.Add("state", "State");
                GrdNonMembers.Columns.Add("zip", "Zip");

                foreach (DataRow row in oDs.Tables[0].Rows)
                {
                    GrdNonMembers.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
                }

                GrdNonMembers.Columns["person_id"].Visible = false;

                if (GrdNonMembers.Rows.Count > 0)
                    selectedPersonId = Convert.ToInt32(GrdNonMembers.Rows[0].Cells["person_id"].Value.ToString());

            }
            catch (Exception ex)
            {

            }            
        }

        private void GrdNonMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedPersonId = Convert.ToInt32(GrdNonMembers.Rows[e.RowIndex].Cells["person_id"].Value.ToString());
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
           
            try
            {
                DBConnector db = new DBConnector();

                List<SqlParameter> oParams = new List<SqlParameter>();
                oParams.Add(new SqlParameter("@group_id", groupId));
                oParams.Add(new SqlParameter("@person_id", selectedPersonId));

                db.ExecuteSP("add_person_to_group", oParams);

                RefreshData();
                this.Hide();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
