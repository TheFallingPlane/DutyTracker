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
    public partial class PrintPreviewForm : Form
    {




        public PrintPreviewForm()
        {
            InitializeComponent();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //This fills the dataGridView from each employee's duty history.
        private void PrintPreviewForm_Load(object sender, EventArgs e)
        {

            string[] fileNames = Directory.GetFiles("Personel Bilgileri", "*.txt")
                            .Select(Path.GetFileName)
                            .ToArray();


            dutyTable.Rows.Clear();
            foreach (string fileName in fileNames)
            {
                int uygulamaCount = 0;
                int yabancilarCount = 0;
                int nobetCount = 0;

                string[] splittedFileName = fileName.Split('#');
                string[] rowStructure = new string[6];

                rowStructure[0] = splittedFileName[0];
                rowStructure[1] = splittedFileName[1];

                if (splittedFileName.Length == 4)
                {
                    rowStructure[2] = splittedFileName[2] + " " + splittedFileName[3].Replace(".txt", "");
                }
                else
                {
                    rowStructure[2] = splittedFileName[2] + " " + splittedFileName[3] + " " + splittedFileName[4].Replace(".txt", "");
                }

                string[] lines = System.IO.File.ReadAllLines(@"Personel Bilgileri/" + fileName);

                foreach (string line in lines)
                {


                    if (line.Length != 0)
                    {
                        string[] splittedLine = line.Split('#');

                        if (splittedLine[1] == "1")
                        {
                            yabancilarCount++;

                        }
                        else if (splittedLine[1] == "2")
                        {
                            uygulamaCount++;

                        }
                        else
                        {
                            nobetCount++;

                        }
                    }
                }
                rowStructure[3] = yabancilarCount.ToString();
                rowStructure[4] = uygulamaCount.ToString();
                rowStructure[5] = nobetCount.ToString();


                dutyTable.Rows.Add(rowStructure);



            }

        }


        private void printBtn_Click(object sender, EventArgs e)
        {
            //Work in Progress
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Work in Progress
        }
    }
}
