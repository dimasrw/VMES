using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VMES.Contragent.DataModel;




namespace VMES.Contragent.View
{
    public partial class ContractorForm : Form
    {
        private GridBuilder gridBuilder;
        public ContractorAdd contractorAdd;
        private SqlConnection connection;

        public ContractorForm()
        { 

            InitializeComponent();
            //connection oject to sql server
            connection = ConnectionSingleton.Connection;
            //строим грид
            gridBuilder = new GridBuilder(gridMain,1,1);
            //получаем данные в грид
            GetRows();
        }

        //подгружаем комбики
        private void LoadCategories()
        {
            connection = ConnectionSingleton.Connection;
            //string connectionString = @"Data Source=DEVCOMP;Initial Catalog=Contragent;Integrated Security=True";

            connection.Open();
            // название процедуры
            string sqlExpression = "SEL_Category";


                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    int i = 0;
                    while (reader.Read())
                    {

                        contractorAdd.LoadComboBoxes(Convert.ToInt32(reader.GetValue(0)), Convert.ToInt32(reader.GetValue(1)), Convert.ToString(reader.GetValue(2)));
                        i += 1;
                    }
                }
                reader.Close();
                connection.Close();   
         
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
                using (contractorAdd = new ContractorAdd())
                {
                contractorAdd.ButtonOkClicked += new EventHandler(AddRowCon);
                LoadCategories();
                contractorAdd.ActiveItemsCombobox(0, 0, 0);
                contractorAdd.ShowDialog();
                }
        }

        /*Работа сБД*/
        private void GetRows()
            {

            
                // название процедуры
                string sqlExpression = "SEL_Contractor";

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

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
                        gridMain.Rows[i].Cells[4].Value = Convert.ToString(reader.GetValue(4));
                        gridMain.Rows[i].Cells[5].Value = reader.GetValue(5);
                        gridMain.Rows[i].Cells[6].Value = reader.GetValue(6);
                        gridMain.Rows[i].Cells[7].Value = reader.GetValue(7);
                        gridMain.Rows[i].Cells[8].Value = reader.GetValue(8);
                        i += 1;
                    }
                }
                reader.Close();
                connection.Close();
            }

        private void AddRow(int i)
        {
         
            string sqlExpression = "ADD_Contractor";
            
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // параметр для ввода имени
                SqlParameter tinParam = new SqlParameter
                {
                    ParameterName = "@TIN",
                    Value = contractorAdd.ContrTIN
                };
                // добавляем параметр
                command.Parameters.Add(tinParam);

                
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@ContrName",
                    Value = contractorAdd.ContrName
                };
                command.Parameters.Add(nameParam);

                SqlParameter fidParam = new SqlParameter
                {
                    ParameterName = "@CategoryFID",
                    Value = contractorAdd.CategoryFirstID
                };
                command.Parameters.Add(fidParam);

                SqlParameter sidParam = new SqlParameter
                {
                    ParameterName = "@CategorySID",
                    Value = contractorAdd.CategorySecondID
                };
                command.Parameters.Add(sidParam);

                SqlParameter tidParam = new SqlParameter
                {
                    ParameterName = "@CategoryTID",
                    Value = contractorAdd.CategoryThirdID
                };
                command.Parameters.Add(tidParam);


                //var result = command.ExecuteScalar();
                gridMain.Rows[i].Cells[0].Value = command.ExecuteScalar();
            connection.Close();

        }

        private void RemoveRow()
        {
            string sqlExpression = "DEL_Contractor";

                     
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // параметр для ввода имени
                SqlParameter cidParam = new SqlParameter
                {
                    ParameterName = "@ContractorID",
                    Value = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[0].Value
                };
                // добавляем параметр
                command.Parameters.Add(cidParam);

                var result = command.ExecuteNonQuery();
                connection.Close();
            
        }

        private void UpdateRow()
        {
         
            string sqlExpression = "UPD_Contractor";

                      
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // параметр для ввода имени
                SqlParameter cidParam = new SqlParameter
                {
                    ParameterName = "@ContractorID",
                    Value = Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[0].Value)
                };
                command.Parameters.Add(cidParam);

                SqlParameter tinParam = new SqlParameter
                {
                    ParameterName = "@TIN",
                    Value = contractorAdd.ContrTIN
                };
                // добавляем параметр
                command.Parameters.Add(tinParam);


                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@ContrName",
                    Value = contractorAdd.ContrName
                };
                command.Parameters.Add(nameParam);

                SqlParameter fidParam = new SqlParameter
                {
                    ParameterName = "@CategoryFID",
                    Value = contractorAdd.CategoryFirstID
                };
                command.Parameters.Add(fidParam);

                SqlParameter sidParam = new SqlParameter
                {
                    ParameterName = "@CategorySID",
                    Value = contractorAdd.CategorySecondID
                };
                command.Parameters.Add(sidParam);

                SqlParameter tidParam = new SqlParameter
                {
                    ParameterName = "@CategoryTID",
                    Value = contractorAdd.CategoryThirdID
                };
                command.Parameters.Add(tidParam);

                var result = command.ExecuteNonQuery();
                connection.Close();
            
        }
        
        private void AddRowCon(object sender, EventArgs e)
        {
        int i = gridMain.Rows.Count;

        gridMain.Rows.Add();
        gridMain.Rows[i].Visible = false;
        AddRow(i);
                
        gridMain.Rows[i].Cells[1].Value = contractorAdd.CategoryFirstID;
        gridMain.Rows[i].Cells[2].Value = contractorAdd.CategorySecondID;
        gridMain.Rows[i].Cells[3].Value = contractorAdd.CategoryThirdID;
        gridMain.Rows[i].Cells[4].Value = contractorAdd.ContrTIN;
        gridMain.Rows[i].Cells[5].Value = contractorAdd.ContrName;
        gridMain.Rows[i].Cells[6].Value = contractorAdd.CategoryFirst;
        gridMain.Rows[i].Cells[7].Value = contractorAdd.CategorySecond;
        gridMain.Rows[i].Cells[8].Value = contractorAdd.CategoryThird;

        contractorAdd.ButtonOkClicked -= new EventHandler(AddRowCon);
        contractorAdd.Close();
        gridMain.Rows[i].Visible = true;
        
        contractorAdd = null;
        
         //указываем активную ячейку
         gridMain.CurrentCell = gridMain.Rows[gridMain.Rows.Count-1].Cells[5];
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
            {
                if (!(gridMain.Rows.Count == 0))
                {
                    using (contractorAdd = new ContractorAdd())
                    {
                        contractorAdd.ButtonOkClicked += new EventHandler(EditRowCon);
                        contractorAdd.ContrTIN = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[4].Value.ToString(); 
                        contractorAdd.ContrName = gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[5].Value.ToString(); 
                        LoadCategories();
                        contractorAdd.ActiveItemsCombobox(Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[1].Value.ToString()),
                                                        Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[2].Value.ToString()),
                                                        Convert.ToInt32(gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[3].Value.ToString()));
                    contractorAdd.FormCaption = "Редактировать";
                    contractorAdd.ShowDialog();
                    }
                }
            }

        private void EditRowCon(object sender, EventArgs e)
            {
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[1].Value = contractorAdd.CategoryFirstID;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[2].Value = contractorAdd.CategorySecondID;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[3].Value = contractorAdd.CategoryThirdID;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[4].Value = contractorAdd.ContrTIN;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[5].Value = contractorAdd.ContrName;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[6].Value = contractorAdd.CategoryFirst;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[7].Value = contractorAdd.CategorySecond;
            gridMain.Rows[gridMain.CurrentCell.RowIndex].Cells[8].Value = contractorAdd.CategoryThird;
            //обновление в бд
            UpdateRow();
            contractorAdd.ButtonOkClicked -= new EventHandler(EditRowCon);
                contractorAdd.Close();
                contractorAdd = null;
            }

        private void btnDel_Click(object sender, EventArgs e)
            {
                if (!(gridMain.Rows.Count == 0))
                {
                    DialogResult result = MessageBox.Show("Удалить контрагента?",
                            "Программа", MessageBoxButtons.YesNo);
                    if (!(result == DialogResult.No))
                    {
                    RemoveRow();
                    gridMain.Rows.RemoveAt(gridMain.CurrentCell.RowIndex);
                    }
                }
            }

        private void gridMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                //двойной клик на гриде
                btnEdit_Click(sender, e);
            }
        
        //***********************************************************************************////
        //выделяет все строки удовлетворяющие условию
        private void SearchAllRows()
        {
            for (int i = 0; i < gridMain.RowCount; i++)
            {
                gridMain.Rows[i].Selected = false;
                for (int j = 0; j < gridMain.ColumnCount; j++)
                    if (gridMain.Rows[i].Cells[j].Value != null)
                        if (gridMain.Rows[i].Cells[j].Value.ToString().Contains(txtSearch.Text))
                        {
                            gridMain.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void SearchRow()
        {
            bool bMustBreak=false;
        
            //с текущей строки
            for (int i = gridMain.CurrentCell.RowIndex+1; i < gridMain.RowCount; i++)
            {
                gridMain.Rows[i].Selected = false;
                //только видимые колонки
                for (int j = 4; j < gridMain.ColumnCount; j++)
                    if (gridMain.Rows[i].Cells[j].Value != null)
                        
                
                    if (gridMain.Rows[i].Cells[j].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                
                    {
                            gridMain.Rows[i].Selected = true;
                            //нашли первое совпадение
                            bMustBreak = true;
                            break;
                    }
                //если нашли первое совпадение, заканчиваем поиск
                if (bMustBreak)
                {
                    //указываем активную ячейку
                    gridMain.CurrentCell = gridMain.Rows[i].Cells[5];
                    break;
                } 
            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRow();
        }

        //****************************************//
        /* открываем для класса наследника */
        //******************************************//
        public DataGridView GetGrid
        {
            get {
                return this.gridMain;
            }
            }

    }

    

}
