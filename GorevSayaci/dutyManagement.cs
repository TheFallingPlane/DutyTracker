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
    public partial class dutyManagement : Form
    {
        string[] fileNames;
        string temp;
        public dutyManagement()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dutyManagement_Load(object sender, EventArgs e)
        {
            fileNames = Directory.GetFiles("Personel Bilgileri", "*.txt")
                                      .Select(Path.GetFileName)
                                      .ToArray();




        }

        private void button1_Click(object sender, EventArgs e)
        {

            string date = dateTimePicker.Value.ToString("dd/MM/yyyy");
            int selectedDuty = 0;
           
            if (yabancilarRdBtn.Checked == false && uygulamaRdBtn.Checked == false && nobetRdBtn.Checked == false)
            {
                MessageBox.Show("Görev tipini seçmediniz. Lütfen bir görev tipi seçiniz.", "Görev Tipi Hatası");
            }
            else
            {
                if (yabancilarRdBtn.Checked)
                {
                    selectedDuty = 1;
                }
                else if (uygulamaRdBtn.Checked)
                {
                    selectedDuty = 2;
                }
                else
                {
                    selectedDuty = 3;
                }
                ListView.CheckedListViewItemCollection selectedEmployees = employeeListView.CheckedItems;
                if (selectedEmployees.Count == 0)
                {
                    MessageBox.Show("Görevde bulunan personel(ler)i seçmediniz. Lütfen personel seçiniz.", "Personel Hatası");
                }
                else
                {
                    foreach (ListViewItem tempItem in selectedEmployees)
                    {
                        string tempItemText = tempItem.Text;

                        tempItemText = tempItemText.Replace(" ", "#");

                        FileStream fs = new FileStream(@"Personel Bilgileri/" + tempItemText + ".txt", FileMode.Open, FileAccess.ReadWrite);
                        fs.Seek(0, SeekOrigin.End);

                        StreamWriter sw = new StreamWriter(fs);

                        sw.WriteLine(date + "#" + selectedDuty);

                        sw.Close();
                        fs.Close();

                    }
                    MessageBox.Show("Görev seçilen personel(ler)e başarıyla eklendi.", "İşlem Başarılı");
                    yabancilarRdBtn.Checked = false;
                    uygulamaRdBtn.Checked = false;
                    nobetRdBtn.Checked = false;

                    employeeListView.Items.Clear();


                }


            }

        }

        private void assignEmployeeBtn_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            bool isAddedBefore = false;

            foreach (string fileName in fileNames)
            {
                if (fileName.Contains(searchTxt.Text))
                {
                    temp = fileName.Replace("#", " ");
                    isFound = true;
                }
            }

            if (!isFound)
            {
                MessageBox.Show("Bu sicile sahip personel kayıtlarda bulunamamıştır. Lütfen bilgileri kontrol ediniz.", "Hatalı İşlem");
            }
            else
            {
                foreach (ListViewItem tempItem in employeeListView.Items)
                {
                    if (tempItem.Text.Contains(searchTxt.Text))
                    {
                        MessageBox.Show("Görev listesine aynı personeli bir kez ekleyebilirsiniz.", "Hatalı işlem");
                        isAddedBefore = true;
                        break;
                    }
                }
                if (!isAddedBefore)
                {
                    employeeListView.Items.Add(new ListViewItem(temp.Replace(".txt", "")));

                    foreach (ListViewItem tempItem in employeeListView.Items)
                    {
                        tempItem.Checked = true;
                    }

                }
            }



        }
    }
}
