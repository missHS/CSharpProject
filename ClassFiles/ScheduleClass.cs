using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MagicTrainingProject
{
    public partial class ScheduleClass : Form

    {
        private string selectedClass;
        
        public ScheduleClass()
        {
            InitializeComponent();
            LoadDataGridWithClasses();
        }

        public void LoadDataGridWithClasses()
        {
            try
            {         
                DataTable tableClasses = DAL.GetDataTable(SQL.GetAllClassesClassNameOnly());
                dataGridViewScheduleClass.DataSource = tableClasses;
            }
            catch(SqlException ex)
            {
                
                    MessageBox.Show("Database error, please contact dial 00-000000 for further assistans");
                
            }
        }



        public void ResetComboBoxesAndTextBox()
        {
            comboBoxHH.SelectedIndex = -1;
            comboBoxMM.SelectedIndex = -1;
            comboBoxRoom.SelectedIndex = -1;            
            TextBoxInstructor.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            try
            {
                int classID = GenerateScheduledClassID();
                string className = selectedClass;
                string classDate = calendarScheduleClass.SelectionRange.ToString();
                string classTime = comboBoxHH.SelectedItem.ToString() + ":" + comboBoxMM.SelectedItem.ToString();
                string classRoom = comboBoxRoom.SelectedItem.ToString();
                string classInstructor = TextBoxInstructor.Text;               

                string[] dateTime = classDate.Split(' ');
                classDate = dateTime[2];

             if (string.IsNullOrEmpty(classInstructor))  
                {
                    throw new NullReferenceException();
                }

                DAL.SendData(SQL.InsertIntoScheduledClass(classID,className, classDate, classTime, classRoom, classInstructor));
                lblrespons.Text = $"Class added: {className} {classDate} {classTime}";
                selectedClass = null;
                ResetComboBoxesAndTextBox();              
            }
            catch(NullReferenceException ex)
            {
                lblrespons.Text = "Make sure you have provided all the needed information";
            }
            catch(SqlException ex)
            {
                if(ex.Number == 547)
                {
                    lblrespons.Text = "Make sure you have selected a class in the list to scheduele";
                }
            }               
        }


        //Generates ID by looking up the highest current ID and adding one
        public int GenerateScheduledClassID()
        {
            try {
                DataTable dataTableClass = DAL.GetDataTable(SQL.GetHighestClassID());
                int classID = Int32.Parse(dataTableClass.Rows[0][0].ToString());

                classID++;
                return classID;
            }
            catch(System.FormatException ex) //if no classes is scheduled
            {
                int classID = 111;
                return classID;
            }
         }

        private void DataGridViewScheduleClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblrespons.Text = "";
                selectedClass = dataGridViewScheduleClass.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                lblrespons.Text = "Make sure you have selected a class in the list";
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
       
        {
            
            StartPage startPage = new StartPage();
            startPage.Visible = true;
            this.Close();
        }

        private void btnCreateNewClass_Click(object sender, EventArgs e)
        {
            AdministrateClass administrateClass = new AdministrateClass()
            {
                Visible = true
            };
            this.Hide();
        }
    }
}
