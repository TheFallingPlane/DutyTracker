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

namespace GorevSayaci
{
    public partial class addEmployeeForm : Form
    {
        public addEmployeeForm()
        {
            InitializeComponent();
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            ranksComboBox.Text = "";
            employeeIDText.Text = "";
            employeeNameText.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //If one or more of the user-filled areas are empty.
            if(ranksComboBox.SelectedItem == null || employeeIDText.Text.Trim().Equals("") || employeeNameText.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bilgilerinizden biri eksik. Lütfen kontrol ediniz.", "Eksik Bilgi");
            }
            else
            {
                string employeeRank = ranksComboBox.SelectedItem.ToString();
                string employeeID = employeeIDText.Text;
                string employeeName = employeeNameText.Text;
                string fileName = @"Personel Bilgileri/" + employeeRank + "#" + employeeID + "#" + employeeName+".txt";

                //If user tries to add an existing employee.
                if (File.Exists(fileName))
                {
                    MessageBox.Show("Bu personel kayıtlarda var. Lütfen bilgileri kontrol ediniz.", "Tekrarlı Kayıt");
                }
                else
                {
                   using(var tempFile = File.Create(fileName))
                    {
                        //Added employee.
                        MessageBox.Show("Personel başarıyla eklendi.", "İşlem başarılı");
                        ranksComboBox.Text = "";
                        employeeIDText.Text = "";
                        employeeNameText.Text = "";
                    }
                    
                    
                }
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
