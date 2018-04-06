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
    public partial class DichChuyen : UserControl
    {
        public DichChuyen()
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
        public string Dich_Chuyen(string ma, int k)
        {
            string kq;
            char[] temp = ma.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
                temp[i] = (char)(((int)temp[i] - 65 + k) % 26 + 65);
            kq = new string(temp);
            return kq;
        }


        public int thamma(string ma)
        {
            
            int[] count = new int[26];
            for (int i = 0; i < 26; i++) count[i] = 0;
            for ( int i = 0; i <26; i++)
            {                
                count[ma[i]-'A']++;                
            }
            int max =65 ;        
            char[] thongke = { 'e', 't', 'a', 'o', 'i', 'n', 's', 'h', 'r', 'd', 'l', 'c', 'u', 'm', 'w', 'f', 'g', 'y', 'p', 'b', 'v', 'k', 'j', 'x', 'q', 'z' };
            for(int i = 65; i < 'Z'; i++)
            {
                if (count[i - 'A'] >= count[max-'A'])
                {
                    max =i;                  
                }
            }


            int key = (max - 'E' + 26) % 26;
            return key;
            
        }
        //public static string decrypt(string cipherText)
        //{
        //    cipherText = cipherText.ToUpper();
        //    double[] frequence = new double[] { 0.082, 0.015, 0.028, 0.043, 0.127, 0.022, 0.20, 0.061, 0.070, 0.002, 0.008, 0.040, 0.024, 0.067, 0.075, 0.019, 0.001, 0.060, 0.063, 0.091, 0.028, 0.010, 0.023, 0.001, 0.020, 0.001 };

        //    int[] cnt = new int[26];
        //    for (int i = 0; i < 26; i++) cnt[i] = 0;

        //    for (int i = 0; i < 26; i++)
        //    {
        //        if (cipherText[i] < 'A' || cipherText[i] > 'Z')
        //            continue;
        //        int k = cipherText[i] - 'A';
        //        cnt[k]++;
        //    }

        //    int ma = 65;
        //    for (int i = 65; i <= 'Z'; i++)
        //        if (cnt[i - 'A'] > cnt[ma - 'A']) ma = i;

        //    int key = (ma - 'E' + 26) % 26;

        //    return decrypt(cipherText, key);
        //}
      
        public string G_DichChuyen(string ma, int k)
        {
            string kq;
            int x;
            char[] temp = ma.ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                x = ((int)temp[i] - 65 - k) % 26;
                if (x < 0) x = x + 26;
                x = x + 65;
                temp[i] = (char)(x);
            }
            kq = new string(temp);
            return kq;
        }
        private void btnMahoa_Click(object sender, EventArgs e)
        {
           string kq= Dich_Chuyen(ChuanHoa(txtInput.Text), (int)txtKey.Value);
            txtOutput.Text = kq;
        }
        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            string kq = G_DichChuyen(ChuanHoa( txtInput.Text), (int)txtKey.Value);
            txtOutput.Text = kq;
        }


        private void btnThamma_Click(object sender, EventArgs e)
        {
           txtOutput.Text= G_DichChuyen(ChuanHoa( txtInput.Text), thamma(ChuanHoa( txtInput.Text)));
        }
    }
}
