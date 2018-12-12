namespace VMES.Contragent.View
{
    partial class SalesMainInterrop
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblContrID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContrName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalesNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBaseSum = new System.Windows.Forms.TextBox();
            this.txtTrialSum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.dtpSalesDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVAT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSelDeal = new System.Windows.Forms.Button();
            this.dtpDealDate = new System.Windows.Forms.DateTimePicker();
            this.txtDealNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDealID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(374, 243);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 37);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(501, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblContrID
            // 
            this.lblContrID.AutoSize = true;
            this.lblContrID.Location = new System.Drawing.Point(11, 243);
            this.lblContrID.Name = "lblContrID";
            this.lblContrID.Size = new System.Drawing.Size(21, 17);
            this.lblContrID.TabIndex = 2;
            this.lblContrID.Text = "-1";
            this.lblContrID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContrName
            // 
            this.txtContrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrName.Location = new System.Drawing.Point(98, 24);
            this.txtContrName.MaxLength = 250;
            this.txtContrName.Name = "txtContrName";
            this.txtContrName.Size = new System.Drawing.Size(500, 22);
            this.txtContrName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblDealID);
            this.panel1.Controls.Add(this.lblContrID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 318);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSalesNum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBaseSum);
            this.groupBox2.Controls.Add(this.txtTrialSum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSum);
            this.groupBox2.Controls.Add(this.dtpSalesDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbVAT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 132);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Акт выполненных работ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(29, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSalesNum
            // 
            this.txtSalesNum.Location = new System.Drawing.Point(83, 31);
            this.txtSalesNum.Name = "txtSalesNum";
            this.txtSalesNum.Size = new System.Drawing.Size(156, 22);
            this.txtSalesNum.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(341, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Оспариваемая";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBaseSum
            // 
            this.txtBaseSum.Location = new System.Drawing.Point(452, 62);
            this.txtBaseSum.Name = "txtBaseSum";
            this.txtBaseSum.Size = new System.Drawing.Size(156, 22);
            this.txtBaseSum.TabIndex = 25;
            this.txtBaseSum.Text = "0";
            // 
            // txtTrialSum
            // 
            this.txtTrialSum.Location = new System.Drawing.Point(452, 92);
            this.txtTrialSum.Name = "txtTrialSum";
            this.txtTrialSum.Size = new System.Drawing.Size(156, 22);
            this.txtTrialSum.TabIndex = 14;
            this.txtTrialSum.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(322, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Не оспариваемая";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(452, 26);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(156, 22);
            this.txtSum.TabIndex = 26;
            this.txtSum.Text = "0";
            // 
            // dtpSalesDate
            // 
            this.dtpSalesDate.Location = new System.Drawing.Point(83, 60);
            this.dtpSalesDate.Name = "dtpSalesDate";
            this.dtpSalesDate.Size = new System.Drawing.Size(161, 22);
            this.dtpSalesDate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(39, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "НДС";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbVAT
            // 
            this.cmbVAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVAT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVAT.FormattingEnabled = true;
            this.cmbVAT.Items.AddRange(new object[] {
            "18",
            "20"});
            this.cmbVAT.Location = new System.Drawing.Point(83, 85);
            this.cmbVAT.Name = "cmbVAT";
            this.cmbVAT.Size = new System.Drawing.Size(59, 24);
            this.cmbVAT.Sorted = true;
            this.cmbVAT.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(396, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сумма";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContrName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSelDeal);
            this.groupBox1.Controls.Add(this.dtpDealDate);
            this.groupBox1.Controls.Add(this.txtDealNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 81);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Договор";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(228, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Дата";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelDeal
            // 
            this.btnSelDeal.Location = new System.Drawing.Point(567, 51);
            this.btnSelDeal.Name = "btnSelDeal";
            this.btnSelDeal.Size = new System.Drawing.Size(33, 22);
            this.btnSelDeal.TabIndex = 13;
            this.btnSelDeal.Text = "...";
            this.btnSelDeal.UseVisualStyleBackColor = true;
            this.btnSelDeal.Click += new System.EventHandler(this.btnSelContractor_Click);
            // 
            // dtpDealDate
            // 
            this.dtpDealDate.Location = new System.Drawing.Point(286, 51);
            this.dtpDealDate.Name = "dtpDealDate";
            this.dtpDealDate.Size = new System.Drawing.Size(161, 22);
            this.dtpDealDate.TabIndex = 28;
            // 
            // txtDealNum
            // 
            this.txtDealNum.Location = new System.Drawing.Point(98, 51);
            this.txtDealNum.MaxLength = 12;
            this.txtDealNum.Name = "txtDealNum";
            this.txtDealNum.Size = new System.Drawing.Size(124, 22);
            this.txtDealNum.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Контрагент";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(29, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Номер";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDealID
            // 
            this.lblDealID.AutoSize = true;
            this.lblDealID.Location = new System.Drawing.Point(62, 243);
            this.lblDealID.Name = "lblDealID";
            this.lblDealID.Size = new System.Drawing.Size(21, 17);
            this.lblDealID.TabIndex = 27;
            this.lblDealID.Text = "-1";
            this.lblDealID.Visible = false;
            // 
            // SalesMainInterrop
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(637, 320);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesMainInterrop";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SalesMainInterrop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblContrID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContrName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSalesDate;
        private System.Windows.Forms.TextBox txtTrialSum;
        private System.Windows.Forms.Button btnSelDeal;
        private System.Windows.Forms.Label lblDealID;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtBaseSum;
        private System.Windows.Forms.TextBox txtSalesNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVAT;
        private System.Windows.Forms.TextBox txtDealNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDealDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}