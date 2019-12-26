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
    public partial class viewDuty : Form
    {
        public viewDuty()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewDutyBtn_Click(object sender, EventArgs e)
        {
            yabancilarDutyTxt.Text = "";
            uygulamaDutyTxt.Text = "";
            nobetDutyTxt.Text = "";

            int uygulamaCount = 0;
            int yabancilarCount = 0;
            int nobetCount = 0;

            bool found = false;

            if (employeeIDTxt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Sicil alanı boş bırakılamaz. Lütfen personel sicilini giriniz.", "Eksik Bilgi");

            }
            else
            {
                string[] fileNames = Directory.GetFiles("Personel Bilgileri", "*.txt")
                                     .Select(Path.GetFileName)
                                     .ToArray();



                foreach (string fileName in fileNames)
                {
                    if (fileName.Contains(employeeIDTxt.Text))
                    {
                        found = true;
                        string[] lines = System.IO.File.ReadAllLines(@"Personel Bilgileri/" + fileName);

                        if (lines.Length == 0)
                        {
                            MessageBox.Show("Kayıtlara göre sicili girilen personel hiç görev yapmamıştır.", "Uyarı");
                        }
                        else
                        {
                            foreach (string line in lines)
                            {


                                if (line.Length != 0)
                                {
                                    string[] splittedLine = line.Split('#');

                                    if (splittedLine[1] == "1")
                                    {
                                        yabancilarCount++;
                                        dutyViewListBox.Items.Add(new ListViewItem(splittedLine[0] + " - " + "Yabancılar"));
                                    }
                                    else if (splittedLine[1] == "2")
                                    {
                                        uygulamaCount++;
                                        dutyViewListBox.Items.Add(new ListViewItem(splittedLine[0] + " - " + "Uygulama"));
                                    }
                                    else
                                    {
                                        nobetCount++;
                                        dutyViewListBox.Items.Add(new ListViewItem(splittedLine[0] + " - " + "Nöbet"));
                                    }
                                }
                            }
                            yabancilarDutyTxt.Text = yabancilarCount.ToString();
                            uygulamaDutyTxt.Text = uygulamaCount.ToString();
                            nobetDutyTxt.Text = nobetCount.ToString();
                        }

                    }

                }
                if (!found)
                {
                    MessageBox.Show("Bu sicile sahip personel kayıtlarda bulunamamıştır. Lütfen bilgileri kontrol ediniz.", "Hatalı İşlem");
                }

            }
        }
    }
}
