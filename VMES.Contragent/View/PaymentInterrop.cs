using System;
using System.Windows.Forms;
using VMES.Contragent.Model;

namespace VMES.Contragent.View
{
    /*
    //Указывает в каком режиме будет работать окно SalesMainInterrop
    public enum SalesWinType
    {
        Main,       //Окно будет использоваться в режиме "Доавить" в основной грид
        MainEdit,   //Окно будет использоваться в режиме "Редактировать" в основном гриде
        Detail,     //Окно будет использоваться в режиме "Доавить" в грид детализации
        DetailEdit  //Окно будет использоваться в режиме "Редактировать" в гриде детализации
    }
    */
    public partial class PaymentInterrop : Form
    {

        public event EventHandler ButtonOkClicked = null;

        private Payment payment;
        private DealForm dealForm;
        private SalesForm salesForm;

        public PaymentInterrop (Payment payment)
        {
            InitializeComponent();
            
            this.payment = payment;
          
            /*
            switch (salesWinType)
            {
                case SalesWinType.Main:
                    this.cmbVAT.SelectedIndex = 0;
                    this.Text = "Добавить акт выполненных работ";
                    break;
                case SalesWinType.MainEdit:
                    this.Text = "Редактировать акт выполненных работ";
                    txtContrName.Enabled = false;
                    txtDealNum.Enabled = false;
                    dtpDealDate.Enabled = false;
                    btnSelDeal.Enabled = false;

                    txtContrName.Text = sales.ContrName;
                    txtDealNum.Text = sales.DealNumber;
                    dtpDealDate.Value = sales.DealDate;
                    txtSalesNum.Text = sales.SalesNum;
                    dtpSalesDate.Value = sales.SalesDate;
                    if (sales.VAT == 18)
                    {
                        cmbVAT.SelectedIndex = 0;
                    }
                    else { cmbVAT.SelectedIndex = 1; }
                    txtSum.Text = sales.SalesSum.ToString();
                    txtBaseSum.Text = sales.SalesBaseSum.ToString();
                    txtTrialSum.Text = sales.SalesTrialSum.ToString();

                    break;
                case SalesWinType.Detail:
                    this.Text ="Добавить корректировку к акту " + sales.NumDataParent;
                    txtBaseSum.Visible = false;
                    txtTrialSum.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;

                    txtContrName.Enabled = false;
                    txtDealNum.Enabled = false;
                    dtpDealDate.Enabled = false;
                    btnSelDeal.Enabled = false;
                    break;
                case SalesWinType.DetailEdit:
                    this.Text = "Редактировать корректировочный акт";
                    break;
            }
            */
        }

      
        
        private void btnSelContractor_Click(object sender, EventArgs e)
        {            
            dealForm = new DealForm();
            dealForm.ShowDialog();

            int i= dealForm.grdDealPublic.CurrentCell.RowIndex;
            this.txtContrName.Text = Convert.ToString(dealForm.grdDealPublic.Rows[i].Cells[3].Value.ToString());
            this.txtDealNum.Text = Convert.ToString(dealForm.grdDealPublic.Rows[i].Cells[4].Value.ToString());
                        
            payment.DealID = Convert.ToInt32(dealForm.grdDealPublic.Rows[i].Cells[0].Value.ToString());
            payment.ContractorID = Convert.ToInt32(dealForm.grdDealPublic.Rows[i].Cells[1].Value.ToString());
            payment.ContrName = Convert.ToString(dealForm.grdDealPublic.Rows[i].Cells[3].Value.ToString());
            payment.DealName = Convert.ToString(dealForm.grdDealPublic.Rows[i].Cells[4].Value.ToString());
                        
            dealForm = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            /*
            sales.SalesNum = this.txtSalesNum.Text;
            sales.SalesDate = this.dtpSalesDate.Value;
            sales.VAT = Convert.ToInt32(this.cmbVAT.Text);
            sales.SalesSum = Convert.ToDecimal(this.txtSum.Text);
            sales.SalesBaseSum = Convert.ToDecimal(this.txtBaseSum.Text);
            sales.SalesTrialSum = Convert.ToDecimal(this.txtTrialSum.Text);
            
            ButtonOkClicked.Invoke(sender, e);
            */
        }

        private void btnSelSale_Click(object sender, EventArgs e)
        {
            salesForm = new SalesForm();

            salesForm.ShowDialog();

            int i = salesForm.SalesGrid.CurrentCell.RowIndex;
            this.txtSalesNum.Text = Convert.ToString(salesForm.SalesGrid.Rows[i].Cells[7].Value.ToString());
            this.dtpSalesDate.Value = Convert.ToDateTime(salesForm.SalesGrid.Rows[i].Cells[6].Value.ToString());
            
            payment.SalesID = Convert.ToInt32(salesForm.SalesGrid.Rows[i].Cells[1].Value.ToString());

            salesForm = null;
        }
    }

}
