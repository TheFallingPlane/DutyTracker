namespace GorevSayaci
{
    partial class PrintPreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPreviewForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.dutyTable = new System.Windows.Forms.DataGridView();
            this.employeeRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yabancilarDutyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uygulamaDutyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nobetDutyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dutyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelBtn.Location = new System.Drawing.Point(12, 447);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 30);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "İptal";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.printBtn.Location = new System.Drawing.Point(740, 448);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(150, 30);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Yazdır";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // dutyTable
            // 
            this.dutyTable.AllowUserToAddRows = false;
            this.dutyTable.AllowUserToDeleteRows = false;
            this.dutyTable.ColumnHeadersHeight = 29;
            this.dutyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeRank,
            this.employeeID,
            this.employeeName,
            this.yabancilarDutyCount,
            this.uygulamaDutyCount,
            this.nobetDutyCount});
            this.dutyTable.Location = new System.Drawing.Point(12, 12);
            this.dutyTable.Name = "dutyTable";
            this.dutyTable.ReadOnly = true;
            this.dutyTable.RowHeadersWidth = 51;
            this.dutyTable.RowTemplate.Height = 24;
            this.dutyTable.Size = new System.Drawing.Size(878, 430);
            this.dutyTable.TabIndex = 2;
            // 
            // employeeRank
            // 
            this.employeeRank.HeaderText = "Rütbe";
            this.employeeRank.MinimumWidth = 6;
            this.employeeRank.Name = "employeeRank";
            this.employeeRank.ReadOnly = true;
            this.employeeRank.Width = 125;
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "Sicil No.";
            this.employeeID.MinimumWidth = 6;
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Width = 75;
            // 
            // employeeName
            // 
            this.employeeName.HeaderText = "Ad Soyad";
            this.employeeName.MinimumWidth = 6;
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            this.employeeName.Width = 150;
            // 
            // yabancilarDutyCount
            // 
            this.yabancilarDutyCount.HeaderText = "Yabancılar";
            this.yabancilarDutyCount.MinimumWidth = 6;
            this.yabancilarDutyCount.Name = "yabancilarDutyCount";
            this.yabancilarDutyCount.ReadOnly = true;
            this.yabancilarDutyCount.Width = 78;
            // 
            // uygulamaDutyCount
            // 
            this.uygulamaDutyCount.HeaderText = "Uygulama";
            this.uygulamaDutyCount.MinimumWidth = 6;
            this.uygulamaDutyCount.Name = "uygulamaDutyCount";
            this.uygulamaDutyCount.ReadOnly = true;
            this.uygulamaDutyCount.Width = 78;
            // 
            // nobetDutyCount
            // 
            this.nobetDutyCount.HeaderText = "Nöbet";
            this.nobetDutyCount.MinimumWidth = 6;
            this.nobetDutyCount.Name = "nobetDutyCount";
            this.nobetDutyCount.ReadOnly = true;
            this.nobetDutyCount.Width = 78;
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "Görev Listesi";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // PrintPreviewForm
            // 
            this.AcceptButton = this.printBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(902, 489);
            this.ControlBox = false;
            this.Controls.Add(this.dutyTable);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "PrintPreviewForm";
            this.Text = "Personel Görev Yazdırma(Önizleme)";
            this.Load += new System.EventHandler(this.PrintPreviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dutyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.DataGridView dutyTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn yabancilarDutyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn uygulamaDutyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn nobetDutyCount;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}