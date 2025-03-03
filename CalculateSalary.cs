using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment
{
    public partial class CalculateSalary : Form
    {
        public CalculateSalary()
        {
            InitializeComponent();
        }
        int ischeck;

        int sum = 0;
        int num;
        string combo1 = "Executive";
        string combo2 = "Non-Executive";
        string combo3 = "Casual-Worker";

        private void btnAdd_72_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtWorkHours_72.Text, out ischeck))//checking
                {
                    int getValue = int.Parse(txtWorkHours_72.Text);
                    if (getValue <= 240 && comboCategory_72.Text==combo1)
                    {
                       int n = dgvDataTable_72.Rows.Add();

                        foreach (DataGridViewRow row in dgvDataTable_72.Rows)
                        {
                            dgvDataTable_72.Rows[n].Cells[0].Value = ("EX" + (row.Index + 1)).ToString();
                        }
                        dgvDataTable_72.Rows[n].Cells[1].Value = txtName_72.Text;
                        dgvDataTable_72.Rows[n].Cells[2].Value = comboCategory_72.Text;
                        dgvDataTable_72.Rows[n].Cells[4].Value = txtLeaves_72.Text;
                        dgvDataTable_72.Rows[n].Cells[5].Value = txtHourlyRate_72.Text;
                        dgvDataTable_72.Rows[n].Cells[6].Value = txtWorkHours_72.Text;
                       

                        double hourlyRate = double.Parse(dgvDataTable_72.Rows[n].Cells[5].Value.ToString());
                        double workHours = double.Parse(dgvDataTable_72.Rows[n].Cells[6].Value.ToString());

                        double basicSalary = workHours * hourlyRate;//basic salary

                        dgvDataTable_72.Rows[n].Cells[3].Value = "Rs. " + basicSalary;//add to dgv
                        double allowance = (basicSalary * 0.1) + (basicSalary * 0.05);
                        dgvDataTable_72.Rows[n].Cells[7].Value = "Rs. " + allowance;
                        double subSalary = basicSalary + allowance ; //add bonus

                        if (double.Parse(dgvDataTable_72.Rows[n].Cells[4].Value.ToString()) >= 4) //leaves
                        {
                            int leaves = (int.Parse(dgvDataTable_72.Rows[n].Cells[4].Value.ToString())) - 3;//3 leaves only
                            double salary = leaves * hourlyRate; // salary of take over 3 leaves
                            double netSalary = subSalary - salary; // deduct the extra leaves salary
                            dgvDataTable_72.Rows[n].Cells[8].Value = "Rs. " + netSalary;//net salary add to dgv
                        }
                        else
                        {
                            dgvDataTable_72.Rows[n].Cells[8].Value = subSalary; //taking accurate leaves  or not
                        }
                    }
                    else if (getValue <= 285 && comboCategory_72.Text == combo2)//Non-Executive
                    {
                        int n = dgvDataTable_72.Rows.Add();

                        foreach (DataGridViewRow row in dgvDataTable_72.Rows)
                        {
                            dgvDataTable_72.Rows[n].Cells[0].Value = ("NEX" + (row.Index + 1)).ToString();
                        }
                        dgvDataTable_72.Rows[n].Cells[1].Value = txtName_72.Text;
                        dgvDataTable_72.Rows[n].Cells[2].Value = comboCategory_72.Text;
                        dgvDataTable_72.Rows[n].Cells[4].Value = txtLeaves_72.Text;
                        dgvDataTable_72.Rows[n].Cells[5].Value = txtHourlyRate_72.Text;
                        dgvDataTable_72.Rows[n].Cells[6].Value = txtWorkHours_72.Text;

                        double hourlyRate = double.Parse(dgvDataTable_72.Rows[n].Cells[5].Value.ToString());
                        double workHours = double.Parse(dgvDataTable_72.Rows[n].Cells[6].Value.ToString());

                        double basicSalary = workHours * hourlyRate;

                        dgvDataTable_72.Rows[n].Cells[3].Value = "Rs. " + basicSalary;

                        double overTime = workHours - 240; //find overtime hours
                        double oTpay = overTime * 1.5; //Calculate OverTime payment
                        double allowance = basicSalary * 0.1;
                        dgvDataTable_72.Rows[n].Cells[7].Value = "Rs. " + allowance;
                        double subSalary = basicSalary + allowance + oTpay;//Calculate sub salary

                        if (double.Parse(dgvDataTable_72.Rows[n].Cells[4].Value.ToString()) >= 3) //leaves
                        {
                            int leaves = (int.Parse(dgvDataTable_72.Rows[n].Cells[4].Value.ToString())) - 2;//2 leaves only
                            double salary = leaves * hourlyRate; // salary of take over 3 leaves
                            double netSalary = subSalary - salary; // deduct the extra leaves salary
                            dgvDataTable_72.Rows[n].Cells[8].Value = netSalary;//net salary add to dgv
                        }
                        else
                        {
                            dgvDataTable_72.Rows[n].Cells[8].Value = subSalary; //taking accurate leaves  or not
                        }
                    }
                    else if (comboCategory_72.Text == combo3)
                    {
                        int n = dgvDataTable_72.Rows.Add();

                        foreach (DataGridViewRow row in dgvDataTable_72.Rows)
                        {
                            dgvDataTable_72.Rows[n].Cells[0].Value = ("CW" + (row.Index + 1)).ToString();
                        }
                        dgvDataTable_72.Rows[n].Cells[1].Value = txtName_72.Text;
                        dgvDataTable_72.Rows[n].Cells[2].Value = comboCategory_72.Text;
                        dgvDataTable_72.Rows[n].Cells[4].Value = txtLeaves_72.Text;
                        dgvDataTable_72.Rows[n].Cells[5].Value = txtHourlyRate_72.Text;
                        dgvDataTable_72.Rows[n].Cells[6].Value = txtWorkHours_72.Text;

                        double hourlyRate = double.Parse(dgvDataTable_72.Rows[n].Cells[5].Value.ToString());
                        double workHours = double.Parse(dgvDataTable_72.Rows[n].Cells[6].Value.ToString());

                        double basicSalary = workHours * hourlyRate; //basic salary

                        dgvDataTable_72.Rows[n].Cells[3].Value = "Rs. " + basicSalary; //add to basic salary col
                        dgvDataTable_72.Rows[n].Cells[7].Value = ("No Allowance").ToString();
                        dgvDataTable_72.Rows[n].Cells[8].Value = basicSalary; //add to net salary col

                        for(int i=0; i<=num; i++)
                        {
                            sum = sum + int.Parse(dgvDataTable_72.Rows[n].Cells[8].Value.ToString());
                        }                     
                    }
                    else
                    {
                        MessageBox.Show("You must Enter Your limit hours");          
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }

                }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_72_Click(object sender, EventArgs e)
        {
            dgvDataTable_72.Rows.Remove(dgvDataTable_72.CurrentRow);
            txtName_72.Clear();
            txtLeaves_72.Clear();
            txtHourlyRate_72.Clear();
            txtWorkHours_72.Clear();
        }

        private void btnExit_72_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTotal_72_Click(object sender, EventArgs e)
        {  
          num = int.Parse(txtEmployee_72.Text);
         lblTotal_72.Text = sum.ToString();
        }

    }   
}
