using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMES.Contragent.Model
{
    public class Payment
    {
        /*
         * Класс служит для отражении информации указанной в платежном документе. 
         * Документ может быть как платежным поручением, так же приходным кассовым ордером
         * или документом отражающим закрытие авансовых платежей.
         */

        private int intContractorID;    //ид контрагента
        private int intDealID;          //ид договора
        private int intSalesID;         //ид документа обязательтва
        private int intPaymentID;       //ид платежа
        private int intChargeType;      //тип документа обязательства
        private int intPaymentType;     //тип документа платежа
        private string strContrName;    //наименование контрагента
        private string strDealName;     //наименование договора
        private string strPaimentOID;   //номер документа
        private DateTime dtPaymentDate;   //дата документа
        private decimal decPaymentSum;     //сумма платежа

        public Payment()
        {
            intContractorID=-1;
            intDealID=-1;
            intSalesID=-1;
            intPaymentID = -1;
            intChargeType= 0;
            intPaymentType = 0;
            strContrName = String.Empty;
            strDealName = String.Empty;
            strPaimentOID = String.Empty;
            dtPaymentDate=DateTime.Today;
            decPaymentSum=0;
        }

        public int ContractorID
        {
            get { return intContractorID; }
            set { intContractorID = value; }
        }

        public int DealID
        {
            get { return intDealID; }
            set { intDealID = value; }
        }

        public int SalesID
        {
            get { return intSalesID; }
            set { intSalesID = value; }
        }


        public int PaymentID
        {
            get { return intPaymentID; }
            set { intPaymentID = value; }
        }

        public int ChargeType
        {
            get { return intChargeType; }
            set { intChargeType = value; }
        }

        public int PaymentType
        {
            get { return intPaymentType; }
            set { intPaymentType = value; }
        }

        public string ContrName
        {
            get { return strContrName; }
            set { strContrName = value; }
        }

        public string DealName
        {
            get { return strDealName; }
            set { strDealName = value; }
        }

        public string PaymentOID
        {
            get { return strPaimentOID;}
            set { strPaimentOID = value; }
        }


        public DateTime PaymentDate
        {
            get { return dtPaymentDate; }
            set { dtPaymentDate = value; }
        }

        public decimal PaymentSum
        {
            get { return decPaymentSum;}
            set { decPaymentSum = value; }
        }
    }
}
