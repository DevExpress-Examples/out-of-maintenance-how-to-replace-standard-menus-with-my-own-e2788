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
    public class MyMenuManager : IDXMenuManager
    {

        public MyMenuManager()
        {

        }



        #region IDXMenuManager Members

        IDXMenuManager IDXMenuManager.Clone(Form newForm)
        {
            return this;
        }

        void IDXMenuManager.DisposeManager()
        {
            
        }

        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos)
        {
            ShowMyCustomMenu(menu, control, pos);     
        }


        private void ShowMyCustomMenu(DXPopupMenu menu, Control control, Point pos)
        {
            MyPopupForm popupForm = new MyPopupForm(menu);
            int maxHeight = Screen.GetWorkingArea(control).Bottom - pos.Y;
            popupForm.Show();
            popupForm.Location = control.PointToScreen(pos);
            Size size = popupForm.BestSize;
            popupForm.Height = Math.Min(maxHeight, size.Height);
            popupForm.Width = size.Width; ;
        }
        #endregion
    }
}
