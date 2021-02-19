namespace MagicTrainingProject
{
    partial class AdministrateClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrateClass));
            this.buttonCreateClass = new System.Windows.Forms.Button();
            this.labelClassName = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelClassNameSearch = new System.Windows.Forms.Label();
            this.textBoxCreateClassName = new System.Windows.Forms.TextBox();
            this.textBoxSearchClassName = new System.Windows.Forms.TextBox();
            this.buttonDeleteClass = new System.Windows.Forms.Button();
            this.buttonEditClass = new System.Windows.Forms.Button();
            this.buttonSearchClass = new System.Windows.Forms.Button();
            this.dataGridViewCurrentClasses = new System.Windows.Forms.DataGridView();
            this.labelCurrentClasses = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxRelease = new System.Windows.Forms.TextBox();
            this.labelResponse = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateClass
            // 
            this.buttonCreateClass.BackColor = System.Drawing.Color.Linen;
            this.buttonCreateClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonCreateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateClass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCreateClass.Location = new System.Drawing.Point(138, 220);
            this.buttonCreateClass.Name = "buttonCreateClass";
            this.buttonCreateClass.Size = new System.Drawing.Size(66, 26);
            this.buttonCreateClass.TabIndex = 0;
            this.buttonCreateClass.Text = "Create";
            this.buttonCreateClass.UseVisualStyleBackColor = false;
            this.buttonCreateClass.Click += new System.EventHandler(this.ButtonCreateClass_Click);
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(37, 110);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(39, 13);
            this.labelClassName.TabIndex = 2;
            this.labelClassName.Text = "Name*";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(37, 163);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(46, 13);
            this.labelDuration.TabIndex = 3;
            this.labelDuration.Text = "Release";
            // 
            // labelClassNameSearch
            // 
            this.labelClassNameSearch.AutoSize = true;
            this.labelClassNameSearch.Location = new System.Drawing.Point(480, 87);
            this.labelClassNameSearch.Name = "labelClassNameSearch";
            this.labelClassNameSearch.Size = new System.Drawing.Size(61, 13);
            this.labelClassNameSearch.TabIndex = 5;
            this.labelClassNameSearch.Text = "Class name";
            // 
            // textBoxCreateClassName
            // 
            this.textBoxCreateClassName.Location = new System.Drawing.Point(40, 126);
            this.textBoxCreateClassName.Name = "textBoxCreateClassName";
            this.textBoxCreateClassName.Size = new System.Drawing.Size(168, 20);
            this.textBoxCreateClassName.TabIndex = 6;
            // 
            // textBoxSearchClassName
            // 
            this.textBoxSearchClassName.Location = new System.Drawing.Point(547, 84);
            this.textBoxSearchClassName.Name = "textBoxSearchClassName";
            this.textBoxSearchClassName.Size = new System.Drawing.Size(103, 20);
            this.textBoxSearchClassName.TabIndex = 9;
            // 
            // buttonDeleteClass
            // 
            this.buttonDeleteClass.BackColor = System.Drawing.Color.Linen;
            this.buttonDeleteClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteClass.Location = new System.Drawing.Point(408, 260);
            this.buttonDeleteClass.Name = "buttonDeleteClass";
            this.buttonDeleteClass.Size = new System.Drawing.Size(66, 26);
            this.buttonDeleteClass.TabIndex = 10;
            this.buttonDeleteClass.Text = "Delete";
            this.buttonDeleteClass.UseVisualStyleBackColor = false;
            this.buttonDeleteClass.Click += new System.EventHandler(this.ButtonDeleteClass_Click);
            // 
            // buttonEditClass
            // 
            this.buttonEditClass.BackColor = System.Drawing.Color.Linen;
            this.buttonEditClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditClass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonEditClass.Location = new System.Drawing.Point(336, 260);
            this.buttonEditClass.Name = "buttonEditClass";
            this.buttonEditClass.Size = new System.Drawing.Size(66, 26);
            this.buttonEditClass.TabIndex = 11;
            this.buttonEditClass.Text = "Edit";
            this.buttonEditClass.UseVisualStyleBackColor = false;
            this.buttonEditClass.Click += new System.EventHandler(this.ButtonEditClass_Click);
            // 
            // buttonSearchClass
            // 
            this.buttonSearchClass.BackColor = System.Drawing.Color.Linen;
            this.buttonSearchClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonSearchClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchClass.Location = new System.Drawing.Point(584, 110);
            this.buttonSearchClass.Name = "buttonSearchClass";
            this.buttonSearchClass.Size = new System.Drawing.Size(66, 26);
            this.buttonSearchClass.TabIndex = 12;
            this.buttonSearchClass.Text = "Search";
            this.buttonSearchClass.UseVisualStyleBackColor = false;
            this.buttonSearchClass.Click += new System.EventHandler(this.ButtonSearchClass_Click);
            // 
            // dataGridViewCurrentClasses
            // 
            this.dataGridViewCurrentClasses.AllowUserToAddRows = false;
            this.dataGridViewCurrentClasses.AllowUserToDeleteRows = false;
            this.dataGridViewCurrentClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCurrentClasses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCurrentClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCurrentClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCurrentClasses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCurrentClasses.Location = new System.Drawing.Point(235, 70);
            this.dataGridViewCurrentClasses.MultiSelect = false;
            this.dataGridViewCurrentClasses.Name = "dataGridViewCurrentClasses";
            this.dataGridViewCurrentClasses.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCurrentClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCurrentClasses.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Peru;
            this.dataGridViewCurrentClasses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCurrentClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCurrentClasses.Size = new System.Drawing.Size(239, 184);
            this.dataGridViewCurrentClasses.TabIndex = 13;
            this.dataGridViewCurrentClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCurrentClasses_CellContentClick);
            this.dataGridViewCurrentClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCurrentClasses_CellContentClick);
            // 
            // labelCurrentClasses
            // 
            this.labelCurrentClasses.AutoSize = true;
            this.labelCurrentClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelCurrentClasses.Location = new System.Drawing.Point(232, 54);
            this.labelCurrentClasses.Name = "labelCurrentClasses";
            this.labelCurrentClasses.Size = new System.Drawing.Size(115, 16);
            this.labelCurrentClasses.TabIndex = 14;
            this.labelCurrentClasses.Text = "Current classes";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Linen;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(138, 220);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(66, 26);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textBoxRelease
            // 
            this.textBoxRelease.Location = new System.Drawing.Point(41, 179);
            this.textBoxRelease.Name = "textBoxRelease";
            this.textBoxRelease.Size = new System.Drawing.Size(168, 20);
            this.textBoxRelease.TabIndex = 17;
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(38, 273);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(0, 13);
            this.labelResponse.TabIndex = 19;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(40, 378);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(66, 29);
            this.buttonHome.TabIndex = 20;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // AdministrateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.textBoxRelease);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCurrentClasses);
            this.Controls.Add(this.dataGridViewCurrentClasses);
            this.Controls.Add(this.buttonSearchClass);
            this.Controls.Add(this.buttonEditClass);
            this.Controls.Add(this.buttonDeleteClass);
            this.Controls.Add(this.textBoxSearchClassName);
            this.Controls.Add(this.textBoxCreateClassName);
            this.Controls.Add(this.labelClassNameSearch);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.buttonCreateClass);
            this.Name = "AdministrateClass";
            this.Text = "AdministrateClass";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateClass;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelClassNameSearch;
        private System.Windows.Forms.TextBox textBoxCreateClassName;
        private System.Windows.Forms.TextBox textBoxSearchClassName;
        private System.Windows.Forms.Button buttonDeleteClass;
        private System.Windows.Forms.Button buttonEditClass;
        private System.Windows.Forms.Button buttonSearchClass;
        private System.Windows.Forms.DataGridView dataGridViewCurrentClasses;
        private System.Windows.Forms.Label labelCurrentClasses;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxRelease;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.Button buttonHome;
    }
}