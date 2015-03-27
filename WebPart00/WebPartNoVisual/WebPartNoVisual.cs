using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace WebPart00.WebPartNoVisual
{
    [ToolboxItemAttribute(false)]
    public class WebPartNoVisual : WebPart
    {
        protected override void CreateChildControls()
        {
            Label lbl=new Label();
            lbl.Text = "Hola";
        }
    }
}
