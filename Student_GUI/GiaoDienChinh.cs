using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.XtraBars;
using Student_GUI.Model;
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
            if(ModulesInfo.GetItem("QLLopHoc") == null)
            {
                ModulesInfo.Add(new ModuleInfo("QLLopHoc", "Student_GUI.Model.QLLopHoc"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("QLLopHoc"));
        }

        private async void accordionControlElement1_Click(object sender, EventArgs e)
        {
            this.barHeaderItem1.Caption = $"{accordionControlElement1.Text}";
            if (ModulesInfo.GetItem("TrangChu") == null)
            {
                ModulesInfo.Add(new ModuleInfo("TrangChu", "Student_GUI.Model.TrangChu"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("TrangChu"));
        }

        private async void accordionControlElement2_Click(object sender, EventArgs e)
        {
            this.barHeaderItem1.Caption = $"{accordionControlElement2.Text}";
            if (ModulesInfo.GetItem("QLHocVien") == null)
            {
                ModulesInfo.Add(new ModuleInfo("QLHocVien", "Student_GUI.Model.QLHocVien"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("QLHocVien"));
        }

        private async void accordionControlElement3_Click(object sender, EventArgs e)
        {
            this.barHeaderItem1.Caption = $"{accordionControlElement2.Text}";
            if (ModulesInfo.GetItem("QLGiaoVien") == null)
            {
                ModulesInfo.Add(new ModuleInfo("QLGiaoVien", "Student_GUI.Model.QLGiaoVien"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("QLGiaoVien"));
        }
    }
}
