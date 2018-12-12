using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMES.Contragent.View
{
    class ContractorFormDialog:ContractorForm
    {
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView gridMain;

        private int contrID;
        private string tin = String.Empty;
        private string contrName = String.Empty;

        public ContractorFormDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(499, 14);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(136, 32);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ContractorFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1254, 825);
            this.Controls.Add(this.btnSelect);
            this.Name = "ContractorFormDialog";
            this.Controls.SetChildIndex(this.btnSelect, 0);
            this.ResumeLayout(false);

        }



        private void btnSelect_Click(object sender, EventArgs e)
        {
            gridMain = base.GetGrid;
            contrID = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[0].Value.ToString());
            tin = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[4].Value.ToString();
            contrName=gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[5].Value.ToString();
            this.Close();
        }

        public int ContrID
        {
            get {
                return contrID;
            }
        }


        public string TIN
        {
            get
            {
                return tin;
            }
        }

        public string ContrName {
            get {
                return contrName;
            }
        }
    }
}
