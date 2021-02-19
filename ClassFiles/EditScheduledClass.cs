using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTrainingProject
{
    public partial class EditScheduledClass : Form
    {
        private int selectedClass;
        private string nameDate;
        

        public EditScheduledClass()
        {
            InitializeComponent();
            FillDataGridScheduledClass();
            ResetComboBoxesAndTextBox();
        }

        public void FillDataGridScheduledClass()
        {
            try
            {
                DataTable tableScheduledClasses = DAL.GetDataTable(SQL.GetScheduledClassFullOverview());
                dataGridScheduledClass.DataSource = tableScheduledClasses;
            }
                  catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong, please contact dial 00-000000 for further assistans. Exception {ex}");
            }
        }


        public void ResetComboBoxesAndTextBox()
        {
            comboBoxScheduledClassHour.SelectedIndex = -1;
            comboBoxScheduledClassMin.SelectedIndex = -1;
            comboBoxScheduledClassRoom.SelectedIndex = -1;
            textBoxScheduledClassInstructor.Text = "";
            monthCalendarScheduledClass.SetDate(monthCalendarScheduledClass.TodayDate);
        }

        private void buttonUpdateScheduledClass_Click(object sender, EventArgs e)
        {
            try
            {
                int scheduledClassID = selectedClass;
                string classDate = monthCalendarScheduledClass.SelectionRange.ToString();
                string classTime = comboBoxScheduledClassHour.SelectedItem.ToString() + ":" + comboBoxScheduledClassMin.SelectedItem.ToString();
                string classRoom = comboBoxScheduledClassRoom.SelectedItem.ToString();
                string classInstructor = textBoxScheduledClassInstructor.Text;

                string[] dateTime = classDate.Split(' ');
                classDate = dateTime[2];
         

                if (!classTime.Equals(DAL.GetDataTable(SQL.CastClassTime(scheduledClassID)).Rows[0].ItemArray[0].ToString()) || !classRoom.Equals(DAL.GetDataTable(SQL.FillRoomName(scheduledClassID)).Rows[0].ItemArray[0].ToString()) || !classInstructor.Equals(DAL.GetDataTable(SQL.FillInstructorName(scheduledClassID)).Rows[0].ItemArray[0].ToString()) || !classDate.Equals(DAL.GetDataTable(SQL.FillClassDate(scheduledClassID)).Rows[0].ItemArray[0].ToString()))
                {
                    DAL.SendData(SQL.UpdateScheduledClass(scheduledClassID, classDate, classTime, classRoom, classInstructor));
                    labelResponseEditScheduledClass.Text = $"{nameDate} is updated";
                    FillDataGridScheduledClass();
                    ResetComboBoxesAndTextBox();
                }
           
            }
            catch (NullReferenceException ex)
            {
                labelResponseEditScheduledClass.Text = "Make sure you have provided all the needed information";
            }
           



            catch (Exception ex)
            {
                labelResponseEditScheduledClass.Text = "Something whent wrong, please contact dial 00-000000 for further assistans" + ex;
            }
        }

        private void buttonDeleteScheduledClass_Click(object sender, EventArgs e)
        {
            int scheduledClassID = selectedClass;
            

            try
            {
                DAL.SendData(SQL.DeleteScheduledClass(scheduledClassID));
                labelResponseEditScheduledClass.Text = $"{nameDate} has been deleted";
                FillDataGridScheduledClass();
                ResetComboBoxesAndTextBox();
            }
            catch (NullReferenceException ex)
            {
                labelResponseEditScheduledClass.Text = "Select a class in the list";
            }
          
            catch (Exception ex)
            {
                labelResponseEditScheduledClass.Text = "Something whent wrong, please contact dial 00-000000 for further assistans " + ex;
            }
        }

        private void dataGridScheduledClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelResponseEditScheduledClass.Text = "";
            ResetComboBoxesAndTextBox();

            try
            {
                selectedClass = Int32.Parse(dataGridScheduledClass.Rows[e.RowIndex].Cells[5].Value.ToString());
                nameDate = dataGridScheduledClass.Rows[e.RowIndex].Cells[0].Value.ToString();
                nameDate += " " + dataGridScheduledClass.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(0,10);

                comboBoxScheduledClassRoom.Text = DAL.GetDataTable(SQL.FillRoomName(selectedClass)).Rows[0]["roomName"].ToString();
                textBoxScheduledClassInstructor.Text = DAL.GetDataTable(SQL.FillInstructorName(selectedClass)).Rows[0]["instructorName"].ToString();
                comboBoxScheduledClassHour.Text = DAL.GetDataTable(SQL.FillClassTime(selectedClass)).Rows[0]["classTime"].ToString().Substring(0, 2);
                comboBoxScheduledClassMin.Text = DAL.GetDataTable(SQL.FillClassTime(selectedClass)).Rows[0]["classTime"].ToString().Substring(3, 2);

                var parsedDate = DateTime.Parse(DAL.GetDataTable(SQL.FillClassDate(selectedClass)).Rows[0]["classDate"].ToString());
                monthCalendarScheduledClass.SetDate(parsedDate);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                labelResponseEditScheduledClass.Text = "Make sure you have selected a class in the list";
            }
         

            catch (Exception ex)
            {
                labelResponseEditScheduledClass.Text = "Something whent wrong, please contact dial 00-000000 for further assistans " + ex;
            }

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartPage startPage = new StartPage();
            startPage.Visible = true;
        }
    }
}
