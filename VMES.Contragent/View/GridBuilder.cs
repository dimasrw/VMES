using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VMES.Contragent.DataModel;


namespace VMES.Contragent.View
{
    class GridBuilder
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        private SqlConnection connection;

        public GridBuilder(DataGridView dgv, int fromID, int gridID)
        {

            ((System.ComponentModel.ISupportInitialize)(dgv)).BeginInit();


            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.Dock = DockStyle.Fill;
            //фон основного окна
            //dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            /*
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dgv.Location = new System.Drawing.Point(-29, 65);
           // dgv.Name = "dgv";
            dgv.ReadOnly = false;
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;


    */
            dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.RowTemplate.Height = 24;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //dgv.Size = new System.Drawing.Size(275, 163);
            dgv.TabIndex = 0;
           // dgv.Theme = MetroFramework.MetroThemeStyle.Light;



            ((System.ComponentModel.ISupportInitialize)(dgv)).EndInit();
            //metroPanel.ResumeLayout(false);

            AddColumsToGrid( dgv,  fromID,  gridID);
        }
        /*
        public void AddColumsToGrid(DataGridView dgv,int columns)
        {


            for (int i = 0; i < columns; i++)
            {

                dgv.Columns.Add("", "");
                dgv.Columns[i].Name = "Column" + i.ToString();
                dgv.Columns[i].HeaderText = "Column" + i.ToString();
                dgv.Columns[i].ReadOnly = true;
            }
        }
*/
        private void AddColumsToGrid(DataGridView dgv, int fromID, int gridID)
        {

            connection = ConnectionSingleton.Connection;
            // название процедуры
            string sqlExpression = "SEL_METAGRID";

            connection.Open();
            
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter midParam = new SqlParameter
            {
                ParameterName = "@MIT",
                Value = fromID
            };
            command.Parameters.Add(midParam);

            SqlParameter groidParam = new SqlParameter
            {
                ParameterName = "@GROID",
                Value = gridID
            };
            command.Parameters.Add(groidParam);


            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                int j = 0;
                while (reader.Read())
                {

                    dgv.Columns.Add("", "");
                    dgv.Columns[j].Name = "Column" + j.ToString();
                    dgv.Columns[j].HeaderText =Convert.ToString( reader.GetValue(3));
                    dgv.Columns[j].Width = Convert.ToInt32(reader.GetValue(4));
                    if (Convert.ToInt32(reader.GetValue(5)) == 0)
                    {
                        dgv.Columns[j].Visible = false;
                    }
                    else {
                        dgv.Columns[j].Visible = true;
                    }
                    
                    dgv.Columns[j].ReadOnly = true;
                    j += 1;
                }
            }
            reader.Close();
            connection.Close();

        }
    }
}
