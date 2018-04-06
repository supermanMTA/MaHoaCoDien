using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaCodien
{
    public partial class HoanVi : UserControl
    {
        public HoanVi()
        {
            InitializeComponent();
        }

        public string hoanvi(string ma, string khoa)
        {
            int n = khoa.Length;
            while (ma.Length % n != 0) ma = ma + 'A';
            int m = ma.Length;
            int[] hv = new int[n];
            char[] temp = new char[m];
            for (int i = 0; i < n; i++)
            {
                hv[i] = (int)khoa[i] - 48;
            }
            int j = 0, x = 0;
            for (int i = 0; i < m; i++)
            {
                temp[i] = ma[hv[j] - 1 + x];
                j++;
                if (j == n) { j = 0; x += n; }
            }
            return new string(temp);
        }
        public string G_HoanVi(string ma, string khoa)
        {
            int n = khoa.Length;
            int m = ma.Length;
            int[] hv = new int[n];
            char[] temp = new char[m];
            for (int i = 0; i < n; i++)
            {
                hv[i] = (int)khoa[i] - 48;
            }
            int[] _hv = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l < n; l++)
                {
                    if (hv[l] == i + 1) { _hv[i] = l + 1; break; }
                }
            }
            int j = 0; int x = 0;
            for (int i = 0; i < m; i++)
            {
                temp[i] = ma[_hv[j] - 1 + x];
                j++;
                if (j == n) { j = 0; x += n; }
            }
            return new string(temp);
        }
        public string sinhhv(int k)
        {
            int[] hv = new int[k];
            bool[] ktra = new bool[k + 1];
            Random ran = new Random();
            int j = 0;
            for (int i = 0; i < k + 1; i++) ktra[i] = true;
            while (j < k)
            {
                hv[j] = ran.Next(1, k + 1);
                if (ktra[hv[j]] == true)
                {
                    ktra[hv[j]] = false;
                    Console.WriteLine(j + " " + hv[j]);
                    j++;
                }
            }
            char[] temp = new char[k];
            for (int i = 0; i < k; i++)
                temp[i] = (char)(hv[i] + 48);
            return new string(temp);

        }
        private void btnMahoa_Click(object sender, EventArgs e)
        {
           txtOutput.Text= hoanvi(txtInput.Text, txtKey.Text);
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
           txtOutput.Text= G_HoanVi(txtInput.Text, txtKey.Text);
        }

        private void btnTaokhoa_Click(object sender, EventArgs e)
        {
            txtKey.Text = sinhhv((int)txtNumber.Value);
            btnTaokhoa.Enabled = false;

        }
    }
}
