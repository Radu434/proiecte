using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorMedie
{
    public partial class Form1 : Form
    {
        public Decimal note=0;
        public Decimal nrNote=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text) is Decimal && Convert.ToDecimal(txtInput.Text) <= 10)
            {

                note += Convert.ToDecimal(txtInput.Text);
                nrNote = nrNote + 1;
                
            }
            else
            {
                txtInput.Text ="introdu nota";
            }
            
        }

        private void rtxtOutput_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
