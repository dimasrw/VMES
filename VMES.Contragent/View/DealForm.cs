using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using VMES.Contragent.DataModel;


namespace VMES.Contragent.View
{
    public enum DealFormType
    {   
        Base,       //форма отображается в качестве основного окна
        Dialog      //Форма отображается в качестве всплывающего окна
    }



    public partial class DealForm : Form
    {
        private GridBuilder gridBuilder;
        private CommandAndParams cap;

        public DealInterrop dealInterrop;

        //открываем доступ чтобы внешнии формы могли получить доступ к данным грида, 
        //знаю, ужасное решение !!!!"" ИСПРАВИТЬ ""!!!!!!!
        public DataGridView grdDealPublic
        {
            get { return this.gridMain; }
        }

        public DealForm(DealFormType dealFormType)
        {
            InitializeComponent();
            
            
            //строим грид
            gridBuilder = new GridBuilder(gridMain, 2, 1);
            //получаем данные в грид
            GetRows();

            switch (dealFormType)
            {
                case DealFormType.Base:
                    this.btnEdit.Visible = false;
                    break;
                case DealFormType.Dialog:
                    this.btnAdd.Visible = false;
                    this.btnEdit.Visible = false;
                    this.btnRemove.Visible = false;
                    break;
            }


        }

        /*Работа с БД*/
        private void GetRows()
        {
            cap = new CommandAndParams("SEL_Deal_All");
            var reader = cap.ExecuteReader();
            
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    gridMain.Rows.Add();

                    gridMain.Rows[i].Cells[0].Value = reader.GetValue(0);
                    gridMain.Rows[i].Cells[1].Value = reader.GetValue(1);
                    gridMain.Rows[i].Cells[2].Value = Convert.ToString(reader.GetValue(2));
                    gridMain.Rows[i].Cells[3].Value = Convert.ToString(reader.GetValue(3));
                    gridMain.Rows[i].Cells[4].Value = Convert.ToString(reader.GetValue(4));
                    gridMain.Rows[i].Cells[5].Value = Convert.ToString(reader.GetValue(5));
                    gridMain.Rows[i].Cells[6].Value = Convert.ToString(reader.GetValue(6));
                    gridMain.Rows[i].Cells[7].Value = Convert.ToInt32(reader.GetValue(7));
                    
                    i += 1;
                }
            }

            reader.Close();
            cap.CloseConnection();
            cap = null;
        }

        private void AddRow(int i)
        {
            cap = new CommandAndParams("ADD_Deal");
            cap.AddParam("@ContractorID", dealInterrop.ContrID);
            cap.AddParam("@DealOID", dealInterrop.DealNumber);
            cap.AddParam("@DealDate", dealInterrop.DealDate);
            cap.AddParam("@DealName", dealInterrop.DealName);
            cap.AddParam("@DealDueDay", dealInterrop.DueDate);

            gridMain.Rows[i].Cells[0].Value = cap.ExecuteScalar();
            cap.CloseConnection();
            cap = null;
        }

        private void UpdateRow()
        {

            cap = new CommandAndParams("UPD_Deal");
            cap.AddParam("@ContractorID", dealInterrop.ContrID);
            cap.AddParam("@DealOID", dealInterrop.DealNumber);
            cap.AddParam("@DealDate", dealInterrop.DealDate);
            cap.AddParam("@DealName", dealInterrop.DealName);
            cap.AddParam("@DealDueDay", dealInterrop.DueDate);
            cap.AddParam("@DealID", Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[0].Value));
            
            var result = cap.ExecuteNonQuery();
            cap.CloseConnection();
            cap = null;
        }

        private void RemoveRow()
        {

            cap = new CommandAndParams("DEL_Deal");
            cap.AddParam("@DealID", gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[0].Value);
            var result = cap.ExecuteNonQuery();
            cap.CloseConnection();
            cap = null;
        }

        /*работа с интерфейсом*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (dealInterrop = new DealInterrop())
            {
            dealInterrop.ButtonOkClicked += new EventHandler(AddRowDeal);
            dealInterrop.ShowDialog();
            }
        }
        
        private void AddRowDeal(object sender, EventArgs e)
        {
            int i = gridMain.Rows.Count;

            gridMain.Rows.Add();
            gridMain.Rows[i].Visible = false;
            AddRow(i);

            gridMain.Rows[i].Cells[1].Value = dealInterrop.ContrID;
            gridMain.Rows[i].Cells[2].Value = dealInterrop.ContrTIN;
            gridMain.Rows[i].Cells[3].Value = dealInterrop.ContrName;
            gridMain.Rows[i].Cells[4].Value = dealInterrop.DealNumber;
            gridMain.Rows[i].Cells[5].Value = dealInterrop.DealDate;
            gridMain.Rows[i].Cells[6].Value = dealInterrop.DealName;
            gridMain.Rows[i].Cells[7].Value = dealInterrop.DueDate;


            dealInterrop.ButtonOkClicked -= new EventHandler(AddRowDeal);
            dealInterrop.Close();
            gridMain.Rows[i].Visible = true;

            dealInterrop = null;

            //указываем активную ячейку
            gridMain.CurrentCell = gridMain.Rows[gridMain.Rows.Count - 1].Cells[2];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (dealInterrop = new DealInterrop())
            {
                              

                dealInterrop.ButtonOkClicked += new EventHandler(EditRowDeal);
                dealInterrop.FormCaption = "Редактировать";

                dealInterrop.ContrID = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[1].Value.ToString());
                dealInterrop.ContrTIN = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[2].Value.ToString();
                dealInterrop.ContrName = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[3].Value.ToString();
                dealInterrop.DealNumber = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[4].Value.ToString();
                dealInterrop.DealDate = Convert.ToDateTime(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[5].Value.ToString());
                dealInterrop.DealName = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[6].Value.ToString();
                dealInterrop.DueDate = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[7].Value.ToString());
                dealInterrop.ShowDialog();
            }
        }

        private void EditRowDeal(object sender, EventArgs e)
        {
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
            dealInterrop = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!(gridMain.Rows.Count == 0))
            {
                DialogResult result = MessageBox.Show("Удалить договор?",
                        "Программа", MessageBoxButtons.YesNo);
                if (!(result == DialogResult.No))
                {
                    RemoveRow();
                    gridMain.Rows.RemoveAt(gridMain.CurrentCell.RowIndex);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
