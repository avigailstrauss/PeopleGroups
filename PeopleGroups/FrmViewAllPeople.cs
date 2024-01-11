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
    public partial class FrmViewAllPeople : Form
    {
        public FrmViewAllPeople()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DBConnector db = new DBConnector();
                DataSet oDs = db.GetDSfromSP("get_persons", new List<SqlParameter>());

                GrdAllPeople.Rows.Clear();
                GrdAllPeople.Columns.Clear();

                GrdAllPeople.Columns.Add("person_id", "Person Id");
                GrdAllPeople.Columns.Add("first_name", "First Name");
                GrdAllPeople.Columns.Add("last_name", "Last Name");
                GrdAllPeople.Columns.Add("nickname", "NickName");
                GrdAllPeople.Columns.Add("email", "Email");
                GrdAllPeople.Columns.Add("add1", "Address");
                GrdAllPeople.Columns.Add("city", "City");
                GrdAllPeople.Columns.Add("state", "State");
                GrdAllPeople.Columns.Add("zip", "Zip");

                foreach (DataRow row in oDs.Tables[0].Rows)
                {
                    GrdAllPeople.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
                }

                GrdAllPeople.Columns["person_id"].Visible = false;
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
