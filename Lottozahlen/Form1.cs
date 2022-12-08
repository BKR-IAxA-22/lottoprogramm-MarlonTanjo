using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottozahlen
{
    public partial class Form1 : Form
    {
        //Hier werden Arrays angelegt, welche für die Lottozahlen und die Tips stehen.
        int[] genLottoNumbers = new int[6];
        int[] lottoTip = new int[6];
        //Hier wird ein Random angelegt, damit eine Random Zahl ausgelost wird.
        Random generator = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void textYourTip_Click(object sender, EventArgs e)
        {

        }

        private void genNumbers_Click(object sender, EventArgs e)
        {
            //Hier werden 6 Zahlen generiert.
            for (int i = 0; i < 6; i++)
            {
                int x = generator.Next(1,49);
                //Wenn es die Zahl schon gibt, so wird diese nicht gespeichert und das Random wiederholt.
                if (genLottoNumbers.Contains(x))
                {
                    i--;
                }
                else
                {
                    //Hier werden die Zahlen gespeichert
                    genLottoNumbers[i] = x;
                }
            }
            //Hier werden die Zahlen ausgegeben.
            lottoNumber1.Text = Convert.ToString(genLottoNumbers[0]);
            lottoNumber2.Text = Convert.ToString(genLottoNumbers[1]);
            lottoNumber3.Text = Convert.ToString(genLottoNumbers[2]);
            lottoNumber4.Text = Convert.ToString(genLottoNumbers[3]);
            lottoNumber5.Text = Convert.ToString(genLottoNumbers[4]);
            lottoNumber6.Text = Convert.ToString(genLottoNumbers[5]);
            //Hier werden die Eingaben überprüft.
            lottoTip[0] = Convert.ToInt32(tip1.Text);
            lottoTip[1] = Convert.ToInt32(tip2.Text);
            lottoTip[2] = Convert.ToInt32(tip3.Text);
            lottoTip[3] = Convert.ToInt32(tip4.Text);
            lottoTip[4] = Convert.ToInt32(tip5.Text);
            lottoTip[5] = Convert.ToInt32(tip6.Text);
        }

        private void tip1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tip2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tip3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tip4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tip5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tip6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lottoNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lottoNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lottoNumber3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lottoNumber4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lottoNumber5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lottoNumber6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
