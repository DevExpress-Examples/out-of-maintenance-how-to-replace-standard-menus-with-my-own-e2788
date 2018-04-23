using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;

namespace WindowsApplication1
{
    public partial class MyPopupForm : DevExpress.XtraEditors.XtraForm
    {
        AppearanceObject _appObject = new AppearanceObject();
        public MyPopupForm(DXPopupMenu menu )
        {
            InitializeComponent();
            PupulateListBoxControl(menu);
            imageListBoxControl1.Click += new EventHandler(listBoxControl1_Click);
            _appObject.Font = new Font(AppearanceObject.DefaultFont.FontFamily, 8);
        }

        void listBoxControl1_Click(object sender, EventArgs e)
        {
            ImageListBoxItem item = imageListBoxControl1.SelectedItem as ImageListBoxItem;
            (item.Value as DXMenuItemWrapper).GenerateClickEvent();
            Close();
        }

        private int GetImageIndex(DXMenuItem item)
        {
            return item.Image == null? - 1 :imageList1.Images.Add(item.Image, Color.Transparent);
        }
        public void PupulateListBoxControl(DXPopupMenu menu)
        {
            foreach (DXMenuItem item in menu.Items)
            {
                imageListBoxControl1.Items.Add(new DXMenuItemWrapper(item), GetImageIndex(item));
            }
        }

        private void MyPopupForm_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        int maxHeight = 200;
        public Size BestSize
        {
            get { return new Size(150, Math.Min(maxHeight, (imageListBoxControl1.ItemCount + 1) * 20)); }
        }

        private void imageListBoxControl1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle bounds = imageListBoxControl1.ClientRectangle;
            bounds.Y = bounds.Height - 10;
            bounds.Height = 10;
            e.Graphics.DrawLine(Pens.Red, bounds.Location, new Point(bounds.Width, bounds.Y));
            _appObject.ForeColor = Color.Black;
            _appObject.DrawString(new GraphicsCache(e.Graphics), "Custom menu", bounds);
            bounds.Offset(-1, -1);
            _appObject.ForeColor = Color.Yellow;
            _appObject.DrawString(new GraphicsCache(e.Graphics), "Custom menu", bounds);
        }
    }
}