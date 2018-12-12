namespace VMES.Contragent.View
{
    partial class ContractorAdd
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
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContrName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTIN = new System.Windows.Forms.TextBox();
            this.cmbCat3 = new System.Windows.Forms.ComboBox();
            this.cmbCat2 = new System.Windows.Forms.ComboBox();
            this.cmbCat1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(526, 165);
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
            this.btnCancel.Location = new System.Drawing.Point(653, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(49, 185);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "-1";
            this.lblID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(5, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContrName
            // 
            this.txtContrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrName.Location = new System.Drawing.Point(118, 43);
            this.txtContrName.MaxLength = 250;
            this.txtContrName.Name = "txtContrName";
            this.txtContrName.Size = new System.Drawing.Size(654, 22);
            this.txtContrName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTIN);
            this.panel1.Controls.Add(this.cmbCat3);
            this.panel1.Controls.Add(this.cmbCat2);
            this.panel1.Controls.Add(this.cmbCat1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtContrName);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 250);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(18, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Категория 3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Категория 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Категория 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTIN
            // 
            this.txtTIN.Location = new System.Drawing.Point(118, 15);
            this.txtTIN.MaxLength = 12;
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(171, 22);
            this.txtTIN.TabIndex = 0;
            // 
            // cmbCat3
            // 
            this.cmbCat3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCat3.Location = new System.Drawing.Point(118, 131);
            this.cmbCat3.Name = "cmbCat3";
            this.cmbCat3.Size = new System.Drawing.Size(512, 24);
            this.cmbCat3.TabIndex = 4;
            // 
            // cmbCat2
            // 
            this.cmbCat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCat2.FormattingEnabled = true;
            this.cmbCat2.Location = new System.Drawing.Point(118, 101);
            this.cmbCat2.Name = "cmbCat2";
            this.cmbCat2.Size = new System.Drawing.Size(171, 24);
            this.cmbCat2.TabIndex = 3;
            // 
            // cmbCat1
            // 
            this.cmbCat1.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCat1.FormattingEnabled = true;
            this.cmbCat1.Location = new System.Drawing.Point(118, 71);
            this.cmbCat1.Name = "cmbCat1";
            this.cmbCat1.Size = new System.Drawing.Size(171, 24);
            this.cmbCat1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(73, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ИНН";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ContractorAdd
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(802, 252);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContractorAdd";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить контрагента";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContrName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTIN;
        private System.Windows.Forms.ComboBox cmbCat3;
        private System.Windows.Forms.ComboBox cmbCat2;
        private System.Windows.Forms.ComboBox cmbCat1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}