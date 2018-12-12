using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMES.Contragent.Conponents
{
    public partial class FinanceTextBox : UserControl
    {
        public FinanceTextBox()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        
    }

    
}
