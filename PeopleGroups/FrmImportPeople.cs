using PeopleGroups.Models;
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
    public partial class FrmImportPeople : Form
    {
        private string filepath;
        public FrmImportPeople()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.ShowDialog();
                TxtFilepath.Text = fileDialog.FileName;
            }
            catch(Exception ex)
            {

            }
            
        }

        private void InsertPeople(List<Person> people)
        {
            try
            {
                DataTable oDt = new DataTable();
                oDt.Columns.Add("first_name");
                oDt.Columns.Add("last_name");
                oDt.Columns.Add("nickname");
                oDt.Columns.Add("email");
                oDt.Columns.Add("add1");
                oDt.Columns.Add("city");
                oDt.Columns.Add("state");
                oDt.Columns.Add("zip");

                foreach (Person person in people)
                {
                    DataRow row = oDt.NewRow();
                    row[0] = person.FName;
                    row[1] = person.LName;
                    row[2] = person.NickName;
                    row[3] = person.email;
                    row[4] = person.Add1;
                    row[5] = person.City;
                    row[6] = person.State;
                    row[7] = person.Zip;

                    oDt.Rows.Add(row);
                }

                DBConnector db = new DBConnector();
                List<SqlParameter> oParams = new List<SqlParameter>();
                oParams.Add(new SqlParameter("@persons", oDt));
                db.ExecuteSP("insert_persons", oParams);
                MessageBox.Show("Success!");
                this.Hide();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            filepath = TxtFilepath.Text;
            if (filepath == null || filepath.Replace(" ", "") == "")
            {
                MessageBox.Show("Please choose a file.");
            }
            else
            {
                try
                {
                    string text = File.ReadAllText(filepath);
                    List<Person> people = JsonSerializer.Deserialize<List<Person>>(text);
                    InsertPeople(people);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
