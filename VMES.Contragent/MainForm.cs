using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMES.Contragent.View;

namespace VMES.Contragent
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ContractorForm contractorForm;

            if (Application.OpenForms.Count > 1)
            {
                if (Application.OpenForms[1].Name == "ContractorForm")
                {
                    MessageBox.Show("Форма открыта!");
                    for (int i = 0; i<Application.OpenForms.Count - 1;i++)
                        {
                        Application.OpenForms[i].Activate();
                        Application.OpenForms[i].WindowState = FormWindowState.Maximized;
                    }
                }
            }
            else {
                contractorForm = new ContractorForm();

                contractorForm.MdiParent = this;
                contractorForm.WindowState = FormWindowState.Normal;
                contractorForm.WindowState = FormWindowState.Maximized;
                contractorForm.Show();
            }
                   

        }

        private void договорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealForm frmDeal = new DealForm(DealFormType.Base);
            frmDeal.MdiParent = this;
            frmDeal.WindowState = FormWindowState.Normal;
            frmDeal.WindowState = FormWindowState.Maximized;
            frmDeal.Show();
        }

        private void актыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm frmSales = new SalesForm();
            frmSales.MdiParent = this;
            frmSales.WindowState = FormWindowState.Normal;
            frmSales.WindowState = FormWindowState.Maximized;
            frmSales.Show();
        }

        private void платежкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm frmPayment = new PaymentForm();
            frmPayment.MdiParent = this;
            frmPayment.WindowState = FormWindowState.Normal;
            frmPayment.WindowState = FormWindowState.Maximized;
            frmPayment.Show();
        }
    }
}
