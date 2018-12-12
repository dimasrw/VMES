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
    public partial class ContractorAdd : Form
    {
        public event EventHandler ButtonOkClicked = null;
   
        private string strName="";
        private string strTIN = "";
        private int intID = -1;
        
        private int intCategoryFirst = 0;
        private int intCategoryThird = 0;
        private int intCategorySecond = 0;
                
        private string strCategoryFirst = String.Empty;
        private string strCategoryThird = String.Empty;
        private string strCategorySecond = String.Empty;
        

        public string FormCaption { set { this.Text = value; } }

        public string ContrName
        {
            get
            { return strName; }
            set
            {
                strName = value;
                this.txtContrName.Text = strName;
            }
        }
                
        public string ContrTIN
        {
            get
            { return strTIN; }
            set
            {
                strTIN = value;
                this.txtTIN.Text = strTIN;
            }
        }

        public int CategoryFirstID
        {
            get
            { return intCategoryFirst; }
            set
            {
                intCategoryFirst = value;
                this.cmbCat1.SelectedIndex = intCategoryFirst;
            }
        }

        public int CategorySecondID
        {
            get
            { return intCategorySecond; }
            set
            {
                intCategorySecond = value;
                this.cmbCat2.SelectedIndex = intCategorySecond;
            }
        }

        public int CategoryThirdID
        {
            get
            {
                return intCategoryThird;
            }
            set
            {
                intCategoryThird = value;
                this.cmbCat3.SelectedIndex = intCategoryThird;
            }
        }

        public string CategoryFirst
        {
            get
            { return strCategoryFirst; }
         
        }

        public string CategorySecond
        {
            get
            { return strCategorySecond; }

        }

        public string CategoryThird
        {
            get
            { return strCategoryThird; }

        }

        public ContractorAdd()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)

        {
            
            strName = this.txtContrName.Text;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
        intCategoryFirst = this.cmbCat1.SelectedIndex;
        intCategoryThird = this.cmbCat3.SelectedIndex;
        intCategorySecond = this.cmbCat2.SelectedIndex;

        strCategoryFirst = Convert.ToString(this.cmbCat1.SelectedItem);
        strCategoryThird = Convert.ToString(this.cmbCat3.SelectedItem);
        strCategorySecond = Convert.ToString(this.cmbCat2.SelectedItem);

        strTIN = this.txtTIN.Text;
        strName = this.txtContrName.Text;
            ButtonOkClicked.Invoke(sender, e);
        }

        //подгружаем комбики
        public void LoadComboBoxes(int IND, int comboIndex,string comboText)
        {
            //если категория 1, если 2 иначе 3
            if (IND == 0)
            {
                this.cmbCat1.Items.Insert(comboIndex, comboText);
            }
            else if (IND == 1)
            {
                this.cmbCat2.Items.Insert(comboIndex, comboText);
            }
            else
            {
                this.cmbCat3.Items.Insert(comboIndex, comboText);
            }
        }

        public void ActiveItemsCombobox(int selected_1, int selected_2, int selected_3)
        {
            //устанавливает выбранные комбо
            this.cmbCat1.SelectedIndex =  selected_1;
            this.cmbCat2.SelectedIndex = selected_2;
            this.cmbCat3.SelectedIndex = selected_3;
        }

    }
}
