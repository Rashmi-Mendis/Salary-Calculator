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
    public partial class Form1 : Form
    {
        public int total;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalarySheet_Click(object sender, EventArgs e)
        {
            CalculateSalary data = new CalculateSalary();
            data.Show();
        }

    }
}
        

