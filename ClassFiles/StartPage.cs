using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTrainingProject
{
    public partial class StartPage : Form
    {
        private int scheduledClassIDSelected;       

        public StartPage()
        {
            InitializeComponent();
            FillDataGridViewUpcomingClasses();
            
        }

        public void FillDataGridViewUpcomingClasses()
        {

            DataTable dataTable = DAL.GetDataTable(SQL.GetScheduledClassFullOverview());
            dataGridViewUpcomingClasses.DataSource = dataTable;

        }

        private void buttonScheduleClass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ScheduleClass scheduleClass = new ScheduleClass();
            scheduleClass.Visible = true;
        }

        private void buttonAdministrateClasses_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdministrateClass administrateClass = new AdministrateClass();
           
            administrateClass.Visible = true;
        }

        private void dataGridViewUpcomingClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                scheduledClassIDSelected = Int32.Parse(dataGridViewUpcomingClasses.Rows[e.RowIndex].Cells[5].Value.ToString());                

            }
        
        }


        private void buttonUnregisterMemberFromClass_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            UnBookMember unBookMember = new UnBookMember();
            //unBookMember.GetInfoFromStartPage(scheduledClassIDSelected);
            unBookMember.Visible = true;
        }

        private void buttonRegisterMemberOnClass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BookMemberOnClass  BookBookMember = new BookMemberOnClass();
            BookBookMember.Visible = true;
        }

        private void buttonEditScheduledClass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EditScheduledClass editScheduledClass = new EditScheduledClass();
            // Create method in Malins form ---- editScheduledClass.GetInfoFromStartPage(scheduledClassIDSelected);
            editScheduledClass.Visible = true;
        }

        private void DatePickerFilterDate_ValueChanged(object sender, EventArgs e)
        {
            string date = dTPickerFilterDate.Value.ToShortDateString();

            DataTable dataTable = DAL.GetDataTable(SQL.GetScheduledClassFilteredOverview(date));
            dataGridViewUpcomingClasses.DataSource = dataTable;
        }

        private void btnClearDateFilter_Click(object sender, EventArgs e)
        {
            dTPickerFilterDate.Value = DateTime.Now;
            FillDataGridViewUpcomingClasses();
        }
    }
}
