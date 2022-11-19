namespace Student_GUI.Model
{
    partial class QLHocVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLCI = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButtonLCI)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton11);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 87, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(812, 452);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleButtonLCI});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(812, 452);
            this.Root.TextVisible = false;
            // 
            // simpleButton11
            // 
            this.simpleButton11.AutoWidthInLayoutControl = true;
            this.simpleButton11.Location = new System.Drawing.Point(367, 209);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(78, 34);
            this.simpleButton11.StyleController = this.layoutControl1;
            this.simpleButton11.TabIndex = 4;
            this.simpleButton11.Text = "QL Học Viên";
            // 
            // simpleButtonLCI
            // 
            this.simpleButtonLCI.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.simpleButtonLCI.Control = this.simpleButton11;
            this.simpleButtonLCI.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.simpleButtonLCI.CustomizationFormText = "simpleButtonLCI";
            this.simpleButtonLCI.Location = new System.Drawing.Point(0, 0);
            this.simpleButtonLCI.Name = "simpleButtonLCI";
            this.simpleButtonLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.simpleButtonLCI.Size = new System.Drawing.Size(786, 426);
            this.simpleButtonLCI.Text = "simpleButtonLCI";
            this.simpleButtonLCI.TextLocation = DevExpress.Utils.Locations.Left;
            this.simpleButtonLCI.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButtonLCI.TextVisible = false;
            this.simpleButtonLCI.TrimClientAreaToControl = false;
            // 
            // QLHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "QLHocVien";
            this.Size = new System.Drawing.Size(812, 452);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButtonLCI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraLayout.LayoutControlItem simpleButtonLCI;
    }
}
