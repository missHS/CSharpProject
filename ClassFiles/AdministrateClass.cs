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
    public partial class AdministrateClass : Form
    {
      
        private string selectedClass;

        public AdministrateClass()
        {
            InitializeComponent();
            FillDataGridCurrentClasses();            

        }
        public void FillDataGridCurrentClasses()
        {
            DataTable tableCurrentClasses = DAL.GetDataTable(SQL.GetAllClassesFullOverview());
            dataGridViewCurrentClasses.DataSource = tableCurrentClasses;
        }
        //Create class
        private void ButtonCreateClass_Click(object sender, EventArgs e)
        {

            string className = textBoxCreateClassName.Text;
            string release = textBoxRelease.Text;
         //   string sql2 = $"INSERT INTO Class VALUES('{className}','{release}')";
         try
            {
                if (String.IsNullOrEmpty(className))
            {
                labelResponse.Text = "The class must have a name";
            }

            else
            {
                DAL.SendData(SQL.InsertIntoClass(className, release));
                FillDataGridCurrentClasses();
                textBoxCreateClassName.Text = "";
                textBoxRelease.Text = "";
                labelResponse.Text = className + " " + release + " was created";
            }
            }
         catch (SqlException ex)

            {
                if (ex.Number == 2627)
                {
                    labelResponse.Text = "A class with that name already exists";
                }
            }
            
        }
        //Delete class
        private void ButtonDeleteClass_Click(object sender, EventArgs e)
        {

            string className = selectedClass;
            if (className != null)
            {
                DAL.SendData(SQL.DeleteClass(className));
                FillDataGridCurrentClasses();
                labelResponse.Text = selectedClass + " was deleted";
                className = null;

            }

        }

        private void DataGridViewCurrentClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {                       
                try

                {
                    labelResponse.Text = "";
                    textBoxCreateClassName.Text = "";
                    textBoxRelease.Text = "";
                    buttonCreateClass.Visible = true;
                    buttonSave.Visible = false;
                    selectedClass = dataGridViewCurrentClasses.Rows[e.RowIndex].Cells[0].Value.ToString();
                    
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    labelResponse.Text = "Make sure you have selected a class in the list";
                }
            }
        
        //Search class
        private void ButtonSearchClass_Click(object sender, EventArgs e)
        {
            
            string classSearch = textBoxSearchClassName.Text;
            dataGridViewCurrentClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewRow row in dataGridViewCurrentClasses.Rows)
            {
               
                if (row.Cells[0].Value.ToString().Equals(classSearch, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    labelResponse.Visible = false;
                    selectedClass = row.Cells[0].Value.ToString();
                    textBoxSearchClassName.Text = "";
                }
                else if (String.IsNullOrEmpty(classSearch)) 
                {
                    row.Selected = false;
                    labelResponse.Text = "Please fill in a class to search";
                    textBoxSearchClassName.Text = "";
                }
                else
                {
                    labelResponse.Text = "Does not exist";
                    textBoxSearchClassName.Text = "";
                }
            
            }
        }
        private void ButtonEditClass_Click(object sender, EventArgs e)
        {
            if (dataGridViewCurrentClasses.Rows.Count > -1)
            {
                textBoxCreateClassName.Text = dataGridViewCurrentClasses.SelectedCells[0].Value.ToString();
                textBoxRelease.Text = dataGridViewCurrentClasses.SelectedCells[1].Value.ToString();
            }
            buttonSave.Visible = true;
            buttonCreateClass.Visible = false;

        }
        //Save edited class
        private void ButtonSave_Click(object sender, EventArgs e)
        {           
            string newRelease = textBoxRelease.Text;
      

            if (textBoxCreateClassName.Text == selectedClass)
            {
                
                DAL.SendData(SQL.UpdateClass(selectedClass, newRelease));
                FillDataGridCurrentClasses();
                textBoxCreateClassName.Text = "";
                textBoxRelease.Text = "";
                buttonCreateClass.Visible = true;
                buttonSave.Visible = false;
                labelResponse.Text = "The class has been updated";
            }
            else labelResponse.Text = "You are not allowed to change the name";

        }
        //Go to home page
        private void ButtonHome_Click(object sender, EventArgs e)
        {           
                this.Visible = false;
                StartPage startPage = new StartPage();
                startPage.Visible = true;
        }
    }
}
