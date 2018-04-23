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
    public partial class Affine : UserControl
    {
        public Affine()
        {
            InitializeComponent();
        }        
        public int gcd(int a, int n)
        {
            if (a % n == 0)
            {
                return n;
            }
            
            return gcd(n, a % n);
        }

        public string ChuanHoa(string ma)
        {
            char[] tg = ma.ToArray();
            int i = 0, dem = 0;
            int n = tg.Length;
            while (i < n)
            {
                if ((int)tg[i] >= 97 && (int)tg[i] <= 122) { tg[i] = (char)((int)tg[i] - 32); }                
                i++;
            }
            string chuoiCH = new string(tg).Substring(0, n - dem);
            return chuoiCH;
        }    

        public string Ecrypt_Affine(string ma, int a, int b)
        {
      //      char[] tg= new char[100];
      //      int n = ma.Length;
            string output = "";
            foreach (char i in ma)
            {
                if(i<'A'||i>'Z') output=output+i;
                 output=output+ (char)(((i - 65) * a + b) % 26 + 65);
            }
            return output;
        }

        public string Decrypt_Affine(string ma, int a, int b)
        {
            char[] tg = ma.ToCharArray();
            int a_ = 0, n = tg.Length, x = 0;
            
            while ((a * a_ - 1) % 26 != 0) a_++;

            for (int i = 0; i < n; i++)
            {
                if (tg[i] < 'A' || tg[i] > 'Z') continue;
                x = a_ * ((int)tg[i] - 65 - b);
                while (x > 26) x -= 26;
                while (x < 0) x += 26;
                tg[i] = (char)(x + 65);
            }
            return new string(tg);
        }

        private void btnMahoa_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_a.Value);
            int ucln = gcd(a, 26);
            if (ucln != 1) MessageBox.Show("Chon lai a");
            txtOutput.Text = Ecrypt_Affine(ChuanHoa(txtInput.Text), (int)txt_a.Value, (int)txt_b.Value);
        }

        private void btnGiaiMa_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_a1.Value);
            int ucln = gcd(a, 26);
            if (ucln != 1) MessageBox.Show("Chon lai a");
            txtOutput1.Text = Decrypt_Affine(ChuanHoa(txtInput1.Text), (int)txt_a1.Value, (int)txt_b1.Value);
        }
    }
}
