using System;

namespace VMES.Contragent.Model
{
    public class Sales
    {
        private int intSalesID;                 //ид акта
        private int intSalesPID;                //ид основного акта для корректировочного
        private int intContrID;                 //ид контрагент
        private int intDealID;                  //ид договора
        private int intVAT;                     //НДС
        private string strContrName;            //название контрагента
        private string strDealNumber;           //номер договора
        private DateTime dtDealDate;            //дата договора
        private string strSalesNum;             //номер акта
        private DateTime dtSalesDate;           //дата акта
        private decimal decSum;                 //общая сумма 
        private decimal decBaseSum;             //не оспариваемая сумма
        private decimal decTrialSum;            //оспариваемая сумма
        private string strNumDataParent;        //Справочно: чтобы пользователь видел, какой акт корректируют

        public Sales()
        {
            intSalesID =        -1;
            intSalesPID =       -1;
            intContrID =        -1;
            intDealID =         -1; 
            intVAT =            -1;
            strContrName =      String.Empty;
            strDealNumber =     String.Empty;
            dtDealDate =        DateTime.Today;
            strSalesNum =       String.Empty;
            dtSalesDate=        DateTime.Today;
            decSum=             0; 
            decBaseSum=         0;
            decTrialSum=        0;
            strNumDataParent = String.Empty;
    }

        public int SalesID
        {
            get
            { return intSalesID; }
            set
            {
                intSalesID = value;
            }
        }

        public int SalesPID
        {
            get
            { return intSalesPID; }
            set
            {
                intSalesPID = value;
            }
        }

        public int ContrID
        {
            get
            { return intContrID; }
            set
            {
                intContrID = value;
            }
        }

        public int DealID
        {
            get
            { return intDealID; }
            set
            {
                intDealID = value;
            }
        }

        public int VAT
        {
            get
            { return intVAT; }
            set
            {
                intVAT = value;
            }
        }

        public string ContrName
        {
            get
            { return strContrName; }
            set
            {
                strContrName = value;
            }
        }

        public string DealNumber
        {
            get
            { return strDealNumber; }
            set
            {
                strDealNumber = value;
            }
        }

        public DateTime DealDate
        {
            get
            { return dtDealDate; }
            set
            {
                dtDealDate = value;
            }
        }

        public string SalesNum
        {
            get
            { return strSalesNum; }
            set
            {
                strSalesNum = value;
            }
        }

        public DateTime SalesDate
        {
            get
            { return dtSalesDate; }
            set
            {
                dtSalesDate = value;
            }
        }

        public decimal SalesSum
        {
            get
            { return decSum; }
            set
            {
                decSum = value;
            }
        }

        public decimal SalesBaseSum
        {
            get
            { return decBaseSum; }
            set
            {
                decBaseSum = value;
            }
        }

        public decimal SalesTrialSum
        {
            get
            { return decTrialSum; }
            set
            {
                decTrialSum = value;
            }
        }

        public string NumDataParent
        {
            set
            {
                strNumDataParent = value;
            }
            get
            {
                return strNumDataParent;
            }
        }
    }
}
