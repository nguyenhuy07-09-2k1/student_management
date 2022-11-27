using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.XtraBars;
using Student_GUI.LayoutControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_GUI
{
    public partial class GiaoDienChinh : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }


        async System.Threading.Tasks.Task LoadModuleAsync(ModuleInfo module)
        {
            await System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormContainer1.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer1.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                    var control = fluentDesignFormContainer1.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                    {
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            control[0].BringToFront();
                        }));
                    }
                }
            });
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            this.barHeaderItem1.Caption = $"{accordionControlElement1.Text}";
            this.fluentDesignFormContainer1.Controls.Add(new TrangChu() { Dock = DockStyle.Fill });
        }

        private async void accordionControlElement4_Click(object sender, EventArgs e)
        {
            this.barHeaderItem1.Caption = $"{accordionControlElement4.Text}";
            if(ModulesInfo.GetItem("QL_LopHoc") == null)
            {
                ModulesInfo.Add(new ModuleInfo("QL_LopHoc", "Student_GUI.LayoutControl.QL_LopHoc"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("QL_LopHoc"));
        }

        private async void accordionControlElement1_Click(object sender, EventArgs e)
        {
            this.barHeaderItem1.Caption = $"{accordionControlElement1.Text}";
            if (ModulesInfo.GetItem("TrangChu") == null)
            {
                ModulesInfo.Add(new ModuleInfo("TrangChu", "Student_GUI.LayoutControl.TrangChu"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("TrangChu"));
        }

        private async void accordionControlElement2_Click(object sender, EventArgs e)
        {
            this.barHeaderItem1.Caption = $"{accordionControlElement2.Text}";
            if (ModulesInfo.GetItem("QL_HocVien") == null)
            {
                ModulesInfo.Add(new ModuleInfo("QL_HocVien", "Student_GUI.LayoutControl.QL_HocVien"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("QL_HocVien"));
        }

        private async void accordionControlElement3_Click(object sender, EventArgs e)
        {
            this.barHeaderItem1.Caption = $"{accordionControlElement2.Text}";
            if (ModulesInfo.GetItem("QL_GiaoVien") == null)
            {
                ModulesInfo.Add(new ModuleInfo("QL_GiaoVien", "Student_GUI.LayoutControl.QL_GiaoVien"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("QL_GiaoVien"));
        }
    }
}
