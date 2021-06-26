using Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        int curRow = -1;
        int selectedID = -1;

        public PeopleForm()
        {
            InitializeComponent();
            LoadPeopleList();
        }
        private void People_Shown(Object sender, EventArgs e)
        {
            leeren();
        }
        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople();
            WireUpPeopleList();
            leeren();
        }

        private void WireUpPeopleList()
        {
            dataGridView1.DataSource = people;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();

            p.Id = selectedID;
            p.VorName = firstNameText.Text;
            p.NachName = lastNameText.Text;
            p.LieblingsLehrer = lieblingsLehrerText.Text;
            p.LieblingsDino = lieblingsDinoText.Text;

            SqliteDataAccess.SavePerson(p);

            selectedID = -1;
            firstNameText.Text = "";
            lastNameText.Text = "";
            lieblingsLehrerText.Text = "";
            lieblingsDinoText.Text = "";

            LoadPeopleList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (!row.IsNewRow)
            {
                curRow = dataGridView1.CurrentRow.Index;
                selectedID = (int)row.Cells[0].Value;
                firstNameText.Text = row.Cells[1].Value.ToString();
                lastNameText.Text = dataGridView1.Rows[curRow].Cells[2].Value.ToString();
                lieblingsLehrerText.Text = dataGridView1.Rows[curRow].Cells[3].Value.ToString();
                lieblingsDinoText.Text = dataGridView1.Rows[curRow].Cells[4].Value.ToString();
            }
        }

        private void leeren()
        {
            dataGridView1.ClearSelection();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Selected = false;
                }
            }
            dataGridView1.CurrentCell = null;
            selectedID = -1;
            firstNameText.Text = "";
            lastNameText.Text = "";
            lieblingsLehrerText.Text = "";
            lieblingsDinoText.Text = "";
        }

        private void personLöschen_Click(object sender, EventArgs e)
        {
            if(selectedID != -1)
            {
                foreach(DataGridViewRow dataGridViewRow in dataGridView1.SelectedRows)
                {
                    PersonModel p = new PersonModel();

                    p.Id = (int)dataGridViewRow.Cells[0].Value;
                    p.VorName = (string)dataGridViewRow.Cells[1].Value;
                    p.NachName = (string)dataGridViewRow.Cells[2].Value;
                    p.LieblingsLehrer = (string)dataGridViewRow.Cells[3].Value;
                    p.LieblingsDino = (string)dataGridViewRow.Cells[4].Value;

                    SqliteDataAccess.DeletePerson(p);

                    selectedID = -1;
                    firstNameText.Text = "";
                    lastNameText.Text = "";
                    lieblingsLehrerText.Text = "";
                    lieblingsDinoText.Text = "";
                }
                LoadPeopleList();
            }    
        }

        private void dataGridView1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dataGridView1.HitTest(e.X, e.Y) == DataGridView.HitTestInfo.Nowhere)
                {
                    leeren();
                }
            }
        }
    }
}
