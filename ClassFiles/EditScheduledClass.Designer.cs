namespace MagicTrainingProject
{
    partial class EditScheduledClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditScheduledClass));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonUpdateScheduledClass = new System.Windows.Forms.Button();
            this.monthCalendarScheduledClass = new System.Windows.Forms.MonthCalendar();
            this.textBoxScheduledClassInstructor = new System.Windows.Forms.TextBox();
            this.labelScheduledClassID = new System.Windows.Forms.Label();
            this.buttonDeleteScheduledClass = new System.Windows.Forms.Button();
            this.labelResponseEditScheduledClass = new System.Windows.Forms.Label();
            this.comboBoxScheduledClassHour = new System.Windows.Forms.ComboBox();
            this.comboBoxScheduledClassMin = new System.Windows.Forms.ComboBox();
            this.comboBoxScheduledClassRoom = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridScheduledClass = new System.Windows.Forms.DataGridView();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelInstructor = new System.Windows.Forms.Label();
            this.labelRoomSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScheduledClass)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateScheduledClass
            // 
            this.buttonUpdateScheduledClass.BackColor = System.Drawing.Color.Linen;
            this.buttonUpdateScheduledClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonUpdateScheduledClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateScheduledClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateScheduledClass.Location = new System.Drawing.Point(659, 392);
            this.buttonUpdateScheduledClass.Name = "buttonUpdateScheduledClass";
            this.buttonUpdateScheduledClass.Size = new System.Drawing.Size(95, 26);
            this.buttonUpdateScheduledClass.TabIndex = 1;
            this.buttonUpdateScheduledClass.Text = "Update Class";
            this.buttonUpdateScheduledClass.UseVisualStyleBackColor = false;
            this.buttonUpdateScheduledClass.Click += new System.EventHandler(this.buttonUpdateScheduledClass_Click);
            // 
            // monthCalendarScheduledClass
            // 
            this.monthCalendarScheduledClass.Location = new System.Drawing.Point(532, 74);
            this.monthCalendarScheduledClass.MaxSelectionCount = 1;
            this.monthCalendarScheduledClass.Name = "monthCalendarScheduledClass";
            this.monthCalendarScheduledClass.ShowTodayCircle = false;
            this.monthCalendarScheduledClass.TabIndex = 5;
            // 
            // textBoxScheduledClassInstructor
            // 
            this.textBoxScheduledClassInstructor.Location = new System.Drawing.Point(659, 309);
            this.textBoxScheduledClassInstructor.Name = "textBoxScheduledClassInstructor";
            this.textBoxScheduledClassInstructor.Size = new System.Drawing.Size(93, 20);
            this.textBoxScheduledClassInstructor.TabIndex = 6;
            // 
            // labelScheduledClassID
            // 
            this.labelScheduledClassID.AutoSize = true;
            this.labelScheduledClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduledClassID.Location = new System.Drawing.Point(34, 45);
            this.labelScheduledClassID.Name = "labelScheduledClassID";
            this.labelScheduledClassID.Size = new System.Drawing.Size(113, 16);
            this.labelScheduledClassID.TabIndex = 10;
            this.labelScheduledClassID.Text = "Selected Class";
            // 
            // buttonDeleteScheduledClass
            // 
            this.buttonDeleteScheduledClass.BackColor = System.Drawing.Color.Linen;
            this.buttonDeleteScheduledClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonDeleteScheduledClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteScheduledClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteScheduledClass.Location = new System.Drawing.Point(562, 392);
            this.buttonDeleteScheduledClass.Name = "buttonDeleteScheduledClass";
            this.buttonDeleteScheduledClass.Size = new System.Drawing.Size(66, 26);
            this.buttonDeleteScheduledClass.TabIndex = 12;
            this.buttonDeleteScheduledClass.Text = "Delete";
            this.buttonDeleteScheduledClass.UseVisualStyleBackColor = false;
            this.buttonDeleteScheduledClass.Click += new System.EventHandler(this.buttonDeleteScheduledClass_Click);
            // 
            // labelResponseEditScheduledClass
            // 
            this.labelResponseEditScheduledClass.AutoSize = true;
            this.labelResponseEditScheduledClass.Location = new System.Drawing.Point(46, 392);
            this.labelResponseEditScheduledClass.Name = "labelResponseEditScheduledClass";
            this.labelResponseEditScheduledClass.Size = new System.Drawing.Size(0, 13);
            this.labelResponseEditScheduledClass.TabIndex = 13;
            // 
            // comboBoxScheduledClassHour
            // 
            this.comboBoxScheduledClassHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScheduledClassHour.FormattingEnabled = true;
            this.comboBoxScheduledClassHour.ItemHeight = 13;
            this.comboBoxScheduledClassHour.Items.AddRange(new object[] {
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
            this.comboBoxScheduledClassHour.Location = new System.Drawing.Point(658, 263);
            this.comboBoxScheduledClassHour.Name = "comboBoxScheduledClassHour";
            this.comboBoxScheduledClassHour.Size = new System.Drawing.Size(44, 21);
            this.comboBoxScheduledClassHour.TabIndex = 15;
            // 
            // comboBoxScheduledClassMin
            // 
            this.comboBoxScheduledClassMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScheduledClassMin.FormattingEnabled = true;
            this.comboBoxScheduledClassMin.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBoxScheduledClassMin.Location = new System.Drawing.Point(708, 263);
            this.comboBoxScheduledClassMin.Name = "comboBoxScheduledClassMin";
            this.comboBoxScheduledClassMin.Size = new System.Drawing.Size(44, 21);
            this.comboBoxScheduledClassMin.TabIndex = 16;
            // 
            // comboBoxScheduledClassRoom
            // 
            this.comboBoxScheduledClassRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScheduledClassRoom.FormattingEnabled = true;
            this.comboBoxScheduledClassRoom.Items.AddRange(new object[] {
            "Red",
            "Blue"});
            this.comboBoxScheduledClassRoom.Location = new System.Drawing.Point(659, 351);
            this.comboBoxScheduledClassRoom.Name = "comboBoxScheduledClassRoom";
            this.comboBoxScheduledClassRoom.Size = new System.Drawing.Size(94, 21);
            this.comboBoxScheduledClassRoom.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(12, 416);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Home";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridScheduledClass
            // 
            this.dataGridScheduledClass.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridScheduledClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridScheduledClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridScheduledClass.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridScheduledClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridScheduledClass.Location = new System.Drawing.Point(37, 74);
            this.dataGridScheduledClass.MultiSelect = false;
            this.dataGridScheduledClass.Name = "dataGridScheduledClass";
            this.dataGridScheduledClass.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridScheduledClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridScheduledClass.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Peru;
            this.dataGridScheduledClass.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridScheduledClass.Size = new System.Drawing.Size(465, 293);
            this.dataGridScheduledClass.TabIndex = 19;
            this.dataGridScheduledClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridScheduledClass_CellContentClick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(532, 263);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(86, 13);
            this.labelTime.TabIndex = 20;
            this.labelTime.Text = "Select start time*";
            // 
            // labelInstructor
            // 
            this.labelInstructor.AutoSize = true;
            this.labelInstructor.Location = new System.Drawing.Point(535, 315);
            this.labelInstructor.Name = "labelInstructor";
            this.labelInstructor.Size = new System.Drawing.Size(93, 13);
            this.labelInstructor.TabIndex = 21;
            this.labelInstructor.Text = "Provide instructor*";
            // 
            // labelRoomSelect
            // 
            this.labelRoomSelect.AutoSize = true;
            this.labelRoomSelect.Location = new System.Drawing.Point(535, 354);
            this.labelRoomSelect.Name = "labelRoomSelect";
            this.labelRoomSelect.Size = new System.Drawing.Size(67, 13);
            this.labelRoomSelect.TabIndex = 22;
            this.labelRoomSelect.Text = "Select room*";
            // 
            // EditScheduledClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRoomSelect);
            this.Controls.Add(this.labelInstructor);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dataGridScheduledClass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBoxScheduledClassRoom);
            this.Controls.Add(this.comboBoxScheduledClassMin);
            this.Controls.Add(this.comboBoxScheduledClassHour);
            this.Controls.Add(this.labelResponseEditScheduledClass);
            this.Controls.Add(this.buttonDeleteScheduledClass);
            this.Controls.Add(this.labelScheduledClassID);
            this.Controls.Add(this.textBoxScheduledClassInstructor);
            this.Controls.Add(this.monthCalendarScheduledClass);
            this.Controls.Add(this.buttonUpdateScheduledClass);
            this.Name = "EditScheduledClass";
            this.Text = "EditScheduledClass";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScheduledClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdateScheduledClass;
        private System.Windows.Forms.MonthCalendar monthCalendarScheduledClass;
        private System.Windows.Forms.TextBox textBoxScheduledClassInstructor;
        private System.Windows.Forms.Label labelScheduledClassID;
        private System.Windows.Forms.Button buttonDeleteScheduledClass;
        private System.Windows.Forms.Label labelResponseEditScheduledClass;
        private System.Windows.Forms.ComboBox comboBoxScheduledClassHour;
        private System.Windows.Forms.ComboBox comboBoxScheduledClassMin;
        private System.Windows.Forms.ComboBox comboBoxScheduledClassRoom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridScheduledClass;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelInstructor;
        private System.Windows.Forms.Label labelRoomSelect;
    }
}