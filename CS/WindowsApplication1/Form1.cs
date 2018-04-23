using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
                private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < 30; i++)
            {
                tbl.Columns.Add(String.Format("Col{0}", i));
            }
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }


        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
            MyMenuManager myMenuManager = new MyMenuManager();
            filterControl1.MenuManager = myMenuManager;
            gridControl1.MenuManager = myMenuManager;
        }
    }
}