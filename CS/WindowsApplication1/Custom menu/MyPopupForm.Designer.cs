namespace WindowsApplication1
{
    partial class MyPopupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.imageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListBoxControl1
            // 
            this.imageListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageListBoxControl1.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.imageListBoxControl1.HotTrackItems = true;
            this.imageListBoxControl1.ImageList = this.imageList1;
            this.imageListBoxControl1.Location = new System.Drawing.Point(0, 20);
            this.imageListBoxControl1.Name = "imageListBoxControl1";
            this.imageListBoxControl1.Size = new System.Drawing.Size(203, 267);
            this.imageListBoxControl1.TabIndex = 0;
            this.imageListBoxControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.imageListBoxControl1_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEdit1.Location = new System.Drawing.Point(0, 0);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "GO!", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.buttonEdit1.Properties.NullValuePrompt = "Search";
            this.buttonEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.buttonEdit1.Size = new System.Drawing.Size(203, 20);
            this.buttonEdit1.TabIndex = 1;
            // 
            // MyPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 287);
            this.Controls.Add(this.imageListBoxControl1);
            this.Controls.Add(this.buttonEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyPopupForm";
            this.Text = "MyPopupForm";
            this.Deactivate += new System.EventHandler(this.MyPopupForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;

    }
}