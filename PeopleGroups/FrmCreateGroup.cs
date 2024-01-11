using PeopleGroups.Models;
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
    public partial class FrmCreateGroup : Form
    {
        public FrmCreateGroup()
        {
            InitializeComponent();
            this.AcceptButton = btnCreateGroup;
        }

        private void BtnCreateGroup_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text.Replace(" ","") == "")
            {
                MessageBox.Show("Please enter a name.");
            }
            else
            {
                try
                {
                    DBConnector db = new DBConnector();
                    List<SqlParameter> oParams = new List<SqlParameter>();
                    oParams.Add(new SqlParameter("@group_name", txtGroupName.Text));
                    db.ExecuteSP("create_group", oParams);
                    MessageBox.Show("Success!");
                    this.Hide();
                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}
