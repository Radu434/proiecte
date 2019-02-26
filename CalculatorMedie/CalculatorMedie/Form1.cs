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
        int note = 0;
        double suma = 0;
        int teza = 0;
        int nr = 0;

        public Form1()
        {
            InitializeComponent();
            txtTeza.Enabled = false;
        }




        private void button1_Click(object sender, EventArgs e)
        {

            txtInput.MaxLength = 2;
            if (txtInput.Text != "")
            {
                nr++;
                lstNote.Items.Add(txtInput.Text);
                
            }
            if (cbTeza.Checked == true && txtTeza.Text != "")
            {
                lstNote.Items.Add(txtTeza.Text);
                teza += int.Parse(txtTeza.Text);

                txtTeza.Enabled = false;
                cbTeza.Enabled = false;   
            }
            
            txtInput.Clear();
            txtTeza.Clear();
        }
        
        private void cbTeza_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTeza.Checked == false)
            {
                txtTeza.Clear();
                txtTeza.Enabled = false;
            }
            if (cbTeza.Checked == true)
            {
                txtTeza.Enabled = true;
            }
        }

        private void txtTeza_TextChanged(object sender, EventArgs e)
        {
            txtTeza.MaxLength = 2;
            string val = txtTeza.Text;
            if (int.TryParse(val, out teza))
            {
                if (teza <= 10)
                {
                    btnIntroducere.Enabled = true;

                }
                else
                {
                    btnIntroducere.Enabled = false;
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if(lstNote.SelectedIndex!=-1)
            {
                lstNote.Items.RemoveAt(lstNote.SelectedIndex);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
             note = 0;
             suma=0;
            teza = 0;
             nr = 0;
            txtInput.Clear();
            txtTeza.Clear();
            lstNote.Items.Clear();
            lstNote.SelectedIndex=-1;
            lblMedie.Text = "";
            txtTeza.Enabled = false;
            cbTeza.Enabled = true;
            cbTeza.Checked = false;
            btnCalculeaza.Enabled = true;
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            suma = 0;
            if(cbTeza.Checked==false)
            {
                for(int i=0; i<lstNote.Items.Count ; i++)
                {
                    suma += Convert.ToInt32(lstNote.Items[i]);
                }
                lblMedie.Text = (suma / nr).ToString();
            }
            else if(cbTeza.Checked==true&&teza!=0)
            {
                for (int i = 0; i < lstNote.Items.Count; i++)
                {
                    suma += Convert.ToInt32(lstNote.Items[i]);
                }
                suma = suma / nr;
                suma = ((suma * 3) + teza) / 4;
                lblMedie.Text = suma.ToString();
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
            txtInput.MaxLength = 2;
            string val = txtInput.Text;
            if (int.TryParse(val, out note))
            {
                if (note <= 10)
                {
                    btnIntroducere.Enabled = true;

                }
                else
                {
                    btnIntroducere.Enabled = false;
                }
            }
        }
    }
}
