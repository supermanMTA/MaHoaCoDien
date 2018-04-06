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
    public partial class Vigenere : UserControl
    {
        public Vigenere()
        {
            InitializeComponent();
        }
        public string ChuanHoa(string ma)
        {
            char[] temp = ma.ToArray();
            int i = 0, dem = 0;
            int n = temp.Length;
            while (i < n)
            {
                if ((int)temp[i] >= 97 && (int)temp[i] <= 122) { temp[i] = (char)((int)temp[i] - 32); }
                if ((int)temp[i] == 32)
                {
                    for (int j = i; j < n - 1; j++) temp[j] = temp[j + 1];
                    dem++;
                    continue;
                }
                i++;
            }
            string kq = new string(temp).Substring(0, n - dem);
            return kq;
        }
        public string vigenere(string ma, string khoa)
        {
            char[] temp = ma.ToCharArray();
            int n = temp.Length, m = khoa.Length;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                temp[i] = (char)(((int)temp[i] - 65 + (int)khoa[j] - 65) % 26 + 65);
                j++;
                if (j == m) j = 0;
            }
            return new string(temp);
        }
        public string G_Vigenere(string ma, string khoa)
        {
            char[] temp = ma.ToCharArray();
            int n = temp.Length, m = khoa.Length, x = 0, j = 0;
            for (int i = 0; i < n; i++)
            {
                x = (int)temp[i];
                while (x - (int)khoa[j] < 0) x += 26;
                temp[i] = (char)(x - (int)khoa[j] + 65);
                j++;
                if (j == m) j = 0;
            }
            return new string(temp);
        }

        private void btnMahoa_Click(object sender, EventArgs e)
        {
            txtOutput.Text = vigenere(ChuanHoa(txtInput.Text), ChuanHoa(txtKey.Text));
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            txtOutput.Text = G_Vigenere(ChuanHoa(txtInput.Text), ChuanHoa(txtKey.Text));
        }
    }
}
