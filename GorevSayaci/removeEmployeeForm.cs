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
    public partial class removeEmployeeForm : Form
    {
        public removeEmployeeForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            //If employee number is empty.
            if (removeEmployeeText.Text.Trim().Equals(""))
            {
                MessageBox.Show("Sicil alanı boş bırakılamaz.", "Eksik Bilgi");
            }
            else
            {
                int i = 0;
                string employeeID = removeEmployeeText.Text;
                string fileName = null;
                string tempFileName = null;

                var fileNames = new DirectoryInfo("Personel Bilgileri").GetFiles("*.txt");

                for (i = 0; i < fileNames.Length; i++)
                {
                    if (fileNames[i].ToString().Contains(employeeID))
                    {
                        fileName = fileNames[i].ToString();
                        break;
                    }
                }
                //Employee not found.
                if (fileName == null)
                {
                    MessageBox.Show("Girilen sicil numarasına sahip personel bulunamadı. Lütfen bilgileri kontrol ediniz.", "İşlem Başarısız");
                }
                else
                {
                    tempFileName = fileName.Replace("#", " ");
                    tempFileName = tempFileName.Replace(".txt", "");
                    DialogResult areYouSureToDelete = MessageBox.Show(tempFileName + " ile ilgili kayıtları silmek istediğinize emin misiniz? Bu işlem geri alınamaz.", "Personel Silme Onay", MessageBoxButtons.YesNoCancel);

                    if (areYouSureToDelete == DialogResult.Yes)
                    {
                        File.Delete(@"Personel Bilgileri/" + fileName);
                        MessageBox.Show("Kayıt başarıyla silindi.", "İşlem Başarılı");
                        removeEmployeeText.Text = "";

                    }
                }
            }
        }
    }
}
