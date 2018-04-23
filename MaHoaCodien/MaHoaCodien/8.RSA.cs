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
    public partial class RSA : UserControl
    {
        public RSA()
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

        private bool kiemTraNguyenTo(int i)
        {
            bool kiemtra = true;
            for (int j = 2; j < i; j++)
                if (i % j == 0)
                {
                    kiemtra = false;
                    break;
                }
            return kiemtra;
        }
        int d = 0;
        int E;
        int n;
        private bool nguyenToCungNhau(int a, int b)
        {
            bool kiemtra = true;
            for (int i = 2; i <= a; i++)
                if (a % i == 0 && b % i == 0)
                    kiemtra = false;
            return kiemtra;
        }
        private void taoKhoa(int p, int q)
        {
            int phi_n;
            n = p * q;
            phi_n = (p - 1) * (q - 1);
            do
            {
                Random rd = new Random();
                E = rd.Next(2, phi_n);
            }
            while (!nguyenToCungNhau(E, phi_n));
            int i = 2;
            while (((1 + i * phi_n) % E) != 0 || d <= 0)
            {
                i++;
                d = (1 + i * phi_n) / E;
            }

        }

        private string Encrypt(string ma,int e,int n)
        {
            string output = "";
            foreach(char p in ma)
            {
                int a;

                output += (char)((Math.Pow((p - 65), e) % n + 65));
            }
            return output;
        }

        private void btnMahoa_Click(object sender, EventArgs e)
        {
            taoKhoa((int)txt_a.Value, (int)txt_b.Value);
           txtOutput.Text= Encrypt(ChuanHoa(txtInput.Text), E, n);
        }
    }
}
