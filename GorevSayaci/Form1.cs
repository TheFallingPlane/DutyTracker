using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Main Form

namespace GorevSayaci
{
    public partial class mainFrame : Form
    {
        public mainFrame()
        {
            InitializeComponent();

            //Simple piece of code that creates files for every employee who is in EmployeeList.txt
             /*string[] lines = System.IO.File.ReadAllLines(@"Personel Listesi/EmployeeList.txt",Encoding.Default);

             foreach(string line in lines)
             {

                 using (var tempFile = File.Create("Personel Bilgileri/" + line.Replace(" ", "#") + ".txt"));
             }*/

        }

        //Button for adding employees.
        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            addEmployeeForm tempForm = new addEmployeeForm();
            tempForm.Show();
        }
        //Button for removing employees.
        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            removeEmployeeForm tempForm = new removeEmployeeForm();
            tempForm.Show();
        }
        //Button for adding duty.("duty" might be the wrong word for it) 
        private void addDutyBtn_Click(object sender, EventArgs e)
        {
            dutyManagement tempForm = new dutyManagement();
            tempForm.Show();
        }

        //Button for viewing duty history for an employee.
        private void viewEmployeeDutyBtn_Click(object sender, EventArgs e)
        {
            viewDuty tempForm = new viewDuty();
            tempForm.Show();
        }

        //Button for printing duty history.(all employees)
        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintPreviewForm tempForm = new PrintPreviewForm();
            tempForm.Show();
        }
    }
}
