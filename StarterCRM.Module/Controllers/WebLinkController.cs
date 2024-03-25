using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraEditors;
using StarterCRM.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterCRM.Module.Controllers
{
    public class WebLinkController : ViewController<DetailView>
    {
        public WebLinkController()
        {

            TargetObjectType = typeof(Company);
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();

            StringPropertyEditor webSiteEditor = View.FindItem("Website") as StringPropertyEditor;
            if (webSiteEditor != null)
            {

                webSiteEditor.Control.Font = new System.Drawing.Font(webSiteEditor.Control.Font,
                    System.Drawing.FontStyle.Underline);
                webSiteEditor.Control.ForeColor = System.Drawing.Color.Blue;
                webSiteEditor.Control.DoubleClick += Control_DoubleClick;
            }


        }
      

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            TextEdit edit = (TextEdit)sender;
            System.Diagnostics.Process.Start(edit.Text);
        }
    }
}
