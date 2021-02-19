namespace MagicTrainingProject
{
    partial class ScheduleClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleClass));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreateNewClass = new System.Windows.Forms.Button();
            this.calendarScheduleClass = new System.Windows.Forms.MonthCalendar();
            this.TextBoxInstructor = new System.Windows.Forms.TextBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.comboBoxHH = new System.Windows.Forms.ComboBox();
            this.comboBoxMM = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblScheduleClass = new System.Windows.Forms.Label();
            this.lblrespons = new System.Windows.Forms.Label();
            this.labelAvailaleClasses = new System.Windows.Forms.Label();
            this.labelInstructor = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewScheduleClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheduleClass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNewClass
            // 
            this.btnCreateNewClass.BackColor = System.Drawing.Color.Linen;
            this.btnCreateNewClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnCreateNewClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewClass.Location = new System.Drawing.Point(93, 326);
            this.btnCreateNewClass.Name = "btnCreateNewClass";
            this.btnCreateNewClass.Size = new System.Drawing.Size(125, 26);
            this.btnCreateNewClass.TabIndex = 0;
            this.btnCreateNewClass.Text = "Create New Class";
            this.btnCreateNewClass.UseVisualStyleBackColor = false;
            this.btnCreateNewClass.Click += new System.EventHandler(this.btnCreateNewClass_Click);
            // 
            // calendarScheduleClass
            // 
            this.calendarScheduleClass.BackColor = System.Drawing.Color.Linen;
            this.calendarScheduleClass.Location = new System.Drawing.Point(392, 81);
            this.calendarScheduleClass.MaxSelectionCount = 1;
            this.calendarScheduleClass.Name = "calendarScheduleClass";
            this.calendarScheduleClass.ShowTodayCircle = false;
            this.calendarScheduleClass.TabIndex = 2;
            this.calendarScheduleClass.TitleBackColor = System.Drawing.Color.Peru;
            this.calendarScheduleClass.TrailingForeColor = System.Drawing.Color.Black;
            // 
            // TextBoxInstructor
            // 
            this.TextBoxInstructor.Location = new System.Drawing.Point(519, 311);
            this.TextBoxInstructor.Name = "TextBoxInstructor";
            this.TextBoxInstructor.Size = new System.Drawing.Size(93, 20);
            this.TextBoxInstructor.TabIndex = 3;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "Red",
            "Blue"});
            this.comboBoxRoom.Location = new System.Drawing.Point(518, 344);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(94, 21);
            this.comboBoxRoom.TabIndex = 4;
            // 
            // comboBoxHH
            // 
            this.comboBoxHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHH.FormattingEnabled = true;
            this.comboBoxHH.Items.AddRange(new object[] {
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.comboBoxHH.Location = new System.Drawing.Point(517, 275);
            this.comboBoxHH.Name = "comboBoxHH";
            this.comboBoxHH.Size = new System.Drawing.Size(44, 21);
            this.comboBoxHH.TabIndex = 5;
            // 
            // comboBoxMM
            // 
            this.comboBoxMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMM.FormattingEnabled = true;
            this.comboBoxMM.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBoxMM.Location = new System.Drawing.Point(567, 275);
            this.comboBoxMM.Name = "comboBoxMM";
            this.comboBoxMM.Size = new System.Drawing.Size(44, 21);
            this.comboBoxMM.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(389, 278);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Select start time*";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Linen;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(536, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 26);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblScheduleClass
            // 
            this.lblScheduleClass.AutoSize = true;
            this.lblScheduleClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleClass.Location = new System.Drawing.Point(90, 53);
            this.lblScheduleClass.Name = "lblScheduleClass";
            this.lblScheduleClass.Size = new System.Drawing.Size(116, 16);
            this.lblScheduleClass.TabIndex = 9;
            this.lblScheduleClass.Text = "Schedule Class";
            // 
            // lblrespons
            // 
            this.lblrespons.AutoSize = true;
            this.lblrespons.Location = new System.Drawing.Point(390, 428);
            this.lblrespons.Name = "lblrespons";
            this.lblrespons.Size = new System.Drawing.Size(0, 13);
            this.lblrespons.TabIndex = 10;
            // 
            // labelAvailaleClasses
            // 
            this.labelAvailaleClasses.AutoSize = true;
            this.labelAvailaleClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailaleClasses.Location = new System.Drawing.Point(90, 91);
            this.labelAvailaleClasses.Name = "labelAvailaleClasses";
            this.labelAvailaleClasses.Size = new System.Drawing.Size(68, 13);
            this.labelAvailaleClasses.TabIndex = 12;
            this.labelAvailaleClasses.Text = "Select class*";
            // 
            // labelInstructor
            // 
            this.labelInstructor.AutoSize = true;
            this.labelInstructor.Location = new System.Drawing.Point(389, 314);
            this.labelInstructor.Name = "labelInstructor";
            this.labelInstructor.Size = new System.Drawing.Size(93, 13);
            this.labelInstructor.TabIndex = 13;
            this.labelInstructor.Text = "Provide instructor*";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(390, 347);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(67, 13);
            this.labelRoom.TabIndex = 14;
            this.labelRoom.Text = "Select room*";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Home";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dataGridViewScheduleClass
            // 
            this.dataGridViewScheduleClass.AllowUserToAddRows = false;
            this.dataGridViewScheduleClass.AllowUserToDeleteRows = false;
            this.dataGridViewScheduleClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScheduleClass.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScheduleClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewScheduleClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScheduleClass.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewScheduleClass.Location = new System.Drawing.Point(93, 107);
            this.dataGridViewScheduleClass.MultiSelect = false;
            this.dataGridViewScheduleClass.Name = "dataGridViewScheduleClass";
            this.dataGridViewScheduleClass.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScheduleClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewScheduleClass.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Peru;
            this.dataGridViewScheduleClass.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewScheduleClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScheduleClass.Size = new System.Drawing.Size(165, 213);
            this.dataGridViewScheduleClass.TabIndex = 16;
            this.dataGridViewScheduleClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewScheduleClass_CellContentClick);
            // 
            // ScheduleClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.dataGridViewScheduleClass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelInstructor);
            this.Controls.Add(this.labelAvailaleClasses);
            this.Controls.Add(this.lblrespons);
            this.Controls.Add(this.lblScheduleClass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.comboBoxMM);
            this.Controls.Add(this.comboBoxHH);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.TextBoxInstructor);
            this.Controls.Add(this.calendarScheduleClass);
            this.Controls.Add(this.btnCreateNewClass);
            this.Name = "ScheduleClass";
            this.Text = "ScheduleClass";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheduleClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewClass;
        private System.Windows.Forms.MonthCalendar calendarScheduleClass;
        private System.Windows.Forms.TextBox TextBoxInstructor;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.ComboBox comboBoxHH;
        private System.Windows.Forms.ComboBox comboBoxMM;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblScheduleClass;
        private System.Windows.Forms.Label lblrespons;
        private System.Windows.Forms.Label labelAvailaleClasses;
        private System.Windows.Forms.Label labelInstructor;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewScheduleClass;
    }
}