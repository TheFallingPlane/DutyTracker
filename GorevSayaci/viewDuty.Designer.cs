namespace GorevSayaci
{
    partial class viewDuty
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeIDTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yabancilarDutyTxt = new System.Windows.Forms.TextBox();
            this.uygulamaDutyTxt = new System.Windows.Forms.TextBox();
            this.nobetDutyTxt = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.viewDutyBtn = new System.Windows.Forms.Button();
            this.dutyViewListBox = new System.Windows.Forms.ListView();
            this.dutyDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personelin Sicili : ";
            // 
            // employeeIDTxt
            // 
            this.employeeIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employeeIDTxt.Location = new System.Drawing.Point(183, 38);
            this.employeeIDTxt.Name = "employeeIDTxt";
            this.employeeIDTxt.Size = new System.Drawing.Size(369, 27);
            this.employeeIDTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yabancılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(232, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uygulama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(450, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nöbet";
            // 
            // yabancilarDutyTxt
            // 
            this.yabancilarDutyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yabancilarDutyTxt.Location = new System.Drawing.Point(33, 140);
            this.yabancilarDutyTxt.Name = "yabancilarDutyTxt";
            this.yabancilarDutyTxt.ReadOnly = true;
            this.yabancilarDutyTxt.Size = new System.Drawing.Size(80, 22);
            this.yabancilarDutyTxt.TabIndex = 6;
            // 
            // uygulamaDutyTxt
            // 
            this.uygulamaDutyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uygulamaDutyTxt.Location = new System.Drawing.Point(235, 140);
            this.uygulamaDutyTxt.Name = "uygulamaDutyTxt";
            this.uygulamaDutyTxt.ReadOnly = true;
            this.uygulamaDutyTxt.Size = new System.Drawing.Size(79, 22);
            this.uygulamaDutyTxt.TabIndex = 7;
            // 
            // nobetDutyTxt
            // 
            this.nobetDutyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nobetDutyTxt.Location = new System.Drawing.Point(437, 140);
            this.nobetDutyTxt.Name = "nobetDutyTxt";
            this.nobetDutyTxt.ReadOnly = true;
            this.nobetDutyTxt.Size = new System.Drawing.Size(79, 22);
            this.nobetDutyTxt.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelButton.Location = new System.Drawing.Point(12, 536);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(190, 30);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "İptal";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // viewDutyBtn
            // 
            this.viewDutyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.viewDutyBtn.Location = new System.Drawing.Point(360, 536);
            this.viewDutyBtn.Name = "viewDutyBtn";
            this.viewDutyBtn.Size = new System.Drawing.Size(190, 30);
            this.viewDutyBtn.TabIndex = 10;
            this.viewDutyBtn.Text = "Görev Görüntüle";
            this.viewDutyBtn.UseVisualStyleBackColor = true;
            this.viewDutyBtn.Click += new System.EventHandler(this.viewDutyBtn_Click);
            // 
            // dutyViewListBox
            // 
            this.dutyViewListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dutyViewListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dutyDetail});
            this.dutyViewListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dutyViewListBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dutyViewListBox.HideSelection = false;
            this.dutyViewListBox.Location = new System.Drawing.Point(17, 181);
            this.dutyViewListBox.MultiSelect = false;
            this.dutyViewListBox.Name = "dutyViewListBox";
            this.dutyViewListBox.Size = new System.Drawing.Size(533, 349);
            this.dutyViewListBox.TabIndex = 11;
            this.dutyViewListBox.UseCompatibleStateImageBehavior = false;
            this.dutyViewListBox.View = System.Windows.Forms.View.Details;
            // 
            // dutyDetail
            // 
            this.dutyDetail.Width = 300;
            // 
            // viewDuty
            // 
            this.AcceptButton = this.viewDutyBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(562, 578);
            this.ControlBox = false;
            this.Controls.Add(this.dutyViewListBox);
            this.Controls.Add(this.viewDutyBtn);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.nobetDutyTxt);
            this.Controls.Add(this.uygulamaDutyTxt);
            this.Controls.Add(this.yabancilarDutyTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeIDTxt);
            this.Controls.Add(this.label1);
            this.Name = "viewDuty";
            this.Text = "Görev Görüntüle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeIDTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yabancilarDutyTxt;
        private System.Windows.Forms.TextBox uygulamaDutyTxt;
        private System.Windows.Forms.TextBox nobetDutyTxt;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button viewDutyBtn;
        private System.Windows.Forms.ListView dutyViewListBox;
        private System.Windows.Forms.ColumnHeader dutyDetail;
    }
}