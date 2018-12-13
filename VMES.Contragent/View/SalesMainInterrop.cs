using System;
using System.Windows.Forms;
using VMES.Contragent.Model;

namespace VMES.Contragent.View
{

    //Указывает в каком режиме будет работать окно SalesMainInterrop
    public enum SalesWinType
    {
        Main,       //Окно будет использоваться в режиме "Доавить" в основной грид
        MainEdit,   //Окно будет использоваться в режиме "Редактировать" в основном гриде
        Detail,     //Окно будет использоваться в режиме "Доавить" в грид детализации
        DetailEdit  //Окно будет использоваться в режиме "Редактировать" в гриде детализации
    }

    public partial class SalesMainInterrop : Form
    {

        public event EventHandler ButtonOkClicked = null;

        private Sales sales;
        private DealForm dealForm;

        public SalesMainInterrop(SalesWinType salesWinType,Sales sales)
        {
            InitializeComponent();
            
            this.sales = sales;
          

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
            
        }

      
        
        private void btnSelContractor_Click(object sender, EventArgs e)
        {
            dealForm = new DealForm(DealFormType.Dialog);
            dealForm.ShowDialog();

            int i= dealForm.grdDealPublic.CurrentCell.RowIndex;
            this.txtContrName.Text = Convert.ToString(dealForm.grdDealPublic.Rows[i].Cells[3].Value.ToString());
            this.txtDealNum.Text = Convert.ToString(dealForm.grdDealPublic.Rows[i].Cells[4].Value.ToString());
            this.dtpDealDate.Text = Convert.ToString(dealForm.grdDealPublic.Rows[i].Cells[5].Value.ToString());

            sales.DealID = Convert.ToInt32(dealForm.grdDealPublic.Rows[i].Cells[0].Value.ToString());
            sales.ContrID = Convert.ToInt32(dealForm.grdDealPublic.Rows[i].Cells[1].Value.ToString());
            sales.ContrName = Convert.ToString(dealForm.grdDealPublic.Rows[i].Cells[3].Value.ToString());
            sales.DealNumber = Convert.ToString(dealForm.grdDealPublic.Rows[i].Cells[4].Value.ToString());
            sales.DealDate = Convert.ToDateTime(dealForm.grdDealPublic.Rows[i].Cells[5].Value.ToString());

            dealForm = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            sales.SalesNum = this.txtSalesNum.Text;
            sales.SalesDate = this.dtpSalesDate.Value;
            sales.VAT = Convert.ToInt32(this.cmbVAT.Text);
            sales.SalesSum = Convert.ToDecimal(this.txtSum.Text);
            sales.SalesBaseSum = Convert.ToDecimal(this.txtBaseSum.Text);
            sales.SalesTrialSum = Convert.ToDecimal(this.txtTrialSum.Text);
            
            ButtonOkClicked.Invoke(sender, e);
        }

    }

}
