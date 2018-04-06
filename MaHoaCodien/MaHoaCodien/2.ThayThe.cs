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
    public partial class ThayThe : UserControl
    {
        public ThayThe()
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
        static private int[] p = new int[26];
        public string Thay_The(string ma)
        {
            char[] temp = ma.ToCharArray();
            int n = temp.Length;
            for (int i = 0; i < n; i++)
            {
                temp[i] = (char)(p[(int)temp[i] - 65] + 65);
            }
            string kq = new string(temp);
            return kq;
        }
        public string G_ThayThe(string ma)
        {
            char[] temp = ma.ToCharArray();
            int n = temp.Length;
            int i = 0;
            while (i < n)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (temp[i] == (char)(p[j] + 65))
                    {
                        temp[i] = (char)(j + 65);
                        i++;
                        break;
                    }
                }
            }
            string kq = new string(temp);
            return kq;
        }
        public void taomaTT()
        {
            Random ran = new Random();
            bool[] ktra = new bool[26];
            for (int j = 0; j < 26; j++) ktra[j] = true;
            int i = 0;
            while (i < 26)
            {
                p[i] = ran.Next(0, 26);
                if (ktra[p[i]] == false) continue;
                ktra[p[i]] = false;
                Console.WriteLine(i + "  " + p[i]);
                i++;
            }

        }
      
        private void btnTaokhoa_Click(object sender, EventArgs e)
        {
            this.taomaTT();
            char[] temp = new char[26];
            for (int i = 0; i < 26; i++)
                temp[i] = (char)(p[i] + 65);
            txtRandom.Text = new string(temp);
        }

        private void btnMahoa_Click(object sender, EventArgs e)
        {
           string kq= Thay_The(ChuanHoa( txtInput.Text));
            txtOutput.Text = kq;
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            string kq=G_ThayThe(ChuanHoa( txtInput.Text));
            txtOutput.Text = kq;
        }
    }
}
