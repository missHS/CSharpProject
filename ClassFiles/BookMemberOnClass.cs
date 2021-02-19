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

namespace MagicTrainingProject
{
    public partial class BookMemberOnClass : Form
    {

        private int selectedMember;
        private int selectedClass;
        private string memberName;

        public BookMemberOnClass()
        {
            InitializeComponent();
            FillDataGridScheduledClasses();
            FillDataGridMembers();
            ClearLabels();

        }


        public void FillDataGridMembers()
        {
            DataTable tableMembers = DAL.GetDataTable(SQL.GetAllMembers());
            dataGridMembers.DataSource = tableMembers;

        }

        public void FillDataGridScheduledClasses()
        {
            DataTable tableScheduledClasses = DAL.GetDataTable(SQL.GetScheduledClassFullOverview());
            dataGridSceduledClasses.DataSource = tableScheduledClasses;


        }

        public void ClearLabels()
        {
            
            labelMessage.Text = "";

        }


       

        private void ButtonSearchMember_Click(object sender, EventArgs e)
        {
            string searchMember = textBoxSearchMember.Text;
            dataGridMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ClearLabels();

            try
            {

                foreach (DataGridViewRow row in dataGridMembers.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchMember))
                    {
                        row.Selected = true;


                        labelMessage.Text = "Member found";
                        break;

                    }
                    else if (row.Cells[1].Value.ToString().Equals(searchMember, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        labelMessage.Text = "Member found";
                        break;
                    }

                    else if ((string.IsNullOrEmpty(searchMember)))
                    {
                        labelMessage.Text = "Fill in a name or number";
                        break;
                        

                    }
                    else
                    {
                        labelMessage.Text = "Member does not exist";
                       
                    }
                }


            }

            catch (Exception ex)
            {

                labelMessage.Text = $"Something went wrong, please contact dial 00-000000 for further assistans. Exception {ex} ";
            }





        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {

            try
            {
                int memberNumber = selectedMember;
                int scheduledClassID = selectedClass;
                ClearLabels();


                if (memberNumber != 0 && scheduledClassID != 0)
                {
                    DAL.SendData(SQL.InsertIntoBookingClass(memberNumber, scheduledClassID));
                    labelMessage.Text = $"{memberName} is booked on class.";


                }
                else if (memberNumber == 0 || scheduledClassID == 0)
                {
                    labelMessage.Text = "Select both a member and a class in the lists";
                }


            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    labelMessage.Text = $"{memberName} is already booked on that class";
                }
                else
                {
                    MessageBox.Show("Something went wrong with the database, please contact dial 00-000000 for further assistans");
                }

            }


        }

        private void DataGridSceduledClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedClass = Int32.Parse(dataGridSceduledClasses.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                labelMessage.Text = "Make sure you have selected a class in the list";
            }
        }

        private void DataGridMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedMember = Int32.Parse(dataGridMembers.Rows[e.RowIndex].Cells[0].Value.ToString());
                memberName = dataGridMembers.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
             catch (ArgumentOutOfRangeException ex)
            {
                labelMessage.Text = "Make sure you have selected a class in the list";
            }

        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartPage startPage = new StartPage();
            startPage.Visible = true;

        }
    }
}
