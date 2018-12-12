using System;
using System.Windows.Forms;
using VMES.Contragent.DataModel;
using VMES.Contragent.Model;

namespace VMES.Contragent.View
{
    public partial class SalesForm : Form
    {
        private GridBuilder gridBuilder;
        private CommandAndParams cap;

        private SalesMainInterrop salesInterrop;
        private Sales sales;


        public SalesForm()
        {
            InitializeComponent();
            
            gridBuilder = new GridBuilder(gridMain, 3, 1);
            gridBuilder = null;
            gridBuilder = new GridBuilder(gridDetail, 3, 2);
            gridBuilder = null;
            
            GetRowsMain();
        }

        public SalesForm(int salesID)
        {
            //для отражения в качетсва всплывающего окна для выбора контрагента
            btnAddDetail.Visible = false;
            btnEditDetail.Visible = false;
            btnDelDetail.Visible = false;
            btnSelect.Visible = true;
        }

        public DataGridView SalesGrid
        {
            get { return this.gridMain; }
        }

        public void GetRowMainByID()
        {
            // выбирает акты только по ид договора

        }
        private void GetRowsMain()
        {
            cap = new CommandAndParams("SEL_Sales_Main_All");
            var reader = cap.ExecuteReader();

            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    gridMain.Rows.Add();

                    gridMain.Rows[i].Cells[0].Value = Convert.ToInt32(reader.GetValue(0));
                    gridMain.Rows[i].Cells[1].Value = Convert.ToInt32(reader.GetValue(1));
                    gridMain.Rows[i].Cells[2].Value = Convert.ToInt32(reader.GetValue(2));
                    gridMain.Rows[i].Cells[3].Value = Convert.ToInt32(reader.GetValue(3));
                    gridMain.Rows[i].Cells[4].Value = Convert.ToString(reader.GetValue(4));
                    gridMain.Rows[i].Cells[5].Value = Convert.ToString(reader.GetValue(5));
                    gridMain.Rows[i].Cells[6].Value = Convert.ToDateTime(reader.GetValue(6));
                    gridMain.Rows[i].Cells[7].Value = Convert.ToString(reader.GetValue(7));
                    gridMain.Rows[i].Cells[8].Value = Convert.ToDateTime(reader.GetValue(8));
                    gridMain.Rows[i].Cells[9].Value = Convert.ToDecimal(reader.GetValue(9));
                    gridMain.Rows[i].Cells[10].Value = Convert.ToDecimal(reader.GetValue(10));
                    gridMain.Rows[i].Cells[11].Value = Convert.ToDecimal(reader.GetValue(11));

                    i += 1;
                }
            }

            reader.Close();
            cap.CloseConnection();
            cap = null;
        }

        private void AddRowMain(int i)
        {
            cap = new CommandAndParams("ADD_Sales_Main");

            cap.AddParam("@ContractorID", sales.ContrID);
            cap.AddParam("@DealID", sales.DealID);
            cap.AddParam("@SalesNum", sales.SalesNum);
            cap.AddParam("@SalesDate", sales.SalesDate);
            cap.AddParam("@VAT", sales.VAT);
            cap.AddParam("@SalesSum", sales.SalesSum);
            cap.AddParam("@SalesBaseSum", sales.SalesBaseSum);
            cap.AddParam("@SalesTrialSum", sales.SalesTrialSum);

            gridMain.Rows[i].Cells[0].Value = cap.ExecuteScalar();
            cap.CloseConnection();
            cap = null;
        }

        private void UpdateRowMain()
        {
            cap = new CommandAndParams("UPD_Sales_Main");

            cap.AddParam("@SalesID", sales.SalesID);
            cap.AddParam("@SalesNum", sales.SalesNum);
            cap.AddParam("@SalesDate", sales.SalesDate);
            cap.AddParam("@VAT", sales.VAT);
            cap.AddParam("@SalesSum", sales.SalesSum);
            cap.AddParam("@SalesBaseSum", sales.SalesBaseSum);
            cap.AddParam("@SalesTrialSum", sales.SalesTrialSum);

            var result = cap.ExecuteNonQuery();
            cap.CloseConnection();
            cap = null;
        }

        private void RemoveRowMain(int i)
        {
            cap = new CommandAndParams("DEL_Sales_Main");
            cap.AddParam("@SalesID", gridMain.Rows[i].Cells[0].Value);
            var result = cap.ExecuteNonQuery();
            cap.CloseConnection();
            cap = null;
        }

        private void btnAddMain_Click(object sender, EventArgs e)
        {
            sales = new Sales();
            using (salesInterrop = new SalesMainInterrop(SalesWinType.Main, sales))
            {
                salesInterrop.ButtonOkClicked += new EventHandler(AddRowSalesMain);
                salesInterrop.ShowDialog();
            }

        }

        private void AddRowSalesMain(object sender, EventArgs e)
        {
            int i = gridMain.Rows.Count;

            gridMain.Rows.Add();

            gridMain.Rows[i].Visible = false;
            AddRowMain(i);

            gridMain.Rows[i].Cells[1].Value = sales.ContrID;
            gridMain.Rows[i].Cells[2].Value = sales.DealID;
            gridMain.Rows[i].Cells[3].Value = sales.VAT;
            gridMain.Rows[i].Cells[4].Value = sales.ContrName;
            gridMain.Rows[i].Cells[5].Value = sales.DealNumber;
            gridMain.Rows[i].Cells[6].Value = sales.DealDate;
            gridMain.Rows[i].Cells[7].Value = sales.SalesNum;
            gridMain.Rows[i].Cells[8].Value = sales.SalesDate;
            gridMain.Rows[i].Cells[9].Value = sales.SalesSum;
            gridMain.Rows[i].Cells[10].Value = sales.SalesBaseSum;
            gridMain.Rows[i].Cells[11].Value = sales.SalesTrialSum;


            salesInterrop.ButtonOkClicked -= new EventHandler(AddRowSalesMain);
            salesInterrop.Close();
            gridMain.Rows[i].Visible = true;

            salesInterrop = null;
            sales = null;

            //указываем активную ячейку
            gridMain.CurrentCell = gridMain.Rows[i].Cells[4];
        }

        private void btnEditMain_Click(object sender, EventArgs e)
        {
            if (!(gridMain.Rows.Count == 0))
            {
                //cоздаем объект и передаем всплывающей форме
                sales = new Sales();
                int i = gridMain.CurrentCell.RowIndex;

                sales.SalesID = Convert.ToInt32(gridMain.Rows[i].Cells[0].Value);
                sales.ContrID = Convert.ToInt32(gridMain.Rows[i].Cells[1].Value);
                sales.DealID = Convert.ToInt32(gridMain.Rows[i].Cells[2].Value);
                sales.VAT = Convert.ToInt32(gridMain.Rows[i].Cells[3].Value);
                sales.ContrName = gridMain.Rows[i].Cells[4].Value.ToString();
                sales.DealNumber = gridMain.Rows[i].Cells[5].Value.ToString();
                sales.DealDate = Convert.ToDateTime(gridMain.Rows[i].Cells[6].Value);
                sales.SalesNum = gridMain.Rows[i].Cells[7].Value.ToString();
                sales.SalesDate = Convert.ToDateTime(gridMain.Rows[i].Cells[8].Value);
                sales.SalesSum = Convert.ToDecimal(gridMain.Rows[i].Cells[9].Value);
                sales.SalesBaseSum = Convert.ToDecimal(gridMain.Rows[i].Cells[10].Value);
                sales.SalesTrialSum = Convert.ToDecimal(gridMain.Rows[i].Cells[11].Value);

                using (salesInterrop = new SalesMainInterrop(SalesWinType.MainEdit, sales))
                {
                    salesInterrop.ButtonOkClicked += new EventHandler(EditRowSalesMain);

                    salesInterrop.ShowDialog();
                }
            }
        }

        private void EditRowSalesMain(object sender, EventArgs e)
        {
            int i = gridMain.CurrentCell.RowIndex;

            gridMain.Rows[i].Cells[3].Value = sales.VAT;
            gridMain.Rows[i].Cells[7].Value = sales.SalesNum;
            gridMain.Rows[i].Cells[8].Value = sales.SalesDate;
            gridMain.Rows[i].Cells[9].Value = sales.SalesSum;
            gridMain.Rows[i].Cells[10].Value = sales.SalesBaseSum;
            gridMain.Rows[i].Cells[11].Value = sales.SalesTrialSum;
            
            //обновление в бд
            UpdateRowMain();

            salesInterrop.ButtonOkClicked -= new EventHandler(EditRowSalesMain);
            salesInterrop.Close();
            salesInterrop = null;
            sales = null;
        }

        private void btnDelMain_Click(object sender, EventArgs e)
        {
            if (!(gridMain.Rows.Count == 0))
            {
                DialogResult result = MessageBox.Show("Удалить акт и связанные с ним корректировочные акты?",
                        "Программа", MessageBoxButtons.YesNo);
                if (!(result == DialogResult.No))
                {
                    int i = gridMain.CurrentCell.RowIndex;
                    RemoveRowMain(i);
                    gridMain.Rows.RemoveAt(i);
                }
            }
        }
        
        /*Корректировочные акты, грид 2*/
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            int i = gridMain.CurrentCell.RowIndex;
            sales = new Sales();
            sales.NumDataParent = gridMain.Rows[i].Cells[7].Value.ToString() +" от "+ gridMain.Rows[i].Cells[8].Value.ToString();
            using (salesInterrop = new SalesMainInterrop(SalesWinType.Detail, sales))
            {
                salesInterrop.ButtonOkClicked += new EventHandler(AddRowSalesDetail);
                salesInterrop.ShowDialog();
            }
         }

        private void AddRowSalesDetail(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}

