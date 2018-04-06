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
    public partial class Hill : UserControl
    {
        public Hill()
        {
            
            InitializeComponent();
        }
        float[,] a = new float[9, 9];
        float[,] b = new float[9, 9];
        int index = 0;
        float det;
        int na;
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
        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt11.Visible = true;
            mt12.Visible = true;
            mt22.Visible = true;
            mt21.Visible = true;
            index = 2;
            if (cbb.SelectedIndex == 1)
            {
                mt13.Visible = true;
                mt23.Visible = true;
                mt31.Visible = true;
                mt32.Visible = true;
                mt33.Visible = true;
                index = 3;
            }
            if (cbb.SelectedIndex == 2)
            {
                mt13.Visible = true;
                mt14.Visible = true;
                mt23.Visible = true;
                mt24.Visible = true;
                mt31.Visible = true;
                mt32.Visible = true;
                mt33.Visible = true;
                mt34.Visible = true;
                mt41.Visible = true;
                mt42.Visible = true;
                mt43.Visible = true;
                mt44.Visible = true;
                index = 4;

            }
            if(cbb.SelectedIndex==3)
            {
                mt13.Visible = true;
                mt14.Visible = true;
                mt15.Visible = true;
                mt23.Visible = true;
                mt24.Visible = true;
                mt25.Visible = true;
                mt31.Visible = true;
                mt32.Visible = true;
                mt33.Visible = true;
                mt34.Visible = true;
                mt35.Visible = true;
                mt41.Visible = true;
                mt42.Visible = true;
                mt43.Visible = true;
                mt44.Visible = true;
                mt45.Visible = true;
                mt51.Visible = true;
                mt52.Visible = true;
                mt53.Visible = true;
                mt54.Visible = true;
                mt55.Visible = true;
                index = 5;
            }
            if (cbb.SelectedIndex == 4)
            {
                mt13.Visible = true;
                mt14.Visible = true;
                mt15.Visible = true;
                mt16.Visible = true;
                mt23.Visible = true;
                mt24.Visible = true;
                mt25.Visible = true;
                mt26.Visible = true;
                mt31.Visible = true;
                mt32.Visible = true;
                mt33.Visible = true;
                mt34.Visible = true;
                mt35.Visible = true;
                mt36.Visible = true;
                mt41.Visible = true;
                mt42.Visible = true;
                mt43.Visible = true;
                mt44.Visible = true;
                mt45.Visible = true;
                mt46.Visible = true;
                mt51.Visible = true;
                mt52.Visible = true;
                mt53.Visible = true;
                mt54.Visible = true;
                mt55.Visible = true;
                mt56.Visible = true;
                mt61.Visible = true;
                mt62.Visible = true;
                mt63.Visible = true;
                mt64.Visible = true;
                mt65.Visible = true;
                mt66.Visible = true;
                index = 6;
            }

            if (cbb.SelectedIndex == 5)
            {
                mt13.Visible = true;
                mt14.Visible = true;
                mt15.Visible = true;
                mt16.Visible = true;
                mt17.Visible = true;
                mt23.Visible = true;
                mt24.Visible = true;
                mt25.Visible = true;
                mt26.Visible = true;
                mt27.Visible = true;
                mt31.Visible = true;
                mt32.Visible = true;
                mt33.Visible = true;
                mt34.Visible = true;
                mt35.Visible = true;
                mt36.Visible = true;
                mt37.Visible = true;
                mt41.Visible = true;
                mt42.Visible = true;
                mt43.Visible = true;
                mt44.Visible = true;
                mt45.Visible = true;
                mt46.Visible = true;
                mt47.Visible = true;
                mt51.Visible = true;
                mt52.Visible = true;
                mt53.Visible = true;
                mt54.Visible = true;
                mt55.Visible = true;
                mt56.Visible = true;
                mt57.Visible = true;
                mt61.Visible = true;
                mt62.Visible = true;
                mt63.Visible = true;
                mt64.Visible = true;
                mt65.Visible = true;
                mt66.Visible = true;
                mt67.Visible = true;
                mt71.Visible = true;
                mt72.Visible = true;
                mt73.Visible = true;
                mt74.Visible = true;
                mt75.Visible = true;
                mt76.Visible = true;
                mt77.Visible = true;
                index = 7;
            }

            if(cbb.SelectedIndex==6)
            {
                mt13.Visible = true;
                mt14.Visible = true;
                mt15.Visible = true;
                mt16.Visible = true;
                mt17.Visible = true;
                mt18.Visible = true;
                mt23.Visible = true;
                mt24.Visible = true;
                mt25.Visible = true;
                mt26.Visible = true;
                mt27.Visible = true;
                mt28.Visible = true;
                mt31.Visible = true;
                mt32.Visible = true;
                mt33.Visible = true;
                mt34.Visible = true;
                mt35.Visible = true;
                mt36.Visible = true;
                mt37.Visible = true;
                mt38.Visible = true;
                mt41.Visible = true;
                mt42.Visible = true;
                mt43.Visible = true;
                mt44.Visible = true;
                mt45.Visible = true;
                mt46.Visible = true;
                mt47.Visible = true;
                mt48.Visible = true;
                mt51.Visible = true;
                mt52.Visible = true;
                mt53.Visible = true;
                mt54.Visible = true;
                mt55.Visible = true;
                mt56.Visible = true;
                mt57.Visible = true;
                mt58.Visible = true;
                mt61.Visible = true;
                mt62.Visible = true;
                mt63.Visible = true;
                mt64.Visible = true;
                mt65.Visible = true;
                mt66.Visible = true;
                mt67.Visible = true;
                mt68.Visible = true;
                mt71.Visible = true;
                mt72.Visible = true;
                mt73.Visible = true;
                mt74.Visible = true;
                mt75.Visible = true;
                mt76.Visible = true;
                mt77.Visible = true;
                mt78.Visible = true;

                mt81.Visible = true;
                mt82.Visible = true;
                mt83.Visible = true;
                mt84.Visible = true;
                mt85.Visible = true;
                mt86.Visible = true;
                mt87.Visible = true;
                mt88.Visible = true;
                index =8;
            }
           // while (true)
           // { 
                taomt(index);
                matran(index);
               // if ( det!= 0) break;
            //}
            mt11.Text = Convert.ToString(a[0, 0]);
            mt12.Text = Convert.ToString(a[0, 1]);
            mt13.Text = Convert.ToString(a[0, 2]);
            mt14.Text = Convert.ToString(a[0, 3]);
            mt15.Text = Convert.ToString(a[0, 4]);
            mt16.Text = Convert.ToString(a[0, 5]);
            mt17.Text = Convert.ToString(a[0, 6]);
            mt18.Text = Convert.ToString(a[0, 7]);
            mt21.Text = Convert.ToString(a[1, 0]);
            mt22.Text = Convert.ToString(a[1, 1]);
            mt23.Text = Convert.ToString(a[1, 2]);
            mt24.Text = Convert.ToString(a[1, 3]);
            mt25.Text = Convert.ToString(a[1, 4]);
            mt26.Text = Convert.ToString(a[1, 5]);
            mt27.Text = Convert.ToString(a[1, 6]);
            mt28.Text = Convert.ToString(a[1, 7]);
            mt31.Text = Convert.ToString(a[2, 0]);
            mt32.Text = Convert.ToString(a[2, 1]);
            mt33.Text = Convert.ToString(a[2, 2]);
            mt34.Text = Convert.ToString(a[2, 3]);
            mt35.Text = Convert.ToString(a[2, 4]);
            mt36.Text = Convert.ToString(a[2, 5]);
            mt37.Text = Convert.ToString(a[2, 6]);
            mt38.Text = Convert.ToString(a[2, 7]);
            mt41.Text = Convert.ToString(a[3, 0]);
            mt42.Text = Convert.ToString(a[3, 1]);
            mt43.Text = Convert.ToString(a[3, 2]);
            mt44.Text = Convert.ToString(a[3, 3]);
            mt45.Text = Convert.ToString(a[3, 4]);
            mt46.Text = Convert.ToString(a[3, 5]);
            mt47.Text = Convert.ToString(a[3, 6]);
            mt48.Text = Convert.ToString(a[3, 7]);
            mt51.Text = Convert.ToString(a[4, 0]);
            mt52.Text = Convert.ToString(a[4, 1]);
            mt53.Text = Convert.ToString(a[4, 2]);
            mt54.Text = Convert.ToString(a[4, 3]);
            mt55.Text = Convert.ToString(a[4, 4]);
            mt56.Text = Convert.ToString(a[4, 5]);
            mt57.Text = Convert.ToString(a[4, 6]);
            mt58.Text = Convert.ToString(a[4, 7]);
            mt61.Text = Convert.ToString(a[5, 0]);
            mt62.Text = Convert.ToString(a[5, 1]);
            mt63.Text = Convert.ToString(a[5, 2]);
            mt64.Text = Convert.ToString(a[5, 3]);
            mt65.Text = Convert.ToString(a[5, 4]);
            mt66.Text = Convert.ToString(a[5, 5]);
            mt67.Text = Convert.ToString(a[5, 6]);
            mt68.Text = Convert.ToString(a[5, 7]);
            mt71.Text = Convert.ToString(a[6, 0]);
            mt72.Text = Convert.ToString(a[6, 1]);
            mt73.Text = Convert.ToString(a[6, 2]);
            mt74.Text = Convert.ToString(a[6, 3]);
            mt75.Text = Convert.ToString(a[6, 4]);
            mt76.Text = Convert.ToString(a[6, 5]);
            mt77.Text = Convert.ToString(a[6, 6]);
            mt78.Text = Convert.ToString(a[6, 7]);
        
            mt81.Text = Convert.ToString(a[7, 0]);
            mt82.Text = Convert.ToString(a[7, 1]);
            mt83.Text = Convert.ToString(a[7, 2]);
            mt84.Text = Convert.ToString(a[7, 3]);
            mt85.Text = Convert.ToString(a[7, 4]);
            mt86.Text = Convert.ToString(a[7, 5]);
            mt87.Text = Convert.ToString(a[7, 6]);
            mt88.Text = Convert.ToString(a[7, 7]);


        }        
        public void taomt(int n)
        {           
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(9 - 1) + 1;
                    if (a[i, j] < 0) a[i, j] = -a[i, j];
                }
            }           
        }
        public string EncrytHill(string ma, int size)
        {
            while (ma.Length % size != 0) ma += 'A';
            float[] x = new float[size];
            int n = ma.Length;
            char[] temp = new char[ma.Length];
            for (int i = 0; i < n; i += size)
            {
                for (int l = 0; l < size; l++)
                    for (int k = 0; k < size; k++)
                        x[l] += ((int)ma[i + k] - 65) * a[k, l];
                for (int j = 0; j < size; j++)
                {
                    temp[i + j] = (char)(x[j] % 26 + 65);
                }
                for (int l = 0; l < size; l++)
                    x[l] = 0;
            }
            return new string(temp);
        }

        public string G_Hill(string ma, int size)
        {
            while (ma.Length % size != 0) ma += 'A';
            float[] x = new float[size];
            int n = ma.Length;
            char[] temp = new char[ma.Length];
            for (int i = 0; i < n; i += size)
            {
                for (int l = 0; l < size; l++)
                    for (int k = 0; k < size; k++)
                        x[l] += ((int)ma[i + k] - 65) * b[k, l];
                for (int j = 0; j < size; j++)
                {
                    temp[i + j] = (char)(x[j] % 26 + 65);
                }
                for (int l = 0; l < size; l++)
                    x[l] = 0;
            }
            return new string(temp);
        }



        void doicho(int i1, int i2)
        {
            int j;
            float tg;
            for (j = 1; j <= na; j++)
            {
                tg = a[i1,j];
                a[i1,j] = a[i2,j];
                a[i2,j] = tg;
            }
        }
        // ham dung de nhan hang i1 voi x roi cong vao hang i2 trong ma tran.
        void cong(int i1, int i2, float x)
        {
            int j;
            for (j = 1; j <= na; j++) a[i2,j] = a[i2,j] + a[i1,j] * x;
        }
        // ham dung giai phuong trinh.
        void matran(int n)
        {
            int i, j, k;
            float x;
         //   int na = 2 * n;
            for (j = 1; j <= n; j++)
            {
                for (i = n; i >= j; i--)
                {
                    if (a[i,j] == 0) continue;
                    if ((i > j) && (a[i,j] != 0))
                    {
                        k = i - 1;
                        while ((k >= j) && (a[k,j] == 0)) k--;
                        if (k < j) doicho(i, j);
                        if ((k >= j) && (k >= 1))
                        {
                            x = -a[i,j] / a[k,j];
                            cong(k, i, x);
                        }
                    }
                }
            }
            for (j = n; j >= 1; j--)
            {
                for (i = 1; i <= j; i++)
                {
                    if (a[i,j] == 0) continue;
                    if ((i < j) && (a[i,j] != 0))
                    {
                        k = i + 1;
                        while ((k <= j) && (a[k,j] == 0)) k++;
                        if ((k <= j) && (k <= na))
                        {
                            x = -a[i,j] / a[k,j];
                            cong(k, i, x);
                        }
                    }
                }
            }
            // tinh dinh thuc
            det = 1;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                    if (i == j) det = det * a[i,j];
         
            // tinh ma tran nghich dao.
            if (det != 0)
            {
                for (i = 1; i <= n; i++)
                    for (j = n + 1; j <= na; j++)
                    {
                        a[i,j] = a[i,j] / a[i,i];
                    }
                for (i = 1; i <= n; i++)
                    for (j = n + 1; j <= na; j++)
                    {
                        b[i,j - n] = a[i,j];
                    }               
            }
           // else Console.Write("\n khong co ma tran nghich dao");
        }

        //void PhanRaLU(float[,] A, float [,] L, float[,]U, int n) {
        //       for (int k = 0; k < n; k++)
        //       {
        //           U[k,k] = A[k,k];
        //           L[k,k] = 1;
        //           for (int i = k + 1; i < n; i++)
        //           {
        //               L[i,k] = A[i,k] / U[k,k];
        //               U[k,i] = A[k,i];
        //               U[i,k] = 0;
        //               L[k,i] = 0;
        //           }
        //           for (int i = k + 1; i < n; i++)
        //               for (int j = k + 1; j < n; j++)
        //                   A[i,j] = A[i,j] - L[i,k] * U[k,j];
        //       }
        //   }

        public double ktr(float[,] matrix, int n)
        {
            
            float[,] U=new float[index,index];
            float[,] L = new float[index, index];
        //    PhanRaLU(a, L, U, index);
            double temp = 1;
            for (int i = 0; i < n; i++)
                temp *= a[i, i];
            return temp;

            }
        private void btnMahoa_Click(object sender, EventArgs e)
        {
            txtOutput.Text= EncrytHill(ChuanHoa( txtInput.Text), index);
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            txtOutput.Text = G_Hill(ChuanHoa(txtInput.Text), index);
        }
    }
}