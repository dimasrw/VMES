using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using VMES.Contragent.DataModel;
using VMES.Contragent.Model;


namespace VMES.Contragent.View
{
       
    public partial class PaymentForm: Form
    {
        private GridBuilder gridBuilder;
        private CommandAndParams cap;

        private PaymentInterrop paymentInterrop;
        private Payment payment;

        //открываем доступ чтобы внешнии формы могли получить доступ к данным грида, 
        //знаю, ужасное решение !!!!"" ИСПРАВИТЬ ""!!!!!!!
        public DataGridView grdPaymentPublic
        {
            get { return this.gridMain; }
        }

        public PaymentForm()
        {
            InitializeComponent();
            
            //строим грид
            gridBuilder = new GridBuilder(gridMain, 4, 1);
            //получаем данные в грид
            GetRows();
        }

        /*Работа с БД*/
        private void GetRows()
        {
            cap = new CommandAndParams("SEL_Payment_All");
            var reader = cap.ExecuteReader();
            
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    gridMain.Rows.Add();

                    gridMain.Rows[i].Cells[0].Value = reader.GetValue(0);
                    gridMain.Rows[i].Cells[1].Value = reader.GetValue(1);
                    gridMain.Rows[i].Cells[2].Value = reader.GetValue(2);
                    gridMain.Rows[i].Cells[3].Value = reader.GetValue(3);
                    gridMain.Rows[i].Cells[4].Value = reader.GetValue(4);
                    gridMain.Rows[i].Cells[5].Value = reader.GetValue(5);
                    gridMain.Rows[i].Cells[6].Value = reader.GetValue(6);
                    gridMain.Rows[i].Cells[7].Value = reader.GetValue(7);
                    gridMain.Rows[i].Cells[8].Value = reader.GetValue(8);
                    gridMain.Rows[i].Cells[9].Value = reader.GetValue(9);
                    gridMain.Rows[i].Cells[10].Value = Convert.ToDecimal(reader.GetValue(10));
                    
                    i += 1;
                }
            }

            reader.Close();
            cap.CloseConnection();
            cap = null;
        }

        private void AddRow(int i)
        {/*
            cap = new CommandAndParams("ADD_Deal");
            cap.AddParam("@ContractorID", dealInterrop.ContrID);
            cap.AddParam("@DealOID", dealInterrop.DealNumber);
            cap.AddParam("@DealDate", dealInterrop.DealDate);
            cap.AddParam("@DealName", dealInterrop.DealName);
            cap.AddParam("@DealDueDay", dealInterrop.DueDate);

            gridMain.Rows[i].Cells[0].Value = cap.ExecuteScalar();
            cap.CloseConnection();
            cap = null;*/
        }

        private void UpdateRow()
        {/*

            cap = new CommandAndParams("UPD_Deal");
            cap.AddParam("@ContractorID", dealInterrop.ContrID);
            cap.AddParam("@DealOID", dealInterrop.DealNumber);
            cap.AddParam("@DealDate", dealInterrop.DealDate);
            cap.AddParam("@DealName", dealInterrop.DealName);
            cap.AddParam("@DealDueDay", dealInterrop.DueDate);
            cap.AddParam("@DealID", Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[0].Value));
            
            var result = cap.ExecuteNonQuery();
            cap.CloseConnection();
            cap = null;*/
        }

        private void RemoveRow()
        {/*

            cap = new CommandAndParams("DEL_Deal");
            cap.AddParam("@DealID", gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[0].Value);
            var result = cap.ExecuteNonQuery();
            cap.CloseConnection();
            cap = null;*/
        }

        /*работа с интерфейсом*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            payment = new Payment();
            using (paymentInterrop = new PaymentInterrop(payment))
            {
                paymentInterrop.ButtonOkClicked += new EventHandler(AddRowPayment);
                paymentInterrop.ShowDialog();
            }
        }
        
        private void AddRowPayment(object sender, EventArgs e)
        {
            int i = gridMain.Rows.Count;

            gridMain.Rows.Add();
            gridMain.Rows[i].Visible = false;
            //AddRow(i);

            gridMain.Rows[i].Cells[0].Value = payment.ContractorID;
            gridMain.Rows[i].Cells[1].Value = payment.DealID;
            gridMain.Rows[i].Cells[2].Value = payment.SalesID;
            gridMain.Rows[i].Cells[3].Value = payment.PaymentID;
            gridMain.Rows[i].Cells[4].Value = payment.ChargeType;
            gridMain.Rows[i].Cells[5].Value = payment.PaymentType;
            gridMain.Rows[i].Cells[6].Value = payment.ContrName;
            gridMain.Rows[i].Cells[7].Value = payment.DealName;
            gridMain.Rows[i].Cells[8].Value = payment.PaymentOID;
            gridMain.Rows[i].Cells[9].Value = payment.PaymentDate;
            gridMain.Rows[i].Cells[10].Value = payment.PaymentSum;

            paymentInterrop.ButtonOkClicked -= new EventHandler(AddRowPayment);
            paymentInterrop.Close();
            gridMain.Rows[i].Visible = true;

            paymentInterrop = null;

            //указываем активную ячейку
            gridMain.CurrentCell = gridMain.Rows[gridMain.Rows.Count - 1].Cells[6];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            payment = new Payment();

            payment.ContractorID = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[0].Value);
            payment.DealID = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[1].Value);
            payment.SalesID = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[2].Value);
            payment.PaymentID = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[3].Value);
            payment.ChargeType = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[4].Value);
            payment.PaymentType = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[5].Value);
            payment.ContrName = Convert.ToString(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[6].Value);
            payment.DealName= Convert.ToString(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[7].Value);
            payment.PaymentOID= Convert.ToString(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[8].Value);
            payment.PaymentDate= Convert.ToDateTime(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[9].Value);
            payment.PaymentSum= Convert.ToDecimal(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[10].Value);

            using (paymentInterrop = new PaymentInterrop(payment))
            {


                //dealInterrop.ButtonOkClicked += new EventHandler(EditRowDeal);
                //paymentInterrop.FormCaption = "Редактировать";
                /*
                dealInterrop.ContrID = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[1].Value.ToString());
                dealInterrop.ContrTIN = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[2].Value.ToString();
                dealInterrop.ContrName = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[3].Value.ToString();
                dealInterrop.DealNumber = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[4].Value.ToString();
                dealInterrop.DealDate = Convert.ToDateTime(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[5].Value.ToString());
                dealInterrop.DealName = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[6].Value.ToString();
                dealInterrop.DueDate = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[7].Value.ToString());*/
                paymentInterrop.ShowDialog();
            }
        }

        private void EditRowDeal(object sender, EventArgs e)
        {/*
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[1].Value = dealInterrop.ContrID;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[2].Value = dealInterrop.ContrTIN;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[3].Value = dealInterrop.ContrName;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[4].Value = dealInterrop.DealNumber;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[5].Value = dealInterrop.DealDate;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[6].Value = dealInterrop.DealName;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[7].Value = dealInterrop.DueDate;
            
            //обновление в бд
            UpdateRow();
            dealInterrop.ButtonOkClicked -= new EventHandler(EditRowDeal);
            dealInterrop.Close();
            dealInterrop = null;*/
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {/*
            if (!(gridMain.Rows.Count == 0))
            {
                DialogResult result = MessageBox.Show("Удалить договор?",
                        "Программа", MessageBoxButtons.YesNo);
                if (!(result == DialogResult.No))
                {
                    RemoveRow();
                    gridMain.Rows.RemoveAt(gridMain.CurrentCell.RowIndex);
                }
            }*/
        }
    
    }
    
}
