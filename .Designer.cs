namespace Assessment
{
    partial class SalaryCalculator
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
            this.comboCategory_72 = new System.Windows.Forms.ComboBox();
            this.btnExit_72 = new System.Windows.Forms.Button();
            this.btnClear_72 = new System.Windows.Forms.Button();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtHourlyRate_72 = new System.Windows.Forms.TextBox();
            this.txtLeaves_72 = new System.Windows.Forms.TextBox();
            this.txtWorkHours_72 = new System.Windows.Forms.TextBox();
            this.txtName_72 = new System.Windows.Forms.TextBox();
            this.dgvDataTable_72 = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable_72)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCategory_72
            // 
            this.comboCategory_72.FormattingEnabled = true;
            this.comboCategory_72.Items.AddRange(new object[] {
            "Executive",
            "Non-Executive",
            "Casual-Worker"});
            this.comboCategory_72.Location = new System.Drawing.Point(461, 99);
            this.comboCategory_72.Name = "comboCategory_72";
            this.comboCategory_72.Size = new System.Drawing.Size(101, 21);
            this.comboCategory_72.TabIndex = 37;
            this.comboCategory_72.SelectedIndexChanged += new System.EventHandler(this.comboCategory_72_SelectedIndexChanged);
            // 
            // btnExit_72
            // 
            this.btnExit_72.Location = new System.Drawing.Point(535, 444);
            this.btnExit_72.Name = "btnExit_72";
            this.btnExit_72.Size = new System.Drawing.Size(534, 32);
            this.btnExit_72.TabIndex = 36;
            this.btnExit_72.Text = "Exit";
            this.btnExit_72.UseVisualStyleBackColor = true;
            this.btnExit_72.Click += new System.EventHandler(this.btnExit_72_Click);
            // 
            // btnClear_72
            // 
            this.btnClear_72.Location = new System.Drawing.Point(3, 444);
            this.btnClear_72.Name = "btnClear_72";
            this.btnClear_72.Size = new System.Drawing.Size(534, 32);
            this.btnClear_72.TabIndex = 35;
            this.btnClear_72.Text = "Clear";
            this.btnClear_72.UseVisualStyleBackColor = true;
            this.btnClear_72.Click += new System.EventHandler(this.btnClear_72_Click);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(327, 66);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(180, 13);
            this.lblTopic.TabIndex = 34;
            this.lblTopic.Text = "Employee Monthly Salary Calculation";
            this.lblTopic.Click += new System.EventHandler(this.lblTopic_Click);
            // 
            // txtHourlyRate_72
            // 
            this.txtHourlyRate_72.Location = new System.Drawing.Point(765, 100);
            this.txtHourlyRate_72.Name = "txtHourlyRate_72";
            this.txtHourlyRate_72.Size = new System.Drawing.Size(93, 20);
            this.txtHourlyRate_72.TabIndex = 33;
            this.txtHourlyRate_72.TextChanged += new System.EventHandler(this.txtHourlyRate_72_TextChanged);
            // 
            // txtLeaves_72
            // 
            this.txtLeaves_72.Location = new System.Drawing.Point(662, 101);
            this.txtLeaves_72.Name = "txtLeaves_72";
            this.txtLeaves_72.Size = new System.Drawing.Size(93, 20);
            this.txtLeaves_72.TabIndex = 32;
            this.txtLeaves_72.TextChanged += new System.EventHandler(this.txtLeaves_72_TextChanged);
            // 
            // txtWorkHours_72
            // 
            this.txtWorkHours_72.Location = new System.Drawing.Point(866, 101);
            this.txtWorkHours_72.Name = "txtWorkHours_72";
            this.txtWorkHours_72.Size = new System.Drawing.Size(93, 20);
            this.txtWorkHours_72.TabIndex = 31;
            this.txtWorkHours_72.TextChanged += new System.EventHandler(this.txtWorkHours_72_TextChanged);
            // 
            // txtName_72
            // 
            this.txtName_72.Location = new System.Drawing.Point(145, 101);
            this.txtName_72.Name = "txtName_72";
            this.txtName_72.Size = new System.Drawing.Size(310, 20);
            this.txtName_72.TabIndex = 30;
            this.txtName_72.TextChanged += new System.EventHandler(this.txtName_72_TextChanged);
            // 
            // dgvDataTable_72
            // 
            this.dgvDataTable_72.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvDataTable_72.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTable_72.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7,
            this.col8});
            this.dgvDataTable_72.Location = new System.Drawing.Point(3, 126);
            this.dgvDataTable_72.Name = "dgvDataTable_72";
            this.dgvDataTable_72.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDataTable_72.Size = new System.Drawing.Size(1061, 312);
            this.dgvDataTable_72.TabIndex = 29;
            this.dgvDataTable_72.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataTable_72_CellContentClick);
            // 
            // col1
            // 
            this.col1.HeaderText = "Emp ID";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col2.HeaderText = "Name";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "Category";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.HeaderText = "Basic Salary";
            this.col4.Name = "col4";
            // 
            // col5
            // 
            this.col5.HeaderText = "Leaves";
            this.col5.Name = "col5";
            // 
            // col6
            // 
            this.col6.HeaderText = "Hourly Rate";
            this.col6.Name = "col6";
            // 
            // col7
            // 
            this.col7.HeaderText = "Worked Hours";
            this.col7.Name = "col7";
            // 
            // col8
            // 
            this.col8.HeaderText = "Net Salary";
            this.col8.Name = "col8";
            // 
            // SalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 601);
            this.Controls.Add(this.comboCategory_72);
            this.Controls.Add(this.btnExit_72);
            this.Controls.Add(this.btnClear_72);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.txtHourlyRate_72);
            this.Controls.Add(this.txtLeaves_72);
            this.Controls.Add(this.txtWorkHours_72);
            this.Controls.Add(this.txtName_72);
            this.Controls.Add(this.dgvDataTable_72);
            this.Name = "SalaryCalculator";
            this.Text = "SalaryCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable_72)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCategory_72;
        private System.Windows.Forms.Button btnExit_72;
        private System.Windows.Forms.Button btnClear_72;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtHourlyRate_72;
        private System.Windows.Forms.TextBox txtLeaves_72;
        private System.Windows.Forms.TextBox txtWorkHours_72;
        private System.Windows.Forms.TextBox txtName_72;
        private System.Windows.Forms.DataGridView dgvDataTable_72;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn col8;
    }
}