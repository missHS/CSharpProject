namespace MagicTrainingProject
{
    partial class StartPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonScheduleClass = new System.Windows.Forms.Button();
            this.buttonAdministrateClasses = new System.Windows.Forms.Button();
            this.dataGridViewUpcomingClasses = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRegisterMemberOnClass = new System.Windows.Forms.Button();
            this.buttonUnregisterMemberFromClass = new System.Windows.Forms.Button();
            this.buttonEditScheduledClass = new System.Windows.Forms.Button();
            this.dTPickerFilterDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearDateFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(33, 55);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(224, 20);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to Magic Training";
            // 
            // buttonScheduleClass
            // 
            this.buttonScheduleClass.BackColor = System.Drawing.Color.Linen;
            this.buttonScheduleClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonScheduleClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScheduleClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleClass.Location = new System.Drawing.Point(37, 107);
            this.buttonScheduleClass.Name = "buttonScheduleClass";
            this.buttonScheduleClass.Size = new System.Drawing.Size(225, 44);
            this.buttonScheduleClass.TabIndex = 2;
            this.buttonScheduleClass.Text = "Schedule Class";
            this.buttonScheduleClass.UseVisualStyleBackColor = false;
            this.buttonScheduleClass.Click += new System.EventHandler(this.buttonScheduleClass_Click);
            // 
            // buttonAdministrateClasses
            // 
            this.buttonAdministrateClasses.BackColor = System.Drawing.Color.Linen;
            this.buttonAdministrateClasses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonAdministrateClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdministrateClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdministrateClasses.Location = new System.Drawing.Point(37, 168);
            this.buttonAdministrateClasses.Name = "buttonAdministrateClasses";
            this.buttonAdministrateClasses.Size = new System.Drawing.Size(225, 44);
            this.buttonAdministrateClasses.TabIndex = 3;
            this.buttonAdministrateClasses.Text = "Administrate Classes";
            this.buttonAdministrateClasses.UseVisualStyleBackColor = false;
            this.buttonAdministrateClasses.Click += new System.EventHandler(this.buttonAdministrateClasses_Click);
            // 
            // dataGridViewUpcomingClasses
            // 
            this.dataGridViewUpcomingClasses.AllowUserToAddRows = false;
            this.dataGridViewUpcomingClasses.AllowUserToDeleteRows = false;
            this.dataGridViewUpcomingClasses.AllowUserToResizeColumns = false;
            this.dataGridViewUpcomingClasses.AllowUserToResizeRows = false;
            this.dataGridViewUpcomingClasses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpcomingClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUpcomingClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpcomingClasses.Location = new System.Drawing.Point(365, 86);
            this.dataGridViewUpcomingClasses.Name = "dataGridViewUpcomingClasses";
            this.dataGridViewUpcomingClasses.ReadOnly = true;
            this.dataGridViewUpcomingClasses.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Peru;
            this.dataGridViewUpcomingClasses.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUpcomingClasses.Size = new System.Drawing.Size(399, 326);
            this.dataGridViewUpcomingClasses.TabIndex = 4;
            this.dataGridViewUpcomingClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpcomingClasses_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Upcoming Classes";
            // 
            // buttonRegisterMemberOnClass
            // 
            this.buttonRegisterMemberOnClass.BackColor = System.Drawing.Color.Linen;
            this.buttonRegisterMemberOnClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonRegisterMemberOnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterMemberOnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterMemberOnClass.Location = new System.Drawing.Point(37, 228);
            this.buttonRegisterMemberOnClass.Name = "buttonRegisterMemberOnClass";
            this.buttonRegisterMemberOnClass.Size = new System.Drawing.Size(225, 44);
            this.buttonRegisterMemberOnClass.TabIndex = 6;
            this.buttonRegisterMemberOnClass.Text = "Register Member on Class";
            this.buttonRegisterMemberOnClass.UseVisualStyleBackColor = false;
            this.buttonRegisterMemberOnClass.Click += new System.EventHandler(this.buttonRegisterMemberOnClass_Click);
            // 
            // buttonUnregisterMemberFromClass
            // 
            this.buttonUnregisterMemberFromClass.BackColor = System.Drawing.Color.Linen;
            this.buttonUnregisterMemberFromClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonUnregisterMemberFromClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonUnregisterMemberFromClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnregisterMemberFromClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnregisterMemberFromClass.Location = new System.Drawing.Point(37, 287);
            this.buttonUnregisterMemberFromClass.Name = "buttonUnregisterMemberFromClass";
            this.buttonUnregisterMemberFromClass.Size = new System.Drawing.Size(225, 44);
            this.buttonUnregisterMemberFromClass.TabIndex = 7;
            this.buttonUnregisterMemberFromClass.Text = "Unregister Member on Class";
            this.buttonUnregisterMemberFromClass.UseVisualStyleBackColor = false;
            this.buttonUnregisterMemberFromClass.Click += new System.EventHandler(this.buttonUnregisterMemberFromClass_Click);
            // 
            // buttonEditScheduledClass
            // 
            this.buttonEditScheduledClass.BackColor = System.Drawing.Color.Linen;
            this.buttonEditScheduledClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonEditScheduledClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditScheduledClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditScheduledClass.Location = new System.Drawing.Point(37, 347);
            this.buttonEditScheduledClass.Name = "buttonEditScheduledClass";
            this.buttonEditScheduledClass.Size = new System.Drawing.Size(225, 44);
            this.buttonEditScheduledClass.TabIndex = 8;
            this.buttonEditScheduledClass.Text = "Edit Schedule Class";
            this.buttonEditScheduledClass.UseVisualStyleBackColor = false;
            this.buttonEditScheduledClass.Click += new System.EventHandler(this.buttonEditScheduledClass_Click);
            // 
            // dTPickerFilterDate
            // 
            this.dTPickerFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerFilterDate.Location = new System.Drawing.Point(639, 60);
            this.dTPickerFilterDate.Name = "dTPickerFilterDate";
            this.dTPickerFilterDate.Size = new System.Drawing.Size(96, 20);
            this.dTPickerFilterDate.TabIndex = 10;
            this.dTPickerFilterDate.ValueChanged += new System.EventHandler(this.DatePickerFilterDate_ValueChanged);
            // 
            // btnClearDateFilter
            // 
            this.btnClearDateFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearDateFilter.FlatAppearance.BorderSize = 0;
            this.btnClearDateFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDateFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearDateFilter.Image")));
            this.btnClearDateFilter.Location = new System.Drawing.Point(740, 60);
            this.btnClearDateFilter.Name = "btnClearDateFilter";
            this.btnClearDateFilter.Size = new System.Drawing.Size(22, 20);
            this.btnClearDateFilter.TabIndex = 11;
            this.btnClearDateFilter.UseVisualStyleBackColor = true;
            this.btnClearDateFilter.Click += new System.EventHandler(this.btnClearDateFilter_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearDateFilter);
            this.Controls.Add(this.dTPickerFilterDate);
            this.Controls.Add(this.buttonEditScheduledClass);
            this.Controls.Add(this.buttonUnregisterMemberFromClass);
            this.Controls.Add(this.buttonRegisterMemberOnClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewUpcomingClasses);
            this.Controls.Add(this.buttonAdministrateClasses);
            this.Controls.Add(this.buttonScheduleClass);
            this.Controls.Add(this.labelWelcome);
            this.Name = "StartPage";
            this.Text = "StartPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonScheduleClass;
        private System.Windows.Forms.Button buttonAdministrateClasses;
        private System.Windows.Forms.DataGridView dataGridViewUpcomingClasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRegisterMemberOnClass;
        private System.Windows.Forms.Button buttonUnregisterMemberFromClass;
        private System.Windows.Forms.Button buttonEditScheduledClass;
        private System.Windows.Forms.DateTimePicker dTPickerFilterDate;
        private System.Windows.Forms.Button btnClearDateFilter;
    }
}

