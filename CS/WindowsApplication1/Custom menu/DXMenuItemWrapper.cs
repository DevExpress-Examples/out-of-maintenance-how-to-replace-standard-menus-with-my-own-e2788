using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;

namespace WindowsApplication1
{
    public class DXMenuItemWrapper
    {

        private DXMenuItem _Item;
        public DXMenuItemWrapper(DXMenuItem item)
        {
            _Item = item;
        }

        public override string ToString()
        {
            return _Item.Caption;
        }

        public void GenerateClickEvent()
        {
            _Item.GenerateClickEvent();
        }
    }
}
