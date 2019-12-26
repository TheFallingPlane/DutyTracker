namespace GorevSayaci
{
    partial class dutyManagement
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.yabancilarRdBtn = new System.Windows.Forms.RadioButton();
            this.uygulamaRdBtn = new System.Windows.Forms.RadioButton();
            this.nobetRdBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addDutyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.employeeData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assignEmployeeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(210, 77);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(140, 27);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2019, 12, 6, 22, 17, 11, 0);
            // 
            // yabancilarRdBtn
            // 
            this.yabancilarRdBtn.AutoSize = true;
            this.yabancilarRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yabancilarRdBtn.Location = new System.Drawing.Point(15, 50);
            this.yabancilarRdBtn.Name = "yabancilarRdBtn";
            this.yabancilarRdBtn.Size = new System.Drawing.Size(118, 24);
            this.yabancilarRdBtn.TabIndex = 1;
            this.yabancilarRdBtn.Text = "Yabancılar";
            this.yabancilarRdBtn.UseVisualStyleBackColor = true;
            // 
            // uygulamaRdBtn
            // 
            this.uygulamaRdBtn.AutoSize = true;
            this.uygulamaRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uygulamaRdBtn.Location = new System.Drawing.Point(15, 80);
            this.uygulamaRdBtn.Name = "uygulamaRdBtn";
            this.uygulamaRdBtn.Size = new System.Drawing.Size(112, 24);
            this.uygulamaRdBtn.TabIndex = 2;
            this.uygulamaRdBtn.Text = "Uygulama";
            this.uygulamaRdBtn.UseVisualStyleBackColor = true;
            // 
            // nobetRdBtn
            // 
            this.nobetRdBtn.AutoSize = true;
            this.nobetRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nobetRdBtn.Location = new System.Drawing.Point(15, 110);
            this.nobetRdBtn.Name = "nobetRdBtn";
            this.nobetRdBtn.Size = new System.Drawing.Size(79, 24);
            this.nobetRdBtn.TabIndex = 3;
            this.nobetRdBtn.Text = "Nöbet";
            this.nobetRdBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Görev Tipi";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.yabancilarRdBtn);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uygulamaRdBtn);
            this.panel1.Controls.Add(this.nobetRdBtn);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 159);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(163, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Görevin Yapıldığı Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Göreve Katılan Personel";
            // 
            // addDutyBtn
            // 
            this.addDutyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addDutyBtn.Location = new System.Drawing.Point(511, 415);
            this.addDutyBtn.Name = "addDutyBtn";
            this.addDutyBtn.Size = new System.Drawing.Size(300, 30);
            this.addDutyBtn.TabIndex = 8;
            this.addDutyBtn.Text = "Görev Ekle";
            this.addDutyBtn.UseVisualStyleBackColor = true;
            this.addDutyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelBtn.Location = new System.Drawing.Point(12, 415);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(300, 30);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "İptal";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // employeeListView
            // 
            this.employeeListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeListView.CheckBoxes = true;
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeData});
            this.employeeListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employeeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(12, 201);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(793, 208);
            this.employeeListView.TabIndex = 10;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            // 
            // employeeData
            // 
            this.employeeData.Text = "Personel Bilgileri";
            this.employeeData.Width = 500;
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTxt.Location = new System.Drawing.Point(498, 72);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(242, 27);
            this.searchTxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(517, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Personel Ekle(Sicil No.)";
            // 
            // assignEmployeeBtn
            // 
            this.assignEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.assignEmployeeBtn.Location = new System.Drawing.Point(530, 118);
            this.assignEmployeeBtn.Name = "assignEmployeeBtn";
            this.assignEmployeeBtn.Size = new System.Drawing.Size(176, 29);
            this.assignEmployeeBtn.TabIndex = 13;
            this.assignEmployeeBtn.Text = "Personel Ekle";
            this.assignEmployeeBtn.UseVisualStyleBackColor = true;
            this.assignEmployeeBtn.Click += new System.EventHandler(this.assignEmployeeBtn_Click);
            // 
            // dutyManagement
            // 
            this.AcceptButton = this.assignEmployeeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(817, 459);
            this.ControlBox = false;
            this.Controls.Add(this.assignEmployeeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addDutyBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "dutyManagement";
            this.Text = "Görev Ekle";
            this.Load += new System.EventHandler(this.dutyManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton yabancilarRdBtn;
        private System.Windows.Forms.RadioButton uygulamaRdBtn;
        private System.Windows.Forms.RadioButton nobetRdBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addDutyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ColumnHeader employeeData;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button assignEmployeeBtn;
    }
}