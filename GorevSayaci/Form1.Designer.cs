namespace GorevSayaci
{
    partial class mainFrame
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
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.removeEmployeeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addDutyBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewEmployeeDutyBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addEmployeeBtn.Location = new System.Drawing.Point(22, 48);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(250, 50);
            this.addEmployeeBtn.TabIndex = 0;
            this.addEmployeeBtn.Text = "Personel Ekle";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // removeEmployeeBtn
            // 
            this.removeEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeEmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.removeEmployeeBtn.Location = new System.Drawing.Point(22, 109);
            this.removeEmployeeBtn.Name = "removeEmployeeBtn";
            this.removeEmployeeBtn.Size = new System.Drawing.Size(250, 50);
            this.removeEmployeeBtn.TabIndex = 1;
            this.removeEmployeeBtn.Text = "Personel Çıkar";
            this.removeEmployeeBtn.UseVisualStyleBackColor = true;
            this.removeEmployeeBtn.Click += new System.EventHandler(this.removeEmployeeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addEmployeeBtn);
            this.panel1.Controls.Add(this.removeEmployeeBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 172);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel Ekle/Çıkar";
            // 
            // addDutyBtn
            // 
            this.addDutyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addDutyBtn.Location = new System.Drawing.Point(27, 48);
            this.addDutyBtn.Name = "addDutyBtn";
            this.addDutyBtn.Size = new System.Drawing.Size(250, 50);
            this.addDutyBtn.TabIndex = 3;
            this.addDutyBtn.Text = "Görev Ekle";
            this.addDutyBtn.UseVisualStyleBackColor = true;
            this.addDutyBtn.Click += new System.EventHandler(this.addDutyBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.viewEmployeeDutyBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addDutyBtn);
            this.panel2.Location = new System.Drawing.Point(344, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 172);
            this.panel2.TabIndex = 4;
            // 
            // viewEmployeeDutyBtn
            // 
            this.viewEmployeeDutyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.viewEmployeeDutyBtn.Location = new System.Drawing.Point(27, 111);
            this.viewEmployeeDutyBtn.Name = "viewEmployeeDutyBtn";
            this.viewEmployeeDutyBtn.Size = new System.Drawing.Size(250, 50);
            this.viewEmployeeDutyBtn.TabIndex = 5;
            this.viewEmployeeDutyBtn.Text = "Görev Görüntüle";
            this.viewEmployeeDutyBtn.UseVisualStyleBackColor = true;
            this.viewEmployeeDutyBtn.Click += new System.EventHandler(this.viewEmployeeDutyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Görev Yönetimi";
            // 
            // printBtn
            // 
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.printBtn.Location = new System.Drawing.Point(165, 202);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(327, 50);
            this.printBtn.TabIndex = 5;
            this.printBtn.Text = "Personel Görev Bilgisi Yazdır";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 264);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "mainFrame";
            this.Text = "Konya Çevik Kuvvet Şube Müdürlüğü";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button removeEmployeeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addDutyBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewEmployeeDutyBtn;
        private System.Windows.Forms.Button printBtn;
    }
}

