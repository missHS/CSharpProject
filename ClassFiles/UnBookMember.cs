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
    public partial class UnBookMember : Form
    {

        private int scheduledClassIDSelected;
        private string memberNumberSelected;
        private string memberName;
        private string scheduledClassName;

        public UnBookMember()
        {
            InitializeComponent();
           
            FillDataGridScheduledClass();
            labelUnregistered.Text = "";
        }



        public void FillDataGridViewMembers()
        {
            try
            {
                DataTable dataTable = DAL.GetDataTable(SQL.GetMembersBookedOnClass(scheduledClassIDSelected));
                dataGridViewMembers.DataSource = dataTable;
            }
           
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong, please contact dial 00-000000 for further assistans. Exception {ex}");
            }

        }
            public void FillDataGridScheduledClass()
        {
            try
            {
                DataTable dataTable = DAL.GetDataTable(SQL.GetScheduledClassFullOverview());
                dataGridViewOverview.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong, please contact dial 00-000000 for further assistans. Exception {ex} ");
            }
        }
       

        private void DataGridViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
             
                {
                    labelUnregistered.Text = "";
                    memberNumberSelected = dataGridViewMembers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    memberName = dataGridViewMembers.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
                catch (ArgumentOutOfRangeException ex)
            {
                labelUnregistered.Text = "Make sure you have selected a class in the list";
            }
        
        }

        private void ButtonUnregisterMember_Click(object sender, EventArgs e)
        {

            try
            {
                if (memberNumberSelected != null)
                {
                    DAL.SendData(SQL.DeleteMemberFromBookingClass(memberNumberSelected));
                    FillDataGridViewMembers(); 
                    labelUnregistered.Text = $"{memberName} is unregistered from {scheduledClassName}";
                    memberNumberSelected = null;
                }
                else if (memberNumberSelected == null)
                {
                    labelUnregistered.Text = "Select a member to unregister";
                }
            }         
            catch (Exception ex)
            {

                labelUnregistered.Text = $"Something went wrong, please contact dial 00-000000 for further assistans. Exception {ex}";


            }  
            
        }

       

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartPage startPage = new StartPage();
            startPage.Visible = true;
        }

        private void DataGridViewOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                scheduledClassIDSelected = Int32.Parse(dataGridViewOverview.Rows[e.RowIndex].Cells[5].Value.ToString());
                scheduledClassName = dataGridViewOverview.Rows[e.RowIndex].Cells[0].Value.ToString();
                FillDataGridViewMembers();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                labelUnregistered.Text = "Make sure you have selected a class in the list";
            }


        }
    }
}
