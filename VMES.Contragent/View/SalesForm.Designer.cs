namespace VMES.Contragent.View
{
    partial class SalesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelMain = new System.Windows.Forms.Button();
            this.btnEditMain = new System.Windows.Forms.Button();
            this.btnAddMain = new System.Windows.Forms.Button();
            this.gridDetail = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelDetail = new System.Windows.Forms.Button();
            this.btnEditDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 674);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridMain);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridDetail);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(938, 674);
            this.splitContainer1.SplitterDistance = 502;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            this.gridMain.AllowUserToDeleteRows = false;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(0, 41);
            this.gridMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridMain.Name = "gridMain";
            this.gridMain.ReadOnly = true;
            this.gridMain.RowTemplate.Height = 24;
            this.gridMain.Size = new System.Drawing.Size(502, 633);
            this.gridMain.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSelect);
            this.panel3.Controls.Add(this.btnDelMain);
            this.panel3.Controls.Add(this.btnEditMain);
            this.panel3.Controls.Add(this.btnAddMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 41);
            this.panel3.TabIndex = 0;
            // 
            // btnDelMain
            // 
            this.btnDelMain.Location = new System.Drawing.Point(232, 6);
            this.btnDelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelMain.Name = "btnDelMain";
            this.btnDelMain.Size = new System.Drawing.Size(107, 29);
            this.btnDelMain.TabIndex = 2;
            this.btnDelMain.Text = "Удалить";
            this.btnDelMain.UseVisualStyleBackColor = true;
            this.btnDelMain.Click += new System.EventHandler(this.btnDelMain_Click);
            // 
            // btnEditMain
            // 
            this.btnEditMain.Location = new System.Drawing.Point(121, 6);
            this.btnEditMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditMain.Name = "btnEditMain";
            this.btnEditMain.Size = new System.Drawing.Size(107, 29);
            this.btnEditMain.TabIndex = 1;
            this.btnEditMain.Text = "Править";
            this.btnEditMain.UseVisualStyleBackColor = true;
            this.btnEditMain.Click += new System.EventHandler(this.btnEditMain_Click);
            // 
            // btnAddMain
            // 
            this.btnAddMain.Location = new System.Drawing.Point(9, 6);
            this.btnAddMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMain.Name = "btnAddMain";
            this.btnAddMain.Size = new System.Drawing.Size(107, 29);
            this.btnAddMain.TabIndex = 0;
            this.btnAddMain.Text = "Добавить";
            this.btnAddMain.UseVisualStyleBackColor = true;
            this.btnAddMain.Click += new System.EventHandler(this.btnAddMain_Click);
            // 
            // gridDetail
            // 
            this.gridDetail.AllowUserToAddRows = false;
            this.gridDetail.AllowUserToDeleteRows = false;
            this.gridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDetail.Location = new System.Drawing.Point(0, 41);
            this.gridDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.ReadOnly = true;
            this.gridDetail.RowTemplate.Height = 24;
            this.gridDetail.Size = new System.Drawing.Size(433, 633);
            this.gridDetail.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelDetail);
            this.panel4.Controls.Add(this.btnEditDetail);
            this.panel4.Controls.Add(this.btnAddDetail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 41);
            this.panel4.TabIndex = 0;
            // 
            // btnDelDetail
            // 
            this.btnDelDetail.Location = new System.Drawing.Point(235, 5);
            this.btnDelDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(107, 29);
            this.btnDelDetail.TabIndex = 3;
            this.btnDelDetail.Text = "Удалить";
            this.btnDelDetail.UseVisualStyleBackColor = true;
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Location = new System.Drawing.Point(123, 5);
            this.btnEditDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(107, 29);
            this.btnEditDetail.TabIndex = 2;
            this.btnEditDetail.Text = "Править";
            this.btnEditDetail.UseVisualStyleBackColor = true;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(11, 5);
            this.btnAddDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(107, 29);
            this.btnAddDetail.TabIndex = 1;
            this.btnAddDetail.Text = "Добавить";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(11, 5);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(107, 29);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalesForm";
            this.Text = "Акты выполненных работ";
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Conponents.FinanceTextBox financeTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelMain;
        private System.Windows.Forms.Button btnEditMain;
        private System.Windows.Forms.Button btnAddMain;
        private System.Windows.Forms.DataGridView gridDetail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelDetail;
        private System.Windows.Forms.Button btnEditDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnSelect;
    }
}