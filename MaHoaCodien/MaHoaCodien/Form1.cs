using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace MaHoaCodien
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            Start list = new Start();
            panelMain.Controls.Clear();
            ////  list.TopLevel = false;
            list.Dock = DockStyle.Fill;
            panelMain.Controls.Add(list);
            list.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DichChuyen list = new DichChuyen();
            panelMain.Controls.Clear();
        
            list.Dock = DockStyle.Fill;
            panelMain.Controls.Add(list);
            list.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThayThe list = new ThayThe();
            panelMain.Controls.Clear();
            
            list.Dock = DockStyle.Fill;
            panelMain.Controls.Add(list);
            list.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Vigenere list = new Vigenere();
            panelMain.Controls.Clear();

            list.Dock = DockStyle.Fill;
            panelMain.Controls.Add(list);
            list.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hill list = new Hill();
            panelMain.Controls.Clear();

            list.Dock = DockStyle.Fill;
            panelMain.Controls.Add(list);
            list.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HoanVi list = new HoanVi();
            panelMain.Controls.Clear();

            list.Dock = DockStyle.Fill;
            panelMain.Controls.Add(list);
            list.Show();
        }
    }
}
