using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVIDAD
{
    public partial class frmACTIVIDAD : Form
    {
        public frmACTIVIDAD()
        {
            InitializeComponent();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);

            int[] res = binario(numero);
            // Console.WriteLine("INICIO");
            for (int i = res.Length - 1; i > 0; i--)
            {
                if (res[0] == 1)
                {
                    this.casilla1.Checked = true;
                }
                else
                {
                    this.casilla1.Checked = false;
                }
                if (res[1] == 1)
                {
                    this.casilla2.Checked = true;
                }
                else
                {
                    this.casilla2.Checked = false;
                }
                if (res[2] == 1)
                {
                    this.casilla3.Checked = true;
                }
                else
                {
                    this.casilla3.Checked = false;
                }
                if (res[3] == 1)
                {
                    this.casilla4.Checked = true;
                }
                else
                {
                    this.casilla4.Checked = false;
                }
                if (res[4] == 1)
                {
                    this.casilla5.Checked = true;
                }
                else
                {
                    this.casilla5.Checked = false;
                }
                if (res[5] == 1)
                {
                    this.casilla6.Checked = true;
                }
                else
                {
                    this.casilla6.Checked = false;
                }
                if (res[6] == 1)
                {
                    this.casilla7.Checked = true;
                }
                else
                {
                    this.casilla7.Checked = false;
                }
                if (res[7] == 1)
                {
                    this.casilla8.Checked = true;
                }
                else
                {
                    this.casilla8.Checked = false;
                }
                Console.WriteLine("{0}", res[i]);
            }


        }
        // Console.WriteLine("FIN");
        // this.checkBox1.Checked = true;
        private int[] binario(int num)
        {
            int[] bin = { 0, 0, 0, 0, 0, 0, 0, 0 };
            //int[] bin =new int [8];
            int i = 0;
            int resto = 0;
            while (num > 0)
            {
                resto = num % 2;
                bin[i++] = resto;
                num = num / 2;
                //Console.WriteLine("{0}", resto);
            }

            return bin;
        }
    }
}
