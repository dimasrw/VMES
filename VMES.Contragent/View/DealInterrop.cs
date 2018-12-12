using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMES.Contragent.View
{
    public partial class DealInterrop : Form
    {
        public DealInterrop()
        {
            InitializeComponent();

        }

        public event EventHandler ButtonOkClicked = null;

        private ContractorFormDialog contractorForm;

        private int intID = -1; //ид контрагентв
        private string strTIN = String.Empty;//ИНН контрагента*
        private string strContrName = String.Empty; //название контрагента
        private string strDealNumber;  //номер договора
        private DateTime dtDeal;//дата договора
        private string strDealName = String.Empty; //название договора
        private int intDueDay = 0;//последний день оплаты


        public int ContrID
        {
            get
            { return intID; }
            set
            {
                intID = value;
                lblID.Text = Convert.ToString(intID);
            }
        }

        public string ContrTIN
        {
            get
            { return strTIN; }
            set
            {
                strTIN = value;
                txtTIN.Text = strTIN;
            }
        }

        public string ContrName
        {
            get
            { return strContrName; }
            set
            {
                strContrName = value;
                txtContrName.Text = strContrName;
            }
        }

        public string DealNumber
        {
            get
            { return strDealNumber; }
            set
            {
                strDealNumber = value;
                txtNumber.Text = strDealNumber;
            }
        }

        public DateTime DealDate
        {
            get
            { return dtDeal; }
            set
            { dtDeal = value;
                dtpDate.Value = dtDeal;
            }
        }

        public string DealName
        {
            get
            { return strDealName; }
            set
            { strDealName = value;
                txtDealName.Text = strDealName;
            }
        }

        public int DueDate
        {
            get
            { return intDueDay; }

            set { intDueDay = value;
                upDueDay.Value = intDueDay;
            }
        }
        
        public string FormCaption { set { this.Text = value; } }

        private void btnSelContractor_Click(object sender, EventArgs e)
        {
            contractorForm = new ContractorFormDialog();
            contractorForm.ShowDialog();
            this.lblID.Text = Convert.ToString(contractorForm.ContrID);
            this.txtTIN.Text = contractorForm.TIN;
            this.txtContrName.Text = contractorForm.ContrName;
            contractorForm = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            intID = Convert.ToInt32(lblID.Text);
            strTIN = txtTIN.Text;
            strContrName = txtContrName.Text;
            strDealNumber = txtNumber.Text;
            dtDeal = dtpDate.Value;
            strDealName = txtDealName.Text;
            intDueDay = Convert.ToInt32(upDueDay.Value);

            ButtonOkClicked.Invoke(sender, e);
        }
    }

}
